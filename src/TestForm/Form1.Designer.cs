namespace TestForm
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.para1 = new Boots.Library.Elements.Para();
			this.flow1 = new Boots.Library.Slots.Flow();
			this.button1 = new Boots.Library.Elements.Button();
			this.flow1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 176);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 1;
			// 
			// para1
			// 
			this.para1.BackColor = System.Drawing.Color.MistyRose;
			this.para1.Location = new System.Drawing.Point(3, 0);
			this.para1.Name = "para1";
			this.para1.Size = new System.Drawing.Size(148, 14);
			this.para1.TabIndex = 0;
			this.para1.Text = "para1";
			// 
			// flow1
			// 
			this.flow1.Controls.Add(this.para1);
			this.flow1.Controls.Add(this.button1);
			this.flow1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flow1.Location = new System.Drawing.Point(0, 0);
			this.flow1.Name = "flow1";
			this.flow1.Size = new System.Drawing.Size(284, 264);
			this.flow1.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(157, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 264);
			this.Controls.Add(this.flow1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.flow1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Boots.Library.Elements.Para para1;
		private System.Windows.Forms.Label label1;
		private Boots.Library.Slots.Flow flow1;
		private Boots.Library.Elements.Button button1;
	}
}

