using System.Drawing.Drawing2D;

namespace SolverForms.DrawLib
{
    public class KGLineCap
    {
        public static CustomLineCap Default()
        {
            GraphicsPath path1 = new GraphicsPath();
            return new CustomLineCap(null, path1);
        }
        public static CustomLineCap Circle(float diameter) 
        {
            GraphicsPath path1 = new GraphicsPath();
            path1.AddEllipse(diameter/-2, diameter/-2, diameter, diameter);
            return new CustomLineCap(path1,null);
        }
        public static CustomLineCap VerticalLine(float length)
        {
            GraphicsPath path1 = new GraphicsPath();
            path1.AddLine(length/2, 0, -length/2, 0);
            return new CustomLineCap(null, path1);
        }
        public static CustomLineCap Arrow(float length)
        {
            GraphicsPath path1 = new GraphicsPath();
            path1.AddLine(-length/2, 0, length/2, 0);
            path1.AddLine(-length/2, 0, 0, length);
            path1.AddLine(0, length, length/2, 0);
            return new CustomLineCap(null, path1);
        }
    }

    public class KGLine : IKGShape
    {
        public IKGShapeType Type { get; } = IKGShapeType.LINE;

        public Color ForeColor { get; set; } = Color.Black;

        public Pen MainPen { get; set; } = new Pen(Color.Black);
        public Pen CapPen { get; set; } = new Pen(Color.Black);
        public Pen DashPen { get; set; } = new Pen(Color.Black);

        public float StrokeThickness { get; set; } = 1f;

        public PointF StartPoint { get; set; }
        public CustomLineCap StartLineCap { get; set; } = KGLineCap.Default();
        public PointF EndPoint 
        {
            get
            {
                return new PointF(StartPoint.X + MathF.Cos(Angle) * Lenth, StartPoint.Y + MathF.Sin(Angle) * Lenth);
            }
        }
        public CustomLineCap EndLineCap { get; set; } = KGLineCap.Default();

        public float Lenth { get; set; }

        public Padding Padding { get; set; } = new Padding(10);
        public float UsefullLength
        {
            get
            {
                return Lenth - Padding.Left - Padding.Right;
            }
        }

        private float angleRad = 0;
        public float Angle 
        {
            get
            {
                return angleRad;
            }
            set
            {
                angleRad = value * (MathF.PI/180);
            }
        }
    }
}