using System;
using System.Windows.Forms;
using License_Login_Register_Auth.gg;

namespace ChetSpoofer
{
	// Token: 0x02000006 RID: 6
	internal static class Program
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00004350 File Offset: 0x00002550
		[STAThread]
		private static void Main()
		{
			OnProgramStart.Initialize("iuot34j9t34jto2j4tr", "43845", "c2TjWotoNIb8RMGVYZ7c7QZ1ziYX4SIavj6", "1.0");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
