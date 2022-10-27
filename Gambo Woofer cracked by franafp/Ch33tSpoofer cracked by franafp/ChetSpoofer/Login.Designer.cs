namespace ChetSpoofer
{
	// Token: 0x02000004 RID: 4
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002A7C File Offset: 0x00000C7C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002AB4 File Offset: 0x00000CB4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ChetSpoofer.Login));
			this.guna2ShadowForm1 = new global::Guna.UI2.WinForms.Guna2ShadowForm(this.components);
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.guna2ControlBox2 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.password = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.username = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Button3 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.guna2ShadowForm1.TargetForm = this;
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl1.DragStartTransparencyValue = 1.0;
			this.guna2DragControl1.TargetControl = this.panel1;
			this.guna2DragControl1.TransparentWhileDrag = false;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.panel1.Controls.Add(this.guna2ControlBox2);
			this.panel1.Controls.Add(this.guna2ControlBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(-2, -4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(358, 31);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.guna2ControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2ControlBox2.ControlBoxType = global::Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.guna2ControlBox2.FillColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
			this.guna2ControlBox2.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox2.Location = new global::System.Drawing.Point(266, 4);
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
			this.guna2ControlBox2.Size = new global::System.Drawing.Size(45, 26);
			this.guna2ControlBox2.TabIndex = 2;
			this.guna2ControlBox2.Click += new global::System.EventHandler(this.guna2ControlBox2_Click);
			this.guna2ControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(311, 4);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 26);
			this.guna2ControlBox1.TabIndex = 1;
			this.guna2ControlBox1.Click += new global::System.EventHandler(this.guna2ControlBox1_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(7, 5);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(147, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "GAMBO - L O G I N";
			this.guna2Button2.CheckedState.Parent = this.guna2Button2;
			this.guna2Button2.CustomImages.Parent = this.guna2Button2;
			this.guna2Button2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button2.DisabledState.Parent = this.guna2Button2;
			this.guna2Button2.FillColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.guna2Button2.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button2.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button2.HoverState.FillColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.guna2Button2.HoverState.Parent = this.guna2Button2;
			this.guna2Button2.Location = new global::System.Drawing.Point(13, 103);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
			this.guna2Button2.Size = new global::System.Drawing.Size(330, 31);
			this.guna2Button2.TabIndex = 7;
			this.guna2Button2.Text = "Log In";
			this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button2_Click);
			this.password.BackColor = global::System.Drawing.Color.Transparent;
			this.password.BorderColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.password.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.password.DefaultText = "";
			this.password.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.password.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.password.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.DisabledState.Parent = this.password;
			this.password.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.FillColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.password.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.password.FocusedState.Parent = this.password;
			this.password.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.password.ForeColor = global::System.Drawing.Color.White;
			this.password.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.password.HoverState.Parent = this.password;
			this.password.IconLeftOffset = new global::System.Drawing.Point(8, 0);
			this.password.Location = new global::System.Drawing.Point(13, 71);
			this.password.Margin = new global::System.Windows.Forms.Padding(4, 3, 4, 3);
			this.password.Name = "password";
			this.password.PasswordChar = '•';
			this.password.PlaceholderText = "Password";
			this.password.SelectedText = "";
			this.password.ShadowDecoration.Parent = this.password;
			this.password.Size = new global::System.Drawing.Size(330, 26);
			this.password.TabIndex = 6;
			this.password.Tag = "";
			this.password.TextChanged += new global::System.EventHandler(this.password_TextChanged);
			this.username.BackColor = global::System.Drawing.Color.Transparent;
			this.username.BorderColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.username.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.username.DefaultText = "";
			this.username.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.username.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.username.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.DisabledState.Parent = this.username;
			this.username.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.FillColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.username.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.username.FocusedState.Parent = this.username;
			this.username.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.username.ForeColor = global::System.Drawing.Color.White;
			this.username.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.username.HoverState.Parent = this.username;
			this.username.IconLeftOffset = new global::System.Drawing.Point(8, 0);
			this.username.Location = new global::System.Drawing.Point(13, 39);
			this.username.Margin = new global::System.Windows.Forms.Padding(4, 3, 4, 3);
			this.username.Name = "username";
			this.username.PasswordChar = '\0';
			this.username.PlaceholderText = "Username";
			this.username.SelectedText = "";
			this.username.ShadowDecoration.Parent = this.username;
			this.username.Size = new global::System.Drawing.Size(330, 26);
			this.username.TabIndex = 5;
			this.username.TextChanged += new global::System.EventHandler(this.username_TextChanged);
			this.guna2Button3.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button3.CausesValidation = false;
			this.guna2Button3.CheckedState.Parent = this.guna2Button3;
			this.guna2Button3.CustomImages.Parent = this.guna2Button3;
			this.guna2Button3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button3.DisabledState.Parent = this.guna2Button3;
			this.guna2Button3.FillColor = global::System.Drawing.Color.FromArgb(19, 19, 19);
			this.guna2Button3.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button3.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button3.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			this.guna2Button3.HoverState.CustomBorderColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			this.guna2Button3.HoverState.FillColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			this.guna2Button3.HoverState.Parent = this.guna2Button3;
			this.guna2Button3.Location = new global::System.Drawing.Point(175, 140);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
			this.guna2Button3.Size = new global::System.Drawing.Size(87, 28);
			this.guna2Button3.TabIndex = 9;
			this.guna2Button3.Text = "Register";
			this.guna2Button3.Click += new global::System.EventHandler(this.guna2Button3_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Silver;
			this.label2.Location = new global::System.Drawing.Point(10, 143);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(171, 21);
			this.label2.TabIndex = 8;
			this.label2.Text = "Don't have an account?";
			this.siticoneBorderlessForm1.BorderRadius = 24;
			this.siticoneBorderlessForm1.ContainerControl = this;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(19, 19, 19);
			base.ClientSize = new global::System.Drawing.Size(355, 180);
			base.Controls.Add(this.guna2Button3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.guna2Button2);
			base.Controls.Add(this.password);
			base.Controls.Add(this.username);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Login";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chet Login";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.Login_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000D RID: 13
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400000E RID: 14
		private global::Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000010 RID: 16
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000012 RID: 18
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x04000013 RID: 19
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;

		// Token: 0x04000014 RID: 20
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

		// Token: 0x04000015 RID: 21
		private global::Guna.UI2.WinForms.Guna2TextBox password;

		// Token: 0x04000016 RID: 22
		private global::Guna.UI2.WinForms.Guna2TextBox username;

		// Token: 0x04000017 RID: 23
		private global::Guna.UI2.WinForms.Guna2Button guna2Button3;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000019 RID: 25
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
	}
}
