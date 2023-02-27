using SolverForms.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SolverForms
{
    public partial class Form1 : Form, INotifyPropertyChanged
    {
        public Guid lastShapeId 
        { 
            get 
            { 
                if(userControl11.LastShape == null) return Guid.Empty;
                return userControl11.LastShape.Id; 
            } 
        }

        private int _shapeLength = 0;
        public int ShapeLength 
        { 
            get { return _shapeLength; }
            set 
            { 
                _shapeLength = value;
                OnPropertyChanged();
            }
        }
        public int _shapeWidth = 0;
        public int shapeWidth 
        { 
            get { return _shapeWidth; }
            set
            {
                _shapeWidth = value;
                OnPropertyChanged();
            }
        }
        private int _xPos = 200;
        public int xPos
        {
            get { return _xPos; }
            set
            {
                _xPos = value;
                OnPropertyChanged();
            }
        }
        private int _yPos = 100;
        public int yPos
        {
            get { return _yPos; }
            set
            {
                _yPos = value;
                OnPropertyChanged();
            }
        }

        public float Angle
        {
            get {
                if (userControl11.LastShape == null) return 0F;
                return ((GLine)userControl11.LastShape).Angle; 
            }
            set
            {
                if (userControl11.LastShape == null) return;
                ((GLine)userControl11.LastShape).Angle = value;
                OnPropertyChanged();
            }
        }
        public Form1()
        {
            InitializeComponent();

            comboBox1.DataSource = new string[] { "Line" };

            checkBox2.DataBindings.Add("Checked" , userControl11, "ShowBoundaries", true, DataSourceUpdateMode.OnPropertyChanged);

            upDownX.DataBindings.Add("Value", this, "xPos", true, DataSourceUpdateMode.OnPropertyChanged);
            upDownX.Maximum = userControl11.Width;
            upDownY.Maximum = userControl11.Height;
            upDownY.DataBindings.Add("Value", this, "yPos", true, DataSourceUpdateMode.OnPropertyChanged);

            widthSlider.DataBindings.Add("Value", this, "shapeWidth", true, DataSourceUpdateMode.OnPropertyChanged);
            lengthSlider.DataBindings.Add("Value", this, "shapeLength", true, DataSourceUpdateMode.OnPropertyChanged);
            angleSlider.DataBindings.Add("Value", this, "Angle", true, DataSourceUpdateMode.OnPropertyChanged);
            selAngleValue.DataBindings.Add("Text", this, "Angle", true, DataSourceUpdateMode.OnPropertyChanged);

            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs pe)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? selectedShapeType = comboBox1.SelectedItem as string;

            if(checkBox1.Checked) 
            {
                Random rnd = new();
                xPos = rnd.Next(userControl11.Size.Width);
                yPos = rnd.Next(userControl11.Size.Height);
            }

            switch (selectedShapeType?.ToLower())
            {
                case "line":
                    userControl11.AddToScene(new GLine()
                    {
                        TopLeft = new Point(xPos, yPos),
                        SolidColor = Color.DarkGray,
                        Width = shapeWidth,
                        Length = ShapeLength,
                        Angle= this.Angle,
                    });
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.ClearScene();
        }

        private void commonShapeProp_ValueChanged(object sender, EventArgs e)
        {
            switch(((Control)sender).Name)
            {
                case "lengthSlider":
                    userControl11.ChangeProperty("length", lastShapeId, length: ShapeLength);
                    break;
                case "widthSlider":
                    userControl11.ChangeProperty("width", lastShapeId, shapeWidth);
                    break;
                case "upDownX":
                case "upDownY":
                case "angleSlider":
                    userControl11.ChangeProperty("position", lastShapeId, posX: xPos, posY: yPos, angle: Angle);
                    break;

            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
 
        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            userControl11.ChangeProperty("position", lastShapeId, posX: xPos, posY: yPos, angle: ++Angle);
        }
    }
}