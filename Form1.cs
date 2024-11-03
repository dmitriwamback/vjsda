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

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Scripts.teleportToRandomScript;
            ForlornApi.Api.ExecuteScript(richTextBox1.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Scripts.superJumpAndSpeed;
            ForlornApi.Api.ExecuteScript(richTextBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Scripts.teleportJump;
            ForlornApi.Api.ExecuteScript(richTextBox1.Text);
        }
    }
}
