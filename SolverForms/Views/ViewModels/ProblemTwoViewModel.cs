using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms.Views.ViewModels
{
    public class ProblemTwoViewModel : INotifyPropertyChanged
    {
        #region Fields
        private int _processorCount = 0;
        private int _processCount = 0;
        private int[,] _sourceQueue = new int[0, 0];
        #endregion

        #region Properties
        public int ProcessorCount
        {
            get { return _processorCount; }
            set
            {
                if (_processorCount == value) return;
                _processorCount = value;
                OnPropertyChanged();
            }
        }
        public int ProcessCount
        {
            get { return _processCount; }
            set
            {
                if (_processCount == value) return;
                _processCount = value;
                OnPropertyChanged();
            }
        }
        public int[,] SourceQueue
        {
            get { return _sourceQueue; }
            set
            {
                if (_sourceQueue == value) return;
                _sourceQueue = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Delegates
        #endregion

        #region Events
        #endregion

        #region Methods
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