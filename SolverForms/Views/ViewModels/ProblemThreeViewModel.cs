using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms.Views.ViewModels
{
    public class ProblemThreeViewModel : INotifyPropertyChanged
    {
        #region Fields
        private int _processorCount = 4;
        private int _processCount = 4;
        private int _copyValue = 2;
        private double[] _sourceQueue = Array.Empty<double>();

        private int _minExecTime = 0;
        private int _reqProcCount = 0;
        private int _minProcCount = 0;

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

        public int MinimalExecutionTime
        {
            get { return _minExecTime; }
            set
            {
                if (_minExecTime == value) return;
                _minExecTime = value;
                OnPropertyChanged(nameof(MinimalExecutionTimeLabelValue));
                OnPropertyChanged();
            }
        }
        public string MinimalExecutionTimeLabelValue
        {
            get { return $"= {MinimalExecutionTime}"; }
        }
        
        public int MinimumProcessorCount
        {
            get { return _minProcCount; }
            set
            {
                if (_minProcCount == value) return;
                _minProcCount = value;
                OnPropertyChanged(nameof(MinimumProcessorCountLabelValue));
                OnPropertyChanged();
            }
        }
        public string MinimumProcessorCountLabelValue
        {
            get { return $"= {MinimumProcessorCount}"; }
        }

        public int RequiredProcessorCount
        {
            get { return _reqProcCount; }
            set
            {
                if (_reqProcCount == value) return;
                _reqProcCount = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(RequiredProcessorCountLabelValue));
            }
        }
        public string RequiredProcessorCountLabelValue
        {
            get { return $"= {RequiredProcessorCount}"; }
        }

        public int SourceDataLength
        {
            get { return SourceQueue.Length; }
        }
        #endregion

        public ProblemThreeViewModel()
        {
            SourceQueue = new double[] { 4, 2, 5, 2 };
        }

        #region Methods
        public void Recalc()
        {
            if (_sourceQueue == null) return;
            if (_processCount == 0) return;
            if (_processorCount == 0) return;
            if (_copyValue== 0) return;

            MinimalExecutionTime = _calculator.MinimumCompletionTime(SourceQueue, ProcessorCount, ProcessCount, CopyValue);
            RequiredProcessorCount = _calculator.RequiredProcessorCount(ProcessorCount, CopyValue);
            MinimumProcessorCount = _calculator.MinimumProcessorCount(ProcessorCount, ProcessCount, CopyValue);
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
