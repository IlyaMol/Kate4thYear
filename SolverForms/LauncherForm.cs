using SolverForms.Views;

namespace SolverForms
{
    public partial class LauncherForm : Form
    {
        public LauncherForm()
        {
            InitializeComponent();

            //ProblemOneTabPage tab1 = new ProblemOneTabPage();
            ProblemTwoTabPage tab2 = new ProblemTwoTabPage();
            //tabControl1.TabPages.Add(tab1);
            tabControl1.TabPages.Add(tab2);
        }
    }
}
