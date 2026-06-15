using System;
using System.Diagnostics;

// Token: 0x02000124 RID: 292
[DebuggerDisplay("{2+F11CA1A4.C3013D95()}")]
internal abstract class Class75
{
	// Token: 0x060002BD RID: 701 RVA: 0x00002451 File Offset: 0x00000651
	public static uint smethod_0(uint uint_0)
	{
		uint_0 -= 2U;
		if (uint_0 < 4U)
		{
			return uint_0;
		}
		return 3U;
	}

	// Token: 0x0200016D RID: 365
	public struct Struct17
	{
		// Token: 0x06000332 RID: 818 RVA: 0x00002462 File Offset: 0x00000662
		public void D026719A()
		{
			if (this.uint_0 < 4U)
			{
				this.uint_0 = 0U;
				return;
			}
			if (this.uint_0 < 10U)
			{
				this.uint_0 -= 3U;
				return;
			}
			this.uint_0 -= 6U;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000024A2 File Offset: 0x000006A2
		public void method_0()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 7U : 10U);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000024BE File Offset: 0x000006BE
		public bool AA245A1B()
		{
			return this.uint_0 < 7U;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000024C9 File Offset: 0x000006C9
		public void method_1()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 9U : 11U);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000024E6 File Offset: 0x000006E6
		public void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 8U : 11U);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002502 File Offset: 0x00000702
		public void method_3()
		{
			this.uint_0 = 0U;
		}

		// Token: 0x0400016E RID: 366
		public uint uint_0;
	}
}
