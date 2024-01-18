using System;
namespace KR18012
{
	public class Base
	{
		public string Name;
		public string Category;
		public string ImagePath;

		public string AsString => GetAsString();

		public Base(string name, string category, string imagePath)
		{
			Name = name;
			Category = category;
			ImagePath = imagePath;
		}

        public override string ToString()
        {
			return $"{Name} - {Category} этап";
        }

        public static bool operator >(Base first, Base second)
		{
			if ((first is Walk) && (second is River))
				return true;
            else if ((first is River) && (second is Walk))
                return false;
			else
			{
				if ((first.Category == "Легкий") && (second.Category == "Сложный"))
					return false;
				if ((first.Category == "Сложный") && (second.Category == "Легкий"))
					return true;
				return true;
            }
		}

        public static bool operator <(Base first, Base second)
        {
			return !((first > second));
        }

        public static bool operator ==(Base first, Base second)
        {
			return ((first.Category == second.Category) && ((first is River) && (second is River) || (first is Walk) && (second is Walk)));
        }

		public static bool operator !=(Base first, Base second)
		{
			return (!(first == second));
		}

        public virtual string GetAsString() => Name + Category + ImagePath;
    }
}

