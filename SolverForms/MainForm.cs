using SolverForms.DrawLib;

namespace SolverForms
{
    public partial class MainForm : Form
    {
        private MainFormViewModel ViewModel = new();
        public MainForm()
        {
            InitializeComponent();
            sourceDataLayout.AutoSize= true;
            sourceDataLayout.AutoSizeMode=AutoSizeMode.GrowAndShrink;
            sourceMatrixView.AutoSize = true;
            sourceMatrixView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            resultMatrixView.AutoSize = true;
            resultMatrixView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            resultMatrixView.Enabled= true;
            CompleteDataBindings();
        }

        private void CompleteDataBindings()
        {
            processorCountNumUpDownValue.DataBindings.Add(
                nameof(processorCountNumUpDownValue.Value),
                ViewModel,
                nameof(ViewModel.ProcessorCount),
                true,
                DataSourceUpdateMode.OnPropertyChanged);
            processCountNumUpDownValue.DataBindings.Add(
                nameof(processorCountNumUpDownValue.Value),
                sourceMatrixView,
                nameof(sourceMatrixView.RowCount),
                true,
                DataSourceUpdateMode.OnPropertyChanged);
            blockCountNumUpDownValue.DataBindings.Add(
                nameof(blockCountNumUpDownValue.Value),
                sourceMatrixView,
                nameof(sourceMatrixView.ColumnCount),
                true,
                DataSourceUpdateMode.OnPropertyChanged);
            criticalPathLengthValue.DataBindings.Add(
                nameof(criticalPathLengthValue.Text),
                ViewModel,
                nameof(ViewModel.CriticalPathLength),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            resultMatrixView.DataBindings.Add(
                nameof(resultMatrixView.DataSource),
                ViewModel,
                nameof(ViewModel.ResultMatrix),
                false,
                DataSourceUpdateMode.OnPropertyChanged);
            resultMatrixView.DataBindings.Add(
                nameof(resultMatrixView.SelectedCells),
                ViewModel,
                nameof(ViewModel.CriticalPath),
                false,
                DataSourceUpdateMode.OnPropertyChanged);

            drawPanel.Paint += (sender, e) => drawPanel_OnPaint(sender, e);
            drawPanel.SizeChanged += (sender, e) => { ViewModel.RedrawGraphics(); };
            sourceMatrixView.DataSourceChanged += ViewModel.DataSourceChangedDelegate;
            ViewModel.OnFrameUpdate += ViewModel_OnFrameUpdate;
            
        }

        private ICollection<KGLine> scene = new HashSet<KGLine>();
        private void drawPanel_OnPaint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            ViewModel.CurrentSceneHeight = g.VisibleClipBounds.Height;
            ViewModel.CurrentSceneWidth = g.VisibleClipBounds.Width;

            g.Clear(drawPanel.BackColor);

            foreach (KGLine line in scene)
            {
                g.DrawLine(new Pen(Color.Black), line.StartPoint, line.EndPoint);
            }
        }

        private void ViewModel_OnFrameUpdate(ICollection<KGLine> scene)
        {
            this.scene = scene;
            drawPanel.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewModel.ProcessorCount = 3;
            sourceMatrixView.DataSource = new int[8, 4]
            {
                { 3,2,1,4 },
                { 1,2,3,1 },
                { 4,1,3,2 },
                { 2,1,1,3 },
                { 1,3,1,1 },
                { 4,3,3,1 },
                { 2,2,3,2 },
                { 1,2,1,5 }
            };
        }
    }
}