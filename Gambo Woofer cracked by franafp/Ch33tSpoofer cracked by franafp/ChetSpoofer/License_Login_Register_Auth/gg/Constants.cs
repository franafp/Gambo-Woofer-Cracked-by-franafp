using System;
using System.Linq;
using System.Security.Principal;

namespace License_Login_Register_Auth.gg
{
	// Token: 0x0200000C RID: 12
	internal class Constants
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00006347 File Offset: 0x00004547
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0000634E File Offset: 0x0000454E
		public static string Token { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00006356 File Offset: 0x00004556
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000635D File Offset: 0x0000455D
		public static string Date { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00006365 File Offset: 0x00004565
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0000636C File Offset: 0x0000456C
		public static string APIENCRYPTKEY { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00006374 File Offset: 0x00004574
		// (set) Token: 0x06000057 RID: 87 RVA: 0x0000637B File Offset: 0x0000457B
		public static string APIENCRYPTSALT { get; set; }

		// Token: 0x06000058 RID: 88 RVA: 0x00006384 File Offset: 0x00004584
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", length)
			select s[Constants.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000063D0 File Offset: 0x000045D0
		public static string HWID()
		{
			return WindowsIdentity.GetCurrent().User.Value;
		}

		// Token: 0x04000045 RID: 69
		public static bool Breached = false;

		// Token: 0x04000046 RID: 70
		public static bool Started = false;

		// Token: 0x04000047 RID: 71
		public static string IV = null;

		// Token: 0x04000048 RID: 72
		public static string Key = null;

		// Token: 0x04000049 RID: 73
		public static string ApiUrl = "https://api.auth.gg/csharp/";

		// Token: 0x0400004A RID: 74
		public static bool Initialized = false;

		// Token: 0x0400004B RID: 75
		public static Random random = new Random();
	}
}
