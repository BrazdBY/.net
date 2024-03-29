namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            var HelloMessage = SharedLibrary.SayHello.GetHello(username);
            var HelloWindow = new HelloForm(HelloMessage);
            HelloWindow.Show();
        }
    }
}
