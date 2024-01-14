using System;
using System.IO;

namespace LAB7
{
	public class TAuto
	{
        public string Brand { get => Brand; set => Brand = value; }
        public DateTime DateOfIssue { get => DateOfIssue; set => DateOfIssue = value; }
        public int EnginePower
        {
            get => EnginePower;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Мощность двигателя не может быть меньше нуля");
                }
                else
                {
                    EnginePower = value;
                }
            }
        }
        public string ImageUrl { get => ImageUrl; set => ImageUrl = value; }

        public TAuto(string brand, DateTime dateOfIssue, int enginePower, string imageUrl)
		{
			Brand = brand;
			DateOfIssue = dateOfIssue;
			EnginePower = enginePower;
			ImageUrl = imageUrl;
		}

        public int GetAnnualTax()
        {
			return EnginePower * 4;
        }

		public virtual DateTime GetNextCarInspection()
		{
			DateTime currentDate = DateTime.Now;
			int yearsPassed = currentDate.Year - DateOfIssue.Year;
			int yearsLeft;

			if (yearsPassed <= 7)
			{
				yearsLeft = yearsPassed + (2 - (yearsPassed % 2));
			}
			else
			{
				yearsLeft = yearsPassed + 1;
			}

			return DateOfIssue.AddYears(yearsLeft);
		}

		public static bool operator >(TAuto car, TAuto otherCar)
		{
			int result = DateTime.Compare(car.GetNextCarInspection(), otherCar.GetNextCarInspection());
			return result > 0;
		}

        public static bool operator <(TAuto car, TAuto otherCar)
        {
            int result = DateTime.Compare(car.GetNextCarInspection(), otherCar.GetNextCarInspection());
            return result < 0;
        }

        public static bool operator ==(TAuto car, TAuto otherCar)
        {
            int result = DateTime.Compare(car.GetNextCarInspection(), otherCar.GetNextCarInspection());
            return result == 0;
        }

        public static bool operator !=(TAuto car, TAuto otherCar)
        {
			return !(car == otherCar);
        }

        public override string ToString()
		{
			string result = $"Информация об автомобиле:\n\tМарка: {this.Brand}" +
							$"\n\tДата выпуска {this.DateOfIssue.ToString("dd.MM.yyyy")}" +
                            $"\n\tДата следующего ТО {this.GetNextCarInspection().ToString("dd.MM.yyyy")}" +
                            $"\n\tМощность двигателя: {this.EnginePower} л.с." +
							$"\n\tСсылка к изображению: {this.ImageUrl}";
			return result;
        }

    }
}

