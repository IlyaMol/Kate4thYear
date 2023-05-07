using ProblemOne;

namespace SolverForms.DrawLib
{
    public static class KStateMashineExtentions
    {
        public static KGLayer? BuildGraphics(this KStateMachine stateMachine)
        {
            KGLayer layer = new KGLayer();

            foreach (KProcess process in stateMachine.Processes)
                foreach (KBlockBinding block in process.BlockBindings)
                {
                    if (block.BlockDuration == 0) continue;
                    layer.AddShape(new KGLine // Линия
                    {
                        StartPoint = new PointF(block.BlockStartTime, 0),
                        Lenth = block.BlockDuration,
                        MainPen = new Pen(new SolidBrush(Color.Black), 1),
                        StartLineCap = KGLineCap.VerticalLine(8),
                        EndLineCap = KGLineCap.VerticalLine(-8),
                    }, process.ExecutorIndex);
                }
            return layer;
        }
    }
}