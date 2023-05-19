using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms.Views.ViewModels
{
    public class ProblemThreeViewModel : INotifyPropertyChanged
    {
        #region Fields
        private int _processorCount = 0;
        private int _processCount = 0;
        private int _tauValue = 1;
        private int _copyValue = 1;
        private double[] _sourceQueue = Array.Empty<double>();

        private ProblemThree.Calculations _calculator = new ProblemThree.Calculations();
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
                Recalc();
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
                Recalc();
            }
        }
        public int TauValue
        {
            get { return _tauValue; }
            set
            {
                if (_tauValue == value) return;
                _tauValue = value;
                OnPropertyChanged();
                Recalc();
            }
        }
        public int CopyValue
        {
            get { return _copyValue; }
            set
            {
                if(_copyValue == value) return;
                _copyValue = value;
                OnPropertyChanged();
                Recalc();
            }
        }
        public double[] SourceQueue
        {
            get { return _sourceQueue; }
            set
            {
                if (_sourceQueue == value) return;
                _sourceQueue = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(this.SourceDataLength));
                Recalc();
            }
        }
        public int SourceDataLength
        {
            get { return SourceQueue.Length; }
        }
        #endregion

        #region Methods
        public void Recalc()
        {
            if (_sourceQueue == null) return;
            if (_processCount == 0) return;
            if (_processorCount == 0) return;
            if (_copyValue== 0) return;


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
