using System;

namespace LAB5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carPark = new TCarPark();

            carPark.LoadFromTxt("/Users/sheisuka/Desktop/cars.txt");
            carPark.DisplayCars();
            Console.WriteLine($"{new String('-', 40)}\nМашины требующие ТО");
            carPark.DisplayCars(carPark.GetCarsNeedCI());

        }
    }
}
