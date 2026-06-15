using System;
using System.Diagnostics;
using System.IO;

// Token: 0x0200018E RID: 398
[DebuggerDisplay("{2+F11CA1A4.C3013D95()}")]
public class GClass13
{
	// Token: 0x06000ECB RID: 3787 RVA: 0x004039AC File Offset: 0x00401BAC
	private void method_0(Stream CDBEC12C, Stream stream_0)
	{
		this.cf9A9A86_0.D2B47022(CDBEC12C);
		this.A2BACA3B.method_2(stream_0, false);
		for (uint num = 0U; num < 12U; num += 1U)
		{
			for (uint num2 = 0U; num2 <= this.uint_1; num2 += 1U)
			{
				uint num3 = (num << 4) + num2;
				this.d13BA20B_2[(int)num3].method_1();
				this.d13BA20B_1[(int)num3].method_1();
			}
			this.d13BA20B_0[(int)num].method_1();
			this.A3BC6421[(int)num].method_1();
			this.d13BA20B_4[(int)num].method_1();
			this.d13BA20B_3[(int)num].method_1();
		}
		this.c7316612_0.method_1();
		for (uint num = 0U; num < 4U; num += 1U)
		{
			this.fdaaaf93_0[(int)num].method_1();
		}
		for (uint num = 0U; num < 114U; num += 1U)
		{
			this.BC01598D[(int)num].method_1();
		}
		this.A1B66104.F2B02E89();
		this.c583C887_0.F2B02E89();
		this.DF267FB1.method_1();
	}

