using SolverForms.DrawLib;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Drawing2D;
using System.Drawing;
using static System.Windows.Forms.DataFormats;

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
                        KGLine line = (KGLine)shape;
                        line.MainPen.CustomStartCap = line.StartLineCap;
                        line.MainPen.CustomEndCap = line.EndLineCap;
                        e.Graphics.DrawLine(line.MainPen, line.StartPoint, line.EndPoint);
                        if(line.Label != null)
                        {
                            e.Graphics.DrawString(line.Label.Text, line.Label.Font, line.Label.MainPen.Brush, line.Label.StartPoint);
                        }
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
