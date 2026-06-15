using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Token: 0x0200000D RID: 13
public class GClass2
{
	// Token: 0x0600000F RID: 15
	public static extern void smethod_0(Form D9B62CB9, string string_0);

	// Token: 0x06000010 RID: 16
	public static extern void smethod_1(Form form_0, string string_0);

	// Token: 0x06000011 RID: 17
	public static extern void smethod_2(string string_0);

	// Token: 0x06000012 RID: 18
	[DllImport("wininet", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool InternetSetOption(int int_1, int CAA9A29C, IntPtr EC038705, int int_2);

	// Token: 0x06000013 RID: 19
	public static extern void smethod_3();

	// Token: 0x06000014 RID: 20
	public static extern void smethod_4();

	// Token: 0x06000015 RID: 21
	public static extern void E62E9F90(object object_0);

	// Token: 0x06000016 RID: 22
	public static extern void smethod_5(string string_0);

	// Token: 0x06000017 RID: 23
	public extern GClass2();

	// Token: 0x04000021 RID: 33
	private static int int_0;

	// Token: 0x02000015 RID: 21
	[CompilerGenerated]
	[Serializable]
	private sealed class F32BF78C
	{
		// Token: 0x060000B1 RID: 177
		public extern F32BF78C();

		// Token: 0x060000B2 RID: 178
		internal extern void ECA359A1();

		// Token: 0x04000056 RID: 86
		public static readonly GClass2.F32BF78C <>9;

		// Token: 0x04000057 RID: 87
		public static Action <>9__6_0;
	}

	// Token: 0x02000016 RID: 22
	[CompilerGenerated]
	private sealed class D2356731
	{
		// Token: 0x060000B3 RID: 179
		public extern D2356731();

		// Token: 0x060000B4 RID: 180
		internal extern void method_0();

		// Token: 0x04000058 RID: 88
		public Form form_0;

		// Token: 0x04000059 RID: 89
		public string C9B41C91;
	}

	// Token: 0x02000017 RID: 23
	[CompilerGenerated]
	private sealed class Class0
	{
		// Token: 0x060000B5 RID: 181
		public extern Class0();

		// Token: 0x060000B6 RID: 182
		internal extern void method_0();

		// Token: 0x0400005A RID: 90
		public Form form_0;

		// Token: 0x0400005B RID: 91
		public string string_0;
	}
}
