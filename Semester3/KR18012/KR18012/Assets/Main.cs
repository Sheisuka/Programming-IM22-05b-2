namespace KR18012
{
    public class Program1
    {
        public static void Main1(string[] args)
        {
            string filePath = "/Users/sheisuka/Desktop/testfile.txt";
            var group = new Group(filePath);
            Console.WriteLine(group);

        }
    }
}