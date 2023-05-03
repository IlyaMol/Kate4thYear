namespace ProblemOne
{
    public class KProcessor
    {
        private KBlock? _currentBlock = null;

        public EStatus Status
        {
            get
            {
                if (_currentBlock != null) return EStatus.Busy;
                return EStatus.Idle;
            }
            set 
            {
                if(value == EStatus.Idle && Status == EStatus.Busy)
                {
                    _currentBlock!.Reset();
                    _currentBlock = null;
                }
            }
        }

        public KBlock? CurrentBlock
        {
            get { return _currentBlock; }
            set
            {
                _currentBlock = value;
                
                if (_currentBlock == null) return;
                
                _currentBlock.Status = EStatus.Busy;
            }
        }
    }
}
