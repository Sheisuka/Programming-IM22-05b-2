using System;
namespace KR18012
{
	public class River: Base
	{
		public decimal Depth;
		public decimal Width;
		public decimal Speed;

		override public string GetAsString()
		{
			return base.GetAsString() + Depth.ToString() + Width.ToString() + Speed.ToString();
		}

		public River(string name, string category, decimal depth, decimal width, decimal speed, string imagePath): base(name, category, imagePath)
		{
			Depth = depth;
			Width = width;
			Speed = speed;
		}
    }
}

