using System;
namespace KR18012
{
	public class Star: SpaceObject
	{
		public Star(string name, int count, decimal weight, decimal luminosity): base(name, count, luminosity, weight, 0){ }
	}
}

