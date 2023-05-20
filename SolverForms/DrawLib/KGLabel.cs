namespace SolverForms.DrawLib
{
    public class KGLabel : IKGShape
    {
        public string Text { get; set; } = "";
        public Font Font { get; set; } = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);

        public IKGShapeType Type { get; } = IKGShapeType.LABEL;

        public Pen MainPen { get; set; } = new Pen(Color.Black);
        public PointF StartPoint { get; set; }

        public PointF EndPoint
        {
            get
            {
                using Bitmap bmp = new Bitmap(1, 1);
                using Graphics g = Graphics.FromImage(bmp);

                SizeF textSize = g.MeasureString(Text, Font);

                float width = textSize.Width;
                float height = textSize.Height;

                float rotatedWidth = (float)(Math.Abs(width * Math.Cos(Angle)) + Math.Abs(height * Math.Sin(Angle)));
                float rotatedHeight = (float)(Math.Abs(height * Math.Cos(Angle)) + Math.Abs(width * Math.Sin(Angle)));

                PointF endPoint = new PointF(StartPoint.X + rotatedWidth, StartPoint.Y + rotatedHeight);
                return endPoint;
            }
        }

        public Padding Padding { get; set; } = new Padding(10);

        private float angleDeg = 0;
        public float Angle
        {
            get
            {
                return angleDeg;
            }
            set
            {
                angleDeg = value * (MathF.PI / 180);
            }
        }
    }
}
