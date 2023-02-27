using SolverForms.Shapes;

namespace SolverForms
{
    public class BackgroundRender
    {
        private GScene _thisScene;
        private Graphics _thisGraphics;
        private CancellationToken _cToken;

        public bool RenderBoundaries { get; set; } = false;

        public BackgroundRender(Graphics graphics, GScene scene, CancellationToken cToken = default)
        {
            _thisScene = scene;
            _thisGraphics = graphics;
            _cToken = cToken;
        }

        public void Start()
        {
            while(!_cToken.IsCancellationRequested)
            {
                //if(_thisScene.IsNeedRender)
                //{
                    _thisGraphics.Clear(_thisScene.Background);
                    foreach (IShape shape in _thisScene.GetChanges())
                    {
                        switch (shape.Type)
                        {
                            case EShapeType.Line: 
                                {
                                    _thisGraphics.DrawLine(
                                    pen: new Pen(new SolidBrush(shape.SolidColor), ((GLine)shape).Width),
                                    pt1: shape.TopLeft,
                                    pt2: new PointF(
                                        (float)(shape.TopLeft.X + Math.Cos(Math.PI / 180 * ((GLine)shape).Angle) * ((GLine)shape).Length),
                                        (float)(shape.TopLeft.Y + Math.Sin(Math.PI / 180 * ((GLine)shape).Angle) * ((GLine)shape).Length)));

                                    if (RenderBoundaries)
                                    {
                                        _thisGraphics.DrawRectangle(
                                            pen: new Pen(new SolidBrush(Color.Red), 1),
                                            rect: Rectangle.Round(shape.Boundaries));
                                    }
                                    break;
                                }
                                
                        }
                    }
                    _thisScene.IsNeedRender = false;
                //}
            }
        }
    }
}
