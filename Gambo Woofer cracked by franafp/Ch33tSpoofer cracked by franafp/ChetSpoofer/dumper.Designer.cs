namespace ChetSpoofer
{
	// Token: 0x02000002 RID: 2
	public partial class dumper : global::System.Windows.Forms.Form
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002104 File Offset: 0x00000304
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000213C File Offset: 0x0000033C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.siticoneBorderlessForm1 = new global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
			this.label4 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox5 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).BeginInit();
			base.SuspendLayout();
			this.siticoneBorderlessForm1.BorderRadius = 24;
			this.siticoneBorderlessForm1.ContainerControl = this;
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Bahnschrift SemiCondensed", 20.25f, global::System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(224, 62);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(313, 33);
			this.label4.TabIndex = 19;
			this.label4.Text = "FIVEM SERVER FILE DUMPER";
			this.label4.Click += new global::System.EventHandler(this.label4_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Bahnschrift SemiCondensed", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(12, 423);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(186, 18);
			this.label1.TabIndex = 22;
			this.label1.Text = "dumper by alokas and usuario";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.pictureBox1.Location = new global::System.Drawing.Point(367, 210);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(53, 51);
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.pictureBox5.Location = new global::System.Drawing.Point(23, 12);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new global::System.Drawing.Size(56, 47);
			this.pictureBox5.TabIndex = 20;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new global::System.EventHandler(this.pictureBox5_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(19, 19, 19);
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.pictureBox5);
			base.Controls.Add(this.label4);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "dumper";
			this.Text = "dumper";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000002 RID: 2
		private global::Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.PictureBox pictureBox5;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label1;
	}
}
