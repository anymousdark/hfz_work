using System.Diagnostics;
using System.IO;

[DebuggerDisplay(/*Could not decode attribute arguments.*/)]
public class 3FBEA496
{
	private Stream 3D88BB17;

	private uint BA877830;

	private uint BCBF742A;

	public uint 7B9D9E95;

	private uint 9510341D;

	private uint 4B2F6714 = 1u;

	private byte[] 299DE922;

	public byte E68AC02C(uint 0A0BBCB9)
	{
		uint num = BA877830 - 0A0BBCB9 - 1;
		if (num >= 9510341D)
		{
			num += 9510341D;
		}
		return 299DE922[num];
	}

	public void 5F079430()
	{
		9E9B1FB7();
		3D88BB17 = null;
	}

	public void BF36DCBE(byte AE188235)
	{
		299DE922[BA877830++] = AE188235;
		if (BA877830 >= 9510341D)
		{
			9E9B1FB7();
		}
	}

	public void 9E9B1FB7()
	{
		uint num = BA877830 - BCBF742A;
		if (num != 0)
		{
			3D88BB17.Write(299DE922, (int)BCBF742A, (int)num);
			if (BA877830 >= 9510341D)
			{
				BA877830 = 0u;
			}
			BCBF742A = BA877830;
		}
	}

	public void 36041A34(Stream AF3643AB, bool 0087823B)
	{
		5F079430();
		3D88BB17 = AF3643AB;
		if (!0087823B)
		{
			BCBF742A = 0u;
			BA877830 = 0u;
			7B9D9E95 = 0u;
		}
	}

	public void 7610CF0B(uint BD39F585, uint 5A298EA5)
	{
		uint num = BA877830 - BD39F585 - 1;
		if (num >= 9510341D)
		{
			num += 9510341D;
		}
		while (5A298EA5 != 0)
		{
			if (num >= 9510341D)
			{
				num = 0u;
			}
			299DE922[BA877830++] = 299DE922[num++];
			if (BA877830 >= 9510341D)
			{
				9E9B1FB7();
			}
			5A298EA5--;
		}
	}

	public void 5B04802F(uint 27260E2A)
	{
		if (9510341D != 27260E2A)
		{
			299DE922 = new byte[27260E2A];
		}
		9510341D = 27260E2A;
		BA877830 = 0u;
		BCBF742A = 0u;
	}
}
