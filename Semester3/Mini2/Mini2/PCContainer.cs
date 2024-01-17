using System;

namespace Mini2
{
	public class PCContainer
	{
		private PCComponent[] Components;
		public PCComponent[] components { get => Components; set { Components = value; } }

        public PCContainer(string path)
		{
			this.components = new PCComponent[0];
			LoadFromTxt(path);
		}

		public void LoadFromTxt(string filePath)
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadLines(filePath);
                PCSetup[] LastPCSetup = new PCSetup[0];

                foreach (var line in lines)
                {
                    if (line == "")
                    {
                        Array.Resize(ref LastPCSetup, LastPCSetup.Length - 1);
                    }
                    else if (line.StartsWith("Сборка"))
                    {
                        var obj = PCSetup.ParseFromString(line);
                        Array.Resize(ref LastPCSetup, LastPCSetup.Length + 1);
                        LastPCSetup[LastPCSetup.Length - 1] = obj;
                        if (LastPCSetup.Length == 1)
                        {

                            AddItem(obj);
                        }
                        else
                        {
                            LastPCSetup[LastPCSetup.Length - 2].AddItem(obj);
                        }
                    }
                    else
                    {
                        var obj = PCComponent.ParseFromString(line);
                        if (LastPCSetup.Length == 0)
                        {
                            AddItem(obj);
                        }
                        else
                        {
                            LastPCSetup[LastPCSetup.Length - 1].AddItem(obj);
                        }
                    }
                }
            }
            else
            {
                throw new ArgumentException("Такого файла нет");
            }

        }

        public void AddItem(PCComponent component)
        {
            PCComponent[] newArray = new PCComponent[this.components.Length + 1];
            Array.Copy(this.components, newArray, this.components.Length);
            newArray[this.components.Length] = component;
            this.components = newArray;
        }

        public PCComponent FindBest()
		{
            float maxVal = 0;
            PCComponent? maxComp = null;

            foreach (var item in this.components)
            {
                if (item.name.StartsWith("Сборка"))
                {
                    var comp_ = PCSetup.FindBest((PCSetup)item);
                    if ((comp_.coef / comp_.price) > maxVal)
                    {
                        maxVal = comp_.coef / comp_.price;
                        maxComp = comp_;
                    }
                }
                else
                {
                    if (maxVal < item.coef / item.price)
                    {
                        maxVal = item.coef / item.price;
                        maxComp = item;
                    }
                }
            }

            return maxComp;
		}

        public override string ToString()
        {
            string res = "";
            foreach (var item in this.components)
            {
                res += $"\n{item}";
            }

            return res;
        }
    }
}

