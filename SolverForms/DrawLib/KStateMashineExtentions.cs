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
                    };

                    lineLayer.AddShape(line, block.ExecutorIndex);

                    KGLabel label = new KGLabel
                    {
                        StartPoint = new PointF(block.BlockStartTime, 0),
                        Text = block.Name
                    };

                    //int leftPadding = ((int)line.EndPoint.X - (int)line.StartPoint.X) - ((int)Math.Floor(label.EndPoint.X - label.StartPoint.X) / 2);
                    label.Padding = new Padding(0, 20, 0, 0);
                    labelLayer.AddShape(label, block.ExecutorIndex);
                }

            return new HashSet<KGLayer>
            {
                lineLayer,
                labelLayer
            };
        }
    }
}