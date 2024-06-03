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
    
    public partial class Create : Form
    {
        private Administrator administrator;
        public Create(Administrator admin)
        {
            InitializeComponent();
            administrator = admin;


        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string playerName = Username.Text;
            string playerId = ID.Text;
            string playerPassword = Password.Text;

            if (string.IsNullOrEmpty(playerName) || string.IsNullOrEmpty(playerId) || string.IsNullOrEmpty(playerPassword))
            {
                MessageBox.Show("Please enter all required information.");
                Username.Text = "";
                ID.Text = "";
                Password.Text = "";
                return;
            }

             if (administrator.Players.Any(player => player.UserId == playerId))
            {
                MessageBox.Show("Player ID already exists.");
                Username.Text = "";
                ID.Text = "";
                Password.Text = "";
                return;
            }

            administrator.CreatePlayer(playerName, playerId, playerPassword);
            MessageBox.Show("Successfully created the account for " + playerName);
            Username.Text = "";
            ID.Text = "";
            Password.Text = "";

           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome(administrator);
            welcome.Show();
            this.Hide();
        }
    }
}
