using System;
using System.Diagnostics;

// Token: 0x0200003F RID: 63
[DebuggerDisplay("{2+F11CA1A4.C3013D95()}")]
public class F281FEA4
{
	// Token: 0x06000125 RID: 293 RVA: 0x000025F4 File Offset: 0x000007F4
	public uint method_0(uint uint_1)
	{
		uint num = uint_1 ^ this.uint_0;
		this.uint_0 = ((this.uint_0 << 7) | (this.uint_0 >> 25)) ^ num;
		return num;
	}

	// Token: 0x06000126 RID: 294 RVA: 0x0000209F File Offset: 0x0000029F
	public F281FEA4()
	{
		this.uint_0 = 1553532948U;
	}

	// Token: 0x04000077 RID: 119
	private uint uint_0;
}
