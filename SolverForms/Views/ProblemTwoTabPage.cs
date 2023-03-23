using SolverForms.Views.ViewModels;

namespace SolverForms.Views
{
    public partial class ProblemTwoTabPage : Form
    {
        private ProblemTwoViewModel viewModel;
        
        public ProblemTwoTabPage()
        {
            viewModel = new ProblemTwoViewModel();
            InitializeComponent();
        }


    }
}