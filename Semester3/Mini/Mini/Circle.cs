using System;
namespace Mini
{
    public class Circle : Point
    {
        private float R;
        private bool Filled;

        public Circle(float x1, float y1, float r, bool filled, string color) : base(x1, y1, color)
        {
            this.r = r;
            this.filled = filled;
        }

        public float r { get; set; }
        public bool filled { get; set; }

        public override string ToString()
        {
            return $"Окружность радиуса {this.r} в ({this.x1}, {this.y1}) цвета {this.color} закрашена {this.filled}";
        }

        public override double GetLength()
        {
            return 2 * 3.14 * this.r;
        }

        public override double GetArea()
        {
            return 3.14 * Math.Pow(this.r, 2);
        }
    }
}

