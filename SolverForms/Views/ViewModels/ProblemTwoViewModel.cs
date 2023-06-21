using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms.Views.ViewModels
{
    public class ProblemTwoViewModel : INotifyPropertyChanged
    {
        #region Fields
        private int _processorCount = 10;
        private int _processCount = 10;
        private int _tauValue = 1;
        private double _resultTauValue = 0;
        private double _optimalBlockCountValue = 0;
        private double _optimalBlockCountValue2 = 0;
        private uint _optimalProcessorCount = 0;
        private double _sqrtN = 0;
        private int _sumTValue = 0;

        private double[] _sourceQueue = Array.Empty<double>();
        private double[] _uniformQueue = Array.Empty<double>();

        private ProblemTwo.Calculations _calculator = new ProblemTwo.Calculations();
        #endregion

        public ProblemTwoViewModel()
        {
            SourceQueue = new double[] { 3, 5, 2, 5, 7, 6, 4, 8, 6, 5 };
        }

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
        public string TauValueLabelText
        {
            get { return $"Величина накладных расходов: τ ≤ {ResultTauValue}"; }
        }
        public string TauLabelText
        {
            get { return $"Оптимальное число блоков при τ=1:"; }
        }
        public double SqrtNValue
        {
            get { return _sqrtN; }
            set
            {
                if (_sqrtN == value) return;
                _sqrtN = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(SqrtNValueLabelText));
            }
        }
        public string SqrtNValueLabelText
        {
            get { return $"= {SqrtNValue}"; }
        }
        public int SumTValue
        {
            get { return _sumTValue; }
            set
            {
                if (_sumTValue == value) return;
                _sumTValue = value; 
                OnPropertyChanged();
                OnPropertyChanged(nameof(SumTValueLabelText));
            }
        }
        public string SumTValueLabelText
        {
            get { return $"= {SumTValue}"; }
        }
        public double OptimalBlockCountValue2
        {
            get { return _optimalBlockCountValue2; }
            set
            {
                if (_optimalBlockCountValue2 == value) return;
                _optimalBlockCountValue2 = value;
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
        public string OptimalBlockCountValueMainLabelText
        {
            get { return $"(пункт в) для p=n={ProcessCount}, τ=1: s(0)={OptimalBlockCountValue}"; }
        }
        public string OptimalBlockCountValueSecondaryLabelText
        {
            get { return $"(пункт г) для p={4}, n={ProcessCount}, τ=1: s(0)={OptimalBlockCountValue2}"; }
        }

        public uint OptimalProcessorCount
        {
            get { return _optimalProcessorCount; }
            set
            {
                if (_optimalProcessorCount == value) return;
                _optimalProcessorCount = value;
                OnPropertyChanged();
            }
        }
        public string OptimalProcessorCountValueText
        {
            get { return $"= {OptimalProcessorCount}"; }
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
            SqrtNValue = _calculator.GetSqrtProcess(_processCount);
            ResultTauValue = _calculator.OverheadCosts(_sourceQueue, _processorCount);
            SumTValue = _calculator.GetSumTBlocks(SourceQueue);
            OptimalBlockCountValue = _calculator.OptimalBlockCount(_sourceQueue, _processorCount, _processCount, _tauValue);
            OptimalBlockCountValue2 = _calculator.OptimalBlockCount(_sourceQueue, 4, _processCount, _tauValue);
            OptimalProcessorCount = _calculator.OptimalProcessorCount(_sourceQueue, _processCount);
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