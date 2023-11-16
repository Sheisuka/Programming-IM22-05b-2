using System;

namespace Mini
{
	public class TImage : Point
	{
		private List<Point> ImgItems;

        public TImage(float x1, float y1, string color) : base(x1, y1, color)
        {
            this.imgItems = new List<Point>();
        }

        public List<Point> imgItems { get => ImgItems; set => ImgItems = value; }

        public void LoadFromTxt(string filePath)
        {
            if (File.Exists(filePath))
            {
                var objLines = File.ReadLines(filePath);

                foreach (var line in objLines)
                {
                    var obj_ = ParseObj(line);
                    this.ImgItems.Add(obj_);
                }
            }
            else
            {
                throw new ArgumentException("Такого файла нет");
            }

        }

        private static Point ParseObj(string line)
        {
            string[] args = line.Split(' ');

            if (args[0] == "point")
            {
                return new Point(float.Parse(args[1]), float.Parse(args[2]), args[3]);
            }
            else if (args[0] == "line")
            {
                return new Line(float.Parse(args[1]), float.Parse(args[2]), float.Parse(args[4]), float.Parse(args[5]), float.Parse(args[5]), args[3]);
            }
            else if (args[0] == "circle")
            {
                bool filled;
                if (args[5] == "0")
                {
                    filled = false;
                }
                else
                {
                    filled = true;
                }

                return new Circle(float.Parse(args[1]), float.Parse(args[2]), float.Parse(args[4]), filled, args[3]);
            }

            var img = new TImage(float.Parse(args[1]), float.Parse(args[2]), args[3]);
            img.LoadFromTxt(args[4]);
            return img;

        }

        public override double GetLength()
        {
            double len = 0;
            foreach (var item in this.imgItems)
            {
                len += item.GetLength();
            }
            return len;
        }

        public override double GetArea()
        {
            double area = 0;
            foreach (var item in this.imgItems)
            {
                area += item.GetArea();
            }
            return area;
        }

        public double SumLengths()
        {
            double sum = 0;
            foreach (var item in this.imgItems)
            {
                sum += item.GetLength();
            }
            return sum;
        }

        public override string ToString()
        {
            string output = "";

            foreach (var item in this.imgItems)
            {
                output += $"\n{item.ToString()}";
            }
            
            return $"Изображение \n[{output}]";
        }
    }
}

