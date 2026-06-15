using System;
using System.Runtime.InteropServices;

public class BAA7FFAC
{
	static BAA7FFAC()
	{
	//Invalid MethodBodyBlock: Invalid relative virtual address (RVA): 0x00444D8C
	}

	[DllImport("libruntime.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "SetCallback")]
	public static extern bool 6D30DA34(int 4CBDB028, IntPtr D6B4A237);

	[DllImport("libruntime.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "Action")]
	public static extern bool 899E0416(int 65AF73B7, int 1B9BCC00, int EC2BFB15);
}
