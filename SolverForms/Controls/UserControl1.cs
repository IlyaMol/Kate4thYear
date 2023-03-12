using SolverForms.DrawLib;

namespace SolverForms.Controls
{
    public partial class UserControl1 : UserControl
    {
        public KGScene? Scene { get; set; }

        public UserControl1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(this.BackColor);
            if (Scene == null) return;
            foreach(IKGShape shape in Scene.Shapes)
            {
                if(shape.Type == IKGShapeType.LINE)
                    e.Graphics.DrawLine(new Pen(Color.Black), shape.StartPoint, shape.EndPoint);
            }
        }
    }
}
