using System;
namespace Mini
{
	public class Point
	{
		private float X;
		private float Y;
		private string Color;

		public Point(float x, float y, string color)
		{
			this.x1 = x;
			this.y1 = y;
			this.color = color;
		}

		public float x1 { get; init; }
		public float y1 { get; init; }
		public string color { get; init; }

        public override string ToString()
        {
			return $"Точка ({this.x1},{this.y1}) цвета {this.color}";
        }

		public virtual double GetLength()
		{
			return 0;
		}

		public virtual double GetArea()
		{
			return 0;
		}
    }
}

