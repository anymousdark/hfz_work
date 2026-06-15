using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

// Token: 0x02000002 RID: 2
public static class GClass0
{
	// Token: 0x06000003 RID: 3
	public static extern byte[] smethod_0(string string_0, Dictionary<string, string> dictionary_0);

	// Token: 0x04000001 RID: 1
	private static X509Certificate2 x509Certificate2_0;

	// Token: 0x04000002 RID: 2
	private static readonly int int_0;

	// Token: 0x02000014 RID: 20
	private class A2290D0F : WebClient
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000AC RID: 172
		// (set) Token: 0x060000AD RID: 173
		public extern int Int32_0
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			set;
		}

		// Token: 0x060000AE RID: 174
		public extern A2290D0F(int int_0);

		// Token: 0x060000AF RID: 175
		protected override extern WebRequest GetWebRequest(Uri F798232B);

		// Token: 0x04000055 RID: 85
		[CompilerGenerated]
		private int BA877CA9;
	}
}
