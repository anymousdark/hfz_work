using System;

// Token: 0x0200010C RID: 268
internal struct D13BA20B
{
	// Token: 0x06000296 RID: 662 RVA: 0x00003328 File Offset: 0x00001528
	public uint method_0(CF9A9A86 cf9A9A86_0)
	{
		uint num = (cf9A9A86_0.uint_0 >> 11) * this.uint_0;
		if (cf9A9A86_0.BE945224 < num)
		{
			cf9A9A86_0.uint_0 = num;
			this.uint_0 += 2048U - this.uint_0 >> 5;
			if (cf9A9A86_0.uint_0 < 16777216U)
			{
				cf9A9A86_0.BE945224 = (cf9A9A86_0.BE945224 << 8) | (uint)((byte)cf9A9A86_0.stream_0.ReadByte());
				cf9A9A86_0.uint_0 <<= 8;
			}
			return 0U;
		}
		cf9A9A86_0.uint_0 -= num;
		cf9A9A86_0.BE945224 -= num;
		this.uint_0 -= this.uint_0 >> 5;
		if (cf9A9A86_0.uint_0 < 16777216U)
		{
			cf9A9A86_0.BE945224 = (cf9A9A86_0.BE945224 << 8) | (uint)((byte)cf9A9A86_0.stream_0.ReadByte());
			cf9A9A86_0.uint_0 <<= 8;
		}
		return 1U;
	}

	// Token: 0x06000297 RID: 663 RVA: 0x00002429 File Offset: 0x00000629
	public void method_1()
	{
		this.uint_0 = 1024U;
	}

	// Token: 0x04000128 RID: 296
	private uint uint_0;
}
