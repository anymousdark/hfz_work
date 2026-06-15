using System.Diagnostics;

[DebuggerDisplay(/*Could not decode attribute arguments.*/)]
internal abstract class 6F31DCA3
{
	public struct 0C0D7A9D
	{
		public uint 36079A1F;

		public void D026719A()
		{
			if (36079A1F < 4)
			{
				36079A1F = 0u;
			}
			else if (36079A1F < 10)
			{
				36079A1F -= 3u;
			}
			else
			{
				36079A1F -= 6u;
			}
		}

		public void 31A71D91()
		{
			36079A1F = ((36079A1F < 7) ? 7u : 10u);
		}

		public bool AA245A1B()
		{
			return 36079A1F < 7;
		}

		public void 9814759A()
		{
			36079A1F = ((36079A1F < 7) ? 9u : 11u);
		}

		public void 6EB07A28()
		{
			36079A1F = ((36079A1F < 7) ? 8u : 11u);
		}

		public void 649C5D33()
		{
			36079A1F = 0u;
		}
	}

	public static uint 050EA7BD(uint 46152E11)
	{
		46152E11 -= 2;
		if (46152E11 < 4)
		{
			return 46152E11;
		}
		return 3u;
	}
}
