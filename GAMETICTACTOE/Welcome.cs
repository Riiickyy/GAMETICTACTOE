using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMETICTACTOE
{
    public partial class Welcome : Form
    {
        private Administrator administrator;
        public Welcome(Administrator admin)
        {
            InitializeComponent();
            administrator = admin;


        }

        private void Adminbutton_Click(object sender, EventArgs e)
        {
            administrator adminForm = new administrator(administrator);
            adminForm.Show();
        }

        private void Playerbutton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(administrator); 
            loginForm.Show();
        }
    }
}
