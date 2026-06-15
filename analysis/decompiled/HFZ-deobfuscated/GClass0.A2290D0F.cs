using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public static class GClass0
{
	private class A2290D0F : WebClient
	{
		[CompilerGenerated]
		private int BA877CA9;

		public extern int Int32_0
		{
			[CompilerGenerated]
			get;
			[CompilerGenerated]
			set;
		}

		public extern A2290D0F(int int_0);

		protected override extern WebRequest GetWebRequest(Uri F798232B);
	}

	private static X509Certificate2 x509Certificate2_0;

	private static readonly int int_0;

	static extern GClass0();

	public static extern byte[] smethod_0(string string_0, Dictionary<string, string> dictionary_0);
}
