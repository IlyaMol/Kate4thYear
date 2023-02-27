namespace SolverForms.Shapes
{
    public class GLine : Shape
    {
        private int _length = 0;
        private int _width = 0;

        public int Length 
        { 
            get {  return _length; }
            set
            {
                _length = value;
                ResizeBoundaries();
            }
        }
        public int Width 
        {
            get { return _width; }
            set
            {
                _width = value;
                ResizeBoundaries();
            }
        }

        private float _angle = 0F;
        public float Angle
        {
            get
            {
                return _angle;
            }
            set
            {
                if (value > 360) _angle = 0;
                else 
                    _angle = value;
            }
        }

        public override EShapeType Type { get; set; } = EShapeType.Line;

        public GLine() : base() 
        {
            Boundaries = new RectangleF()
            {
                Width = this.Length,
                Height = this.Width,
                Location = new PointF(this.TopLeft.X, this.TopLeft.Y - (Width/2))
            };
        }

        internal override void ResizeBoundaries()
        {
            Boundaries = new RectangleF()
            {
                Width = this.Length,
                Height = this.Width,
                Location = new PointF(this.TopLeft.X, this.TopLeft.Y - (Width / 2))
            };
        }
    }
}
