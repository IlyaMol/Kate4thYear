namespace SolverForms.Shapes
{
    public abstract class Shape : IShape
    {
        private PointF _topLeftPosition;
        public Guid Id { get; private set; }

        public bool IsChanged { get; set; }
        public PointF TopLeft 
        {
            get { return _topLeftPosition; }
            set
            {
                _topLeftPosition = value;
                ResizeBoundaries();
            }
        }
        public Color SolidColor { get; set; }
        public GScene? ParentScene { get; set; }

        public RectangleF Boundaries { get; set; }

        public abstract EShapeType Type { get; set; }

        public Shape()
        {
            Id = Guid.NewGuid();
            Boundaries = Rectangle.Empty;
        }

        internal abstract void ResizeBoundaries();
    }
}
