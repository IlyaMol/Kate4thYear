using SolverForms.Views;

namespace SolverForms
{
    public partial class LauncherForm : Form
    {
        public LauncherForm()
        {
            InitializeComponent();

            ProblemOneTabPage tab1 = new ProblemOneTabPage();
            tabControl1.TabPages.Add(tab1);
        }
    }
}
