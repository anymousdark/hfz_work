using System;
using System.Runtime.InteropServices;

// Token: 0x020001A9 RID: 425
internal static class B7316602
{
	// Token: 0x06000F2C RID: 3884 RVA: 0x004059B4 File Offset: 0x00403BB4
	unsafe static B7316602()
	{
		long num;
		bool flag;
		sbyte b;
		bool flag2;
		uint num2;
		int num3;
		for (;;)
		{
			num = B7316602.smethod_1();
			flag = true;
			b = -1;
			b = (sbyte)(193858769 + (193858744 ^ (int)b));
			for (;;)
			{
				Type type;
				switch (b % 6)
				{
				default:
					b = (sbyte)((int)((byte)b) ^ -25);
					if (Environment.OSVersion.Platform != (PlatformID)111101470 + ((int)b + -111101467))
					{
						goto IL_03C7;
					}
					b = (sbyte)(((22435 >> (int)b) | 2023505920) / 1);
					if ((int)(((b < b) ? 1 : 0) - -b - b / ~(int)b) / 1379368471 <= (int)((byte)((int)b - ((int)b & -1163287774))))
					{
						b = (sbyte)(-339235577 + -339235626 / ~((158 / (int)(~(int)b)) ^ (b >> 4)));
						continue;
					}
					break;
				case 1:
					b = (sbyte)(((~((379755952 > (-1565018474 & (int)b)) ? 1 : 0)) ? 1 : 0) - -2);
					flag2 = IntPtr.Size == (((int)b ^ ~(b >> (int)b)) | (int)b) - -5;
					num2 = ((uint)(~(uint)b % ~(uint)b) - 1117871803U) % ~((uint)b / ~((uint)((byte)b) / 1201665300U));
					b = (sbyte)((((uint)b - ((uint)b >> (int)b) < (uint)((short)(~(short)b))) ? 1 : 0) - -20);
					continue;
				case 2:
					b = (sbyte)(((num2 & 2057288704U) - ((num2 == 3970494781U) ? 1U : 0U) + (uint)b) / (((3263331361U >> (int)num2) | (3098120637U + num2)) % -num2) + uint.MaxValue);
					break;
				case 3:
					b = ((num2 + (uint)b % (797556520U / num2) > (uint)(((int)b << (int)(num2 >> (int)b)) % (731465986 % (int)b - -459892314))) ? 1 : 0);
					type = typeof(B7316602.Struct21);
					goto IL_0237;
				case 4:
					b = (sbyte)(158563824U + (num2 + 2813130139U) % 747886733U * (29U ^ num2));
					type = typeof(B7316602.Struct20);
					num2 ^= 3177095460U;
					goto IL_0237;
				case 5:
					goto IL_0282;
				}
				if (!flag2)
				{
					num2 = (uint)((byte)((uint)b + num2) ^ 36);
					b = (sbyte)(33 + (b >> (int)(((uint)(b % ~(uint)b) | (num2 + (uint)b)) * num2)));
					continue;
				}
				if (num2 != 0U)
				{
					b = (sbyte)(16 ^ (125650761 * (int)b << (int)((((-678847966 == (int)b) >> 14) ? 1U : 0U) % num2)));
					continue;
				}
				break;
				IL_0237:
				num3 = Marshal.SizeOf(type);
				num2 = (uint)(-86 >> (int)((uint)(-(uint)b) / ~num2 % (uint)(~(uint)b)));
				if ((uint)b % num2 / 2888600970U != 0U)
				{
					break;
				}
				b = (sbyte)(4248282881U + num2 / (uint)((byte)(3850741924U / (uint)(~(uint)b) >> (int)b)));
			}
		}
		IL_0282:
		b = (sbyte)(((4294967174U < ~((uint)b % ~(num2 ^ num2))) ? 1 : 0) + -1);
		IntPtr intPtr = Marshal.AllocHGlobal(num3);
		short num4;
		try
		{
			num4 = (short)num2;
			uint num5;
			if (B7316602.NtQueryVirtualMemory(new IntPtr((int)num4 * -1127061311 - -1856975061), new IntPtr(num), (uint)((~num4 >> (int)b) - 85), intPtr, (uint)num3, out num5) == 0U)
			{
				b = (sbyte)(num2 * 1308893313U);
				if (2528513695U + (uint)b < ((num2 / num2 / (uint)b) ^ 2108620303U) % ((~((((int)(~(int)num4) == (-1230662772 & (int)num4)) >> (int)((num2 / ~(num2 % (uint)num4)) & 31U)) ? 1U : 0U)) ? 1U : 0U))
				{
					if (flag2)
					{
						bool flag3 = (((B7316602.Struct20)Marshal.PtrToStructure(intPtr, typeof(B7316602.Struct20))).uint_5 & (16777216U + (((num2 - (uint)b) / 517339029U) & (uint)num4))) != 0U;
						b += 86;
						if (flag3)
						{
							flag = num2 % 1554338345U + 3108676776U != 0U;
							goto IL_03C7;
						}
						goto IL_03B4;
					}
					else
					{
						bool flag4 = (((B7316602.Struct21)Marshal.PtrToStructure(intPtr, typeof(B7316602.Struct21))).uint_1 & (-((num2 - 1636690595U) / 3561669703U) - 4278190080U)) != 0U;
						b ^= -86;
						if (!flag4)
						{
							goto IL_03B4;
						}
					}
				}
				flag = b << 18 != 0;
			}
			IL_03B4:;
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		IL_03C7:
		num2 = 16831488U;
		if (((num2 % num2 >> (int)num2) | 1613095982U) == 0U)
		{
			goto IL_06BE;
		}
		num2 = (uint)((byte)(num2 | num2)) + 2911626260U;
		uint num6;
		uint num7;
		BE32229B.Struct2* ptr2;
		uint num8;
		int num9;
		for (;;)
		{
			IL_03F3:
			switch (num2 % 10U)
			{
			default:
				num2 = 142717968U ^ (164717339U & num2);
				if (!flag)
				{
					goto IL_084E;
				}
				if (((((num2 > num2) ? 1 : 0) > (-332301914 << (int)num2) + -1162273888) ? 1U : 0U) != ((uint)((ushort)(num2 + num2)) & (353571259U + num2)))
				{
					num2 = ((num2 >> (int)(num2 + num2)) + num2 >> 0) - 550081621U;
					continue;
				}
				goto IL_0848;
			case 1U:
			{
				num2 = (num2 | 147U) + 533250117U;
				BE32229B.Struct4* ptr = num;
				if ((uint)ptr->EC21A7AD != 1109494456U + (3138244645U % num2 / (uint)(1352562621 >> (int)num2) + (num2 ^ num2)) * 2493487751U)
				{
					goto IL_0795;
				}
				if ((short)(-585362523 / ((~((833890998U == num2) ? 1 : 0)) ? 1 : 0)) == 0)
				{
					num2 = 2689181438U ^ (num2 * (num2 * 3786226231U) >> (int)(-(int)(4028631183U * num2)));
					continue;
				}
				goto IL_06BE;
			}
			case 2U:
			{
				num2 = 16831488U + ((((num2 % num2 > 464715048U) ? 1 : 0) == -1800488260) ? 1U : 0U);
				BE32229B.Struct4* ptr;
				num6 = ptr->uint_0;
				num7 = (uint)((int)num2 >> (((int)(3240183475U & num2) >> 10 > (int)num2) ? 1 : 0));
				if ((3769481117U ^ (-num7 % 4037623228U % (num7 << (int)num2))) != ~((336144413U ^ (1773351581U & num2)) >> (int)num7))
				{
					num2 = 3733799052U + (1731042067U ^ ((num7 << 22) % num7));
					continue;
				}
				break;
			}
			case 3U:
				num2 = ((66576U < num2 / 1586829188U + (1862742305U >> (int)(num7 ^ 2669198254U))) ? 1U : 0U) + 16831487U;
				ptr2 = num / (long)sizeof(BE32229B.Struct2) + num6;
				goto IL_05C3;
			case 4U:
				num2 = (uint)((short)num2) / (1596967871U << (int)num2) + 16831488U;
				break;
			case 5U:
				goto IL_069C;
			case 6U:
				num2 = (uint)((5361124 << (int)(num8 % num8) >> ((int)(num7 | num8) >> (int)(num7 / 539674033U))) % -1525810773 - -14150926);
				if (num9 >= B7316602.EB8EDE1E.Length)
				{
					goto IL_0795;
				}
				goto IL_06D6;
			case 7U:
				num2 = 453732667U + num2 * 1150578437U;
				if (B7316602.EB8EDE1E != null)
				{
					goto IL_084E;
				}
				if (((1535790725 << (int)num8 > -559525748) ? 1U : 0U) / num2 / 2729521003U < 1U << ((int)num2 >> (int)((num8 * 891246984U) | 3391872385U)))
				{
					continue;
				}
				goto IL_06C7;
			case 8U:
				goto IL_0848;
			case 9U:
				goto IL_0892;
			}
			B7316602.EB8EDE1E = new BE32229B.Struct0[(int)ptr2->dda48D88_0.E6982BBB];
			num8 = num7 % (num2 ^ 1819091922U) / num7;
			if (836170200 >> ((2121780820U * num8 < num7) ? 1 : 0) != 0)
			{
				num2 = 2945096326U + ((((uint)(-1140515815 >> (int)num8) >> 26 == num7) ? 1U : 0U) | 2200629655U);
				continue;
			}
			goto IL_05C3;
			IL_0795:
			num8 = (num2 | (uint)(-13503576 + ((int)num2 >> 2))) << (int)(2796556723U % (1126668567U * num2 * 3465660427U));
			num2 = 2576636097U ^ (num2 / (uint)((int)((3449219743U | num2) % (1352063272U - num8)) >> (int)(3441483022U * (2710654884U / num8))));
			continue;
			IL_05C3:
			if (ptr2->uint_0 == (16814416U ^ (0U ^ num7)))
			{
				goto IL_05DA;
			}
			goto IL_0795;
		}
		IL_069C:
		num2 = ((3926324129U | (1637474603U >> (int)num8)) + 1334324905U) % num2 + 3915333055U;
		goto IL_06BE;
		IL_0848:
		throw new BadImageFormatException();
		IL_0892:
		num2 = 16831488U + (uint)((short)(num2 / 1717160258U));
		return;
		IL_05DA:
		num6 += (uint)(Marshal.SizeOf(typeof(BE32229B.Struct2)) + (int)ptr2->dda48D88_0.ushort_1);
		num2 = num2;
		num2 = 2636386684U ^ ((-((((741957283U == num7) ? 1U : 0U) / 1755513383U > num7) ? 1U : 0U)) ? 1U : 0U);
		goto IL_03F3;
		IL_06BE:
		BE32229B.Struct0* ptr3 = num / (long)sizeof(BE32229B.Struct0) + num6;
		IL_06C7:
		num9 = (int)(num7 * num2 % num8);
		goto IL_0720;
		IL_06D6:
		B7316602.EB8EDE1E[num9] = ptr3[num9];
		num4 = 1;
		if ((int)num4 + -1784719263 == 0)
		{
			goto IL_05DA;
		}
		num9 += (int)((uint)((ushort)num4) + ~(-((uint)num4 >> 14)) - uint.MaxValue);
		num8 = 1U;
		num7 = 16831488U;
		num2 = 16831488U;
		IL_0720:
		if (((-777164275 == (int)(-(int)((byte)num7))) ? 1U : 0U) <= -(num7 + (uint)(-(uint)((short)num2))))
		{
			num2 = ((num2 | ((num2 % num7) ^ num7)) ^ (num7 | num8)) - 601984251U;
			goto IL_03F3;
		}
		IL_084E:
		if (((num2 / 110014352U == 858540337U) ? 1U : 0U) * ((num2 - (num2 | 2260192298U)) ^ 370923652U) != (num2 & 647885886U))
		{
			num2 = (num2 & 2350112292U) ^ 194087103U;
			goto IL_03F3;
		}
		goto IL_06D6;
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x00406280 File Offset: 0x00404480
	public static IntPtr smethod_0(uint A5186610)
	{
		short num = -9208;
		num = -15979 ^ (0 ^ num);
		byte b;
		uint num2;
		uint num5;
		for (;;)
		{
			uint num3;
			switch (num % 7)
			{
			default:
				num = (short)((int)(num - num - (((1032795578 == (int)num) ? 1 : 0) | num)) / ~(((int)num + -359192850) & ((int)num % 1975149583 % (int)num)) - 16789);
				goto IL_006A;
			case 1:
				num = (short)(((int)((short)b % num) ^ ((((short)b == num) ? 1 : 0) + 1235616416 % (int)num + 38428)) + -44115);
				num2 = A5186610;
				if (~num << ((((int)num ^ (b >> 15)) == 663340202) ? 1 : 0) != 0)
				{
					num = (short)(((-1036908375 | ((int)(num / ~(int)num) + 2034080180)) & (int)((sbyte)(num3 - num3))) ^ 19994);
					continue;
				}
				goto IL_03BF;
			case 2:
				num = (short)((-114 >> (-1164726081 / (int)num << 27)) - -114);
				goto IL_01AE;
			case 3:
			{
				num = -9868 + num;
				int num4;
				if (num4 >= B7316602.EB8EDE1E.Length)
				{
					b = 167;
					num3 = 167U;
					goto IL_02D6;
				}
				b = 167;
				if ((538284675 | (int)b) < (int)b)
				{
					goto IL_006A;
				}
				BE32229B.Struct0 @struct = B7316602.EB8EDE1E[num4];
				if (A5186610 < @struct.uint_1)
				{
					num3 = (uint)b;
					if (num4 == 0)
					{
						num = ((1857867155 < (int)(num3 % (2223083297U % num3)) >> 14) ? 1 : 0);
						num = (short)((num3 << (int)b / ~((int)b / (-1497630710 << (int)num3))) - 4294943627U);
						continue;
					}
					goto IL_02D6;
				}
				else
				{
					if ((int)(0 & b) / (-1876717470 / (int)b) != 0)
					{
						goto IL_01AE;
					}
					sbyte b2;
					if (A5186610 >= @struct.uint_1)
					{
						num5 = (uint)b;
						if (A5186610 < @struct.uint_1 + @struct.uint_0)
						{
							b2 = (sbyte)(-1255906241 & (int)((ushort)b));
							goto IL_01F7;
						}
					}
					if (b != 0)
					{
						num4 += (((int)b << (int)b) ^ (b % b >> ((int)b << 6) * (int)(b + b))) - 21375;
						num5 = 4294958586U;
						break;
					}
					IL_01F7:
					num2 = @struct.CA177F1C + A5186610 - @struct.uint_1;
					num3 = 167U;
					if ((-50598145 & (int)b) <= -(((b2 >> 16) - 1027238416) % (int)(2910885599U ^ (3643074490U * num5))))
					{
						goto IL_02D6;
					}
					goto IL_006A;
				}
				break;
			}
			case 4:
				num = (short)(23010U + 0U % ((num3 ^ 1871035542U) * ((uint)b | 1546981025U)));
				if (num2 != 0U)
				{
					goto IL_03BF;
				}
				num5 = 2972280850U * num3 / ((num3 >> 15) - 3778857749U);
				if ((uint)((short)(1631244084 >> (((int)(b % b) == -1127872919) ? 1 : 0))) < (num5 | 4038560296U))
				{
					num = (short)(((uint)b % 16038U % num3 >> (int)(num3 / 1795433358U)) + 32142U);
					continue;
				}
				break;
			case 5:
				goto IL_038E;
			case 6:
				goto IL_041D;
			}
			IL_0277:
			num = (short)num5;
			if ((uint)num / num5 != 0U)
			{
				num = (short)(1771233163 + 1771232005 / ((~(((uint)(num + num) / (num5 / num5) == 3358948885U * (uint)num) ? 1 : 0)) ? 1 : 0));
				continue;
			}
			IL_006A:
			if (B7316602.EB8EDE1E != null)
			{
				num2 = (4022328282U >> (int)num) - 15712219U;
				num5 = (uint)((int)num - (((int)num | -829279732) + (num >> 2) / 1587924151));
				int num4 = (int)((3001666356U >> (int)(1907090305U / num5)) ^ 715U);
				goto IL_0277;
			}
			num2 = A5186610;
			num += 32218;
			b = 167;
			num3 = 167U;
			goto IL_03BF;
			IL_02D6:
			num = (short)(3527891426U ^ (0U >> (int)(b | b) << (int)(755876403U / num3)));
			num = (short)((int)((-763146434 > (int)(b ^ (b & b))) ? 1 : 0) - -26688);
			continue;
			IL_01AE:
			goto IL_02D6;
			IL_03BF:
			num3 = num3 / (uint)b % 4294935322U;
			if (2189946772U * (uint)(num | num) >> 13 == 332802670U - num3)
			{
				goto IL_02D6;
			}
			num = (short)(11059 + (-((int)b / 2073792803) + ((num3 < 773815858U) ? 1 : 0)) % (1461369914 / ((1370981523 | (int)num) ^ ((int)b & 463446564))));
		}
		IL_038E:
		num = (short)(23010U ^ (4070572675U / num5));
		throw new BadImageFormatException();
		IL_041D:
		num = (short)((int)b * 587678778 - -641914892);
		return new IntPtr(B7316602.smethod_1() + (long)((ulong)num2));
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x004066C8 File Offset: 0x004048C8
	public unsafe static long smethod_1()
	{
		fixed (byte* ptr = &B7316602.byte_0)
		{
			return ptr;
		}
	}

	// Token: 0x06000F2F RID: 3887
	[DllImport("ntdll.dll")]
	private static extern uint NtQueryVirtualMemory(IntPtr A6312584, IntPtr intptr_0, uint uint_0, IntPtr intptr_1, uint uint_1, out uint uint_2);

	// Token: 0x040001E5 RID: 485
	private static readonly BE32229B.Struct0[] EB8EDE1E;

	// Token: 0x040001E6 RID: 486 RVA: 0x00002088 File Offset: 0x00000288
	// Note: this field is marked with 'hasfieldrva' and has an initial value of '77'.
	public static readonly byte byte_0;

	// Token: 0x02000201 RID: 513
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct20
	{
		// Token: 0x04000261 RID: 609
		public uint uint_0;

		// Token: 0x04000262 RID: 610
		public uint FCA4859C;

		// Token: 0x04000263 RID: 611
		public uint uint_1;

		// Token: 0x04000264 RID: 612
		public uint uint_2;

		// Token: 0x04000265 RID: 613
		public uint uint_3;

		// Token: 0x04000266 RID: 614
		public uint uint_4;

		// Token: 0x04000267 RID: 615
		public uint uint_5;
	}

	// Token: 0x02000228 RID: 552
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct21
	{
		// Token: 0x0400028F RID: 655
		public ulong ulong_0;

		// Token: 0x04000290 RID: 656
		public ulong ACAD3719;

		// Token: 0x04000291 RID: 657
		public uint B92261A3;

		// Token: 0x04000292 RID: 658
		public uint ED9C2930;

		// Token: 0x04000293 RID: 659
		public ulong FCBDFA83;

		// Token: 0x04000294 RID: 660
		public uint AC9CD41A;

		// Token: 0x04000295 RID: 661
		public uint uint_0;

		// Token: 0x04000296 RID: 662
		public uint uint_1;

		// Token: 0x04000297 RID: 663
		public uint uint_2;
	}

	// Token: 0x0200023B RID: 571
	public static class F11CA1A4
	{
		// Token: 0x0600118D RID: 4493 RVA: 0x000025DD File Offset: 0x000007DD
		public static string C3013D95()
		{
			return (string)new GClass12().method_1344(null, 7625771);
		}

		// Token: 0x040002AA RID: 682
		public static object[] E0149CB1;

		// Token: 0x0200023F RID: 575
		// (Invoke) Token: 0x060011A7 RID: 4519
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void Delegate124();
	}
}
