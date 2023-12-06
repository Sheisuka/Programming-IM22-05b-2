using System;
using System.Linq;

namespace LAB5
{
	public class TTruck : TAuto
	{
        private int LiftCap;
        private int CurrentCap;
        private List<Cargo> Cargos;

        public TTruck(string brand, DateTime dateOfIssue, int enginePower, string imageUrl, 
                        int liftCap) : base(brand, dateOfIssue, enginePower, imageUrl)
        {
            this.liftCap = liftCap;
            this.currentCap = liftCap;
            this.cargos = new List<Cargo>();
        }

        public int liftCap { get => LiftCap;
            init
            {
                if (value < 0)
                {
                    throw new ArgumentException("Грузоподъемность не может быть меньше нуля");
                }
                else
                {
                    LiftCap = value;
                }
            }
        }

        public int currentCap { get => CurrentCap;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Грузоподъемность не может быть меньше нуля");
                }
                else if (value > this.liftCap) {
                    throw new ArgumentException("Некорректная грузоподъемность");
                }
                else
                {
                    CurrentCap = value;
                }
            }
        }

        public List<Cargo> cargos { get => Cargos; set => Cargos = value; }

        public override DateTime GetNextCarInspection()
        {
            DateTime currentDate = DateTime.Now;

            int yearsPassed = currentDate.Year - dateOfIssue.Year;
            int yearsLeft = yearsPassed + 1;

            return dateOfIssue.AddYears(yearsLeft);
        }

        public void LiftCargo(Cargo cargo)
        {
            if (this.currentCap - cargo.weight < 0) {
                Console.WriteLine("Вес груза слишком большой");
            }
            else
            {
                this.cargos.Add(cargo);
                this.currentCap -= cargo.weight;
                Console.WriteLine($"Поднять груз \"{cargo.name}\" с весом {cargo.weight}");
            }
        }

        public void PutDownCargo(Cargo cargo)
        {
            if (this.cargos.Contains(cargo))
            {
                this.cargos.Remove(cargo);
                this.currentCap += cargo.weight;
                Console.WriteLine($"Выгружен груз \"{cargo.name}\" с весом {cargo.weight}");
            }
            else
            {
                Console.WriteLine("Такого груза нет");
            }
        }

        public override string ToString()
        {
            List<string> cargoNames = new List<string>();

            foreach (var cargo in this.cargos)
            {
                cargoNames.Add(cargo.name);
            }

            string result = $"Информация об автомобиле:\n\tМарка: {this.brand}" +
                            $"\n\tДата выпуска {this.dateOfIssue.ToString("dd.MM.yyyy")}" +
                            $"\n\tДата следующего ТО {this.GetNextCarInspection().ToString("dd.MM.yyyy")}" +
                            $"\n\tМощность двигателя: {this.enginePower} л.с." +
                            $"\n\tГрузоподъемность: {this.liftCap}" +
                            $"\n\tСвободная грузоподъемность: {this.currentCap}" +
                            $"\n\tПеревозимый груз: {String.Join(", ", cargoNames)}" +
                            $"\n\tСсылка к изображению: {this.imageUrl}";
			return result;
        }
    }
}

