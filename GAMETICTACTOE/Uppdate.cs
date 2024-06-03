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
    
    public partial class Uppdate : Form
    {
        private Administrator administrator;
        public Uppdate(Administrator admin)
        {
            InitializeComponent();
            administrator = admin;


        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string playerIdToUpdate = OldID.Text;
            string newPassword = NewPassword.Text;

            if (string.IsNullOrEmpty(playerIdToUpdate) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please enter both player ID and new password.");
                OldID.Text = "";
                NewPassword.Text = "";
                return;
            }

            administrator.UpdatePlayerPassword(playerIdToUpdate, newPassword);
            OldID.Text = "";
            NewPassword.Text = "";
           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void NewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void OldID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome(administrator);
            welcome.Show();
            this.Hide();
        }
    }
}
