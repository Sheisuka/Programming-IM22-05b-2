using System;

namespace LAB5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carPark = new TCarPark();

            carPark.LoadFromTxt("/Users/sheisuka/Desktop/cars.txt");

            foreach (var car in carPark.carPark)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine($"{new String('-', 40)}\nМашины требующие ТО");
            foreach (var car in carPark.GetCarsNeedCI())
            {
                Console.WriteLine(car);
            }

        }
    }
}
