using ProblemOne.KStates;

namespace ProblemOne
{
    public class KBlockBinding
    {
        private EBlockState _status = EBlockState.Ready;
        private KProcessor? _currentExecutor;

        public KBlock Block { get; private set; }
        public KProcess Process { get; private set; }
        public uint ThreadIndex { get; set; } = 0;
        public bool IsBinded { get; set;} = false;

        public KProcessor? CurrentExecutor 
        {
            get { return _currentExecutor; }
            set
            {
                _currentExecutor = value;
                Process.LastExecutedBlock = Block.PipelineIndex;
            }
        }
        
        public int ExecutorIndex { get; set; } = -1;

        public string Name { get { return $"t{Process.Index + 1}{Block.PipelineIndex + 1}"; } }

        public EBlockState Status
        {
            get
            {
                // устанавливается по окончании выполнения
                // сбрасывается методом Reset()
                if (_status == EBlockState.Done) return EBlockState.Done;

                if (Block.IsBlocked)
                {
                    if (CurrentExecutor == null)
                        return EBlockState.Waiting;
                    else
                        return EBlockState.Busy;
                }
                else
                {
                    if (IsBinded)
                        return EBlockState.Binded;
                    return EBlockState.Ready;
                }
            }
        }

        public int BlockStartTime { get; set; }
        public int BlockDuration { get; set; }
        public int BlockEndTime { get { return BlockStartTime + BlockDuration; } }
                
        public KBlockBinding? NextBlock
        {
            get
            {
                return Process.BlockBindings.FirstOrDefault(bb => bb.Block.PipelineIndex == Block.PipelineIndex + 1);
            }
        }
        public KBlockBinding? PreviousBlock 
        { 
            get
            {
                var previousBlock = Process.BlockBindings.FirstOrDefault(bb => bb.Block.PipelineIndex == Block.PipelineIndex - 1);

                if (previousBlock == null)
                    previousBlock = Process.TransitiveBlock;

                return previousBlock;
            }
        }
        public KBlockBinding? FromNextProcess
        {
            get { return Block.Bindings.FirstOrDefault(bb => bb.Process.Index == Process.Index + 1); }
        }
        public KBlockBinding? FromPreviousProcess
        {
            get { return Block.Bindings.FirstOrDefault(bb => bb.Process.Index == Process.Index - 1); }
        }
        public KBlockBinding? NextBinding
        {
            get
            {
                return Block.Bindings.Where(bb => bb.ThreadIndex == ThreadIndex).FirstOrDefault(bb => bb.Process.Index == Process.Index + 1);
            }
        }
        public KBlockBinding? PreviousBinding
        {
            get
            {
                return Block.Bindings.FirstOrDefault(bb => bb.Block.PipelineIndex == Block.PipelineIndex - 1);
            }
        }

        public KBlockBinding(KBlock block, KProcess process, int blockDuration)
        {
            Block = block;
            Process = process;
            BlockDuration = blockDuration;
        }

        public void DoTick(int currentTick)
        {
            if (Status == EBlockState.Waiting) return;
            if (Status == EBlockState.Busy)
            {
                if (BlockEndTime <= currentTick)
                {
                    // выполнение блока закончилось
                    Block.IsBlocked = false;
                    Block.CurrentProcess = null;
                    IsBinded = false;
                    CurrentExecutor = null;
                    _status = EBlockState.Done;
                }
            }
            if (Status == EBlockState.Binded)
            {
                Block.IsBlocked = true;
                BlockStartTime = currentTick;
                Block.CurrentProcess = Process;
            }
        }

        public int LastCalculatedEndTime { get; private set; } = int.MaxValue;
        public int CalculatedEndTime 
        {
            get
            {
                if (Status == EBlockState.Busy || Status == EBlockState.Done)
                    LastCalculatedEndTime = BlockEndTime;
                else
                if (PreviousBlock != null && (PreviousBlock.Status == EBlockState.Ready || PreviousBlock.Status == EBlockState.Waiting))
                {
                    if (PreviousBlock.LastCalculatedEndTime != int.MaxValue)
                        LastCalculatedEndTime =
                            PreviousBlock.LastCalculatedEndTime + BlockDuration;
                    else
                        LastCalculatedEndTime = int.MaxValue;
                }
                else
                    LastCalculatedEndTime = Process.BlockBindings
                        .Where(bb => bb.Block.PipelineIndex <= Block.PipelineIndex)
                        .Sum(bb => bb.BlockDuration) + Process.ProcessStartTime;

                return LastCalculatedEndTime;
            }
        }

        public bool CanStart(int testTick)
        {
            if (FromPreviousProcess == null) return true;
            if (FromPreviousProcess.CalculatedEndTime > testTick) return false;

            if (NextBlock == null) return true;
            if (NextBlock.CanStart(testTick + BlockDuration)) return true;

            return false;
        }

        public bool CanStartSS(int testTick)
        {
            if (PreviousBlock == null) return true;

            if (PreviousBlock.CalculatedEndTime > testTick) return false;

            //if (PreviousBlock.ExecutorIndex == -1) return false;

            if (NextBinding == null) return true;
            if (NextBinding.CanStartSS(testTick + BlockDuration)) return true;

            return false;
        }

        public void Reset()
        {
            BlockStartTime = 0;
            ExecutorIndex = -1;
            _status = EBlockState.Ready;
        }
    }
}