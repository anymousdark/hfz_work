using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

public class GForm0 : Form
{
	private delegate void Delegate0(int int_0, int int_1, int B00EB12A, [MarshalAs(UnmanagedType.LPStr)] string E41072B1, [MarshalAs(UnmanagedType.LPStr)] string A5357CB2);

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct B91CC19B : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder B8A84B89;

		public GForm0 gform0_0;

		extern void IAsyncStateMachine.MoveNext();

		[DebuggerHidden]
		extern void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine B6A63100);
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct AF18E8BE : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		extern void IAsyncStateMachine.MoveNext();

		[DebuggerHidden]
		extern void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine DF08FCA7);
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct D0B794B2 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public GForm0 gform0_0;

		extern void IAsyncStateMachine.MoveNext();

		[DebuggerHidden]
		extern void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated]
	private sealed class Class1
	{
		public GForm0 gform0_0;

		public string CB2DC1B4;

		public extern Class1();

		internal extern void method_0();

		internal extern void method_1();

		internal extern void E3B89E12();

		internal extern void method_2();

		internal extern void method_3();

		internal extern void method_4();

		internal extern void DA8AB618();

		internal extern void method_5();

		internal extern void method_6();

		internal extern void C1BA768E();

		internal extern void method_7();

		internal extern void DA1D7F98();
	}

	[CompilerGenerated]
	private sealed class Class2
	{
		public DialogResult DD050E00;

		public GForm0 E8117E95;

		public extern Class2();

		internal extern void F898A2B9();
	}

	[CompilerGenerated]
	private sealed class Class3
	{
		public GForm0 gform0_0;

		public string string_0;

		public extern Class3();

		internal extern void method_0();

		internal extern void ECB6812D();

		internal extern void method_1();

		internal extern void method_2();

		internal extern void method_3();

		internal extern void method_4();
	}

	[CompilerGenerated]
	private sealed class F0B8C1AB
	{
		public GForm0 gform0_0;

		public string EDBD4FAC;

		public extern F0B8C1AB();

		internal extern void method_0();

		internal extern void method_1();

		internal extern void ED9E9FA4();

		internal extern void method_2();

		internal extern void method_3();

		internal extern void method_4();

		internal extern void method_5();

		internal extern void C19DABBB();

		internal extern void method_6();

		internal extern void method_7();

		internal extern void FA9A75B6();

		internal extern void method_8();

		internal extern void method_9();

		internal extern void FCBA4E94();

		internal extern void E6305F82();

		internal extern void method_10();

		internal extern void A926D7BE();

		internal extern void C6913503();

		internal extern void method_11();

		internal extern void method_12();

		internal extern void method_13();

		internal extern void method_14();
	}

	[CompilerGenerated]
	private sealed class Class4
	{
		public DialogResult A4931E32;

		public GForm0 gform0_0;

		public extern Class4();

		internal extern void method_0();
	}

	[CompilerGenerated]
	private sealed class Class5
	{
		public Image image_0;

		public GForm0 B9B16A21;

		public extern Class5();

		internal extern void method_0();
	}

	[CompilerGenerated]
	private sealed class Class6
	{
		public string string_0;

		public extern Class6();

		internal extern void DC155522();
	}

	private static Delegate0 delegate0_0;

	private static Delegate0 delegate0_1;

	private const int B31777B6 = 274;

	private const int CCAE34B4 = 61456;

	private const int int_0 = 2;

	private static string string_0;

	private static string string_1;

	private static string string_2;

	private static string string_3;

	private static string string_4;

	private static string C889469D;

	private static string string_5;

	private static string string_6;

	private static string string_7;

	private static string string_8;

	private static string string_9;

	private static string F60FB31B;

	private static string string_10;

	private static bool bool_0;

	private static string string_11;

	private static string string_12;

	private IContainer icontainer_0;

	private Guna2ControlBox guna2ControlBox_0;

	private Guna2ControlBox guna2ControlBox_1;

	private Guna2Panel guna2Panel_0;

	private Guna2HtmlLabel guna2HtmlLabel_0;

	private Guna2Button guna2Button_0;

	private Guna2HtmlLabel guna2HtmlLabel_1;

	private Guna2HtmlLabel guna2HtmlLabel_2;

	private Guna2HtmlLabel guna2HtmlLabel_3;

	private Guna2HtmlLabel D6035003;

	private Guna2HtmlLabel guna2HtmlLabel_4;

	private Guna2HtmlLabel D13AD821;

	private Guna2HtmlLabel EB377D19;

	private Guna2HtmlLabel guna2HtmlLabel_5;

	private Guna2HtmlLabel guna2HtmlLabel_6;

	private Guna2HtmlLabel guna2HtmlLabel_7;

	private Guna2HtmlLabel guna2HtmlLabel_8;

	private Guna2HtmlLabel guna2HtmlLabel_9;

	private Guna2HtmlLabel DA9650B5;

	private Guna2HtmlLabel guna2HtmlLabel_10;

	private Guna2HtmlLabel guna2HtmlLabel_11;

	private Guna2Button DF17080C;

	private Guna2CheckBox guna2CheckBox_0;

	private Guna2PictureBox guna2PictureBox_0;

	private Guna2PictureBox guna2PictureBox_1;

	private Guna2HtmlLabel BF9CEEAE;

	private extern string String_0 { get; set; }

	private extern string String_1 { get; set; }

	private extern string String_2 { get; set; }

	private static extern string CE220497 { get; set; }

	private extern string F5038D19 { get; set; }

	private extern string String_3 { get; set; }

	private static extern string F481601C { get; set; }

	private extern string String_4 { get; set; }

	private static extern string EC863280 { get; set; }

	private extern string String_5 { get; set; }

	private extern string E5293B05 { get; set; }

	private extern string String_6 { get; set; }

	private static extern bool Boolean_0 { get; set; }

	private extern string String_7 { get; set; }

	private extern string String_8 { get; set; }

	private extern string String_9 { get; set; }

	public extern GForm0();

	private extern bool BF3B409F();

	private extern bool method_0();

	private extern bool BEA6DA34(B60F9C3D b60F9C3D_0, ref Delegate0 F6A52918, Delegate0 delegate0_2);

	private static extern void smethod_0(EC83E8B7 ec83E8B7_0);

	private static extern void ED802100(GEnum2 genum2_0);

	private static extern void smethod_1(B60F9C3D b60F9C3D_0);

	private extern void method_1(int int_1, int int_2, int EEA67235, string AFB4B33A, string string_13);

	private extern void method_2(string string_13);

	private extern void method_3(string string_13);

	private extern void method_4();

	private extern void F937EDA1(string D0244236);

	private extern void E13C8DB6(int int_1, int int_2, int int_3, string string_13, string C0023487);

	private extern void method_5(string B29F132E);

	private extern void method_6(string A8B6A0B3, string string_13);

	private extern void method_7(object sender, EventArgs e);

	private extern void method_8(GEnum1 genum1_0, string string_13, string string_14);

	private extern void A18B0E8C(object sender, EventArgs e);

	private extern void D2194E2F(GEnum1 genum1_0, string string_13, string string_14);

	private extern void method_9(object sender, EventArgs e);

	private extern void method_10(GEnum1 genum1_0, string E89229BA, string string_13);

	private extern void A6802AA0(bool C6BB703B);

	private extern void F2A87730();

	[DllImport("user32.dll")]
	private static extern bool ReleaseCapture();

	[DllImport("user32.dll")]
	private static extern bool SendMessage(IntPtr BA35859E, int D6ABA0A7, int int_1, int int_2);

	private extern void method_11(object sender, MouseEventArgs e);

	private extern void method_12(object sender, EventArgs e);

	private extern void method_13(object sender, EventArgs e);

	private static extern void smethod_2(string string_13);

	private extern void method_14(object sender, EventArgs e);

	private extern void method_15(object sender, EventArgs e);

	protected override extern void Dispose(bool E0281B30);

	private extern void F326BD32();

	[CompilerGenerated]
	private extern void CF09A406();

	[CompilerGenerated]
	private extern void B011ECB5();

	[CompilerGenerated]
	private extern void method_16();

	[CompilerGenerated]
	private extern void method_17();

	[CompilerGenerated]
	private extern void AF317A15();

	[CompilerGenerated]
	private extern void method_18();

	[CompilerGenerated]
	private extern void method_19();

	[CompilerGenerated]
	private extern void method_20();

	[CompilerGenerated]
	private extern void method_21();

	[CompilerGenerated]
	private extern void A0A3E80B();

	[CompilerGenerated]
	private extern void method_22();

	[AsyncStateMachine(typeof(AF18E8BE))]
	[CompilerGenerated]
	private extern Task method_23();

	[CompilerGenerated]
	private extern void method_24();

	[CompilerGenerated]
	private extern void method_25();

	[CompilerGenerated]
	private extern void method_26();

	[CompilerGenerated]
	private extern void D1156BB6();

	[CompilerGenerated]
	private extern void method_27();

	[CompilerGenerated]
	private extern void method_28();

	[CompilerGenerated]
	private extern void A48F6713();

	[CompilerGenerated]
	[AsyncStateMachine(typeof(D0B794B2))]
	private extern Task AA3AB310();

	[CompilerGenerated]
	private extern void B699F636();

	[CompilerGenerated]
	private extern void method_29();

	[CompilerGenerated]
	private extern void method_30();

	[CompilerGenerated]
	private extern void CC2E02BE();

	[CompilerGenerated]
	private extern void E2009B93();

	[CompilerGenerated]
	private extern void method_31();

	[CompilerGenerated]
	private extern void method_32();

	[CompilerGenerated]
	[AsyncStateMachine(typeof(B91CC19B))]
	private extern Task F7A785A7();

	[CompilerGenerated]
	private extern void C2154031();

	[CompilerGenerated]
	private extern void method_33();

	[CompilerGenerated]
	private extern void FC9D2BB7();

	[CompilerGenerated]
	private extern void B52A7819();

	[CompilerGenerated]
	private extern void ADA986AC();

	[CompilerGenerated]
	private extern void F709BDA3();

	[CompilerGenerated]
	private extern void BB32273D();

	[CompilerGenerated]
	private extern void method_34();

	[CompilerGenerated]
	private extern void method_35();

	[CompilerGenerated]
	private extern void method_36();

	[CompilerGenerated]
	private extern void F32E9581();

	[CompilerGenerated]
	private extern void method_37();

	[CompilerGenerated]
	private extern void FFAD3291();

	[CompilerGenerated]
	private extern void method_38();

	[CompilerGenerated]
	private extern void method_39();

	[CompilerGenerated]
	private extern void D3A09CA4();

	[CompilerGenerated]
	private extern void D4BB482A();

	[CompilerGenerated]
	private extern void method_40();

	[CompilerGenerated]
	private extern void method_41();

	[CompilerGenerated]
	private extern void C31ED680();

	[CompilerGenerated]
	private extern void method_42();

	[CompilerGenerated]
	private extern void method_43();

	[CompilerGenerated]
	private extern void E7AB4011();

	[CompilerGenerated]
	private extern void method_44();

	[CompilerGenerated]
	private extern void method_45();

	[CompilerGenerated]
	private extern void method_46();

	[CompilerGenerated]
	private extern void method_47();

	[CompilerGenerated]
	private extern void B1057CB4();

	[CompilerGenerated]
	private extern void B893F63C();

	[CompilerGenerated]
	private extern void method_48();

	[CompilerGenerated]
	private extern void BB32DC3C();

	[CompilerGenerated]
	private extern void method_49();

	[CompilerGenerated]
	private extern void method_50();

	[CompilerGenerated]
	private extern void method_51();

	[CompilerGenerated]
	private extern void D208B9B7();

	[CompilerGenerated]
	private extern void method_52();

	[CompilerGenerated]
	private extern void method_53();

	[CompilerGenerated]
	private extern void method_54();

	[CompilerGenerated]
	private extern void AD8B85AD();
}
