using System;
using System.IO;

namespace LAB5
{
	public class TAuto
	{
		private string Brand;
		private DateTime DateOfIssue;
		private int EnginePower;
		private string ImageUrl;

		public TAuto(string brand, DateTime dateOfIssue, int enginePower, string imageUrl)
		{
			this.brand = brand;
			this.dateOfIssue = dateOfIssue;
			this.enginePower = enginePower;
			this.imageUrl = imageUrl;
		}

		public string brand { get => Brand; init => Brand = value; }
        public DateTime dateOfIssue { get => DateOfIssue; init => DateOfIssue = value; }
        public int enginePower { get => EnginePower;
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
        public string imageUrl { get => ImageUrl; set => ImageUrl = value; }

        public int GetAnnualTax()
        {
			return enginePower * 4;
        }

		public virtual DateTime GetNextCarInspection()
		{
			DateTime currentDate = DateTime.Now;
			int yearsPassed = currentDate.Year - dateOfIssue.Year;
			int yearsLeft;

			if (yearsPassed <= 7)
			{
				yearsLeft = yearsPassed + (2 - (yearsPassed % 2));
			}
			else
			{
				yearsLeft = yearsPassed + 1;
			}

			return dateOfIssue.AddYears(yearsLeft);
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
			string result = $"Информация об автомобиле:\n\tМарка: {this.brand}" +
							$"\n\tДата выпуска {this.dateOfIssue.ToString("dd.MM.yyyy")}" +
							$"\n\tМощность двигателя: {this.enginePower} л.с." +
							$"\n\tСсылка к изображению: {this.imageUrl}";
			return result;
        }

    }
}

