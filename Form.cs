namespace vjsda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.ExecuteScript(richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.Inject();
        }
    }
}
