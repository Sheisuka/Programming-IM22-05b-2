using System;
namespace LAB2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car1 = new TAuto("Mercedes", DateTime.Now, 170, "/Users/sheisuka/Desktop/Projects/Programming-IM22-05b-2/Semester3/LAB2/LAB2/ggg.jpg");
            Console.WriteLine(car1);
            Console.WriteLine(car1.GetNextCarInspection());
            Console.WriteLine(car1.GetAnnualTax());
        }
    }
}
