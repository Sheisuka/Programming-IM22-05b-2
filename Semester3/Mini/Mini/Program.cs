namespace Mini
{
    public class Program
    {
        static void Main(string[] args)
        {
            var img1 = new TImage(0, 0, "");
            img1.LoadFromTxt("/Users/sheisuka/Desktop/text1.txt");
            
            Console.WriteLine(img1);

            Console.WriteLine($"\nОбщая длина {img1.SumLengths()}");

            Console.WriteLine($"\nОбщая площадь {img1.GetArea()}\n");
        }
    }
}