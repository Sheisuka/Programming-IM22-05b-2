using System;
namespace KR18012
{
	public class Walk: Base
	{
		public decimal PathLength;
		public decimal Angle;

		public Walk(string name, string category, decimal pathLength, decimal angle, string imagePath): base(name, category, imagePath)
		{
			PathLength = pathLength;
			Angle = angle;
		}

        public override string GetAsString()
        {
            return base.GetAsString() + PathLength.ToString() + Angle.ToString();
        }
    }
}

