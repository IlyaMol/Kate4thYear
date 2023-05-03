using ProblemOne;

namespace SolverForms.DrawLib
{
    public static class KStateMashineExtentions
    {
        public static KGLayer? BuildGraphics(this KStateMachine stateMachine)
        {
            KGLayer layer = new KGLayer();

            foreach (KProcess process in stateMachine.Processes)
                foreach (KBlock block in process.Blocks)
                {
                    if (block.Duration == 0) continue;
                    layer.AddShape(new KGLine // Линия
                    {
                        StartPoint = new PointF(block.StartTime, 0),
                        Lenth = block.Duration,
                        MainPen = new Pen(new SolidBrush(Color.Black), 1),
                        StartLineCap = KGLineCap.VerticalLine(8),
                        EndLineCap = KGLineCap.VerticalLine(-8),
                    }, process.Index);
                    layer.AddShape(new KGSymbol
                    {
                        Char = ((char)block.PipelineIndex),
                        StartPoint = new PointF(block.StartTime/2, 0),
                        MainPen = new Pen(new SolidBrush(Color.Black), 1),
                    });
                }
            return layer;
        }
    }
}