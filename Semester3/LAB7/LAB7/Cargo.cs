using System;
using System.Xml.Linq;

namespace LAB7
{
	public class Cargo
	{
        public string Name
        {
            get => Name;
            set
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

        public int Weight
        {
            get => Weight;
            set
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

        public Cargo(string name, int weight)
		{
			Name = name;
			Weight = weight;
		}
	}
}

