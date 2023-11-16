using System;
namespace Mini
{
	public class Line: Point
	{
		private float X2;
		private float Y2;
		private float Width;

		public Line(float x1, float y1, float x2, float y2, float width, string color): base(x1, y1, color)
		{
			this.x2 = x2;
			this.y2 = y2;
			this.width = width;
		}

		public float x2 { get; set; }
        public float y2 { get; set; }
        public float width { get; set; }

        public override string ToString()
        {
            return $"Прямая из ({this.x1}, {this.y1}) в ({this.x2}, {this.y2}) цвета {this.color} ширины {this.width}";
        }

		public override double GetLength()
		{
			return Math.Sqrt(Math.Pow((this.x2 - this.x1), 2) + Math.Pow((this.y2 - this.y1), 2));
        }

        public override double GetArea()
        {
			return this.GetLength() * this.width;
        }
    }
}

