namespace Feladatok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            new Visszaszamlalas().ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
       => new Regisztracio().ShowDialog();
    }
}
