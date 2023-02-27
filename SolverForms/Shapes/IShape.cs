namespace SolverForms.Shapes
{
    public interface IShape
    {
        Guid Id { get; }

        GScene? ParentScene { get; internal set; }

        EShapeType Type { get; }

        Color SolidColor { get; set; }
        PointF TopLeft { get; set; }

        RectangleF Boundaries { get; set; }
    }
}