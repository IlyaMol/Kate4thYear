namespace SolverForms.Controls
{
    public partial class UserControl1 : UserControl
    {
        public ICollection<DrawLib.KGLine> Scene { get; set; }

        public UserControl1()
        {
            InitializeComponent();
            Scene = new List<DrawLib.KGLine>();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach(var scene in Scene)
            {
                e.Graphics.DrawLine(new Pen(Color.Black), scene.StartPoint, scene.EndPoint);
            }
        }
    }
}
