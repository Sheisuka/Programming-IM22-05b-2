using System;

namespace LAB3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var truck = new TTruck("Mercedes", DateTime.Now, 370, "image.jpg", 1000);
            var cargo1 = new Cargo("Бревно 1", 400);
            var cargo2 = new Cargo("Бревно 2", 400);
            var cargo3 = new Cargo("Бревно 3", 400);
            truck.LiftCargo(cargo1);
            truck.LiftCargo(cargo2);
            truck.LiftCargo(cargo3);
            truck.PutDownCargo(cargo1);
            truck.LiftCargo(cargo3);
            Console.WriteLine(truck);

        }
    }
}
