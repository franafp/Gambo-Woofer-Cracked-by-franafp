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
	// Token: 0x02000004 RID: 4
	public partial class Login : Form
	{
		// Token: 0x0600000D RID: 13 RVA: 0x0000298B File Offset: 0x00000B8B
		public Login()
		{
			this.InitializeComponent();
			base.TopMost = true;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000029AB File Offset: 0x00000BAB
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000029AE File Offset: 0x00000BAE
		private void guna2ControlBox2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000029BC File Offset: 0x00000BBC
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			Register register = new Register();
			register.Show();
			base.Hide();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000029E0 File Offset: 0x00000BE0
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			bool flag = API.Login(this.username.Text, this.password.Text);
			if (flag)
			{
				MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				API.Log(User.Username, "Signed in");
				Main main = new Main();
				main.Show();
				base.Hide();
			}
			else
			{
				MessageBox.Show("Password/Username Invaild", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002A5D File Offset: 0x00000C5D
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
			base.Hide();
			Application.Exit();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002A73 File Offset: 0x00000C73
		private void username_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002A76 File Offset: 0x00000C76
		private void password_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002A79 File Offset: 0x00000C79
		private void Login_Load(object sender, EventArgs e)
		{
		}
	}
}
