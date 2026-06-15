using System;

// Token: 0x020000F9 RID: 249
public static class GClass9
{
	// Token: 0x06000279 RID: 633 RVA: 0x00002EF8 File Offset: 0x000010F8
	public unsafe static uint DCA21C8D(IntPtr intptr_0, uint uint_1)
	{
		uint num = 9U;
		uint num2 = 9U ^ (num | (num - num));
		if ((((908896061U ^ num) - 1965122583U) ^ (3812286652U ^ num)) % 1112905685U == 0U)
		{
			goto IL_0128;
		}
		num = -(num * (num % 1655972520U * (num - num))) - 687700181U;
		byte* ptr;
		int num3;
		for (;;)
		{
			IL_0042:
			switch (num % 5U)
			{
			default:
				goto IL_005E;
			case 1U:
				num = 406104600U * num - 3290868968U;
				num2 = GClass9.uint_0[(int)((byte)((uint)ptr[num3] ^ num2))] ^ (num2 >> (int)(((118264948U / num > (uint)((byte)num)) ? 1 : 0) % -(sbyte)num - -7));
				if (((1855833619U - (num - num) / (uint)((byte)num)) & 4294967294U) == 0U)
				{
					goto IL_0087;
				}
				num = (4155680915U / (((num + 906428568U) | num) + num)) ^ 3267267861U;
				break;
			case 2U:
				goto IL_010E;
			case 3U:
				num = ((num + 1110474424U) * 3423198862U << (int)(1425653748U - num)) / (3380828837U % (2752969519U * num)) - 8U;
				if ((long)num3 >= (long)((ulong)uint_1))
				{
					if (((3416001797U & (3005902988U ^ num)) - 2921607306U) % (210910911U / ~num) == (2651116295U + (num & num) << 8) % (uint)((int)(1150924178U | num) >> (int)(num / ~(int)num)))
					{
						goto IL_0128;
					}
					num = 3510213564U + ((0U & num) >> (int)((1563265042U + (num | num)) % ~(int)num));
				}
				else
				{
					num = 248U;
					num = 2812352668U + num % ~((num & 3367457813U) / num);
				}
				break;
			case 4U:
				goto IL_023C;
			}
		}
		IL_005E:
		num = 3607267106U ^ num;
		ptr = (byte*)intptr_0.ToPointer();
		goto IL_006E;
		IL_010E:
		num = (uint)((((int)num >> (int)(num / num)) - 1644629178 >> (int)num) - 16052);
		goto IL_0128;
		IL_023C:
		num = (uint)(((int)(num % ~(int)num) >> (int)num) - -1);
		return ~num2;
		IL_006E:
		num = 2761984268U & num;
		num3 = (int)(-(int)(num << (int)num >> 30)) >> (int)num;
		IL_0087:
		goto IL_0153;
		IL_0128:
		num3 += (int)(4282962311U + ((896710645U / num) | (168846894U >> (int)(61127948U % -(int)num))));
		num ^= 240U;
		IL_0153:
		num -= num;
		if (44U / ~(num * num / (num | 4239797653U) % ~(num / ~num)) >= ((num % (3121138340U % ~num % 1295090578U)) & (num % (uint)(~(uint)(((int)num >> 27) / 429780880)))))
		{
			num = 3675190913U ^ (3753631423U & (1504321035U * num % 360640225U));
			goto IL_0042;
		}
		goto IL_006E;
	}

	// Token: 0x0600027A RID: 634 RVA: 0x00003150 File Offset: 0x00001350
	static GClass9()
	{
		uint num5;
		for (int i = 0; i < GClass9.uint_0.Length; i += (int)((short)num5 % 24708 - -1))
		{
			uint num = (uint)i;
			int num2 = 0;
			short num3;
			for (;;)
			{
				num3 = 0;
				if (num2 >= (int)(61106 ^ (ushort)(313388730 << (int)num3)))
				{
					break;
				}
				byte b = 129;
				if (((int)b & 137371680) == 0)
				{
					ushort num4;
					for (;;)
					{
						switch (b % 3)
						{
						default:
							if ((num & (4294967230U ^ ~((uint)b >> (int)(b | b)))) == (uint)(1 + ((int)b << 21) % (int)(b + b)))
							{
								num3 = ((true ^ ((int)b % ((int)b % -1338679527) > 1496153882)) ? 1 : 0);
								b = (byte)(((uint)num3 >> (int)num3 - -65129695 + -1331442263) / (uint)b + 157U);
							}
							else
							{
								num4 = (ushort)(b * b);
								b = (byte)(-1476578587 + (((-1957126254 > -((int)num4 << (int)b)) ? 1 : 0) | 1476578607));
							}
							break;
						case 1:
							goto IL_00A1;
						case 2:
							goto IL_0120;
						}
					}
					IL_0120:
					b = (byte)(~(1270589984 & (int)num4) - -130);
					num >>= 1 ^ (1 & (((int)(~(int)num4) ^ -1853045458) & -660457063));
					num3 = 1;
					goto IL_014B;
					IL_00A1:
					b = (byte)(((uint)((byte)(-(byte)num3)) / 3155026349U >> (-1660511485 >> (17935400 & (int)b))) - 4294967167U);
					num = (num >> (int)(((uint)((ushort)((uint)num3 >> (int)b)) >> 26) + 1U)) ^ (3323245914U ^ ((732706362U ^ ((uint)b >> (int)(b * b))) * (uint)((sbyte)num3)));
				}
				IL_014B:
				num2 += (int)(num3 + 1 + -1);
				continue;
				goto IL_014B;
			}
			do
			{
				GClass9.uint_0[i] = num;
				num5 = (uint)((uint)(0 - num3) << ((num3 < num3) ? 1 : 0) % (1480128269 << (int)num3));
			}
			while (1292857508U + num5 < ~num5);
		}
	}

	// Token: 0x04000115 RID: 277
	private static uint[] uint_0 = new uint[256];
}
