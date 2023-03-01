using SolverForms.Helpers;
using System.Text;

namespace SolverForms
{
    public partial class MainForm : Form
    {
        public MainFormViewModel ViewModel { get; set; } = new MainFormViewModel();

        public MainForm()
        {
            InitializeComponent();
            CompleteDataBindings();
        }

        private void CompleteDataBindings()
        {
            processorCountNumUpDownValue.DataBindings.Add("Value", ViewModel, "ProcessorCount", false, DataSourceUpdateMode.OnPropertyChanged);
            processCountNumUpDownValue.DataBindings.Add("Value", ViewModel, "ProcessCount", false, DataSourceUpdateMode.OnPropertyChanged); 
            blockCountNumUpDownValue.DataBindings.Add("Value", ViewModel, "BlockCount", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            if(openJsonFile.ShowDialog(this) == DialogResult.OK)
            {
                long fileLength = openJsonFile.OpenFile().Length;
                byte[] buffer = new byte[fileLength];
                openJsonFile.OpenFile().Read(buffer);
                var jsonString = Encoding.Default.GetString(buffer);
                if (jsonString == null) return;
                MainFormViewModel? data = Json.Deserialize<MainFormViewModel>(jsonString);
                if(data == null) return;
                ViewModel = data;
            }
        }
        private void exportButton_Click(object sender, EventArgs e)
        {
            string jsonString = Json.Serialize(ViewModel);
            if(saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                Stream stream = saveFileDialog.OpenFile();
                if (stream.CanWrite)
                {
                    byte[] bytes = Encoding.ASCII.GetBytes(jsonString);
                    stream.Write(bytes);
                }
                stream.Close();
                saveFileDialog.Dispose();
            }
        }
    }
}