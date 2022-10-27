using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace License_Login_Register_Auth.gg
{
	// Token: 0x0200000F RID: 15
	internal class OnProgramStart
	{
		// Token: 0x06000086 RID: 134 RVA: 0x0000656C File Offset: 0x0000476C
		public static void Initialize(string name, string aid, string secret, string version)
		{
			bool flag = string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(aid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version);
			if (flag)
			{
				Process.GetCurrentProcess().Kill();
			}
			OnProgramStart.AID = aid;
			OnProgramStart.Secret = secret;
			OnProgramStart.Version = version;
			OnProgramStart.Name = name;
			string[] array = new string[0];
			using (WebClient webClient = new WebClient())
			{
				try
				{
					webClient.Proxy = null;
					Security.Start();
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string apiUrl = Constants.ApiUrl;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Encryption.EncryptService(Constants.Token);
					nameValueCollection["timestamp"] = Encryption.EncryptService(DateTime.Now.ToString());
					nameValueCollection["aid"] = Encryption.APIService(OnProgramStart.AID);
					nameValueCollection["session_id"] = Constants.IV;
					nameValueCollection["api_id"] = Constants.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Constants.APIENCRYPTKEY;
					nameValueCollection["session_key"] = Constants.Key;
					nameValueCollection["secret"] = Encryption.APIService(OnProgramStart.Secret);
					nameValueCollection["type"] = Encryption.APIService("start");
					array = Encryption.DecryptService(@default.GetString(webClient2.UploadValues(apiUrl, nameValueCollection))).Split("|".ToCharArray());
					bool flag2 = Security.MaliciousCheck(array[1]);
					if (flag2)
					{
						Process.GetCurrentProcess().Kill();
					}
					bool breached = Constants.Breached;
					if (breached)
					{
						Process.GetCurrentProcess().Kill();
					}
					bool flag3 = array[0] != Constants.Token;
					if (flag3)
					{
						Process.GetCurrentProcess().Kill();
					}
					string text = array[2];
					string a = text;
					if (!(a == "success"))
					{
						if (a == "binderror")
						{
							Process.GetCurrentProcess().Kill();
							return;
						}
						if (a == "banned")
						{
							Process.GetCurrentProcess().Kill();
							return;
						}
					}
					else
					{
						Constants.Initialized = true;
						bool flag4 = array[3] == "Enabled";
						if (flag4)
						{
							ApplicationSettings.Status = true;
						}
						bool flag5 = array[4] == "Enabled";
						if (flag5)
						{
							ApplicationSettings.DeveloperMode = true;
						}
						ApplicationSettings.Hash = array[5];
						ApplicationSettings.Version = array[6];
						ApplicationSettings.Update_Link = array[7];
						bool flag6 = array[8] == "Enabled";
						if (flag6)
						{
							ApplicationSettings.Freemode = true;
						}
						bool flag7 = array[9] == "Enabled";
						if (flag7)
						{
							ApplicationSettings.Login = true;
						}
						ApplicationSettings.Name = array[10];
						bool flag8 = array[11] == "Enabled";
						if (flag8)
						{
							ApplicationSettings.Register = true;
						}
						bool developerMode = ApplicationSettings.DeveloperMode;
						if (developerMode)
						{
							File.Create(Environment.CurrentDirectory + "/integrity.log").Close();
							string contents = Security.Integrity(Process.GetCurrentProcess().MainModule.FileName);
							File.WriteAllText(Environment.CurrentDirectory + "/integrity.log", contents);
						}
						else
						{
							bool flag9 = array[12] == "Enabled";
							if (flag9)
							{
								bool flag10 = ApplicationSettings.Hash != Security.Integrity(Process.GetCurrentProcess().MainModule.FileName);
								if (flag10)
								{
									Process.GetCurrentProcess().Kill();
								}
							}
							bool flag11 = ApplicationSettings.Version != OnProgramStart.Version;
							if (flag11)
							{
								Process.Start(ApplicationSettings.Update_Link);
								Process.GetCurrentProcess().Kill();
							}
						}
						bool flag12 = !ApplicationSettings.Status;
						if (flag12)
						{
							Process.GetCurrentProcess().Kill();
						}
					}
					Security.End();
				}
				catch (Exception)
				{
					Process.GetCurrentProcess().Kill();
				}
			}
		}

		// Token: 0x04000060 RID: 96
		public static string AID;

		// Token: 0x04000061 RID: 97
		public static string Secret;

		// Token: 0x04000062 RID: 98
		public static string Version;

		// Token: 0x04000063 RID: 99
		public static string Name;

		// Token: 0x04000064 RID: 100
		public static string Salt;
	}
}
