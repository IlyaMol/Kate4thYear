namespace SolverForms.DrawLib
{
    public class KGLine
    {
        public PointF StartPoint { get; set; }
        public PointF EndPoint 
        {
            get
            {
                return new PointF(StartPoint.X + MathF.Cos(Angle) * Lenth, StartPoint.Y + MathF.Sin(Angle) * Lenth);
            }
        }

        public float Lenth { get; set; }

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