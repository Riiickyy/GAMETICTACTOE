using System;
using System.Windows.Forms;

namespace GAMETICTACTOE
{
    public partial class administrator : Form
    {
        private Administrator admin;
        public administrator(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin; // Assign the passed Administrator object to the local admin variable
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create create = new Create(admin);
            create.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uppdate update = new Uppdate(admin);
            update.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome(admin);
            welcome.Show();
        }

        private void administrator_Load(object sender, EventArgs e)
        {

        }
    }
}
