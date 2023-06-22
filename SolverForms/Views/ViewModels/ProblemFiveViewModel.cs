using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms.Views.ViewModels
{
    public class ProblemFiveViewModel : INotifyPropertyChanged
    {
        #region Fields
        private int _processReqACount = 0;
        private int _processReqBCount = 0;
        private int _processReqCCount = 0;

        private const int minTVal = 100;

        private const int pValA = 10;
        private const int pValB = 10;
        private const int pValC = 6;

        private const int sValA = 20;
        private const int sValB = 15;
        private const int sValC = 15;

        private const double tValA = 1;
        private const double tValB = 1;
        private const double tValC = 0.1;

        private ProblemFive.Calculations _calculator = new ProblemFive.Calculations();
        #endregion

        #region Properties
        
        public int ProcessReqACount
        {
            get { return _processReqACount; }
            set
            {
                if (_processReqACount == value) return;
                _processReqACount = value;
                OnPropertyChanged(nameof(ProcessReqACountLabel));
                OnPropertyChanged();
            }
        }
        public string ProcessReqACountLabel
        {
            get
            {
                return $"а) при k = {_calculator.GetKArgument(pValA, sValA)}," +
                    $" r = {_calculator.GetRArgument(pValA, sValA)}:" +
                    $" n0 = {ProcessReqACount}";
            }
        }
        public int ProcessReqBCount
        {
            get { return _processReqBCount; }
            set
            {
                if (_processReqBCount == value) return;
                _processReqBCount = value;
                OnPropertyChanged(nameof(ProcessReqBCountLabel));
                OnPropertyChanged();
            }
        }
        public string ProcessReqBCountLabel
        {
            get
            {
                return $"б) при k = {_calculator.GetKArgument(pValB, sValB)}," +
                    $" r = {_calculator.GetRArgument(pValB, sValB)}:" +
                    $" n0 = {ProcessReqBCount}";
            }
        }
        public int ProcessReqCCount
        {
            get { return _processReqCCount; }
            set
            {
                if (_processReqCCount == value) return;
                _processReqCCount = value;
                OnPropertyChanged(nameof(ProcessReqCCountLabel));
                OnPropertyChanged();
            }
        }
        public string ProcessReqCCountLabel
        {
            get
            {
                return $"в) при k = {_calculator.GetKArgument(pValC, sValC)}," +
                    $" r = {_calculator.GetRArgument(pValC, sValC)}:" +
                    $" n0 = {ProcessReqCCount}";
            }
        }
        #endregion

        public ProblemFiveViewModel()
        {
            Recalc();
        }

        #region Methods
        public void Recalc()
        {
            ProcessReqACount = _calculator.GetProcessRequiredCount(minTVal, pValA, sValA, tValA);
            ProcessReqBCount = _calculator.GetProcessRequiredCount(minTVal, pValB, sValB, tValB);
            ProcessReqCCount = _calculator.GetProcessRequiredCount(minTVal, pValC, sValC, tValC);
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