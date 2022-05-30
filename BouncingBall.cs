using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBall
{
    class BouncingBall
    {
        int ballWidth, BallHeight, BallPosX, BallPosY, moveStepX, moveStepY, ClientSizeHeight, ClientSizeWidth;
        public BouncingBall(int BW, int BH, int BPX, int BPY, int MSX, int MSY, int CSW, int CSH)
        {
            this.ballWidth = BW;
            this.BallHeight = BH;
            this.BallPosX = BPX;
            this.BallPosY = BPY;
            this.moveStepX = MSX;
            this.moveStepY = MSY;
            this.ClientSizeWidth = CSW;
            this.ClientSizeHeight = CSH;
        }

        public void MoveBall()
        {
            // update coordinates
            BallPosX += moveStepX;
            if (BallPosX < 0 || BallPosX + ballWidth > this.ClientSizeWidth)
            {
                moveStepX = -moveStepX;
            }

            BallPosY += moveStepY;
            if (BallPosY < 0 || BallPosY + BallHeight > this.ClientSizeHeight)
            {
                moveStepY = -moveStepY;
            }
        }

        public void CreateBall(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            e.Graphics.Clear(Color.White);

            e.Graphics.FillEllipse(Brushes.Red,BallPosX, BallPosY,ballWidth, BallHeight);

            e.Graphics.DrawEllipse(Pens.Black, BallPosX, BallPosY, ballWidth, BallHeight);
        }
    }
}
