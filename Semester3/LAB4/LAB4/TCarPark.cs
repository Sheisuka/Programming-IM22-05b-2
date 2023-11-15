using System;
using System.Globalization;

namespace LAB4
{
	public class TCarPark
	{
		private List<TAuto> CarPark;

		public TCarPark()
		{
			this.carPark = new List<TAuto>();
		}

		public List<TAuto> carPark { get; set; }

		public List<TAuto> GetCarsNeedCI()
		{
			var curMonth = DateTime.Now.Month;
			return this.carPark.Where(car => car.GetNextCarInspection().Month == curMonth).ToList();
		}

        public void LoadFromTxt(string filePath)
		{ 
			if (File.Exists(filePath)) {
				var carLines = File.ReadLines(filePath);

				foreach (var line in carLines)
				{
					var car = ParseCar(line);
					this.carPark.Add(car);
				}
			}
			else
			{
				throw new ArgumentException("Такого файла нет");
			}

		}

        // TAuto string brand, DateTime dateOfIssue, int enginePower, string imageUrl
        // TTruck string brand, DateTime dateOfIssue, int enginePower, string imageUrl, int liftCap
        private TAuto ParseCar(string carDataLine)
		{
            string DateFormat = "dd/MM/yyyy";

            string[] args = carDataLine.Split(" ");
            string brand = args[0];
            DateTime date = DateTime.ParseExact(args[1], DateFormat, CultureInfo.InvariantCulture);
            int enginePower = int.Parse(args[2]);
            string imageUrl = args[3];

			TAuto car;

			if (args.Length == 5)
			{
                int liftCap = int.Parse(args[4]);
                car = new TTruck(brand, date, enginePower, imageUrl, liftCap);
            }
			else
			{
                car = new TAuto(brand, date, enginePower, imageUrl);
            }
			return car;
		} 
	}
}

