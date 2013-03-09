namespace ParkingBrake
{
	partial class FormMovie
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
			this.listBoxTitle = new System.Windows.Forms.ListBox();
			this.listBoxChapter = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxQuality = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonDone = new System.Windows.Forms.Button();
			this.buttonForeign = new System.Windows.Forms.Button();
			this.listBoxAudio = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBoxTitle
			// 
			this.listBoxTitle.FormattingEnabled = true;
			this.listBoxTitle.Location = new System.Drawing.Point(12, 25);
			this.listBoxTitle.Name = "listBoxTitle";
			this.listBoxTitle.Size = new System.Drawing.Size(163, 238);
			this.listBoxTitle.TabIndex = 0;
			this.listBoxTitle.SelectedIndexChanged += new System.EventHandler(this.listBoxTitle_SelectedIndexChanged);
			// 
			// listBoxChapter
			// 
			this.listBoxChapter.FormattingEnabled = true;
			this.listBoxChapter.Location = new System.Drawing.Point(181, 25);
			this.listBoxChapter.Name = "listBoxChapter";
			this.listBoxChapter.Size = new System.Drawing.Size(163, 238);
			this.listBoxChapter.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Title Tracks";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(178, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Chapter Tracks";
			// 
			// textBoxQuality
			// 
			this.textBoxQuality.Location = new System.Drawing.Point(96, 385);
			this.textBoxQuality.Name = "textBoxQuality";
			this.textBoxQuality.Size = new System.Drawing.Size(36, 20);
			this.textBoxQuality.TabIndex = 6;
			this.textBoxQuality.Text = "20";
			this.textBoxQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxQuality.TextChanged += new System.EventHandler(this.textBoxQuality_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 388);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Quality (18-21):";
			// 
			// buttonDone
			// 
			this.buttonDone.Location = new System.Drawing.Point(291, 383);
			this.buttonDone.Name = "buttonDone";
			this.buttonDone.Size = new System.Drawing.Size(53, 23);
			this.buttonDone.TabIndex = 9;
			this.buttonDone.Text = "Done";
			this.buttonDone.UseVisualStyleBackColor = true;
			this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
			// 
			// buttonForeign
			// 
			this.buttonForeign.Location = new System.Drawing.Point(181, 383);
			this.buttonForeign.Name = "buttonForeign";
			this.buttonForeign.Size = new System.Drawing.Size(104, 23);
			this.buttonForeign.TabIndex = 10;
			this.buttonForeign.Text = "Subtitle Options";
			this.buttonForeign.UseVisualStyleBackColor = true;
			this.buttonForeign.Click += new System.EventHandler(this.buttonForeign_Click);
			// 
			// listBoxAudio
			// 
			this.listBoxAudio.FormattingEnabled = true;
			this.listBoxAudio.Location = new System.Drawing.Point(12, 282);
			this.listBoxAudio.Name = "listBoxAudio";
			this.listBoxAudio.Size = new System.Drawing.Size(332, 95);
			this.listBoxAudio.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 266);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Audio Tracks";
			// 
			// FormMovie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 412);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.listBoxAudio);
			this.Controls.Add(this.buttonForeign);
			this.Controls.Add(this.buttonDone);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxQuality);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBoxChapter);
			this.Controls.Add(this.listBoxTitle);
			this.Name = "FormMovie";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Movie Options";
			this.Load += new System.EventHandler(this.FormMovie_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxTitle;
		private System.Windows.Forms.ListBox listBoxChapter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxQuality;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonDone;
		private System.Windows.Forms.Button buttonForeign;
		private System.Windows.Forms.ListBox listBoxAudio;
		private System.Windows.Forms.Label label4;
	}
}