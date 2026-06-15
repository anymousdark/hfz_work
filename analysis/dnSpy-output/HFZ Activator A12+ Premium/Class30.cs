using System;
using System.Reflection;
using System.Runtime.InteropServices;

// Token: 0x02000083 RID: 131
internal static class Class30
{
	// Token: 0x0600019C RID: 412 RVA: 0x00002129 File Offset: 0x00000329
	public static bool smethod_0(IntPtr DF38D91F, UIntPtr uintptr_0, Class30.Enum4 D61E5C96)
	{
		return (bool)new GClass12().method_1344(new object[] { DF38D91F, uintptr_0, D61E5C96 }, 4688068);
	}

	// Token: 0x0600019D RID: 413 RVA: 0x00002164 File Offset: 0x00000364
	internal static IntPtr smethod_1(IntPtr intptr_3, object EE91A33D)
	{
		return (IntPtr)new GClass12().method_1344(new object[] { intptr_3, EE91A33D }, 4633689);
	}

	// Token: 0x0600019E RID: 414 RVA: 0x00002191 File Offset: 0x00000391
	public static bool smethod_2()
	{
		return (bool)new GClass12().method_1344(null, 4699932);
	}

	// Token: 0x0600019F RID: 415 RVA: 0x000021A8 File Offset: 0x000003A8
	public static byte[] CB9046A9()
	{
		return (byte[])new GClass12().method_1344(null, 4713097);
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00002788 File Offset: 0x00000988
	public static IntPtr BE9C2AB5(IntPtr intptr_3, UIntPtr F71349AB, Class30.A63B728E a63B728E_0, Class30.Enum3 B3AE718C)
	{
		return (IntPtr)new GClass12().method_1344(new object[] { intptr_3, F71349AB, a63B728E_0, B3AE718C }, 4690183);
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x000027D8 File Offset: 0x000009D8
	public unsafe static IntPtr D62E870C(IntPtr intptr_3, Class30.Enum3 F19BB91F, ulong ulong_0, ref UIntPtr uintptr_0, out IntPtr intptr_4)
	{
		GClass12 gclass = new GClass12();
		object[] array = new object[5];
		array[0] = intptr_3;
		array[1] = F19BB91F;
		array[2] = ulong_0;
		int num = 3;
		TypedReference typedReference = __makeref(uintptr_0);
		array[num] = &typedReference;
		int num2 = 4;
		TypedReference typedReference2 = __makeref(intptr_4);
		array[num2] = &typedReference2;
		return (IntPtr)gclass.method_1344(array, 4687388);
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x000021BF File Offset: 0x000003BF
	public static bool DAAC4581(IntPtr intptr_3, UIntPtr uintptr_0)
	{
		return (bool)new GClass12().method_1344(new object[] { intptr_3, uintptr_0 }, 4708262);
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x000021F1 File Offset: 0x000003F1
	public static byte[] E29C8BB4(uint uint_0)
	{
		return (byte[])new GClass12().method_1344(new object[] { uint_0 }, 4622244);
	}

	// Token: 0x060001A4 RID: 420
	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr GetModuleHandle(string ED16BC9D);

	// Token: 0x060001A5 RID: 421 RVA: 0x0000221A File Offset: 0x0000041A
	public static byte[] smethod_3(string string_0)
	{
		return (byte[])new GClass12().method_1344(new object[] { string_0 }, 4683109);
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x0000223E File Offset: 0x0000043E
	public static uint smethod_4()
	{
		return (uint)new GClass12().method_1344(null, 4712833);
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x00002255 File Offset: 0x00000455
	public static bool smethod_5()
	{
		return (bool)new GClass12().method_1344(null, 4698883);
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x00002850 File Offset: 0x00000A50
	public unsafe static uint smethod_6(IntPtr B835AD89, Class30.F3A4FB2A f3A4FB2A_0, out object object_0, uint uint_0, out uint uint_1)
	{
		GClass12 gclass = new GClass12();
		object[] array = new object[5];
		array[0] = B835AD89;
		array[1] = f3A4FB2A_0;
		int num = 2;
		TypedReference typedReference = __makeref(object_0);
		array[num] = &typedReference;
		array[3] = uint_0;
		int num2 = 4;
		TypedReference typedReference2 = __makeref(uint_1);
		array[num2] = &typedReference2;
		return (uint)gclass.method_1344(array, 4624136);
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x0000226C File Offset: 0x0000046C
	public static string smethod_7()
	{
		return (string)new GClass12().method_1344(null, 4647718);
	}

	// Token: 0x060001AA RID: 426 RVA: 0x000028C8 File Offset: 0x00000AC8
	public unsafe static bool smethod_8(IntPtr intptr_3, UIntPtr uintptr_0, Class30.Enum3 enum3_0, out Class30.Enum3 FE2FAD8E)
	{
		GClass12 gclass = new GClass12();
		object[] array = new object[4];
		array[0] = intptr_3;
		array[1] = uintptr_0;
		array[2] = enum3_0;
		int num = 3;
		TypedReference typedReference = __makeref(FE2FAD8E);
		array[num] = &typedReference;
		return (bool)gclass.method_1344(array, 4692092);
	}

	// Token: 0x060001AB RID: 427 RVA: 0x00002283 File Offset: 0x00000483
	public static byte[] smethod_9(string string_0)
	{
		return (byte[])new GClass12().method_1344(new object[] { string_0 }, 4645481);
	}

	// Token: 0x060001AC RID: 428 RVA: 0x000022A7 File Offset: 0x000004A7
	public static IntPtr smethod_10(string B822891C, Class30.BC8777AF bc8777AF_0, uint C9AB6E2C)
	{
		return (IntPtr)new GClass12().method_1344(new object[] { B822891C, bc8777AF_0, C9AB6E2C }, 4693708);
	}

	// Token: 0x060001AD RID: 429 RVA: 0x000022DD File Offset: 0x000004DD
	public static bool C0A2512C(bool F99CB382 = false)
	{
		return (bool)new GClass12().method_1344(new object[] { F99CB382 }, 4707663);
	}

	// Token: 0x060001AE RID: 430 RVA: 0x00002928 File Offset: 0x00000B28
	private static bool smethod_11(byte[] byte_0)
	{
		int num = byte_0.Length;
		for (int i = 0; i < num; i++)
		{
			if (i + 3 < num && byte_0[i] == 81 && byte_0[i + 1] == 69 && byte_0[i + 2] == 77 && byte_0[i + 3] == 85)
			{
				return true;
			}
			if (i + 5 < num && byte_0[i] == 79 && byte_0[i + 1] == 114 && byte_0[i + 2] == 97 && byte_0[i + 3] == 99 && byte_0[i + 4] == 108 && byte_0[i + 5] == 101)
			{
				return true;
			}
			if (i + 6 < num && byte_0[i] == 105 && byte_0[i + 1] == 110 && byte_0[i + 2] == 110 && byte_0[i + 3] == 111 && byte_0[i + 4] == 116 && byte_0[i + 5] == 101 && byte_0[i + 6] == 107)
			{
				return true;
			}
			if (i + 9 < num && byte_0[i] == 86 && byte_0[i + 1] == 105 && byte_0[i + 2] == 114 && byte_0[i + 3] == 116 && byte_0[i + 4] == 117 && byte_0[i + 5] == 97 && byte_0[i + 6] == 108 && byte_0[i + 7] == 66 && byte_0[i + 8] == 111 && byte_0[i + 9] == 120)
			{
				return true;
			}
			if (i + 15 < num && byte_0[i] == 86 && byte_0[i + 1] == 105 && byte_0[i + 2] == 114 && byte_0[i + 3] == 116 && byte_0[i + 4] == 117 && byte_0[i + 5] == 97 && byte_0[i + 6] == 108 && byte_0[i + 7] == 32 && byte_0[i + 8] == 80 && byte_0[i + 9] == 108 && byte_0[i + 10] == 97 && byte_0[i + 11] == 116 && byte_0[i + 12] == 102 && byte_0[i + 13] == 111 && byte_0[i + 14] == 114 && byte_0[i + 15] == 109)
			{
				return true;
			}
			if (i + 5 < num && byte_0[i] == 86 && byte_0[i + 1] == 77 && byte_0[i + 2] == 119 && byte_0[i + 3] == 97 && byte_0[i + 4] == 114 && byte_0[i + 5] == 101)
			{
				return true;
			}
			if (i + 8 < num && byte_0[i] == 80 && byte_0[i + 1] == 97 && byte_0[i + 2] == 114 && byte_0[i + 3] == 97 && byte_0[i + 4] == 108 && byte_0[i + 5] == 108 && byte_0[i + 6] == 101 && byte_0[i + 7] == 108 && byte_0[i + 8] == 115)
			{
				return true;
			}
			if (i + 5 < num && byte_0[i] == 55 && byte_0[i + 1] == 55 && byte_0[i + 2] == 55 && byte_0[i + 3] == 55 && byte_0[i + 4] == 55 && byte_0[i + 5] == 55)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060001AF RID: 431 RVA: 0x00002306 File Offset: 0x00000506
	private static IntPtr DB0BC18B(uint uint_0)
	{
		return (IntPtr)new GClass12().method_1344(new object[] { uint_0 }, 4635101);
	}

	// Token: 0x060001B0 RID: 432
	[DllImport("libdl.so.2")]
	private static extern IntPtr dlsym(IntPtr intptr_3, string string_0);

	// Token: 0x060001B1 RID: 433 RVA: 0x0000232F File Offset: 0x0000052F
	public static string C998A20E(Module CC3647AD)
	{
		return (string)new GClass12().method_1344(new object[] { CC3647AD }, 4710024);
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00002CA0 File Offset: 0x00000EA0
	private unsafe static uint smethod_12(Class30.B0B935A8 b0B935A8_0, out object DF98220D, uint BC925CAB, out uint D7832F29)
	{
		GClass12 gclass = new GClass12();
		object[] array = new object[4];
		array[0] = b0B935A8_0;
		int num = 1;
		TypedReference typedReference = __makeref(DF98220D);
		array[num] = &typedReference;
		array[2] = BC925CAB;
		int num2 = 3;
		TypedReference typedReference2 = __makeref(D7832F29);
		array[num2] = &typedReference2;
		return (uint)gclass.method_1344(array, 4623111);
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00002353 File Offset: 0x00000553
	public static byte[] EAB0A091(uint uint_0, uint A43AC1B6)
	{
		return (byte[])new GClass12().method_1344(new object[] { uint_0, A43AC1B6 }, 5123542);
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00002385 File Offset: 0x00000585
	public static bool ADAC89BD(IntPtr EB196338)
	{
		return (bool)new GClass12().method_1344(new object[] { EB196338 }, 4694293);
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x000023AE File Offset: 0x000005AE
	public static void DEB1D51E(string E5021C91, string string_0, uint CC017BBA, uint uint_0)
	{
		new GClass12().method_1344(new object[] { E5021C91, string_0, CC017BBA, uint_0 }, 4696870);
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x000023E4 File Offset: 0x000005E4
	static Class30()
	{
		new GClass12().method_1344(null, 4641282);
	}

	// Token: 0x0400008D RID: 141
	private static Class30.A905243E a905243E_0;

	// Token: 0x0400008E RID: 142
	private static Class30.Delegate35 delegate35_0;

	// Token: 0x0400008F RID: 143
	private static Class30.Delegate49 delegate49_0;

	// Token: 0x04000090 RID: 144
	private static Class30.Delegate39 delegate39_0;

	// Token: 0x04000091 RID: 145
	private static Class30.Delegate42 delegate42_0;

	// Token: 0x04000092 RID: 146
	private static Class30.Delegate40 AA968792;

	// Token: 0x04000093 RID: 147
	private static Class30.Delegate44 D1863B82;

	// Token: 0x04000094 RID: 148
	private static Class30.F697C49F D8B98D18;

	// Token: 0x04000095 RID: 149
	private static Class30.Delegate33 delegate33_0;

	// Token: 0x04000096 RID: 150
	private static Class30.Delegate48 FA2B5C9E;

	// Token: 0x04000097 RID: 151
	private static Class30.Delegate38 F0021F28;

	// Token: 0x04000098 RID: 152
	private static Class30.A1B43A00 DB85141A;

	// Token: 0x04000099 RID: 153
	private static Class30.Delegate32 D6270115;

	// Token: 0x0400009A RID: 154
	private static Class30.Delegate46 delegate46_0;

	// Token: 0x0400009B RID: 155
	private static Class30.Delegate36 A0B54D9E;

	// Token: 0x0400009C RID: 156
	private static Class30.Delegate34 delegate34_0;

	// Token: 0x0400009D RID: 157
	private static Class30.D185BC3E D5BAFA8C;

	// Token: 0x0400009E RID: 158
	public static readonly IntPtr intptr_0;

	// Token: 0x0400009F RID: 159
	private static Class30.Delegate47 BEB2E833;

	// Token: 0x040000A0 RID: 160
	public static readonly IntPtr intptr_1;

	// Token: 0x040000A1 RID: 161
	private static Class30.Delegate37 E7180A1E;

	// Token: 0x040000A2 RID: 162
	private static Class30.DE91E189 de91E189_0;

	// Token: 0x040000A3 RID: 163
	private static Class30.Delegate41 delegate41_0;

	// Token: 0x040000A4 RID: 164
	private static Class30.Delegate43 delegate43_0;

	// Token: 0x040000A5 RID: 165
	private static Class30.Delegate45 E5AEFAAE;

	// Token: 0x040000A6 RID: 166
	private static Class30.A08AF33D ADBBFC10;

	// Token: 0x040000A7 RID: 167
	private static Class30.E2127486 e2127486_0;

	// Token: 0x040000A8 RID: 168
	private static Class30.EDA8593B eda8593B_0;

	// Token: 0x040000A9 RID: 169
	public static readonly IntPtr intptr_2;

	// Token: 0x02000086 RID: 134
	// (Invoke) Token: 0x060001BB RID: 443
	private delegate int Delegate32(IntPtr intptr_0);

	// Token: 0x02000088 RID: 136
	public struct Struct5
	{
		// Token: 0x040000AB RID: 171
		public uint uint_0;

		// Token: 0x040000AC RID: 172
		public int int_0;

		// Token: 0x040000AD RID: 173
		public int B6AC7D1F;
	}

	// Token: 0x0200008C RID: 140
	public enum Enum0
	{
		// Token: 0x040000AE RID: 174
		B0140215 = 17
	}

	// Token: 0x02000090 RID: 144
	// (Invoke) Token: 0x060001CA RID: 458
	private delegate uint Delegate33(IntPtr intptr_0);

	// Token: 0x020000A0 RID: 160
	// (Invoke) Token: 0x060001E6 RID: 486
	private delegate IntPtr EDA8593B(string F3370E08, IntPtr FF93AC21);

	// Token: 0x020000AE RID: 174
	// (Invoke) Token: 0x06000205 RID: 517
	private delegate int E2127486(IntPtr F19B6488);

	// Token: 0x020000B4 RID: 180
	public enum Enum1
	{
		// Token: 0x040000B8 RID: 184
		E881E934 = 2
	}

	// Token: 0x020000B7 RID: 183
	public struct Struct6
	{
		// Token: 0x040000BA RID: 186
		public uint B0392608;

		// Token: 0x040000BB RID: 187
		public uint uint_0;

		// Token: 0x040000BC RID: 188
		public uint A995A3B2;

		// Token: 0x040000BD RID: 189
		public uint uint_1;
	}

	// Token: 0x020000B8 RID: 184
	// (Invoke) Token: 0x06000214 RID: 532
	private delegate int Delegate34(IntPtr CB25F720, UIntPtr uintptr_0, Class30.Enum5 enum5_0);

	// Token: 0x020000BE RID: 190
	// (Invoke) Token: 0x06000221 RID: 545
	private delegate uint F697C49F(IntPtr intptr_0, IntPtr intptr_1);

	// Token: 0x020000C7 RID: 199
	public enum Enum2
	{
		// Token: 0x040000C2 RID: 194
		B42EEF8D = 7,
		// Token: 0x040000C3 RID: 195
		const_1,
		// Token: 0x040000C4 RID: 196
		const_2 = 2,
		// Token: 0x040000C5 RID: 197
		const_3,
		// Token: 0x040000C6 RID: 198
		const_4 = 6,
		// Token: 0x040000C7 RID: 199
		F1BABBAD = 4,
		// Token: 0x040000C8 RID: 200
		const_6 = 1,
		// Token: 0x040000C9 RID: 201
		const_7 = 0,
		// Token: 0x040000CA RID: 202
		const_8 = 5
	}

	// Token: 0x020000CA RID: 202
	public enum Enum3 : uint
	{
		// Token: 0x040000CC RID: 204
		E2AC83A7 = 256U,
		// Token: 0x040000CD RID: 205
		const_1 = 16U,
		// Token: 0x040000CE RID: 206
		BAA89A9E = 2U,
		// Token: 0x040000CF RID: 207
		const_3 = 4U,
		// Token: 0x040000D0 RID: 208
		const_4 = 64U,
		// Token: 0x040000D1 RID: 209
		F30CF7B5 = 0U,
		// Token: 0x040000D2 RID: 210
		const_6 = 32U,
		// Token: 0x040000D3 RID: 211
		const_7 = 1U,
		// Token: 0x040000D4 RID: 212
		const_8 = 8U
	}

	// Token: 0x020000CE RID: 206
	// (Invoke) Token: 0x06000239 RID: 569
	private delegate uint DE91E189(IntPtr intptr_0, Class30.Enum0 enum0_0, IntPtr EE130002, uint uint_0, out uint BBA2BB30);

	// Token: 0x020000CF RID: 207
	public struct EE1B7FAF
	{
		// Token: 0x040000D6 RID: 214
		public uint uint_0;

		// Token: 0x040000D7 RID: 215
		public uint uint_1;

		// Token: 0x040000D8 RID: 216
		public byte B2AD7892;
	}

	// Token: 0x020000D8 RID: 216
	// (Invoke) Token: 0x06000249 RID: 585
	private delegate uint Delegate35(IntPtr intptr_0, IntPtr intptr_1, out IntPtr F6A0A40B, UIntPtr uintptr_0, UIntPtr uintptr_1, Class30.Struct12 E1089538, ref UIntPtr uintptr_2, uint uint_0, uint uint_1, Class30.Enum3 enum3_0);

	// Token: 0x020000DA RID: 218
	private struct Struct7
	{
		// Token: 0x04000109 RID: 265
		public IntPtr DC94EE9B;

		// Token: 0x0400010A RID: 266
		public IntPtr A4B1AD2E;

		// Token: 0x0400010B RID: 267
		public IntPtr DF21DA39;

		// Token: 0x0400010C RID: 268
		public IntPtr E9ACF891;

		// Token: 0x0400010D RID: 269
		public int int_0;

		// Token: 0x0400010E RID: 270
		public int int_1;
	}

	// Token: 0x02000100 RID: 256
	// (Invoke) Token: 0x06000282 RID: 642
	private delegate uint Delegate36(IntPtr intptr_0, ref IntPtr intptr_1, ref UIntPtr uintptr_0, Class30.Enum4 enum4_0);

	// Token: 0x02000118 RID: 280
	public enum A63B728E : uint
	{
		// Token: 0x04000157 RID: 343
		const_0 = 8192U,
		// Token: 0x04000158 RID: 344
		B33B0C3C = 4096U
	}

	// Token: 0x0200011C RID: 284
	// (Invoke) Token: 0x060002AC RID: 684
	private delegate IntPtr A08AF33D(IntPtr intptr_0);

	// Token: 0x02000120 RID: 288
	// (Invoke) Token: 0x060002B3 RID: 691
	private delegate uint Delegate37(out IntPtr C1934181, Class30.BC8777AF bc8777AF_0, ref Class30.AD340B82 ad340B82_0, out Class30.Struct9 struct9_0, uint B63B8FA6, uint F291FC93);

	// Token: 0x02000138 RID: 312
	// (Invoke) Token: 0x060002DC RID: 732
	private delegate int Delegate38(IntPtr intptr_0, UIntPtr E4884FBF);

	// Token: 0x02000148 RID: 328
	// (Invoke) Token: 0x060002FA RID: 762
	private delegate uint Delegate39(uint uint_0, uint BB367134, uint D51FA228, IntPtr[] D91DDDA1, uint uint_1, out Class30.Enum2 enum2_0);

	// Token: 0x02000151 RID: 337
	public struct Struct8
	{
		// Token: 0x0400015B RID: 347
		public uint uint_0;

		// Token: 0x0400015C RID: 348
		public uint D7291C36;

		// Token: 0x0400015D RID: 349
		public Class30.Struct5 struct5_0;

		// Token: 0x0400015E RID: 350
		public Class30.Struct5 struct5_1;

		// Token: 0x0400015F RID: 351
		public Class30.Struct5 struct5_2;
	}

	// Token: 0x02000155 RID: 341
	public struct D812C7B0
	{
		// Token: 0x04000160 RID: 352
		public uint uint_0;

		// Token: 0x04000161 RID: 353
		public uint B5A93934;

		// Token: 0x04000162 RID: 354
		public uint uint_1;

		// Token: 0x04000163 RID: 355
		public uint uint_2;

		// Token: 0x04000164 RID: 356
		public uint uint_3;

		// Token: 0x04000165 RID: 357
		public uint E52E5F3A;

		// Token: 0x04000166 RID: 358
		public IntPtr intptr_0;

		// Token: 0x04000167 RID: 359
		public IntPtr intptr_1;

		// Token: 0x04000168 RID: 360
		public IntPtr E80AF686;

		// Token: 0x04000169 RID: 361
		public IntPtr intptr_2;

		// Token: 0x0400016A RID: 362
		public byte byte_0;
	}

	// Token: 0x02000159 RID: 345
	// (Invoke) Token: 0x06000314 RID: 788
	private delegate uint Delegate40(IntPtr CB085825, IntPtr C1BD300E, Class30.Enum1 AB3DE4A3, IntPtr intptr_0, uint uint_0, out uint D08CF9A6);

	// Token: 0x0200015A RID: 346
	public struct Struct9
	{
		// Token: 0x0400016B RID: 363
		public uint uint_0;

		// Token: 0x0400016C RID: 364
		public IntPtr intptr_0;
	}

	// Token: 0x0200016C RID: 364
	// (Invoke) Token: 0x0600032F RID: 815
	private delegate uint Delegate41(Class30.B0B935A8 b0B935A8_0, IntPtr intptr_0, uint uint_0, out uint F89E76A0);

	// Token: 0x0200016F RID: 367
	// (Invoke) Token: 0x0600033B RID: 827
	private delegate IntPtr D185BC3E(IntPtr A1BCED17, UIntPtr uintptr_0, Class30.Enum5 ED068406, Class30.Enum5 enum5_0, IntPtr intptr_0, uint uint_0);

	// Token: 0x02000173 RID: 371
	// (Invoke) Token: 0x06000344 RID: 836
	private delegate uint A1B43A00(IntPtr intptr_0, Class30.Enum0 enum0_0, IntPtr intptr_1, uint uint_0);

	// Token: 0x0200017C RID: 380
	public enum F3A4FB2A
	{
		// Token: 0x0400017C RID: 380
		const_0 = 30,
		// Token: 0x0400017D RID: 381
		D8225416 = 7,
		// Token: 0x0400017E RID: 382
		D312F720 = 0
	}

	// Token: 0x02000182 RID: 386
	public struct Struct10
	{
		// Token: 0x04000182 RID: 386
		public Class30.Struct12 D12D1BB1;

		// Token: 0x04000183 RID: 387
		public uint E8115DB3;

		// Token: 0x04000184 RID: 388
		public uint uint_0;

		// Token: 0x04000185 RID: 389
		public byte byte_0;

		// Token: 0x04000186 RID: 390
		public char char_0;
	}

	// Token: 0x02000187 RID: 391
	public enum B0B935A8
	{
		// Token: 0x040001AD RID: 429
		A738CCB0 = 35,
		// Token: 0x040001AE RID: 430
		BB8F3EAA = 76,
		// Token: 0x040001AF RID: 431
		D3355495 = 0
	}

	// Token: 0x02000188 RID: 392
	public enum Enum4 : uint
	{
		// Token: 0x040001B1 RID: 433
		const_0 = 32768U
	}

	// Token: 0x02000194 RID: 404
	// (Invoke) Token: 0x06000EDA RID: 3802
	private delegate uint Delegate42(IntPtr intptr_0, out Class30.Struct9 struct9_0, IntPtr intptr_1, uint uint_0, uint EEB86106);

	// Token: 0x02000196 RID: 406
	public enum BC8777AF : uint
	{
		// Token: 0x040001CC RID: 460
		E29A3CA0 = 1048576U,
		// Token: 0x040001CD RID: 461
		const_1 = 2U,
		// Token: 0x040001CE RID: 462
		const_2 = 32U,
		// Token: 0x040001CF RID: 463
		B2AC5B30 = 2U,
		// Token: 0x040001D0 RID: 464
		const_4 = 1U,
		// Token: 0x040001D1 RID: 465
		const_5 = 128U,
		// Token: 0x040001D2 RID: 466
		F00FFD08 = 1U,
		// Token: 0x040001D3 RID: 467
		const_7 = 64U,
		// Token: 0x040001D4 RID: 468
		const_8 = 8U,
		// Token: 0x040001D5 RID: 469
		C6243ABF = 2954240U,
		// Token: 0x040001D6 RID: 470
		B73A263B = 134217728U,
		// Token: 0x040001D7 RID: 471
		B13DCBB8 = 4U,
		// Token: 0x040001D8 RID: 472
		const_12 = 2147483648U,
		// Token: 0x040001D9 RID: 473
		D3262226 = 1U
	}

	// Token: 0x0200019E RID: 414
	// (Invoke) Token: 0x06000EF1 RID: 3825
	private delegate uint Delegate43(IntPtr intptr_0, Class30.F3A4FB2A f3A4FB2A_0, IntPtr EC8577B9, uint uint_0, out uint uint_1);

	// Token: 0x020001A7 RID: 423
	// (Invoke) Token: 0x06000F1D RID: 3869
	private delegate UIntPtr Delegate44(IntPtr intptr_0, UIntPtr uintptr_0, Class30.Enum5 enum5_0);

	// Token: 0x020001AA RID: 426
	public enum Enum5 : uint
	{
		// Token: 0x040001E7 RID: 487
		AA1BEA3C = 2U,
		// Token: 0x040001E8 RID: 488
		B015343C = 1U,
		// Token: 0x040001E9 RID: 489
		const_2,
		// Token: 0x040001EA RID: 490
		F9AC1EB4 = 1U,
		// Token: 0x040001EB RID: 491
		FD062D9D = 0U,
		// Token: 0x040001EC RID: 492
		const_5 = 32U,
		// Token: 0x040001ED RID: 493
		const_6 = 2U,
		// Token: 0x040001EE RID: 494
		const_7 = 0U,
		// Token: 0x040001EF RID: 495
		F78DA98B,
		// Token: 0x040001F0 RID: 496
		B9B0292D = 0U,
		// Token: 0x040001F1 RID: 497
		const_10,
		// Token: 0x040001F2 RID: 498
		const_11 = 4U
	}

	// Token: 0x020001B5 RID: 437
	// (Invoke) Token: 0x06000F40 RID: 3904
	private delegate IntPtr A905243E(string FB14A43C, Class30.Enum5 FA90B620);

	// Token: 0x020001BD RID: 445
	// (Invoke) Token: 0x06000F71 RID: 3953
	private delegate uint Delegate45(IntPtr E6B37206, ref IntPtr intptr_0, IntPtr AFAD8A96, ref UIntPtr uintptr_0, Class30.A63B728E a63B728E_0, Class30.Enum3 enum3_0);

	// Token: 0x020001CB RID: 459
	// (Invoke) Token: 0x06000F9D RID: 3997
	private delegate uint Delegate46(IntPtr D11AF40A, ref IntPtr intptr_0, ref UIntPtr D29FD389, Class30.Enum3 enum3_0, out Class30.Enum3 AB0CE20E);

	// Token: 0x020001CD RID: 461
	public struct Struct11
	{
		// Token: 0x0400023B RID: 571
		public byte B9230F36;

		// Token: 0x0400023C RID: 572
		public byte byte_0;
	}

	// Token: 0x020001D2 RID: 466
	public struct Struct12
	{
		// Token: 0x06000FAD RID: 4013 RVA: 0x00409A94 File Offset: 0x00407C94
		public unsafe long method_0()
		{
			GClass12 gclass = new GClass12();
			object[] array = new object[1];
			int num = 0;
			TypedReference typedReference = __makeref(this);
			array[num] = &typedReference;
			return (long)gclass.method_1344(array, 5123841);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00409AD8 File Offset: 0x00407CD8
		public unsafe void method_1(long long_0)
		{
			GClass12 gclass = new GClass12();
			object[] array = new object[2];
			int num = 0;
			TypedReference typedReference = __makeref(this);
			array[num] = &typedReference;
			array[1] = long_0;
			gclass.method_1344(array, 5124115);
		}

		// Token: 0x0400023E RID: 574
		public uint B7167239;

		// Token: 0x0400023F RID: 575
		public int int_0;
	}

	// Token: 0x020001E9 RID: 489
	// (Invoke) Token: 0x0600102F RID: 4143
	private delegate uint Delegate47(IntPtr intptr_0, IntPtr intptr_1, IntPtr A9283F2E, IntPtr intptr_2, out Class30.Struct9 struct9_0, uint uint_0, IntPtr D5081A8D, uint B115B13F, IntPtr A536CBA4, uint uint_1);

	// Token: 0x02000203 RID: 515
	// (Invoke) Token: 0x06001067 RID: 4199
	private delegate uint Delegate48(out IntPtr intptr_0, Class30.BC8777AF bc8777AF_0, ref Class30.AD340B82 ad340B82_0, ref Class30.Struct12 struct12_0, Class30.Enum3 F817C829, uint uint_0, IntPtr A2A8F831);

	// Token: 0x02000207 RID: 519
	public struct Struct13
	{
		// Token: 0x0400026B RID: 619
		public uint uint_0;

		// Token: 0x0400026C RID: 620
		public uint uint_1;
	}

	// Token: 0x02000217 RID: 535
	public struct AD340B82
	{
		// Token: 0x060010D0 RID: 4304 RVA: 0x0040DC68 File Offset: 0x0040BE68
		public unsafe void method_0()
		{
			GClass12 gclass = new GClass12();
			object[] array = new object[1];
			int num = 0;
			TypedReference typedReference = __makeref(this);
			array[num] = &typedReference;
			gclass.method_1344(array, 5124219);
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0040DCA8 File Offset: 0x0040BEA8
		public unsafe AD340B82(Class30.AA3FC8A5 E2099820, uint DA1BB71E)
		{
			GClass12 gclass = new GClass12();
			object[] array = new object[3];
			int num = 0;
			TypedReference typedReference = __makeref(this);
			array[num] = &typedReference;
			array[1] = E2099820;
			array[2] = DA1BB71E;
			gclass.method_1344(array, 5124636);
		}

		// Token: 0x04000277 RID: 631
		public readonly uint uint_0;

		// Token: 0x04000278 RID: 632
		public readonly IntPtr B5BCD5BE;

		// Token: 0x04000279 RID: 633
		public readonly IntPtr intptr_0;

		// Token: 0x0400027A RID: 634
		public readonly uint uint_1;

		// Token: 0x0400027B RID: 635
		public readonly IntPtr intptr_1;

		// Token: 0x0400027C RID: 636
		public readonly IntPtr ECB6F129;
	}

	// Token: 0x02000219 RID: 537
	public struct AA3FC8A5
	{
		// Token: 0x060010D3 RID: 4307 RVA: 0x0040DCF8 File Offset: 0x0040BEF8
		public unsafe void method_0()
		{
			GClass12 gclass = new GClass12();
			object[] array = new object[1];
			int num = 0;
			TypedReference typedReference = __makeref(this);
			array[num] = &typedReference;
			gclass.method_1344(array, 5124900);
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0040DD38 File Offset: 0x0040BF38
		public unsafe AA3FC8A5(string string_0)
		{
			GClass12 gclass = new GClass12();
			object[] array = new object[2];
			int num = 0;
			TypedReference typedReference = __makeref(this);
			array[num] = &typedReference;
			array[1] = string_0;
			gclass.method_1344(array, 5125364);
		}

		// Token: 0x0400027D RID: 637
		public readonly ushort FC8F1693;

		// Token: 0x0400027E RID: 638
		public readonly ushort ushort_0;

		// Token: 0x0400027F RID: 639
		public readonly IntPtr CC1C5F08;
	}

	// Token: 0x02000223 RID: 547
	public struct B60CC71A
	{
		// Token: 0x04000287 RID: 647
		public IntPtr intptr_0;

		// Token: 0x04000288 RID: 648
		public IntPtr intptr_1;

		// Token: 0x04000289 RID: 649
		public IntPtr intptr_2;

		// Token: 0x0400028A RID: 650
		public IntPtr intptr_3;

		// Token: 0x0400028B RID: 651
		public IntPtr C4B2A323;

		// Token: 0x0400028C RID: 652
		public IntPtr DF05B482;
	}

	// Token: 0x0200022F RID: 559
	// (Invoke) Token: 0x0600114E RID: 4430
	private delegate IntPtr Delegate49(string C30FECB6, string string_0);

	// Token: 0x02000230 RID: 560
	public struct Struct14
	{
		// Token: 0x0400029D RID: 669
		public uint uint_0;

		// Token: 0x0400029E RID: 670
		public uint uint_1;

		// Token: 0x0400029F RID: 671
		public byte byte_0;

		// Token: 0x040002A0 RID: 672
		public byte BE00D335;

		// Token: 0x040002A1 RID: 673
		public byte byte_1;

		// Token: 0x040002A2 RID: 674
		public byte byte_2;

		// Token: 0x040002A3 RID: 675
		public uint uint_2;

		// Token: 0x040002A4 RID: 676
		public uint uint_3;

		// Token: 0x040002A5 RID: 677
		public uint uint_4;

		// Token: 0x040002A6 RID: 678
		public uint uint_5;
	}
}
