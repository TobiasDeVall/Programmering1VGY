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
    public partial class Form2 : Form
    {

        int x = 0;
        int i = 0;

        int projectileVelocity = 12;

        int projectilex;
        int projectiley;

        int[] invaderx = new int[10] { 10, 110, 210, 310, 410, 510, 610, 710, 810, 910 };
        int[] invadery = new int[10] { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 };


        bool left = false;
        bool right = false;

        public Form2()
        {
            InitializeComponent();

            KeyDown += new KeyEventHandler(Form2_KeyDown);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(SpaceShip);

           Invaders(); //KOLLA HÄR ANDRE

        }

        public void Invaders(PaintEventArgs e)
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create array of rectangles.
            Rectangle[] rects =
                     {
                 new Rectangle( 0,   0, 100, 200),
                 new Rectangle(100, 200, 250,  50),
                 new Rectangle(300,   0,  50, 100)
             };

            // Draw rectangles to screen.
            e.Graphics.DrawRectangles(blackPen, rects);
        }

        private void SpaceShip(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, (Width / 2) - 50 + x, Height - 50, 100, 50);


        }

        private void projectile(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, projectilex, projectiley, 2, 10);


        }

        public void Form2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();

            }

            if (e.KeyCode == Keys.Left)
            {
                left = true;
                right = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                left = false;
                right = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            if (left)
            {
                x = x - 4;
            }
            else if (right)
            {
                x = x + 4;
            }

            this.Refresh();
        }
    }
}
