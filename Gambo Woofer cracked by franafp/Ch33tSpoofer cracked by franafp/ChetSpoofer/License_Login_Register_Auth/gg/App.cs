using System;
using System.Collections.Generic;

namespace License_Login_Register_Auth.gg
{
	// Token: 0x0200000B RID: 11
	internal class App
	{
		// Token: 0x0600004D RID: 77 RVA: 0x000062C0 File Offset: 0x000044C0
		public static string GrabVariable(string name)
		{
			string result;
			try
			{
				bool flag = User.ID != null || User.HWID != null || User.IP != null || !Constants.Breached;
				if (flag)
				{
					result = App.Variables[name];
				}
				else
				{
					Constants.Breached = true;
					result = "User is not logged in, possible breach detected!";
				}
			}
			catch
			{
				result = "N/A";
			}
			return result;
		}

		// Token: 0x0400003F RID: 63
		public static string Error = null;

		// Token: 0x04000040 RID: 64
		public static Dictionary<string, string> Variables = new Dictionary<string, string>();
	}
}
