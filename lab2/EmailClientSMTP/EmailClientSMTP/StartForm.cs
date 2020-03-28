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
    }
}
