using System;
namespace KR18012
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string filePath = "/Users/sheisuka/Desktop/marshrut1.txt"; // 1
			var route = new Route(filePath);
			Console.WriteLine(route);

			Console.WriteLine(route.HardestElements); // 2

			Console.WriteLine(route.EnergyWasted); // 3

			route.SortByType(); // 4
			Console.WriteLine(route);

			Console.WriteLine(route.FindBySubstring("базаиха.jpg")); // 5
		}
	}
}

