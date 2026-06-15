using System;

// Token: 0x020000DD RID: 221
internal struct FDAAAF93
{
	// Token: 0x0600024E RID: 590 RVA: 0x00002DD8 File Offset: 0x00000FD8
	public uint method_0(CF9A9A86 cf9A9A86_0)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < this.D2145E9A; i++)
		{
			uint num3 = this.DA0EF71B[(int)num].method_0(cf9A9A86_0);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00002E28 File Offset: 0x00001028
	public void method_1()
	{
		uint num = 1U;
		while ((ulong)num < (ulong)(1L << (this.D2145E9A & 31)))
		{
			this.DA0EF71B[(int)num].method_1();
			num += 1U;
		}
	}

	// Token: 0x06000250 RID: 592 RVA: 0x00002E64 File Offset: 0x00001064
	public static uint smethod_0(D13BA20B[] C6B2DE02, uint uint_0, CF9A9A86 C2269532, int int_0)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < int_0; i++)
		{
			uint num3 = C6B2DE02[(int)(uint_0 + num)].method_0(C2269532);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00002EAC File Offset: 0x000010AC
	public uint B88BB209(CF9A9A86 E10D3B8C)
	{
		uint num = 1U;
		for (int i = this.D2145E9A; i > 0; i--)
		{
			num = (num << 1) + this.DA0EF71B[(int)num].method_0(E10D3B8C);
		}
		return num - (1U << this.D2145E9A);
	}

	// Token: 0x06000252 RID: 594 RVA: 0x0000240F File Offset: 0x0000060F
	public FDAAAF93(int D2145E9A)
	{
		this.D2145E9A = D2145E9A;
		this.DA0EF71B = new D13BA20B[1 << D2145E9A];
	}

	// Token: 0x0400010F RID: 271
	private readonly D13BA20B[] DA0EF71B;

	// Token: 0x04000110 RID: 272
	private readonly int D2145E9A;
}
