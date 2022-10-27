using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using License_Login_Register_Auth.gg;
using Siticone.Desktop.UI.WinForms;

namespace ChetSpoofer
{
	// Token: 0x02000007 RID: 7
	public partial class Register : Form
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00004385 File Offset: 0x00002585
		public Register()
		{
			this.InitializeComponent();
			base.TopMost = true;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000043A8 File Offset: 0x000025A8
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			base.Hide();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000043CA File Offset: 0x000025CA
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000043D3 File Offset: 0x000025D3
		private void guna2ControlBox2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000043E0 File Offset: 0x000025E0
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			bool flag = API.Register(this.username.Text, this.password.Text, this.email.Text, this.license.Text);
			if (flag)
			{
				MessageBox.Show("Register has been successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("License/Password/Username/Email Invaild", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}
}
