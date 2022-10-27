namespace ChetSpoofer
{
	// Token: 0x02000007 RID: 7
	public partial class Register : global::System.Windows.Forms.Form
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00004450 File Offset: 0x00002650
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004488 File Offset: 0x00002688
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ChetSpoofer.Register));
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.guna2ControlBox2 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.guna2Button3 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.password = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.username = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.email = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.license = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2ShadowForm2 = new global::Guna.UI2.WinForms.Guna2ShadowForm(this.components);
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl1.DragStartTransparencyValue = 1.0;
			this.guna2DragControl1.TargetControl = this.panel1;
			this.guna2DragControl1.TransparentWhileDrag = false;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.panel1.Controls.Add(this.guna2ControlBox2);
			this.panel1.Controls.Add(this.guna2ControlBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(-1, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(358, 31);
			this.panel1.TabIndex = 10;
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
			this.label1.Location = new global::System.Drawing.Point(7, 4);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(181, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "GAMBO - R E G I S T E R";
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
			this.guna2Button3.Location = new global::System.Drawing.Point(195, 214);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
			this.guna2Button3.Size = new global::System.Drawing.Size(69, 28);
			this.guna2Button3.TabIndex = 15;
			this.guna2Button3.Text = "Login";
			this.guna2Button3.Click += new global::System.EventHandler(this.guna2Button3_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Silver;
			this.label2.Location = new global::System.Drawing.Point(12, 216);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(188, 21);
			this.label2.TabIndex = 14;
			this.label2.Text = "Have already an Account?";
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
			this.guna2Button2.Location = new global::System.Drawing.Point(14, 172);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
			this.guna2Button2.Size = new global::System.Drawing.Size(330, 31);
			this.guna2Button2.TabIndex = 13;
			this.guna2Button2.Text = "Register";
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
			this.password.Location = new global::System.Drawing.Point(14, 74);
			this.password.Margin = new global::System.Windows.Forms.Padding(4, 3, 4, 3);
			this.password.Name = "password";
			this.password.PasswordChar = '•';
			this.password.PlaceholderText = "Password";
			this.password.SelectedText = "";
			this.password.ShadowDecoration.Parent = this.password;
			this.password.Size = new global::System.Drawing.Size(330, 26);
			this.password.TabIndex = 12;
			this.password.Tag = "";
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
			this.username.Location = new global::System.Drawing.Point(14, 42);
			this.username.Margin = new global::System.Windows.Forms.Padding(4, 3, 4, 3);
			this.username.Name = "username";
			this.username.PasswordChar = '\0';
			this.username.PlaceholderText = "Username";
			this.username.SelectedText = "";
			this.username.ShadowDecoration.Parent = this.username;
			this.username.Size = new global::System.Drawing.Size(330, 26);
			this.username.TabIndex = 11;
			this.email.BackColor = global::System.Drawing.Color.Transparent;
			this.email.BorderColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.email.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.email.DefaultText = "";
			this.email.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.email.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.email.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.email.DisabledState.Parent = this.email;
			this.email.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.email.FillColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.email.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.email.FocusedState.Parent = this.email;
			this.email.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.email.ForeColor = global::System.Drawing.Color.White;
			this.email.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.email.HoverState.Parent = this.email;
			this.email.IconLeftOffset = new global::System.Drawing.Point(8, 0);
			this.email.Location = new global::System.Drawing.Point(14, 106);
			this.email.Margin = new global::System.Windows.Forms.Padding(4, 3, 4, 3);
			this.email.Name = "email";
			this.email.PasswordChar = '\0';
			this.email.PlaceholderText = "Email";
			this.email.SelectedText = "";
			this.email.ShadowDecoration.Parent = this.email;
			this.email.Size = new global::System.Drawing.Size(330, 26);
			this.email.TabIndex = 16;
			this.email.Tag = "";
			this.license.BackColor = global::System.Drawing.Color.Transparent;
			this.license.BorderColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.license.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.license.DefaultText = "";
			this.license.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.license.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.license.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.license.DisabledState.Parent = this.license;
			this.license.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.license.FillColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.license.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.license.FocusedState.Parent = this.license;
			this.license.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.license.ForeColor = global::System.Drawing.Color.White;
			this.license.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.license.HoverState.Parent = this.license;
			this.license.IconLeftOffset = new global::System.Drawing.Point(8, 0);
			this.license.Location = new global::System.Drawing.Point(14, 139);
			this.license.Margin = new global::System.Windows.Forms.Padding(4, 3, 4, 3);
			this.license.Name = "license";
			this.license.PasswordChar = '\0';
			this.license.PlaceholderText = "License";
			this.license.SelectedText = "";
			this.license.ShadowDecoration.Parent = this.license;
			this.license.Size = new global::System.Drawing.Size(330, 26);
			this.license.TabIndex = 17;
			this.license.Tag = "";
			this.guna2ShadowForm2.TargetForm = this;
			this.siticoneBorderlessForm1.BorderRadius = 24;
			this.siticoneBorderlessForm1.ContainerControl = this;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(19, 19, 19);
			base.ClientSize = new global::System.Drawing.Size(355, 255);
			base.Controls.Add(this.license);
			base.Controls.Add(this.email);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.guna2Button3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.guna2Button2);
			base.Controls.Add(this.password);
			base.Controls.Add(this.username);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Register";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Register";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000023 RID: 35
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000024 RID: 36
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000026 RID: 38
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;

		// Token: 0x04000027 RID: 39
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000029 RID: 41
		private global::Guna.UI2.WinForms.Guna2Button guna2Button3;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400002B RID: 43
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

		// Token: 0x0400002C RID: 44
		private global::Guna.UI2.WinForms.Guna2TextBox password;

		// Token: 0x0400002D RID: 45
		private global::Guna.UI2.WinForms.Guna2TextBox username;

		// Token: 0x0400002E RID: 46
		private global::Guna.UI2.WinForms.Guna2TextBox license;

		// Token: 0x0400002F RID: 47
		private global::Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm2;

		// Token: 0x04000030 RID: 48
		private global::Guna.UI2.WinForms.Guna2TextBox email;

		// Token: 0x04000031 RID: 49
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
	}
}
