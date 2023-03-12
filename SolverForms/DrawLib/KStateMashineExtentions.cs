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
                    layer.AddShape(new KGLine() // Штрих левый
                    {
                        StartPoint = new PointF(block.StartTime, 3f),
                        Lenth = 0.5f,
                        Angle = 90
                    }, process.Index);
                    layer.AddShape(new KGLine // Линия
                    {
                        StartPoint = new PointF(block.StartTime, 0),
                        Lenth = block.Duration
                    }, process.Index);
                    layer.AddShape(new KGLine() // Штрих правый
                    {
                        StartPoint = new PointF(block.EndTime, 3f),
                        Lenth = 0.5f,
                        Angle = 90
                    }, process.Index);
                }
            return layer;
        }
    }
}