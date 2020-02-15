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
			
		}
	}
}
