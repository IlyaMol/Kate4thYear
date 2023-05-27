namespace SolverForms.DrawLib
{


    public class KSceneGenerator
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public float XUnitSize { get; private set; }
        public float YUnitSize { get; private set; }

        public Padding CoordPadding { get; set; } = new Padding();

        public KSceneGenerator(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public ICollection<KGLine> GetCoordPlane(int yDelimetersCount, int offset = 5)
        {
            ICollection<KGLine> scene = new List<KGLine>();
            KGLine xCoordLine = new KGLine() {
                StartPoint = new PointF(CoordPadding.Left, Height - (CoordPadding.Bottom)),
                Padding = new Padding(0,0,10,0),
                Lenth = Width - CoordPadding.Right*2,
                Angle = 0f
            };
            KGLine yCoordLine = new KGLine()
            {
                StartPoint = new PointF(CoordPadding.Left, Height - (CoordPadding.Bottom)),
                Lenth = Height - CoordPadding.Top*2,
                Angle = 270f
            };

            for (int i = 1; i <= yDelimetersCount; i++)
            {
                YUnitSize = yCoordLine.UsefullLength / yDelimetersCount;
                scene.Add(new KGLine()
                {
                    StartPoint = new PointF(CoordPadding.Left - offset / 2, (Height - CoordPadding.Bottom) - YUnitSize * i),
                    Lenth = offset,
                    Angle = 0f
                });
            }

            int xDelimetersCount = (int)((xCoordLine.Lenth - offset*2) / (offset * 3));
            for (int i = 1; i <= xDelimetersCount; i++)
            {
                YUnitSize = xCoordLine.UsefullLength / xDelimetersCount;
                scene.Add(new KGLine()
                {
                    StartPoint = new PointF((CoordPadding.Left + YUnitSize * i), Height - (CoordPadding.Bottom) - offset / 2),
                    Lenth = offset,
                    Angle = 90f
                });
            }
                

            scene.Add(xCoordLine);
            scene.Add(yCoordLine);
            return scene;
        }
    }
}
