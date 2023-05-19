using ProblemOne.KStates;

namespace ProblemOne
{
    public class KBlockBinding
    {
        private EBlockState _status = EBlockState.Ready;

        public KBlock Block { get; private set; }
        public KProcess Process { get; private set; }
        public uint ThreadIndex { get; set; } = 0;

        public KProcessor? CurrentExecutor { get; set; }

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
                    return EBlockState.Ready;
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

                    _status = EBlockState.Done;
                    CurrentExecutor = null;
                }
            }
            if (Status == EBlockState.Ready)
            {
                Block.IsBlocked = true;
                BlockStartTime = currentTick;
                Block.CurrentProcess = Process;
            }
        }

        public void Reset()
        {
            BlockStartTime = 0;
            _status = EBlockState.Ready;
        }
    }
}
