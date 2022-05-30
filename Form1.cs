using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBall
{
    public partial class Form1 : Form
    {
        private int bWidth = 300;
        private int bHeight = 300;
        private int bPosX = 0;
        private int bPosY = 0;
        private int mStepX = 4;
        private int mStepY = 4;
        BouncingBall palla1;

        public Form1()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint,
                true
                );
            palla1 = new BouncingBall(bWidth, bHeight, bPosX, bPosY, mStepX, mStepY, this.ClientSize.Width, this.ClientSize.Height);
            this.Paint += new System.Windows.Forms.PaintEventHandler(palla1.CreateBall);
            this.UpdateStyles();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            palla1.MoveBall();
            this.Refresh();
        }
    }
}
