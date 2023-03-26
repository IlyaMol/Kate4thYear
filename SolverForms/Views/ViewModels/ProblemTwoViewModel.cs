using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms.Views.ViewModels
{
    public class ProblemTwoViewModel : INotifyPropertyChanged
    {
        #region Fields
        private int _processorCount = 0;
        private int _processCount = 0;
        private int _tauValue = 1;
        private double _resultTauValue = 0;
        private double _optimalBlockCountValue = 0;

        private double[] _sourceQueue = Array.Empty<double>();
        private double[] _uniformQueue = Array.Empty<double>();

        private ProblemTwo.Calculations _calculator = new ProblemTwo.Calculations();
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
                OnPropertyChanged(nameof(TauLabelText));
                Recalc();
            }
        }
        public string TauLabelText
        {
            get { return $"Оптимальное число блоков при τ = {TauValue}:"; }
        }
        public double ResultTauValue
        {
            get { return _resultTauValue; }
            set
            {
                if (_resultTauValue == value) return;
                _resultTauValue = value;
                OnPropertyChanged();
            }
        }
        public double OptimalBlockCountValue
        {
            get { return _optimalBlockCountValue; }
            set
            {
                if (_optimalBlockCountValue == value) return;
                _optimalBlockCountValue = value;
                OnPropertyChanged();
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
        public double[] UniformQueue
        {
            get { return _uniformQueue; }
            set
            {
                if (_uniformQueue == value) return;
                _uniformQueue = value;
                OnPropertyChanged();
            }
        }
        public int SourceDataLength
        {
            get { return SourceQueue.Length; }
        }
        #endregion

        #region Delegates
        #endregion

        #region Events
        #endregion

        #region Methods
        public void Recalc()
        {
            if (_sourceQueue == null) return;
            if(_processCount== 0) return;
            if (_processorCount == 0) return;

            UniformQueue = _calculator.GetUniformSruct(_sourceQueue);
            ResultTauValue = _calculator.OverheadCosts(_sourceQueue, _processorCount);
            OptimalBlockCountValue = _calculator.OptimalBlockCount(_sourceQueue, _processorCount, _processCount, _tauValue);
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