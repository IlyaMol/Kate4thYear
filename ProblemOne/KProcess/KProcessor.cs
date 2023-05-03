namespace ProblemOne
{
    public class KProcessor
    {
        private KProcess? _currentProcess = null;

        public EStatus Status
        {
            get
            {
                if (_currentProcess != null && _currentProcess.Status == EStatus.Busy) return EStatus.Busy;
                if(_currentProcess != null && _currentProcess.Status == EStatus.Done)
                {
                    _currentProcess = null;
                    return EStatus.Idle;
                }
                return EStatus.Idle;
            }
            set 
            {
                if(value == EStatus.Idle && Status == EStatus.Busy)
                {
                    _currentProcess = null;
                }
            }
        }

        public KProcess? CurrentProcess
        {
            get { return _currentProcess; }
            set
            {
                _currentProcess = value;
            }
        }
    }
}
