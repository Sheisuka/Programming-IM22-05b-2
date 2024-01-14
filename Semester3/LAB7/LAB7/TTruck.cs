using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;

namespace LAB7
{
	public class TTruck : TAuto
	{
        public int LiftCap
        {
            get => LiftCap;
            set
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

        public int CurrentCap
        {
            get => CurrentCap;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Грузоподъемность не может быть меньше нуля");
                }
                else if (value > LiftCap)
                {
                    throw new ArgumentException("Некорректная грузоподъемность");
                }
                else
                {
                    CurrentCap = value;
                }
            }
        }

        public List<Cargo> Cargos { get => Cargos; set => Cargos = value; }

        public TTruck(string brand, DateTime dateOfIssue, int enginePower, string imageUrl,
                        int liftCap) : base(brand, dateOfIssue, enginePower, imageUrl)
        {
            LiftCap = liftCap;
            CurrentCap = liftCap;
            Cargos = new List<Cargo>();
        }

        public override DateTime GetNextCarInspection()
        {
            DateTime currentDate = DateTime.Now;

            int yearsPassed = currentDate.Year - DateOfIssue.Year;
            int yearsLeft = yearsPassed + 1;

            return DateOfIssue.AddYears(yearsLeft);
        }

        public void LiftCargo(Cargo cargo)
        {
            if (CurrentCap - cargo.Weight < 0) {
                Console.WriteLine("Вес груза слишком большой");
            }
            else
            {
                Cargos.Add(cargo);
                CurrentCap -= cargo.Weight;
                Console.WriteLine($"Поднять груз \"{cargo.Name}\" с весом {cargo.Weight}");
            }
        }

        public void PutDownCargo(Cargo cargo)
        {
            if (Cargos.Contains(cargo))
            {
                Cargos.Remove(cargo);
                CurrentCap += cargo.Weight;
                Console.WriteLine($"Выгружен груз \"{cargo.Name}\" с весом {cargo.Weight}");
            }
            else
            {
                Console.WriteLine("Такого груза нет");
            }
        }

        public override string ToString()
        {
            List<string> cargoNames = new List<string>();

            foreach (var cargo in Cargos)
            {
                cargoNames.Add(cargo.Name);
            }

            string result = base.ToString() +
                            $"\n\tГрузоподъемность: {LiftCap}" +
                            $"\n\tСвободная грузоподъемность: {CurrentCap}" +
                            $"\n\tПеревозимый груз: {String.Join(", ", cargoNames)}";

            return result;
        }
    }
}

