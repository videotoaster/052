using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _052
{
    public partial class Form1 : Form
    {
        public bool CARNAGE = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void timerDrawNonsense(object sender, EventArgs e)
        {
            if (CARNAGE != true) { return; } // if we can't carnage don't carnage dipshit
            System.Drawing.Graphics graphics = this.CreateGraphics();
            System.Drawing.Point point = new Point();
            System.Random randomizer = new Random(); // new random to randomize the random
            Icon[] wincons = { // systemicons. <3
                SystemIcons.Error,
                SystemIcons.Warning,
                SystemIcons.Information,
                SystemIcons.Question,
                SystemIcons.Application,
                SystemIcons.Shield
            };
            int icon = randomizer.Next(0, wincons.Length);
            point.X = randomizer.Next(0, this.Width);
            point.Y = randomizer.Next(0, this.Height);
            graphics.DrawImage(wincons[icon].ToBitmap(), point);
            int onein = 25; // one in (x) chance of drawing dialog.
            if (randomizer.Next(0, onein) == onein - 1)
            {
                MessageBox.Show("i m happy in drongus", "BingusBangusBongus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formBootNonsense(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show(this, "ayyo buddy ol pal do ya reely wunna run 054", "dumbass", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (box == DialogResult.No)
            {
                this.Close(); // DIE
            }
            CARNAGE = true;
        }
    }
}
