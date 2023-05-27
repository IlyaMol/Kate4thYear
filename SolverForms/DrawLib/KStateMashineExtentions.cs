using ProblemOne;

namespace SolverForms.DrawLib
{
    public static class KStateMashineExtentions
    {
        public static ICollection<KGLayer> BuildGraphics(this KStateMachine stateMachine)
        {
            KGLayer lineLayer = new KGLayer();
            KGLayer labelLayer = new KGLayer();

            foreach (KProcess process in stateMachine.Processes)
                foreach (KBlockBinding block in process.BlockBindings)
                {
                    if (block.BlockDuration == 0) continue;

                    KGLine line = new KGLine // Линия
                    {
                        StartPoint = new PointF(block.BlockStartTime, 0),
                        Lenth = block.BlockDuration,
                        MainPen = new Pen(new SolidBrush(Color.Black), 1),
                        StartLineCap = KGLineCap.VerticalLine(8),
                        EndLineCap = KGLineCap.VerticalLine(-8),
                    }.AddLabel(block.Name, EGLabelPosition.Top, EGTextAlignment.Center, new Padding(10,10,10,20));

                    lineLayer.AddShape(line, block.ExecutorIndex);
                }

            return new HashSet<KGLayer>
            {
                lineLayer,
                labelLayer
            };
        }
    }
}