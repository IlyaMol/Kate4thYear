using ProblemOne;
using ProblemOne.KGraph;
using ProblemOne.Model;
using SolverForms.DrawLib;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms
{
    public class MainFormViewModel : INotifyPropertyChanged
    {
        #region Fields
        private bool _isBusy = false;
        private int _processorCount = 0;

        private int[,] _sourceMatrix = new int[0, 0];
        private int[,] _resultMatrix = new int[0, 0];

        private int _selectedCriticalPathIndex = 1;
        private ConcurrentBag<KPath<KVertex>> _criticalPaths = new();
        private KPath<KVertex> selectedCriticalPath = new();

        private KGraph? graph;
        #endregion

        #region Properties
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                if (_isBusy == value) return;
                _isBusy = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsNotBusy));
            }
        }
        public bool IsNotBusy
        {
            get { return !_isBusy; }
        }

        public ICollection<int[,]>? SubProcess { get; private set; }

        public int ProcessorCount
        {
            get { return _processorCount; }
            set
            {
                if (_processorCount == value) return;
                _processorCount = value;
                RecalcResult();
                OnPropertyChanged();
            }
        }
        public int[,] SourceMatrix
        {
            get { return _sourceMatrix; }
            set
            {
                if (_sourceMatrix == value) return;
                _sourceMatrix = value;
                OnPropertyChanged();
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

        public ConcurrentBag<KPath<KVertex>> criticalPaths
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
        #endregion

        public delegate void UpdateFrameDelegate(ICollection<KGLine> scene);
        public event UpdateFrameDelegate? OnFrameUpdate;

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

        #region Methods
        public void DataSourceChangedDelegate(int[,] newDataSource)
        {
            SourceMatrix = newDataSource;

            int[,] tmpMatr = new int[newDataSource.GetLength(0), newDataSource.GetLength(1)];
            Array.Copy(newDataSource, 0, tmpMatr, 0, newDataSource.Length);

            RecalcResult();
        }

        public void RecalcResult()
        {
            SubProcess = KMatrixTransform.SplitMatrix(SourceMatrix, _processorCount);
            int[,] preparedMatrix = KMatrixTransform.BuildProcTimeMatrix(SubProcess);

            CancellationTokenSource s = new CancellationTokenSource();
            if (KGraph.TryBuid(preparedMatrix, out graph))
                KGraph.GetCriticalPath(graph, s.Token);

            criticalPaths = graph.CriticalPaths;

            ResultMatrix = preparedMatrix;

            RedrawGraphics();
        }

        public void RedrawGraphics()
        {
            if (graph == null) { return; }
            if (criticalPaths.Count > 0 && _selectedCriticalPathIndex > 0)
            {
                int count = 0;
                foreach(KPath<KVertex> kp in criticalPaths) 
                {
                    count++;
                    if(count == _selectedCriticalPathIndex)
                        selectedCriticalPath = kp;
                }
            }

            // TODO(wwaffe): here start of test graphics code
            SceneGenerator generator = new(CurrentSceneWidth, CurrentSceneHeight) { CoordPadding = new Padding(20) };
            ICollection<KGLine> scene = generator.GetCoordPlane(ProcessorCount);
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