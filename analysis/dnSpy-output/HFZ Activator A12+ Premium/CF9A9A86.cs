using System;
using System.Diagnostics;
using System.IO;

// Token: 0x020000BD RID: 189
[DebuggerDisplay("{2+F11CA1A4.C3013D95()}")]
internal class CF9A9A86
{
	// Token: 0x0600021E RID: 542 RVA: 0x00002406 File Offset: 0x00000606
	public void method_0()
	{
		this.stream_0 = null;
	}

	// Token: 0x0600021F RID: 543 RVA: 0x00002D0C File Offset: 0x00000F0C
	public uint method_1(int C5914934)
	{
		uint num = this.uint_0;
		uint num2 = this.BE945224;
		uint num3 = 0U;
		for (int i = C5914934; i > 0; i--)
		{
			num >>= 1;
			uint num4 = num2 - num >> 31;
			num2 -= num & (num4 - 1U);
			num3 = (num3 << 1) | (1U - num4);
			if (num < 16777216U)
			{
				num2 = (num2 << 8) | (uint)((byte)this.stream_0.ReadByte());
				num <<= 8;
			}
		}
		this.uint_0 = num;
		this.BE945224 = num2;
		return num3;
	}

	// Token: 0x06000220 RID: 544 RVA: 0x00002D88 File Offset: 0x00000F88
	public void D2B47022(Stream stream_1)
	{
		this.stream_0 = stream_1;
		this.BE945224 = 0U;
		this.uint_0 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			this.BE945224 = (this.BE945224 << 8) | (uint)((byte)this.stream_0.ReadByte());
		}
	}

	// Token: 0x040000BE RID: 190
	public uint BE945224;

	// Token: 0x040000BF RID: 191
	public uint uint_0;

	// Token: 0x040000C0 RID: 192
	public Stream stream_0;

	// Token: 0x040000C1 RID: 193
	private uint uint_1 = 1U;
}
