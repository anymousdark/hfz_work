using System.Diagnostics;
using System.IO;

[DebuggerDisplay(/*Could not decode attribute arguments.*/)]
internal class CF9A9A86
{
	public uint BE945224;

	public uint 7DBC532F;

	public Stream 528ADE92;

	private uint 15A68C24 = 1u;

	public void 339DF22E()
	{
		528ADE92 = null;
	}

	public uint 492AC40A(int C5914934)
	{
		uint num = 7DBC532F;
		uint num2 = BE945224;
		uint num3 = 0u;
		for (int num4 = C5914934; num4 > 0; num4--)
		{
			num >>= 1;
			uint num5 = num2 - num >> 31;
			num2 -= num & (num5 - 1);
			num3 = (num3 << 1) | (1 - num5);
			if (num < 16777216)
			{
				num2 = (num2 << 8) | (byte)528ADE92.ReadByte();
				num <<= 8;
			}
		}
		7DBC532F = num;
		BE945224 = num2;
		return num3;
	}

	public void D2B47022(Stream 7E2F5885)
	{
		528ADE92 = 7E2F5885;
		BE945224 = 0u;
		7DBC532F = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			BE945224 = (BE945224 << 8) | (byte)528ADE92.ReadByte();
		}
	}
}
