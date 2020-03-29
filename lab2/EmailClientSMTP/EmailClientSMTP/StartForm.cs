using System;
using System.Windows.Forms;

namespace EmailClientSMTP
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new SendForm().Show();
            Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new RetriveMail().Show();
            Hide();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
