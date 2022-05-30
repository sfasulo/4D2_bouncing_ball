using System;

namespace BouncingBall
{
	public class Ball
	{
		
		int width = 300;
		int height = 300;
		int posX = 0;
		int posY = 0;
		int stepX = 4;
		int stepY = 4;

		public int Width
		{
			get
			{
				return width;
			}
			set
			{
				if (value > 0)
					width = value;
				else
					throw new ArgumentException("Non può essere inserito un valore minore o uguale a 0");
			}
		}

		public int Height
		{
			get
			{
				return height;
			}
			set
			{
				if (value > 0)
					height = value;
				else
					throw new ArgumentException("Non può essere inserito un valore minore o uguale a 0");
			}
		}

		public int PosX { get; set; }

		public int PosY { get; set; }

		public int StepX
		{
			get
			{
				return stepX;
			}
			set
			{
				if (value > 0)
					stepX = value;
				else
					throw new ArgumentException("Non può essere inserito un valore minore o uguale a 0");
			}
		}

		public int StepY
		{
			get
			{
				return stepY;
			}
			set
			{
				if (value > 0)
					stepY = value;
				else
					throw new ArgumentException("Non può essere inserito un valore minore o uguale a 0");
			}
		}

		public Ball(int width, int height, int posx, int posy, int stepx, int stepy)
		{
			Width = width;
			Height = height;
			PosX = posx;
			PosY = posy;
			StepX = stepx;
			StepY = stepy;
		}
		public Ball() { }; //Costruttore senza parametri in caso si vogliano tenere i valori di "default"
	}
}
