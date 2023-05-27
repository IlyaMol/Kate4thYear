namespace SolverForms.DrawLib
{
    public interface IKGShape
    {
        IKGShapeType Type { get; }

        Pen MainPen { get; set; }

        PointF StartPoint { get; set; }
        PointF EndPoint { get; }

        Padding Padding { get; set; }

        float Angle { get; set; }
    }
}
