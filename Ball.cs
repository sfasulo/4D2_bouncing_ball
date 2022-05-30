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
        private int ballWidth;
        private int ballHeight;
        private int ballPosX;
        private int ballPosY;
        private int moveStepX;
        private int moveStepY;
        Form f;
        public Ball(Form f, int bWidth, int bHeight, int bPosX, int bPosY, int mStepX, int mStepY)
        {
            this.f = f;
            BallWidth = bWidth;
            BallHeight = bHeight;
            BallPosX = bPosX;
            BallPosY = bPosY;
            MoveStepX = mStepX;
            MoveStepY = mStepY;
        }
        public int BallWidth
        {
            get => ballWidth;
            set
            {
                if (value > 0)
                    ballWidth = value;
                else throw new Exception("Valore inserito non accettato");
            }
        }
        public int BallHeight
        {
            get => BallHeight;
            set
            {
                if (value > 0)
                    ballHeight = value;
                else throw new Exception("Valore inserito non accettato");
            }
        }

        public int BallPosX
        {
            get => ballPosX;
            set
            {
                if (value >= 0)
                    ballPosX = value;
            }
        }

        public int BallPosY
        {
            get => ballPosY;
            set
            {
                if (value >= 0)
                    ballPosY = value;
            }
        }
        public int MoveStepY
        {
            get => moveStepY;
            set
            {
                if (value > 0)
                    moveStepY = value;
            }
        }
        public int MoveStepX
        {
            get => moveStepX;
            set
            {
                if (value > 0)
                    moveStepX = value;
            }
        }

        public void PaintCircle(Object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            e.Graphics.Clear(f.BackColor);

            e.Graphics.FillEllipse(Brushes.LightGreen,
                ballPosX, ballPosY,
                ballWidth, ballHeight);

            e.Graphics.DrawEllipse(Pens.Black,
                ballPosX, ballPosY,
                ballWidth, ballHeight);
        }

        public void MoveBall(Object sender, EventArgs e)
        {
            // update coordinates
            ballPosX += moveStepX;
            if (
                ballPosX < 0 ||
                ballPosX + ballWidth > f.ClientSize.Width
                )
            {
                moveStepX = -moveStepX;
            }

            ballPosY += moveStepY;
            if (
                ballPosY < 0 ||
                ballPosY + ballHeight > f.ClientSize.Height
                )
            {
                moveStepY = -moveStepY;
            }

            // update painting
            f.Refresh();
        }
    }
}
