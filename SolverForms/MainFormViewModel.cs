using ProblemOne;
using ProblemOne.KGraph;
using ProblemOne.Model;
using SolverForms.Controls;
using SolverForms.DrawLib;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms
{
    public class MainFormViewModel : INotifyPropertyChanged
    {
        #region Fields
        private bool isBusy = false;
        private int processorCount = 0;
        private int[,] sourceMatrix = new int[0, 0];
        private int[,] resultMatrix = new int[0, 0];

        private int selectedCriticalPathIndex = 1;
        private ConcurrentBag<KPath<KVertex>> criticalPaths = new();
        private KPath<KVertex> selectedCriticalPath = new();

        private KGraph? graph;
        #endregion

        #region Properties
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                if (isBusy == value) return;
                isBusy = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsNotBusy));
            }
        }
        public bool IsNotBusy
        {
            get
            {
                return !isBusy;
            }
        }

        public ICollection<int[,]>? SubProcess { get; private set; }

        public int ProcessorCount
        {
            get { return processorCount; }
            set
            {
                if (processorCount == value) return;
                processorCount = value;
                RecalcResult();
                OnPropertyChanged();
            }
        }
        public int ProcessCount
        {
            get { return sourceMatrix.GetLength(0); }
        }
        public int BlockCount
        {
            get { return sourceMatrix.GetLength(1); }
        }
        public int[,] SourceMatrix
        {
            get { return sourceMatrix; }
            set
            {
                if (sourceMatrix == value) return;
                sourceMatrix = value;
                OnPropertyChanged();
            }
        }
        public int[,] ResultMatrix
        {
            get { return resultMatrix; }
            set
            {
                if (resultMatrix == value) return;
                resultMatrix = value;
                OnPropertyChanged();
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
            set
            {
                OnPropertyChanged();
            }
        }
        public int SelectedCriticalPathIndex
        {
            get { return selectedCriticalPathIndex; }
            set
            {
                if (selectedCriticalPathIndex == value) return;
                selectedCriticalPathIndex = value;
                RedrawGraphics();
                OnPropertyChanged();
            }
        }
        public IEnumerable<KCoordinates> SelectedCriticalPath
        {
            get
            {
                return selectedCriticalPath.AsCoordinates();
            }
        }
        #endregion

        public delegate void UpdateFrameDelegate(ICollection<KGLine> scene);
        public event UpdateFrameDelegate? OnFrameUpdate;

        public float CurrentSceneWidth { get; set; }
        public float CurrentSceneHeight { get; set; }

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
            SelectedCriticalPathIndex = 1;

            SubProcess = KMatrixTransform.SplitMatrix(SourceMatrix, processorCount);
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
            if (graph == null)
            {
                return;
            }
            if (criticalPaths.Count > 0 && selectedCriticalPathIndex > 0)
            {
                int count = 0;
                foreach(KPath<KVertex> kp in criticalPaths) 
                {
                    count++;
                    if(count == selectedCriticalPathIndex)
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