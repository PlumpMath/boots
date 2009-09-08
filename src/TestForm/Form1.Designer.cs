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
			this.flow1 = new SteelToeBoots.Library.Slots.Flow();
			this.para1 = new SteelToeBoots.Library.Elements.Para();
			this.button1 = new SteelToeBoots.Library.Elements.Button();
			this.stack1 = new SteelToeBoots.Library.Slots.Stack();
			this.para2 = new SteelToeBoots.Library.Elements.Para();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.flow2 = new SteelToeBoots.Library.Slots.Flow();
			this.button2 = new SteelToeBoots.Library.Elements.Button();
			this.button3 = new SteelToeBoots.Library.Elements.Button();
			this.flow3 = new SteelToeBoots.Library.Slots.Flow();
			this.flow1.SuspendLayout();
			this.stack1.SuspendLayout();
			this.flow2.SuspendLayout();
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
			// flow1
			// 
			this.flow1.Controls.Add(this.para1);
			this.flow1.Controls.Add(this.button1);
			this.flow1.Controls.Add(this.stack1);
			this.flow1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flow1.Location = new System.Drawing.Point(0, 0);
			this.flow1.Name = "flow1";
			this.flow1.Size = new System.Drawing.Size(284, 264);
			this.flow1.TabIndex = 2;
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
			// stack1
			// 
			this.stack1.BackColor = System.Drawing.Color.RosyBrown;
			this.stack1.Controls.Add(this.para2);
			this.stack1.Controls.Add(this.textBox1);
			this.stack1.Controls.Add(this.flow2);
			this.stack1.Controls.Add(this.flow3);
			this.stack1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.stack1.Location = new System.Drawing.Point(3, 32);
			this.stack1.Name = "stack1";
			this.stack1.Size = new System.Drawing.Size(281, 232);
			this.stack1.TabIndex = 2;
			// 
			// para2
			// 
			this.para2.Location = new System.Drawing.Point(3, 0);
			this.para2.Name = "para2";
			this.para2.Size = new System.Drawing.Size(100, 23);
			this.para2.TabIndex = 0;
			this.para2.Text = "para2";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(3, 26);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(275, 20);
			this.textBox1.TabIndex = 1;
			// 
			// flow2
			// 
			this.flow2.BackColor = System.Drawing.Color.LightCoral;
			this.flow2.Controls.Add(this.button2);
			this.flow2.Controls.Add(this.button3);
			this.flow2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flow2.Location = new System.Drawing.Point(3, 52);
			this.flow2.Name = "flow2";
			this.flow2.Size = new System.Drawing.Size(278, 100);
			this.flow2.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(200, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 0;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(119, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 1;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// flow3
			// 
			this.flow3.Location = new System.Drawing.Point(287, 3);
			this.flow3.Name = "flow3";
			this.flow3.Size = new System.Drawing.Size(200, 74);
			this.flow3.TabIndex = 3;
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
			this.stack1.ResumeLayout(false);
			this.stack1.PerformLayout();
			this.flow2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private SteelToeBoots.Library.Elements.Para para1;
		private System.Windows.Forms.Label label1;
		private SteelToeBoots.Library.Slots.Flow flow1;
		private SteelToeBoots.Library.Elements.Button button1;
		private SteelToeBoots.Library.Slots.Stack stack1;
		private SteelToeBoots.Library.Elements.Para para2;
		private System.Windows.Forms.TextBox textBox1;
		private SteelToeBoots.Library.Slots.Flow flow2;
		private SteelToeBoots.Library.Elements.Button button2;
		private SteelToeBoots.Library.Elements.Button button3;
		private SteelToeBoots.Library.Slots.Flow flow3;
	}
}

