using SolverForms.DrawLib;

namespace SolverForms.Views.Controls
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
            foreach (IKGShape shape in Scene.Shapes)
            {
                if(shape.Type == IKGShapeType.LINE)
                {
                    shape.MainPen.CustomStartCap = ((KGLine)shape).StartLineCap;
                    shape.MainPen.CustomEndCap = ((KGLine)shape).EndLineCap;
                    e.Graphics.DrawLine(shape.MainPen, shape.StartPoint, shape.EndPoint);
                }
            }
        }
    }
}
