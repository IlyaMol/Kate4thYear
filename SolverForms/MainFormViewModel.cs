using ProblemOne;
using ProblemOne.Model;
using SolverForms.Controls;
using SolverForms.DrawLib;
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
        private int criticalPathLength = 0;
        private int selectedCriticalPathIndex = 1;
        private List<List<KVertex>> criticalPaths = new();
        private List<KVertex> selectedCriticalPath = new();
        private KGraph? graph;
        #endregion

        public event EventHandler? NeedCalculatePaths;

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

        public int CriticalPathCount
        {
            get
            {
                if(criticalPaths.Count > 0)
                    return criticalPaths.Count;
                else return 1;
            }
        }
        public int SelectedCriticalPathIndex
        {
            get { return selectedCriticalPathIndex; }
            set
            {
                if (selectedCriticalPathIndex == value) return;
                selectedCriticalPathIndex= value;
                RedrawGraphics();
                OnPropertyChanged();
            }
        }

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
        
        public int CriticalPathLength
        {
            get 
            {
                if (selectedCriticalPath.Count > 0)
                    return selectedCriticalPath.Sum(v => v.Weight);
                else return 0;
            }
            set
            {
                OnPropertyChanged();
            }
        }
        
        public List<Coordinates> SelectedCriticalPath
        {
            get
            {
                List<Coordinates> result = new List<Coordinates>();
                foreach (KVertex vertex in selectedCriticalPath)
                    result.Add(new Coordinates() { RowIndex = vertex.RowIndex, ColumnIndex = vertex.ColumnIndex});
                return result;
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

        //Thread th1 = new Thread(new ThreadStart(RecalcResult));

        public void RecalcResult()
        {
            SelectedCriticalPathIndex = 1;

            SubProcess = KMatrixTransform.SplitMatrix(SourceMatrix, processorCount);
            int[,] preparedMatrix = KMatrixTransform.BuildProcTimeMatrix(SubProcess);

            if (KGraph.TryBuid(preparedMatrix, out graph))
                NeedCalculatePaths?.Invoke(this, new EventArgs());

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
                selectedCriticalPath = criticalPaths[selectedCriticalPathIndex - 1];

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