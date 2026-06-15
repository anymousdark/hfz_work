using System.Diagnostics;

[DebuggerDisplay(/*Could not decode attribute arguments.*/)]
public class F281FEA4
{
	private uint 13866081;

	public uint 2BAD76AE(uint 3E3A2CAA)
	{
		uint num = 3E3A2CAA ^ 13866081;
		13866081 = ((13866081 << 7) | (13866081 >> 25)) ^ num;
		return num;
	}

	public F281FEA4()
	{
		13866081 = 1553532948u;
	}
}
