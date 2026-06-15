internal struct FDAAAF93
{
	private readonly D13BA20B[] DA0EF71B;

	private readonly int 471850B4;

	public uint 091C3B21(CF9A9A86 1A2337B7)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < 471850B4; i++)
		{
			uint num3 = DA0EF71B[num].9131D083(1A2337B7);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	public void 8523629E()
	{
		for (uint num = 1u; num < 1 << 471850B4; num++)
		{
			DA0EF71B[num].911BCF37();
		}
	}

	public static uint 602926AD(D13BA20B[] C6B2DE02, uint 87AD0815, CF9A9A86 C2269532, int 189351B9)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = 0; i < 189351B9; i++)
		{
			uint num3 = C6B2DE02[87AD0815 + num].9131D083(C2269532);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	public uint B88BB209(CF9A9A86 E10D3B8C)
	{
		uint num = 1u;
		for (int num2 = 471850B4; num2 > 0; num2--)
		{
			num = (num << 1) + DA0EF71B[num].9131D083(E10D3B8C);
		}
		return num - (uint)(1 << 471850B4);
	}

	public FDAAAF93(int D2145E9A)
	{
		471850B4 = D2145E9A;
		DA0EF71B = new D13BA20B[1 << D2145E9A];
	}
}
