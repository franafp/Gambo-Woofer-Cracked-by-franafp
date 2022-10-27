namespace ChetSpoofer
{
	// Token: 0x02000005 RID: 5
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00003DE8 File Offset: 0x00001FE8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003E20 File Offset: 0x00002020
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ChetSpoofer.Main));
			this.guna2ShadowForm1 = new global::Guna.UI2.WinForms.Guna2ShadowForm(this.components);
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.guna2ShadowForm1.TargetForm = this;
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl1.DragStartTransparencyValue = 1.0;
			this.guna2DragControl1.TargetControl = this;
			this.guna2DragControl1.TransparentWhileDrag = false;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Bahnschrift SemiCondensed", 20.25f, global::System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(63, 97);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(113, 33);
			this.label2.TabIndex = 3;
			this.label2.Text = "SPOOFER";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Bahnschrift SemiCondensed", 20.25f, global::System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(63, 199);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(122, 33);
			this.label3.TabIndex = 4;
			this.label3.Text = "EXECUTOR";
			this.label3.Click += new global::System.EventHandler(this.label3_Click);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Bahnschrift SemiCondensed", 20.25f, global::System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(63, 298);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(103, 33);
			this.label4.TabIndex = 5;
			this.label4.Text = "DUMPER";
			this.label4.Click += new global::System.EventHandler(this.label4_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Bahnschrift SemiCondensed", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(613, 424);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(59, 18);
			this.label1.TabIndex = 6;
			this.label1.Text = "DISCORD";
			this.siticoneBorderlessForm1.BorderRadius = 24;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.pictureBox1.Location = new global::System.Drawing.Point(292, 33);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(370, 363);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(19, 19, 19);
			base.ClientSize = new global::System.Drawing.Size(674, 445);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;			base.Name = "Main";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			base.Load += new global::System.EventHandler(this.Main_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001A RID: 26
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001B RID: 27
		private global::Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;

		// Token: 0x0400001C RID: 28
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000022 RID: 34
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
	}
}
