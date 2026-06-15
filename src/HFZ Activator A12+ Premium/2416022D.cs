using System;

public static class 2416022D
{
	private static uint[] 0422AC9E;

	public unsafe static uint DCA21C8D(IntPtr 8A25B531, uint 0435633F)
	{
		uint num = 9u;
		uint num2 = 9 ^ (num | (num - num));
		if ((int)(((0x362CA73D ^ num) - 1965122583) ^ (0xE33AE0BCu ^ num)) % 1112905685 != 0)
		{
			num = (uint)(-((int)num * ((int)num % 1655972520 * (int)(num - num))) - 687700181);
			goto IL_0042;
		}
		goto IL_0128;
		IL_0153:
		num -= num;
		if (44u / (uint)(~((int)(num * num) / (int)(num | 0xFCB62D95u) % (int)(~(num / ~num)))) >= ((num % (uint)((int)(3121138340u % ~num) % 1295090578)) & (num % ~((uint)((int)num >> 27) / 429780880u))))
		{
			num = (uint)(-619776383 ^ (-541335873 & ((int)(1504321035 * num) % 360640225)));
			goto IL_0042;
		}
		goto IL_006e;
		IL_0042:
		int num3 = default(int);
		byte* ptr = default(byte*);
		while (true)
		{
			switch (num % 5)
			{
			case 1u:
				goto IL_00ab;
			case 2u:
				goto IL_010e;
			case 3u:
				goto IL_01af;
			case 4u:
				num = (uint)(((int)num % (int)(~num) >> (int)num) - -1);
				return ~num2;
			}
			break;
			IL_01af:
			num = (uint)((int)(num + 1110474424) * -871768434 << (int)(1425653748 - num)) / (3380828837u % (uint)(-1541997777 * (int)num)) - 8;
			if (num3 < 0435633F)
			{
				num = 248u;
				num = 2812352668u + num % ~((num & 0xC8B75415u) / num);
				continue;
			}
			if (((int)(0xCB9C0D05u & (0xB32A708Cu ^ num)) - -1373359990) % (210910911 / (int)(~num)) != (-1643851001 + (int)(num & num) << 8) % ((int)(0x4499B592 | num) >> (int)num / (int)(~num)))
			{
				num = 3510213564u + ((0 & num) >> (int)((1563265042 + (num | num)) % ~num));
				continue;
			}
			goto IL_0128;
			IL_010e:
			num = (uint)((((int)num >> (int)(num / num)) - 1644629178 >> (int)num) - 16052);
			goto IL_0128;
			IL_00ab:
			num = 406104600 * num - 3290868968u;
			num2 = 0422AC9E[(byte)(ptr[num3] ^ num2)] ^ (num2 >> (((int)(118264948 / num) > (int)(byte)num) ? 1 : 0) % -(sbyte)num - -7);
			if (((1855833619 - (num - num) / (byte)num) & 0xFFFFFFFEu) == 0)
			{
				goto IL_0153;
			}
			num = (4155680915u / (((num + 906428568) | num) + num)) ^ 0xC2BE8D15u;
		}
		num = 0xD7028722u ^ num;
		ptr = (byte*)8A25B531.ToPointer();
		goto IL_006e;
		IL_0128:
		num3 += -12004985 + (int)((896710645 / num) | (uint)(168846894 >>> 61127948 % (int)(0 - num)));
		num ^= 0xF0;
		goto IL_0153;
		IL_006e:
		num = 0xA4A0890Cu & num;
		num3 = (int)(0 - (num << (int)num >> 30)) >> (int)num;
		goto IL_0153;
	}

	static 2416022D()
	{
		0422AC9E = new uint[256];
		ushort num4 = default(ushort);
		uint num5;
		for (int i = 0; i < 0422AC9E.Length; i += (int)((uint)(short)num5 % 24708u) - -1)
		{
			uint num = (uint)i;
			int num2 = 0;
			short num3;
			while (true)
			{
				num3 = 0;
				if (num2 >= (0xEEB2 ^ (ushort)(313388730 << (int)num3)))
				{
					break;
				}
				byte b = 129;
				if ((b & 0x8302020) == 0)
				{
					while (true)
					{
						switch ((uint)b % 3u)
						{
						default:
							if ((num & (uint)(-66 ^ ~(b >>> (b | b)))) == 1 + (uint)(b << 21) % (uint)(b + b))
							{
								num3 = (short)(1 ^ (((int)b % (int)((uint)b % 2956287769u) > 1496153882) ? 1 : 0));
								b = (byte)((num3 >>> num3 - -65129695 + -1331442263) / b + 157);
							}
							else
							{
								num4 = (ushort)(b * b);
								b = (byte)(2818388709u + (((2337841042u > (uint)(-(num4 << (int)b))) ? 1u : 0u) | 0x5802CD2Fu));
							}
							continue;
						case 1u:
							b = (byte)(((uint)(byte)(-num3) / 3155026349u >> (-1660511485 >> (0x111AC28 & b))) - 4294967167u);
							num = (num >> ((ushort)(num3 >>> (int)b) >>> 26) + 1) ^ (uint)(-971721382 ^ ((0x2BAC363A ^ (b >>> b * b)) * (sbyte)num3));
							break;
						case 2u:
							b = (byte)(~(0x4BBBAA20 & num4) - -130);
							num >>= 1 ^ (1 & ((~num4 ^ -1853045458) & -660457063));
							num3 = 1;
							break;
						}
						break;
					}
				}
				num2 += num3 + 1 + -1;
			}
			do
			{
				0422AC9E[i] = num;
				num5 = (uint)(-num3 << ((num3 < num3) ? 1 : 0) % (1480128269 << (int)num3));
			}
			while ((int)(1292857508 + num5) < (int)(~num5));
		}
	}
}
