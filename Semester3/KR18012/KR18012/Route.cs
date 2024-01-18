using System;
namespace KR18012
{
	public class Route
	{
		public Base[] Elements;
		public int Count => Elements.Length;
		public decimal EnergyWasted
		{
			get
			{
				decimal energyWasted = 0;
				foreach(var element in Elements)
				{
					if (element is River)
						energyWasted += ((River)element).Width * ((River)element).Speed;
					else if (element is Walk)
						energyWasted += (1 + ((Walk)element).Angle) * ((Walk)element).PathLength;
				}

				return energyWasted;
			}
		}

		public Route HardestElements
		{
			get
			{
                var res = new Dictionary<string, List<Base>>();
                res["Легкий"] = new List<Base>();
                res["Сложный"] = new List<Base>();
                string maxCat = "Легкий";

                foreach (var element in Elements)
                {
                    if (element.Category == "Сложный")
                        maxCat = "Сложный";
                    if (element.Category == maxCat)
                        res[maxCat].Add(element);
                }

                return new Route(res[maxCat]);
            }
		}

		public Route(string filePath)
		{
			Elements = new Base[0];
			LoadFromTxt(filePath);
        }

		public Route(List<Base> objs)
		{
			Elements = new Base[0];
			foreach (var obj in objs)
				Add(obj);
		}

		private void LoadFromTxt(string filePath)
		{
			if (!File.Exists(filePath))
				throw new ArgumentException("Файла по данному пути не существует");

			var reader = new StreamReader(filePath);
			var currentData = new List<String>();
			string? str;

			while (((str = reader.ReadLine()) != null) || (currentData.Count != 0))
			{
				if ((str == "") || (str is null))
				{
					Base? obj = null;
					if (currentData.Count == 5) // Пеший участок
					{
						(string name, string cat, decimal length, decimal angle, string path) =
							(currentData[0], currentData[1], decimal.Parse(currentData[2].Replace(" км", "")),
							decimal.Parse(currentData[3]), currentData[4]);
						obj = new Walk(name, cat, length, angle, path);
					}
					else if (currentData.Count == 6) // Река
					{
                        (string name, string cat, decimal depth, decimal width, decimal speed, string path) =
                                                    (currentData[0], currentData[1], decimal.Parse(currentData[2].Replace(" м", "")),
                                                    decimal.Parse(currentData[3].Replace(" м", "")), decimal.Parse(currentData[4]), currentData[5]);
                        obj = new River(name, cat, depth, width, speed, path);
                    }
					Add(obj);
					currentData.Clear();
				}
				else
					currentData.Add(str);
			}
		}

        public override string ToString()
        {
			string result = "";
			foreach (var element in Elements)
				result += $"{element}\n";

			return result;
        }

        private void Add(Base? obj)
		{
			if (obj is not null)
			{
				var tempArray = new Base[Count + 1];
				Elements.CopyTo(tempArray, 0);
				Elements = tempArray;
				Elements[Count - 1] = obj;
			}
		}

		public void SortByType()
		{
            Base temp;
            for (var i = 0; i < Count - 1; i ++)
                for (var j = i + 1; j < Count; j++)
				{
					if (Elements[i] > Elements[j])
					{
						temp = Elements[j];
						Elements[j] = Elements[i];
						Elements[i] = temp;
					}
				}
		}

		public Base? FindBySubstring(string substring)
		{
			foreach(var element in Elements)
			{
				if (element.AsString.Contains(substring))
					return element;
			}

			return null;
		}
	}
}

