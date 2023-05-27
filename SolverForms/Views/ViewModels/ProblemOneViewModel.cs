using ProblemOne;
using ProblemOne.KGraph;
using ProblemOne.Model;
using SolverForms.DrawLib;
using SolverForms.Extensions;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms.Views.ViewModels
{
    public class ProblemOneViewModel : INotifyPropertyChanged
    {
        #region Fields
        private bool _isBusy = false;
        private bool _buildCombined = false;
        private int _processorCount = 0;
        private int _copyCount = 1;

        private int[,] _sourceMatrix = new int[0, 0];
        private int[,] _resultMatrix = new int[0, 0];

        private int _selectedCriticalPathIndex = 1;
        private ConcurrentBag<KPath<KVertex>> _criticalPaths = new();
        private KPath<KVertex> selectedCriticalPath = new();

        public IList<KExecuteModeType> ExecuteModeTypes { get; } = new List<KExecuteModeType>()
        {
            new KExecuteModeType() { Name = "Асинхронный", Type = EExecuteModeType.Async},
            new KExecuteModeType() { Name = "Первый синх.", Type = EExecuteModeType.SyncFirst},
            new KExecuteModeType() { Name = "Второй синх.", Type = EExecuteModeType.SyncSecond}
        };
        public IList<KDistributeModeType> DistributionModeTypes { get; } = new List<KDistributeModeType>()
        {
            new KDistributeModeType() { Name = "Сосред.", Type = EDistributeModeType.Centralized},
            new KDistributeModeType() { Name = "Распред.", Type = EDistributeModeType.Distributed}
        };

        private EExecuteModeType _selectedProcType = EExecuteModeType.Async;
        public EExecuteModeType SelectedExecuteType 
        {
            get { return _selectedProcType; }
            set
            {
                if (_selectedProcType == value) return;
                _selectedProcType = value;
                RecalcResult();
                OnPropertyChanged();
            }
        }

        private EDistributeModeType _selectedDistributeType = EDistributeModeType.Centralized;
        public EDistributeModeType SelectedDistributeType
        {
            get { return _selectedDistributeType; }
            set
            {
                if (_selectedDistributeType == value) return;
                _selectedDistributeType = value;
                RecalcResult();
                OnPropertyChanged();
            }
        }

        private KGraph? graph;

        private float _drawingScale = 5;
        #endregion

        #region Properties


        public int CopyCount
        {
            get { return _copyCount; }
            set
            {
                if (_copyCount == value) return;
                _copyCount = value;
                OnPropertyChanged();
                RecalcResult();
            }
        }

        public ICollection<int[,]>? SubProcess { get; private set; }
        public int ProcessorCount
        {
            get { return _processorCount; }
            set
            {
                if (_processorCount == value) return;
                _processorCount = value;
                OnPropertyChanged();
                RecalcResult();
            }
        }
        public int[,] SourceMatrix
        {
            get { return _sourceMatrix; }
            set
            {
                if (_sourceMatrix == null) return;
                if (_sourceMatrix.Compare(value)) return;
                _sourceMatrix = value;
                OnPropertyChanged();
                RecalcResult();
            }
        }
        public int[,] ResultMatrix
        {
            get { return _resultMatrix; }
            set
            {
                if (_resultMatrix == value) return;
                _resultMatrix = value;
                OnPropertyChanged();
            }
        }

        private ConcurrentBag<KPath<KVertex>> criticalPaths
        {
            get { return _criticalPaths; }
            set
            {
                if (_criticalPaths == value) return;
                _criticalPaths = value;
                SelectedCriticalPathIndex = 1;
                OnPropertyChanged(nameof(CriticalPathLength));
                OnPropertyChanged(nameof(CriticalPathCount));
            }
        }
        public int CriticalPathCount
        {
            get
            {
                if (criticalPaths.Count > 0)
                    return criticalPaths.Count;
                else return 1;
            }
        }
        public int CriticalPathLength
        {
            get
            {
                if (selectedCriticalPath.Count > 0)
                    return selectedCriticalPath.Length;
                else return 0;
            }
        }
        public int SelectedCriticalPathIndex
        {
            get { return _selectedCriticalPathIndex; }
            set
            {
                if (_selectedCriticalPathIndex == value) return;
                _selectedCriticalPathIndex = value;
                RedrawGraphics();
                OnPropertyChanged();
            }
        }
        public IEnumerable<KCoordinates> SelectedCriticalPath
        {
            get { return selectedCriticalPath.AsCoordinates(); }
        }

        public bool BulidCombined
        {
            get { return _buildCombined; }
            set
            {
                if (value == _buildCombined) return;
                _buildCombined = value;
                OnPropertyChanged();
                RedrawGraphics();
            }
        }
        public delegate void UpdateFrameDelegate(KGScene scene);
        public event UpdateFrameDelegate? OnFrameUpdate;

        public float DrawingScale
        {
            get { return _drawingScale; }
            set
            {
                if (_drawingScale == value) return;
                _drawingScale = value;
                OnPropertyChanged();
                RedrawGraphics();
            }
        }
        private float currentSceneWidth = 0;
        public float CurrentSceneWidth
        {
            get { return currentSceneWidth; }
            set
            {
                if (currentSceneWidth == value) return;
                currentSceneWidth = value;
                OnPropertyChanged();
                RedrawGraphics();
            }
        }
        private float currentSceneHeight = 0;
        public float CurrentSceneHeight
        {
            get { return currentSceneHeight; }
            set
            {
                if (currentSceneHeight == value) return;
                currentSceneHeight = value;
                OnPropertyChanged();
                RedrawGraphics();
            }
        }
        #endregion

        #region Methods
        public void DataSourceChangedDelegate(int[,] newDataSource)
        {
            SourceMatrix = newDataSource;

            int[,] tmpMatr = new int[newDataSource.GetLength(0), newDataSource.GetLength(1)];
            Array.Copy(newDataSource, 0, tmpMatr, 0, newDataSource.Length);

            RecalcResult();
        }

        public KStateMachine? Machine = null;
        public void RecalcResult()
        {
            SubProcess = KMatrixTransform.SplitMatrix(SourceMatrix, _processorCount);
            if (SubProcess.Count < 1) return;

            int[,] preparedMatrix = KMatrixTransform.BuildProcTimeMatrix(SubProcess);

            CancellationTokenSource s = new CancellationTokenSource();
            if (KGraph.TryBuid(preparedMatrix, out graph))
                KGraph.GetCriticalPath(graph, s.Token);
            criticalPaths = graph.CriticalPaths;
            ResultMatrix = preparedMatrix;
            KStateMachine.TryBuild(SourceMatrix, _processorCount, _copyCount, out Machine);

            if (graph == null) { return; }
            if (!criticalPaths.IsEmpty && _selectedCriticalPathIndex > 0)
            {
                int count = 0;
                foreach (KPath<KVertex> kp in criticalPaths)
                {
                    count++;
                    if (count == _selectedCriticalPathIndex)
                        selectedCriticalPath = kp;
                }
            }

            RedrawGraphics();
        }

        public void RedrawGraphics()
        {
            if(Machine == null) return;

            ICollection<KGLayer> machineResultGraphics = Machine.Execute(SelectedExecuteType, SelectedDistributeType, BulidCombined)
                                                     .BuildGraphics();
            
           // TODO(wwaffe): here start of test graphics code
           KGScene scene = KGScene.NewScene()
                                  .SetDimensions(width: CurrentSceneWidth, height: CurrentSceneHeight, padding: new Padding(20))
                                  .UseCoordPlane(yDelimeters: ProcessorCount, scale: DrawingScale)
                                  .AddLayers(machineResultGraphics)
                                  .Build();
            OnFrameUpdate?.Invoke(scene);
            //end draw algo
        }
        #endregion

        #region INotify... implementation
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}