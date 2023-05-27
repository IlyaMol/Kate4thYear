using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms.Views.ViewModels
{
    public class ProblemFiveViewModel : INotifyPropertyChanged
    {
        #region Fields
        private int _processorCount = 10;
        private int _blockCount = 20;
        private double _eVal = 1;
        private int _minExecTime = 100;

        private int _processReqCount = 0;

        private ProblemFive.Calculations _calculator = new ProblemFive.Calculations();
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
        public int BlockCount
        {
            get { return _blockCount; }
            set
            {
                if (_blockCount == value) return;
                _blockCount = value;
                OnPropertyChanged();
                Recalc();
            }
        }
        public double eVal
        {
            get { return _eVal; }
            set
            {
                if (_eVal == value) return;
                _eVal = value;
                OnPropertyChanged();
                Recalc();
            }
        }
        public int MinExecTime
        {
            get { return _minExecTime; }
            set
            {
                if (_minExecTime == value) return;
                _minExecTime = value;
                OnPropertyChanged();
                Recalc();
            }
        }

        public int ProcessReqCount
        {
            get { return _processReqCount; }
            set
            {
                if (_processReqCount == value) return;
                _processReqCount = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Methods
        public void Recalc()
        {
            if (_minExecTime == 0) return;
            if (_blockCount == 0) return;
            if (_processorCount == 0) return;

            ProcessReqCount = _calculator.GetProcessRequiredCount(MinExecTime, ProcessorCount, BlockCount, eVal);
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