	// Token: 0x06000ECC RID: 3788 RVA: 0x00403ADC File Offset: 0x00401CDC
	public void method_1(byte[] F731410A)
	{
		if (F731410A.Length < 5)
		{
			throw new ArgumentException();
		}
		int num = (int)(F731410A[0] % 9);
		byte b = F731410A[0] / 9;
		int num2 = (int)(b % 5);
		int num3 = (int)(b / 5);
		if (num3 > 4)
		{
			throw new ArgumentException();
		}
		uint num4 = 0U;
		for (int i = 0; i < 4; i++)
		{
			num4 += (uint)((uint)F731410A[1 + i] << i * 8);
		}
		this.method_3(num4);
		this.method_5(num2, num);
		this.method_2(num3);
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x00403B58 File Offset: 0x00401D58
	private void method_2(int D6B79A84)
	{
		if (D6B79A84 > 4)
		{
			throw new ArgumentException();
		}
		uint num = 1U << D6B79A84;
		this.A1B66104.D6318933(num);
		this.c583C887_0.D6318933(num);
		this.uint_1 = num - 1U;
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x00403B9C File Offset: 0x00401D9C
	private void method_3(uint C382469E)
	{
		if (this.CFADF882 != C382469E)
		{
			this.CFADF882 = C382469E;
			this.uint_0 = Math.Max(this.CFADF882, 1U);
			uint num = Math.Max(this.uint_0, 4096U);
			this.A2BACA3B.method_4(num);
		}
	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x00403BEC File Offset: 0x00401DEC
	public void method_4(Stream F49E3D86, Stream A68578B5, long DC80C78F)
	{
		this.method_0(F49E3D86, A68578B5);
		Class75.Struct17 @struct = default(Class75.Struct17);
		@struct.method_3();
		uint num = 0U;
		uint num2 = 0U;
		uint num3 = 0U;
		uint num4 = 0U;
		ulong num5 = 0UL;
		if (num5 < (ulong)DC80C78F)
		{
			if (this.d13BA20B_2[(int)((int)@struct.uint_0 << 4)].method_0(this.cf9A9A86_0) != 0U)
			{
				throw new InvalidDataException();
			}
			@struct.D026719A();
			byte b = this.c7316612_0.method_0(this.cf9A9A86_0, 0U, 0);
			this.A2BACA3B.BF36DCBE(b);
			num5 += 1UL;
		}
		while (num5 < (ulong)DC80C78F)
		{
			uint num6 = (uint)num5 & this.uint_1;
			if (this.d13BA20B_2[(int)((@struct.uint_0 << 4) + num6)].method_0(this.cf9A9A86_0) == 0U)
			{
				byte b2 = this.A2BACA3B.E68AC02C(0U);
				byte b3;
				if (!@struct.AA245A1B())
				{
					b3 = this.c7316612_0.C188D539(this.cf9A9A86_0, (uint)num5, b2, this.A2BACA3B.E68AC02C(num));
				}
				else
				{
					b3 = this.c7316612_0.method_0(this.cf9A9A86_0, (uint)num5, b2);
				}
				this.A2BACA3B.BF36DCBE(b3);
				@struct.D026719A();
				num5 += 1UL;
			}
			else
			{
				uint num8;
				if (this.d13BA20B_0[(int)@struct.uint_0].method_0(this.cf9A9A86_0) == 1U)
				{
					if (this.A3BC6421[(int)@struct.uint_0].method_0(this.cf9A9A86_0) == 0U)
					{
						if (this.d13BA20B_1[(int)((@struct.uint_0 << 4) + num6)].method_0(this.cf9A9A86_0) == 0U)
						{
							@struct.method_1();
							this.A2BACA3B.BF36DCBE(this.A2BACA3B.E68AC02C(num));
							num5 += 1UL;
							continue;
						}
					}
					else
					{
						uint num7;
						if (this.d13BA20B_4[(int)@struct.uint_0].method_0(this.cf9A9A86_0) == 0U)
						{
							num7 = num2;
						}
						else
						{
							if (this.d13BA20B_3[(int)@struct.uint_0].method_0(this.cf9A9A86_0) == 0U)
							{
								num7 = num3;
							}
							else
							{
								num7 = num4;
								num4 = num3;
							}
							num3 = num2;
						}
						num2 = num;
						num = num7;
					}
					num8 = this.c583C887_0.A309A526(this.cf9A9A86_0, num6) + 2U;
					@struct.method_2();
				}
				else
				{
					num4 = num3;
					num3 = num2;
					num2 = num;
					num8 = 2U + this.A1B66104.A309A526(this.cf9A9A86_0, num6);
					@struct.method_0();
					uint num9 = this.fdaaaf93_0[(int)Class75.smethod_0(num8)].B88BB209(this.cf9A9A86_0);
					if (num9 >= 4U)
					{
						int num10 = (int)((num9 >> 1) - 1U);
						num = (2U | (num9 & 1U)) << num10;
						if (num9 < 14U)
						{
							num += FDAAAF93.smethod_0(this.BC01598D, num - num9 - 1U, this.cf9A9A86_0, num10);
						}
						else
						{
							num += this.cf9A9A86_0.method_1(num10 - 4) << 4;
							num += this.DF267FB1.method_0(this.cf9A9A86_0);
						}
					}
					else
					{
						num = num9;
					}
				}
				if ((ulong)num >= (ulong)this.A2BACA3B.uint_0 + num5 || num >= this.uint_0)
				{
					if (num != 4294967295U)
					{
						throw new InvalidDataException();
					}
					break;
				}
				else
				{
					this.A2BACA3B.method_3(num, num8);
					num5 += (ulong)num8;
				}
			}
		}
		this.A2BACA3B.method_1();
		this.A2BACA3B.method_0();
		this.cf9A9A86_0.method_0();
	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x0000250B File Offset: 0x0000070B
	private void method_5(int A826CCB4, int int_0)
	{
		if (A826CCB4 > 8)
		{
			throw new ArgumentException();
		}
		if (int_0 > 8)
		{
			throw new ArgumentException();
		}
		this.c7316612_0.C994C4B3(A826CCB4, int_0);
	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x00403F74 File Offset: 0x00402174
	public GClass13()
	{
		this.CFADF882 = uint.MaxValue;
		int num = 0;
		while ((long)num < 4L)
		{
			this.fdaaaf93_0[num] = new FDAAAF93(6);
			num++;
		}
	}

	// Token: 0x040001B6 RID: 438
	private readonly D13BA20B[] d13BA20B_0 = new D13BA20B[12];

	// Token: 0x040001B7 RID: 439
	private readonly D13BA20B[] d13BA20B_1 = new D13BA20B[192];

	// Token: 0x040001B8 RID: 440
	private readonly GClass13.C583C887 c583C887_0 = new GClass13.C583C887();

	// Token: 0x040001B9 RID: 441
	private readonly GClass5 A2BACA3B = new GClass5();

	// Token: 0x040001BA RID: 442
	private readonly FDAAAF93[] fdaaaf93_0 = new FDAAAF93[4];

	// Token: 0x040001BB RID: 443
	private FDAAAF93 DF267FB1 = new FDAAAF93(4);

	// Token: 0x040001BC RID: 444
	private readonly D13BA20B[] A3BC6421 = new D13BA20B[12];

	// Token: 0x040001BD RID: 445
	private uint uint_0;

	// Token: 0x040001BE RID: 446
	private readonly CF9A9A86 cf9A9A86_0 = new CF9A9A86();

	// Token: 0x040001BF RID: 447
	private readonly D13BA20B[] d13BA20B_2 = new D13BA20B[192];

	// Token: 0x040001C0 RID: 448
	private readonly GClass13.C7316612 c7316612_0 = new GClass13.C7316612();

	// Token: 0x040001C1 RID: 449
	private uint CFADF882;

	// Token: 0x040001C2 RID: 450
	private readonly GClass13.C583C887 A1B66104 = new GClass13.C583C887();

	// Token: 0x040001C3 RID: 451
	private readonly D13BA20B[] BC01598D = new D13BA20B[114];

	// Token: 0x040001C4 RID: 452
	private uint uint_1;

	// Token: 0x040001C5 RID: 453
	private readonly D13BA20B[] d13BA20B_3 = new D13BA20B[12];

	// Token: 0x040001C6 RID: 454
	private readonly D13BA20B[] d13BA20B_4 = new D13BA20B[12];

	// Token: 0x040001C7 RID: 455
	private uint uint_2 = 1U;

	// Token: 0x020001D3 RID: 467
	[DebuggerDisplay("{2+F11CA1A4.C3013D95()}")]
	private class C583C887
	{
		// Token: 0x06000FB0 RID: 4016 RVA: 0x00409B20 File Offset: 0x00407D20
		public uint A309A526(CF9A9A86 D93767AE, uint uint_1)
		{
			if (this.BE03BD9C.method_0(D93767AE) == 0U)
			{
				return this.FA1F7098[(int)uint_1].B88BB209(D93767AE);
			}
			uint num = 8U;
			if (this.d13BA20B_0.method_0(D93767AE) == 0U)
			{
				num += this.fdaaaf93_0[(int)uint_1].B88BB209(D93767AE);
			}
			else
			{
				num += 8U;
				num += this.D6B1AE20.B88BB209(D93767AE);
			}
			return num;
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00409B94 File Offset: 0x00407D94
		public void F2B02E89()
		{
			this.BE03BD9C.method_1();
			for (uint num = 0U; num < this.uint_0; num += 1U)
			{
				this.FA1F7098[(int)num].method_1();
				this.fdaaaf93_0[(int)num].method_1();
			}
			this.d13BA20B_0.method_1();
			this.D6B1AE20.method_1();
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00409BFC File Offset: 0x00407DFC
		public void D6318933(uint uint_1)
		{
			for (uint num = this.uint_0; num < uint_1; num += 1U)
			{
				this.FA1F7098[(int)num] = new FDAAAF93(3);
				this.fdaaaf93_0[(int)num] = new FDAAAF93(3);
			}
			this.uint_0 = uint_1;
		}

		// Token: 0x04000240 RID: 576
		private D13BA20B d13BA20B_0;

		// Token: 0x04000241 RID: 577
		private readonly FDAAAF93[] FA1F7098 = new FDAAAF93[16];

		// Token: 0x04000242 RID: 578
		private FDAAAF93 D6B1AE20 = new FDAAAF93(8);

		// Token: 0x04000243 RID: 579
		private readonly FDAAAF93[] fdaaaf93_0 = new FDAAAF93[16];

		// Token: 0x04000244 RID: 580
		private uint uint_0;

		// Token: 0x04000245 RID: 581
		private D13BA20B BE03BD9C;
	}

	// Token: 0x020001D4 RID: 468
	[DebuggerDisplay("{2+F11CA1A4.C3013D95()}")]
	private class C7316612
	{
		// Token: 0x06000FB3 RID: 4019 RVA: 0x00002562 File Offset: 0x00000762
		private uint D99A9632(uint uint_2, byte byte_0)
		{
			return ((uint_2 & this.uint_0) << this.int_0) + (uint)(byte_0 >> 8 - this.int_0);
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00002584 File Offset: 0x00000784
		public byte method_0(CF9A9A86 cf9A9A86_0, uint D2259621, byte byte_0)
		{
			return this.CD950686[(int)this.D99A9632(D2259621, byte_0)].method_0(cf9A9A86_0);
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x000025AE File Offset: 0x000007AE
		public byte C188D539(CF9A9A86 cf9A9A86_0, uint uint_2, byte C8939022, byte DB9337AA)
		{
			return this.CD950686[(int)this.D99A9632(uint_2, C8939022)].A92BCD0A(cf9A9A86_0, DB9337AA);
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00409C4C File Offset: 0x00407E4C
		public void method_1()
		{
			uint num = 1U << this.int_0 + this.DA8DE326;
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this.CD950686[(int)num2].B9B0B60C();
			}
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00409C90 File Offset: 0x00407E90
		public void C994C4B3(int int_1, int EA8FE50B)
		{
			if (this.CD950686 != null && this.int_0 == EA8FE50B && this.DA8DE326 == int_1)
			{
				return;
			}
			this.DA8DE326 = int_1;
			this.uint_0 = (1U << int_1) - 1U;
			this.int_0 = EA8FE50B;
			uint num = 1U << this.int_0 + this.DA8DE326;
			this.CD950686 = new GClass13.C7316612.Struct19[num];
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this.CD950686[(int)num2].B9194BB4();
			}
		}

		// Token: 0x04000246 RID: 582
		private uint uint_0;

		// Token: 0x04000247 RID: 583
		private int int_0;

		// Token: 0x04000248 RID: 584
		private GClass13.C7316612.Struct19[] CD950686;

		// Token: 0x04000249 RID: 585
		private int DA8DE326;

		// Token: 0x0400024A RID: 586
		private uint uint_1 = 1U;

		// Token: 0x020001FD RID: 509
		private struct Struct19
		{
			// Token: 0x0600105D RID: 4189 RVA: 0x0040C040 File Offset: 0x0040A240
			public byte A92BCD0A(CF9A9A86 BF3AEB94, byte F9BF5B31)
			{
				uint num = 1U;
				for (;;)
				{
					uint num2 = (uint)((F9BF5B31 >> 7) & 1);
					F9BF5B31 = (byte)(F9BF5B31 << 1);
					uint num3 = this.d13BA20B_0[(int)((1U + num2 << 8) + num)].method_0(BF3AEB94);
					num = (num << 1) | num3;
					if (num2 != num3)
					{
						break;
					}
					if (num >= 256U)
					{
						goto IL_006B;
					}
				}
				while (num < 256U)
				{
					num = (num << 1) | this.d13BA20B_0[(int)num].method_0(BF3AEB94);
				}
				IL_006B:
				return (byte)num;
			}

			// Token: 0x0600105E RID: 4190 RVA: 0x0040C0BC File Offset: 0x0040A2BC
			public byte method_0(CF9A9A86 A0129FB7)
			{
				uint num = 1U;
				do
				{
					num = (num << 1) | this.d13BA20B_0[(int)num].method_0(A0129FB7);
				}
				while (num < 256U);
				return (byte)num;
			}

			// Token: 0x0600105F RID: 4191 RVA: 0x0040C0F0 File Offset: 0x0040A2F0
			public void B9B0B60C()
			{
				for (int i = 0; i < 768; i++)
				{
					this.d13BA20B_0[i].method_1();
				}
			}

			// Token: 0x06001060 RID: 4192 RVA: 0x000025CB File Offset: 0x000007CB
			public void B9194BB4()
			{
				this.d13BA20B_0 = new D13BA20B[768];
			}

			// Token: 0x04000260 RID: 608
			private D13BA20B[] d13BA20B_0;
		}
	}
}
