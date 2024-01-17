using System;
namespace Mini2
{
	public class PCSetup : PCComponent
	{
        public PCComponent[] components;

        public PCSetup(string name) : base(name, 1, 0)
        {
            this.components = new PCComponent[0];
        }

		public PCSetup(string name, int coef, int price) : base(name, coef, price)
        {
            this.components = new PCComponent[0];
        }

        public void AddItem(PCComponent component)
        {
            PCComponent[] newArray = new PCComponent[this.components.Length + 1];
            Array.Copy(this.components, newArray, this.components.Length);
            newArray[this.components.Length] = component;
            this.components = newArray;
        }

        public int GetCoef()
		{
            int coef = 1;
            foreach (PCComponent item in this.components)
            {
                if (item.name.Contains("Сборка"))
                {
                    coef *= item.coef;
                }
            }

            return coef;
		}

        public static PCComponent FindBest(PCSetup pc)
        {
            float maxVal = 0;
            PCComponent? maxComp = null;

            foreach (var comp in pc.components)
            {
                if (comp.name.StartsWith("Сборка"))
                {
                    var comp_ = FindBest((PCSetup)comp);
                    if ((comp_.coef / comp_.price) > maxVal)
                    {
                        maxVal = comp_.coef / comp_.price;
                        maxComp = comp_;
                    }
                }
                else
                {
                    if (maxVal < (comp.coef / comp.price))
                    {
                        maxVal = comp.coef / comp.price;
                        maxComp = comp;
                    }
                }
            }

            return maxComp;
        }

        public override string ToString()
        {
            string res = this.name;
            foreach (var item in this.components)
            {
                res += $"\n\t{item}";
            }

            return res;
        }

        public static new PCSetup ParseFromString(string data)
        {
            if (data.Trim().Length == 5)
            {
                throw new ArgumentException("Сборка должна иметь имя");
            }

            return new PCSetup(data.Trim());
        }
    }
}

