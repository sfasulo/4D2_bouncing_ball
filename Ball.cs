using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBall
{
    class Ball
    {
        Form1 f;
        private int ballWidth = 300;
        private int ballHeight = 300;
        private int ballPosX = 0;
        private int ballPosY = 0;
        private int moveStepX = 4;
        private int moveStepY = 4;

        public Ball(Form1 f1)
        {
            f = f1;
        }

        public void Paint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            e.Graphics.Clear(f.BackColor);

            e.Graphics.FillEllipse(Brushes.Red,
                ballPosX, ballPosY,
                ballWidth, ballHeight);

            e.Graphics.DrawEllipse(Pens.Black,
                ballPosX, ballPosY,
                ballWidth, ballHeight);
        }

        public void Move()
        {
            ballPosX += moveStepX;
            if (ballPosX < 0 || ballPosX + ballWidth > f.ClientSize.Width)
            {
                moveStepX = -moveStepX;
            }

            ballPosY += moveStepY;
            if (ballPosY < 0 || ballPosY + ballHeight > f.ClientSize.Height)
            {
                moveStepY = -moveStepY;
            }
        }
    }
}
