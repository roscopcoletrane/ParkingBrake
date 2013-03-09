namespace ParkingBrake
{
	partial class FormProgress
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
			this.listBoxQueue = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// listBoxQueue
			// 
			this.listBoxQueue.FormattingEnabled = true;
			this.listBoxQueue.Location = new System.Drawing.Point(12, 12);
			this.listBoxQueue.Name = "listBoxQueue";
			this.listBoxQueue.Size = new System.Drawing.Size(736, 238);
			this.listBoxQueue.TabIndex = 0;
			// 
			// FormProgress
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 262);
			this.Controls.Add(this.listBoxQueue);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FormProgress";
			this.Text = "FormProgress";
			this.Load += new System.EventHandler(this.FormProgress_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxQueue;
	}
}