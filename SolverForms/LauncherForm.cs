 using SolverForms.Views;

namespace SolverForms
{
    public partial class LauncherForm : Form
    {
        public LauncherForm()
        {
            InitializeComponent();

            tabControl1.TabPages.Add(new ProblemOneTabPage());
            tabControl1.TabPages.Add(new ProblemTwoTabPage());
            tabControl1.TabPages.Add(new ProblemThreeTabPage());
            tabControl1.TabPages.Add(new ProblemFiveTabPage());
        }
    }
}
