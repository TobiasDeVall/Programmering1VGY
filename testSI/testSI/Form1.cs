using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testSI
{
    public partial class Form1 : Form
    {
        private bool playGame;

        public Form1()
        {

            playGame = true;

            InitializeComponent();
            KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down)
            {
                playButton.Text = "PLAY";
                highScore.Text = "**HIGH SCORE**";

                playGame = false;

            }
            else if (e.KeyCode == Keys.Up)
            {
                playButton.Text = "**PLAY**";
                highScore.Text = "HIGH SCORE";

                playGame = true;

            }

            if(e.KeyCode == Keys.Enter && playGame)
            {
                this.Hide();

                Form2 game = new Form2();

                game.Show();

            }
        }
    }
}
