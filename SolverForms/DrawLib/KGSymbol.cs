namespace SolverForms.DrawLib
{
    public class KGSymbol : IKGShape
    {
        public IKGShapeType Type { get; } = IKGShapeType.SYMBOL;

        public Pen MainPen { get; set; } = new Pen(Color.Black);

        public PointF StartPoint { get; set; }
        public PointF EndPoint { get; }

        public Padding Padding { get; set; } = new Padding(10);

        public char Char { get; set; } = ' ';

        private float angleRad = 0;
        public float Angle
        {
            get
            {
                return angleRad;
            }
            set
            {
                angleRad = value * (MathF.PI / 180);
            }
        }

        public override string ToString()
        {
            return Char.ToString();
        }
    }
}
