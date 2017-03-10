using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickTackToe
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = x turn; false = y turn;
        int turnCount = 0;
        //static String player1, player2;

        /*
        public static void setPlayerNames(String name1, String name2)
        {
            player1 = name1;
            player2 = name2;

        }
        */

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Tobias de Vall", "Tick Tack Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turnCount++;

            checkForWinner();
        }

        private void checkForWinner()
        {
            bool thereIsAWinner = false;

            //Horizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                thereIsAWinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                thereIsAWinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                thereIsAWinner = true;

            //Vertical checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                thereIsAWinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                thereIsAWinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                thereIsAWinner = true;

            //Diagnol checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                thereIsAWinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                thereIsAWinner = true;

            if (thereIsAWinner)
            {
                disableButtons();

                string winner = "";
                if (turn)
                {
                    winner = p2.Text;
                    oWinCount.Text = (Int32.Parse(oWinCount.Text) + 1).ToString();
                }
                else
                {
                    winner = p1.Text;
                    xWinCount.Text = (Int32.Parse(xWinCount.Text) + 1).ToString();
                }

                MessageBox.Show(winner + " Wins!", "Yay!");
            }//End if
            else
            {
                if (turnCount == 9)
                {
                    drawCount.Text = (Int32.Parse(drawCount.Text) + 1).ToString();
                    MessageBox.Show(" Draw!", "Bummer!");
                }

            }


        } //End checkForWinner

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }//End foreach
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;

            
                foreach (Control c in Controls)
                {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }//End foreach
            

        }

        private void buttonEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }//End if
        }

        private void butonLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }//End if

        }

        private void resetWinCounsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xWinCount.Text = "0";
            oWinCount.Text = "0";
            drawCount.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Form f2 = new Form2();
            f2.ShowDialog();
            label1.Text = player1;
            label3.Text = player2;
            */
        }
    }
}
