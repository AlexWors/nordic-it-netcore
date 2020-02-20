using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork13
{
	class Helicopter : BaseFly
	{
		public byte BladesCount { get; private set; }

		public Helicopter(int maxHeight, byte bladesCount) : base(maxHeight)
		{
			BladesCount = bladesCount;
			Console.WriteLine("It’s a helicopter, welcome aboard!");
		}

		public override void WriteAllProperties()
		{
			Console.Write(
				$"Properties of {GetType().Name}:" +
				$"\n\t{nameof(BladesCount)}:\t{BladesCount}");
			base.WriteAllProperties();
		}
	}
}
