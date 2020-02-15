using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork13
{
	public abstract class BaseFly
	{
		public int MaxHeight { get; private set; }

		public int CurrentHeight { get; private set; }

		public void TakeUpper(int delta)
		{
			if (delta <= 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (CurrentHeight + delta > MaxHeight)
			{
				CurrentHeight = MaxHeight;
			}
			else
			{
				CurrentHeight += delta;
			}
		}

		public void TakeLower(int delta)
		{
			if (delta <= 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (CurrentHeight - delta > 0)
			{
				CurrentHeight = CurrentHeight - delta;
			}
			else if (CurrentHeight - delta == 0)
			{
				CurrentHeight = 0;
			}
			else
			{
				throw new InvalidOperationException("Crash!");
			}
		}

		public BaseFly(int maxHeight)
		{
			MaxHeight = maxHeight;
			CurrentHeight = 0;
		}

		public virtual void WriteAllProperties()
		{
			//добавить общие
		}
	}
}
