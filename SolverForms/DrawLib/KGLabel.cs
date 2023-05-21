namespace SolverForms.DrawLib
{
    public class KGLabel : IKGShape
    {
        private PointF _startPoint;

        public string Text { get; set; } = "";
        public Font Font { get; set; } = new Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point);

        public EGTextAlignment Alignment { get; set; } // Alignment of the label (Left, Right, Center)
        public EGLabelPosition Position { get; set; } // Position of the label in relation to the line (Left, Right, Top, Bottom)
        public KGLine? AssociatedShape { get; set; }

        public IKGShapeType Type { get; } = IKGShapeType.LABEL;

        public Pen MainPen { get; set; } = new Pen(Color.Black);
        public PointF StartPoint 
        { 
            get
            {
                if (AssociatedShape == null)
                    return _startPoint;
                else return CalculateLabelPosition();
            }
            set
            {
                if (AssociatedShape == null)
                    _startPoint = value;
            }
        }

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

        private PointF CalculateLabelPosition()
        {
            PointF labelPosition = PointF.Empty;

            if (AssociatedShape == null) return labelPosition;

            SizeF textSize = TextRenderer.MeasureText(Text, Font);

            // Calculate the label's position relative to the line's endpoints
            float labelOffsetX = 0;
            float labelOffsetY = 0;

            float lineThickness = AssociatedShape.EndPoint.X - AssociatedShape.StartPoint.X;
            float lineThisknessY = AssociatedShape.EndPoint.Y - AssociatedShape.StartPoint.Y;

            switch (this.Position)
            {
                case EGLabelPosition.Left:
                    if(Alignment == EGTextAlignment.Center)
                    {
                        labelOffsetY -= textSize.Height /2;
                        labelOffsetX -= textSize.Width;
                    }
                    break;
                case EGLabelPosition.Right:
                    labelOffsetX += textSize.Width;
                    break;
                case EGLabelPosition.Top:
                    if (Alignment == EGTextAlignment.Center)
                    {
                        labelOffsetX += (AssociatedShape.Lenth - textSize.Width) / 2;
                        labelOffsetY -= textSize.Height + AssociatedShape.StrokeThickness;
                    }
                    break;
                case EGLabelPosition.Bottom:
                    if (Alignment == EGTextAlignment.Center)
                    {
                        labelOffsetX += (AssociatedShape.Lenth - textSize.Width) / 2;
                        labelOffsetY += textSize.Height - Padding.Vertical;
                    }
                    
                    break;
            }

            // Apply the offset to the line's start point
            PointF startPoint = AssociatedShape.StartPoint;
            labelPosition = new PointF(startPoint.X + labelOffsetX, startPoint.Y + labelOffsetY);

            return labelPosition;
        }
    }
}
