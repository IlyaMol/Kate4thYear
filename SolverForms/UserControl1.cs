using SolverForms.Shapes;
using System.Diagnostics;

namespace SolverForms
{
    public partial class UserControl1 : UserControl
    {
        private GScene _thisScene;
        private CancellationTokenSource tokenSource = new CancellationTokenSource();
        BackgroundRender _render;

        public IShape? LastShape { get; private set; } = new GLine();

        public bool ShowBoundaries 
        { 
            get
            {
                return _render.RenderBoundaries;
            }
            set
            {
                _render.RenderBoundaries = value;
                _thisScene.IsNeedRender= true;
            }
        }

        public UserControl1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            this.Disposed += OnDispose;

            _thisScene = new GScene(this.BackColor);

            _render = new BackgroundRender(CreateGraphics(), _thisScene, tokenSource.Token);

            Thread th = new Thread(new ThreadStart(_render.Start));
            th.Start();
        }

        public GScene GetScene()
        {
            return _thisScene;
        }

        public Guid AddToScene(IShape? shape)
        {
            if (shape != null)
            {
                _thisScene.AddShape(shape);
                LastShape = shape;
                return shape.Id;
            }
            return Guid.Empty;
        }

        public void ClearScene()
        {
            _thisScene.ClearScene();
        }

        public void ChangeProperty(string propName, Guid shapeId, int? width = null, int? length = null, int? posX = null, int? posY = null, float? angle = null)
        {
            switch (propName.ToLower())
            {
                case "length":
                    LastShape = _thisScene.ShapeChanger.ChangeLength(shapeId, length);
                    break;
                case "width":
                    LastShape = _thisScene.ShapeChanger.ChangeWidth(shapeId, width);
                    break;
                case "position":
                        LastShape = _thisScene.ShapeChanger.ChangePosition(shapeId, posX, posY, angle);
                    break;
            }
        }

        private void OnDispose(object sender, EventArgs e)
        {
            tokenSource.Cancel();
        }

        private void UserControl1_MouseClick(object sender, MouseEventArgs e)
        {
            LastShape = _thisScene.Shapes.FirstOrDefault(
                sh => sh.Boundaries.Contains(e.Location));

            Debug.WriteLine(e.Location);
        }

        private void UserControl1_MouseDown(object sender, MouseEventArgs e)
        {
            Debug.WriteLine($"{e.X} {e.Y}");
        }
    }
}
