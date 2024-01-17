using System;

namespace LAB6
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carPark = new TCarPark();

            carPark.LoadFromTxt("/Users/sheisuka/Desktop/cars.txt");
            carPark.DisplayCars();
            //Console.WriteLine($"{new String('-', 40)}\nМашины требующие ТО");
            //carPark.DisplayCars(carPark.GetCarsNeedCI());
            Console.WriteLine($"{new String('-', 40)}\nМашины старше 20 лет");
            carPark.DisplayCars(carPark.GetOldCars());
        }
    }
}
