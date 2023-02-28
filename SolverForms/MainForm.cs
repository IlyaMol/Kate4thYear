namespace SolverForms
{
    public partial class MainForm : Form
    {
        private StateMashineViewModel MashineViewModel { get; set; } = new StateMashineViewModel();

        public MainForm()
        {
            InitializeComponent();
            CompleteDataBindings();

            kGraphView1.DataSource = MashineViewModel.Matrix;
        } 

        private void CompleteDataBindings()
        {
            processorCountNumUpDownValue.DataBindings.Add("Value", MashineViewModel, "ProcessorCount");
            processCountNumUpDownValue.DataBindings.Add("Value", MashineViewModel, "ProcessCount"); 
            blockCountNumUpDownValue.DataBindings.Add("Value", MashineViewModel, "BlockCount");
        }

        private void BuildGraphButton_Click(object sender, EventArgs e)
        {
            MashineViewModel.TryBuildGraph();
            kGraphView1.DataSource = MashineViewModel.Matrix;
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            MashineViewModel.ImportJson();
        }
    }
}