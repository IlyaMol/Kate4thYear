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
                // устанавливается процессором по окончании выполнения
                // сбрасывается только методом Reset()
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
                    else
                    if (Block.Bindings.Any(bb => bb.IsBinded))
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
                return Process.BlockBindings.FirstOrDefault(bb => bb.Block.PipelineIndex == Block.PipelineIndex - 1);
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
                    _status = EBlockState.Done;
                    CurrentExecutor = null;
                }
            }
            if (Status == EBlockState.Binded)
            {
                Block.IsBlocked = true;
                BlockStartTime = currentTick;
                Block.CurrentProcess = Process;
            }
        }

        public void Reset()
        {
            BlockStartTime = 0;
            ExecutorIndex = -1;
            _status = EBlockState.Ready;
        }
    }
}