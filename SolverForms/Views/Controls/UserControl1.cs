using SolverForms.DrawLib;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Drawing2D;
using System.Drawing;

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
            foreach(var layer in Scene.SceneShapes)
            foreach (IKGShape shape in layer)
            {
                if(shape.Type == IKGShapeType.LINE)
                {
                    shape.MainPen.CustomStartCap = ((KGLine)shape).StartLineCap;
                    shape.MainPen.CustomEndCap = ((KGLine)shape).EndLineCap;
                    e.Graphics.DrawLine(shape.MainPen, shape.StartPoint, shape.EndPoint);
                }
                if (shape.Type == IKGShapeType.LABEL)
                {
                    using (Matrix matrix = new Matrix())
                    {
                        matrix.Translate(shape.StartPoint.X, shape.StartPoint.Y);
                        matrix.RotateAt(shape.Angle, shape.StartPoint);
                        e.Graphics.Transform = matrix;
                        e.Graphics.DrawString(((KGLabel)shape).Text, ((KGLabel)shape).Font, Brushes.Black, PointF.Empty);
                    }
                }
                if (shape.Type == IKGShapeType.SYMBOL)
                {
                    e.Graphics.DrawString(shape.ToString(), SystemFonts.DefaultFont, shape.MainPen.Brush, shape.StartPoint);
                }
            }
        }
    }
}
