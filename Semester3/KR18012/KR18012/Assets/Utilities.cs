using System;
namespace KR18012
{
	public class Utilities
	{
		public static bool IsNumber(string str)
		{
			foreach(var s in str)
			{
				if ((!char.IsDigit(s)) && (s != '.'))
					return false;
			}
			return true;
		}
	}
}

