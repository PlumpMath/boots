namespace SteelToeBoots.Library
{
	partial class Canvas
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
			this.verticalScrollBar = new System.Windows.Forms.VScrollBar();
			this.canvasFlow = new SteelToeBoots.Library.Slots.Flow();
			this.SuspendLayout();
			// 
			// verticalScrollBar
			// 
			this.verticalScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
			this.verticalScrollBar.Location = new System.Drawing.Point(267, 0);
			this.verticalScrollBar.Name = "verticalScrollBar";
			this.verticalScrollBar.Size = new System.Drawing.Size(17, 264);
			this.verticalScrollBar.TabIndex = 0;
			// 
			// canvasFlow
			// 
			this.canvasFlow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.canvasFlow.Location = new System.Drawing.Point(0, 0);
			this.canvasFlow.Name = "canvasFlow";
			this.canvasFlow.Size = new System.Drawing.Size(267, 264);
			this.canvasFlow.TabIndex = 1;
			// 
			// Canvas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(284, 264);
			this.Controls.Add(this.canvasFlow);
			this.Controls.Add(this.verticalScrollBar);
			this.Name = "Canvas";
			this.Text = "Boots";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.VScrollBar verticalScrollBar;
		private global::SteelToeBoots.Library.Slots.Flow canvasFlow;
	}
}