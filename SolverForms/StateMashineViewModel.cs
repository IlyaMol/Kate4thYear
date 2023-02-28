using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms
{
    public class StateMashineViewModel : INotifyPropertyChanged
    {
        #region Fields
        private int processorCount;
        private int processCount;
        private int blockCount;
        #endregion

        #region Properties
        public int ProcessorCount 
        {
            get { return processorCount; }
            set
            {
                if (processCount == value) return;
                processorCount = value;
                OnPropertyChanged();
            }
        }
        public int ProcessCount
        {
            get { return processCount; }
            set
            {
                if (processCount == value) return;
                processCount = value;
                OnPropertyChanged();
            }
        }
        public int BlockCount
        {
            get { return blockCount; }
            set
            {
                if (blockCount == value) return;
                blockCount = value;
                OnPropertyChanged();
            }
        }
        #endregion

        private int[,] _matrix = new int[0, 0];
        public int[,] Matrix 
        {
            get { return _matrix; }
            set
            {
                if(_matrix == value) return;
                _matrix = value; 
                OnPropertyChanged();
            }
        }

        #region Methods
        public bool TryBuildGraph()
        {
            Matrix = new int[ProcessCount, BlockCount];
            return true;
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
