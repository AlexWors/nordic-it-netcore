using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork13
{
	class Plane : BaseFly
	{
		public byte EnginesCount { get; private set; }

		public Plane(int maxHeight, byte enginesCount) : base(maxHeight)
		{
			EnginesCount = enginesCount;
			Console.WriteLine("it's plane, welcome aboard!");
		}

		public override void WriteAllProperties()
		{
			Console.Write(
				$"Properties of {this.GetType().Name}:" +
				$"\n\t{nameof(EnginesCount)}:\t{EnginesCount}");
			base.WriteAllProperties();
		}
	}
}
