using System;
using System.Diagnostics;
using System.IO;

// Token: 0x02000066 RID: 102
[DebuggerDisplay("{2+F11CA1A4.C3013D95()}")]
public class GClass5
{
	// Token: 0x0600015E RID: 350 RVA: 0x00002628 File Offset: 0x00000828
	public byte E68AC02C(uint uint_3)
	{
		uint num = this.BA877830 - uint_3 - 1U;
		if (num >= this.uint_1)
		{
			num += this.uint_1;
		}
		return this.byte_0[(int)num];
	}

	// Token: 0x0600015F RID: 351 RVA: 0x000020B2 File Offset: 0x000002B2
	public void method_0()
	{
		this.method_1();
		this.stream_0 = null;
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00002660 File Offset: 0x00000860
	public void BF36DCBE(byte AE188235)
	{
		byte[] array = this.byte_0;
		uint ba = this.BA877830;
		this.BA877830 = ba + 1U;
		array[(int)ba] = AE188235;
		if (this.BA877830 >= this.uint_1)
		{
			this.method_1();
		}
	}

	// Token: 0x06000161 RID: 353 RVA: 0x000026A0 File Offset: 0x000008A0
	public void method_1()
	{
		uint num = this.BA877830 - this.BCBF742A;
		if (num == 0U)
		{
			return;
		}
		this.stream_0.Write(this.byte_0, (int)this.BCBF742A, (int)num);
		if (this.BA877830 >= this.uint_1)
		{
			this.BA877830 = 0U;
		}
		this.BCBF742A = this.BA877830;
	}

	// Token: 0x06000162 RID: 354 RVA: 0x000020C1 File Offset: 0x000002C1
	public void method_2(Stream AF3643AB, bool bool_0)
	{
		this.method_0();
		this.stream_0 = AF3643AB;
		if (!bool_0)
		{
			this.BCBF742A = 0U;
			this.BA877830 = 0U;
			this.uint_0 = 0U;
		}
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00002700 File Offset: 0x00000900
	public void method_3(uint BD39F585, uint uint_3)
	{
		uint num = this.BA877830 - BD39F585 - 1U;
		if (num >= this.uint_1)
		{
			num += this.uint_1;
		}
		while (uint_3 > 0U)
		{
			if (num >= this.uint_1)
			{
				num = 0U;
			}
			byte[] array = this.byte_0;
			uint ba = this.BA877830;
			this.BA877830 = ba + 1U;
			array[(int)ba] = this.byte_0[(int)num++];
			if (this.BA877830 >= this.uint_1)
			{
				this.method_1();
			}
			uint_3 -= 1U;
		}
	}

	// Token: 0x06000165 RID: 357 RVA: 0x000020FA File Offset: 0x000002FA
	public void method_4(uint uint_3)
	{
		if (this.uint_1 != uint_3)
		{
			this.byte_0 = new byte[uint_3];
		}
		this.uint_1 = uint_3;
		this.BA877830 = 0U;
		this.BCBF742A = 0U;
	}

	// Token: 0x0400007A RID: 122
	private Stream stream_0;

	// Token: 0x0400007B RID: 123
	private uint BA877830;

	// Token: 0x0400007C RID: 124
	private uint BCBF742A;

	// Token: 0x0400007D RID: 125
	public uint uint_0;

	// Token: 0x0400007E RID: 126
	private uint uint_1;

	// Token: 0x0400007F RID: 127
	private uint uint_2 = 1U;

	// Token: 0x04000080 RID: 128
	private byte[] byte_0;
}
