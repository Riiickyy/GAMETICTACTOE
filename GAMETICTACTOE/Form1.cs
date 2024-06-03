using System;
using System.Windows.Forms;

namespace GAMETICTACTOE
{

    public partial class Form1 : Form
    {
        private char[,] board = new char[3, 3];
        private bool xTurn = true;
        private Button[,] buttons = new Button[3, 3];
        public int moveCOunt = 0;
        private int moveCount;
        private Administrator admini;

        public Form1()
        {
            InitializeComponent();
           
            InitializeBoard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeBoard()
        {
            buttons = new Button[,]
              {
                { button000, button02121, button02zz },
                { button10, button11, button12 },
                { button20, button21, button22 }
              };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].TabIndex = i * 3 + j;
                    buttons[i, j].Click += new EventHandler(this.Button_Click);
                    board[i, j] = '-';
                }
            }
        }


        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int row = clickedButton.TabIndex / 3;
            int col = clickedButton.TabIndex % 3;

            if (board[row, col] == '-')
            {
                board[row, col] = xTurn ? 'X' : 'O';
                clickedButton.Text = xTurn ? "X" : "O";

                moveCount++; // Increment move count

                xTurn = !xTurn;

                TicTacToeDeterminer determiner = new TicTacToeDeterminer(board);
                char winner = determiner.CheckWinner();
                if (winner != '-')
                {
                    MessageBox.Show($"The Winner is {winner}");
                    ResetBoard();
                }
                else if (moveCount == 9) // Draw detected after 9 moves
                {
                    MessageBox.Show("Game is draw!");
                    ResetBoard();
                }
            }
        }



        private void ResetBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = "";
                    board[i, j] = '-';
                }
            }
            xTurn = true;
            moveCount = 0; 
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 