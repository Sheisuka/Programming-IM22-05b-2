namespace KR18012
{
    public class Group: SpaceObject//, IEnumerable<Star>, IEnumerator<Star>
	{
		public SpaceObject[] Entities = new SpaceObject[0];
		public new int Count => Entities.Length;

		public Group(string? filePath = null): base("Группа из файла", 0, 0, 0, 0)
		{
			if (filePath is not null)
				LoadFromTxt(filePath);
		}

		public Group(string name, int count, string[] lines, ref int i): base(name, 0, 0, 0, 0)
		{
            GetFromReader(lines, count, ref i);
        }

		private void GetFromReader(string[] lines, int objectsLeft, ref int i)
		{
            string? currentString;
            SpaceObject obj;
            var currentData = new List<string>();

            for (var j = i; j< lines.Length; j++)
            {
                if (objectsLeft == 0) break;
                currentString = lines[j];

                if (!Utilities.IsNumber(currentString) || (j == lines.Length - 1))
                {
                    if (currentData.Count == 2) // Считали название, после него число и теперь снова получили название => в currentData
                    {                                                                                   // лежат данные для Группы
                        (string name, int count) = (currentData[0], int.Parse(currentData[1]));
                        obj = new Group(name, count, lines, ref j);
                        this.Add(obj);
                        currentData.Clear();
                        objectsLeft -= 1;
                        if (objectsLeft == 0) i = j - 1;
                    }
                    else if (currentData.Count == 4) // Звезда
                    {
                        (string name, int count, decimal weight, decimal luminosity) =
                            (currentData[0], int.Parse(currentData[1]), decimal.Parse(currentData[2]), decimal.Parse(currentData[3]));
                        obj = new Star(name, count, weight, luminosity);
                        this.Add(obj);
                        currentData.Clear();
                        currentData.Add(currentString);
                        objectsLeft -= 1;
                        if (objectsLeft == 0) i = j - 1;
                    }
                    else if (currentData.Count == 5) // Планета 
                    {
                        (string name, int count, decimal luminosity, decimal weight, decimal diametr) =
                            (currentData[0], int.Parse(currentData[1]), decimal.Parse(currentData[2]), decimal.Parse(currentData[3]), decimal.Parse(currentData[4]));
                        obj = new Planet(name, count, luminosity, weight, diametr);
                        this.Add(obj);
                        currentData.Clear();
                        currentData.Add(currentString);
                        objectsLeft -= 1;
                        if (objectsLeft == 0) i = j - 1;
                    }
                    else
                        currentData.Add(currentString);
                }
                else
                {
                    currentData.Add(currentString);
                }
            }
        }

		private void LoadFromTxt(string filePath)
		{
            var lines = File.ReadAllLines(filePath);
			var currentData = new List<string>();
			string? currentString;
			SpaceObject obj;

            for (int i = 0; i < lines.Length; i++)
            {
                currentString = lines[i];
				if (!Utilities.IsNumber(currentString))
				{
					if (currentData.Count == 2) // Считали название, после него число и теперь снова получили название => в currentData
					{                                                                                   // лежат данные для Группы
						(string name, int count) = (currentData[0], int.Parse(currentData[1]));
						obj = new Group(name, count, lines, ref i);
                        this.Add(obj);
                        currentData.Clear();
                    }
					else if (currentData.Count == 4) // Звезда
					{
						(string name, int count, decimal weight, decimal luminosity) =
							(currentData[0], int.Parse(currentData[1]), decimal.Parse(currentData[2]), decimal.Parse(currentData[3]));
						obj = new Star(name, count, weight, luminosity);
                        this.Add(obj);
						currentData.Clear();
                    }
					else if (currentData.Count == 5) // Планета 
					{
                        (string name, int count, decimal luminosity, decimal weight, decimal diametr) =
                            (currentData[0], int.Parse(currentData[1]), decimal.Parse(currentData[2]), decimal.Parse(currentData[3]), decimal.Parse(currentData[4]));
                        obj = new Planet(name, count, luminosity, weight, diametr);
                        this.Add(obj);
                        currentData.Clear();
                    }
                    else
                        currentData.Add(currentString);
                }
				else
					currentData.Add(currentString);
			}
			
		}

		private void Add(SpaceObject obj)
		{
			SpaceObject[] newArray = new SpaceObject[Count + 1];
			Entities.CopyTo(newArray, 0);
            Entities = newArray;
			Entities[Count - 1] = obj;
		}

        public string DisplayHierarchy(int? indent = 0)
        {
            if (indent is null) indent = 0;
            string output = new string(' ', (int)indent) + Name + "\n";

            foreach(var entity in Entities)
            {
                if (entity is Group)
                    output += ((Group)entity).DisplayHierarchy(indent + 5);
                else
                    output += new string(' ', (int)indent + 5) + entity + "\n";
            }

            return output;
        }

        public override string ToString()
        {
           return DisplayHierarchy();
        }
    }
}

