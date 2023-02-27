namespace SolverForms
{
    public partial class Form1 : Form
    {
        private StateMashineViewModel MashineViewModel { get; set; } = new StateMashineViewModel();

        public Form1()
        {
            InitializeComponent();
            CompleteDataBindings();
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
        }
    }
}