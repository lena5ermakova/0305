namespace _0305
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // установка обработчика события Scroll
            trackBar1.Scroll += trackBar1_Scroll;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = String.Format("Текущее значение: {0}", trackBar1.Value);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}