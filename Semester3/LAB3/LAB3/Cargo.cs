using System;

namespace LAB3
{
	public class Cargo
	{
		private string Name;
		private int Weight;

		public Cargo(string name, int weight)
		{
			this.name = name;
			this.weight = weight;
		}

		public string name { get => Name;
			init
			{
				if (value.Length == 0)
				{
					throw new ArgumentException("Название не должно быть пустым");
				}
				else
				{
					Name = value;
				}
			}
		}

		public int weight { get => Weight;
			init
			{
				if (value <= 0)
				{
					throw new ArgumentException("Вес должен быть больше нуля");
				}
				else
				{
					Weight = value;
				}
			}
		}
	}
}

