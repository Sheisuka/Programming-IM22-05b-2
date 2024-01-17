using System;
namespace Mini2
{
	public class PCComponent
	{
		private string Name;
		private int Coef;
		private int Price;

		public string name { get => Name; init => Name = value; }
		public int coef { get => Coef;
			set
			{
				if (value > 0)
				{
					Coef = value;
				}
				else
				{
					throw new ArgumentException("Коэффициент должен быть положительным");
				}
			}
		}

        public int price { get => Price;
            set
            {
                if (value >= 0)
                {
                    Price = value;
                }
                else
                {
                    throw new ArgumentException("Цена должна быть неотрицательна");
                }
            }
        }

        public PCComponent(string name, int coef, int price)
		{
			this.Name = name;
			this.Coef = coef;
			this.Price = price;
		}

		public static PCComponent ParseFromString(string data)
		{
			var args = data.Split(" ", StringSplitOptions.RemoveEmptyEntries);

			if (args.Length < 3)
			{
				throw new ArgumentException("Необходимо 3 значения для инициализации PCComponent");
			}

			int price = int.Parse(args[args.Length - 1]);
			int coef = int.Parse(args[args.Length - 2]);
			string name = string.Join(" ", args.Take(args.Length - 3));

            return new PCComponent(name, coef, price);
		}

        public override string ToString()
        {
			return $"{this.name} {this.coef} {this.price}";
        }
    }
}

