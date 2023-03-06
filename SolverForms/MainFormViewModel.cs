using problemOne.Model;
using SolverForms.Controls;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms
{
    public class MainFormViewModel : INotifyPropertyChanged
    {
        #region Fields
        private int processorCount = 0;
        private int[,] sourceMatrix = new int[0, 0];
        private int[,] resultMatrix = new int[0, 0];
        private int criticalPathLength = 0;
        private List<KVertex> criticalPath = new List<KVertex>();
        private KGraph? graph;
        #endregion

        #region Properties
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
            get { return criticalPathLength; }
            set
            {
                if(criticalPathLength == value) return;
                criticalPathLength = value;
                OnPropertyChanged();
            }
        }
        public List<Coordinates> CriticalPath
        {
            get
            {
                List<Coordinates> result = new List<Coordinates>();
                foreach (KVertex vertex in criticalPath)
                    result.Add(new Coordinates() { RowIndex = vertex.RowIndex, ColumnIndex = vertex.ColumnIndex});
                return result;
            }
        }
        #endregion

        public Dictionary<int, int[,]>? SubProcess { get; private set; }

        #region Methods
        public void DataSourceChangedDelegate(int[,] newDataSource)
        {
            SourceMatrix = newDataSource;

            int[,] tmpMatr = new int[newDataSource.GetLength(0), newDataSource.GetLength(1)];
            Array.Copy(newDataSource, 0, tmpMatr, 0, newDataSource.Length);

            RecalcResult();
        }

        private void RecalcResult()
        {
            SubProcess = KGraph.GetSubProcesses(SourceMatrix, processorCount);
            int[,] preparedMatrix = KGraph.PrepareMatrix(SourceMatrix, processorCount);
            ResultMatrix = preparedMatrix;

            if(KGraph.TryBuid(preparedMatrix, out graph))
            {
                criticalPath = graph.GetCriticalPath();
                CriticalPathLength = criticalPath.Sum(v => v.Weight);
            }
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