using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GAMETICTACTOE
{
    public partial class Login : Form
    {
        private Administrator administrator;
        private bool isLoggedIn = false;


        public Login(Administrator admin)
        {
            InitializeComponent();
            administrator = admin;


        }

        private void LOGINBUTTON_Click(object sender, EventArgs e)
        {
            string playerId = PlayerID.Text;
            string password = PlayerPassword.Text;

            if (string.IsNullOrEmpty(playerId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both ID and password.");
                PlayerID.Text = "";
                PlayerPassword.Text = "";
                return;
            }

            isLoggedIn = administrator.Players.Any(player => player.VerifyLogin(playerId, password));

            if (isLoggedIn)
            {


                Form1 playerWindow = new Form1();
                playerWindow.FormClosed += (s, args) => this.Show();
                PlayerID.Text = "";
                PlayerPassword.Text = "";
                playerWindow.Show();
                this.Hide();

            }
            else
            {
                // Display error message
                MessageBox.Show("Invalid ID or password.");
                PlayerID.Text = "";
                PlayerPassword.Text = "";
            }
        }

       



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome(administrator);
            welcome.Show();
            this.Hide();
        }
    }

}