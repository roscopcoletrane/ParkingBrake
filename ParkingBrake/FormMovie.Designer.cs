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
			this.checkBoxForeign = new System.Windows.Forms.CheckBox();
			this.buttonGo = new System.Windows.Forms.Button();
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
			this.textBoxQuality.Location = new System.Drawing.Point(96, 279);
			this.textBoxQuality.Name = "textBoxQuality";
			this.textBoxQuality.Size = new System.Drawing.Size(36, 20);
			this.textBoxQuality.TabIndex = 6;
			this.textBoxQuality.Text = "20";
			this.textBoxQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 282);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Quality (18-21):";
			// 
			// checkBoxForeign
			// 
			this.checkBoxForeign.AutoSize = true;
			this.checkBoxForeign.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxForeign.Location = new System.Drawing.Point(158, 281);
			this.checkBoxForeign.Name = "checkBoxForeign";
			this.checkBoxForeign.Size = new System.Drawing.Size(100, 17);
			this.checkBoxForeign.TabIndex = 8;
			this.checkBoxForeign.Text = "Foreign Options";
			this.checkBoxForeign.UseVisualStyleBackColor = true;
			// 
			// buttonGo
			// 
			this.buttonGo.Location = new System.Drawing.Point(285, 277);
			this.buttonGo.Name = "buttonGo";
			this.buttonGo.Size = new System.Drawing.Size(59, 23);
			this.buttonGo.TabIndex = 9;
			this.buttonGo.Text = "Go";
			this.buttonGo.UseVisualStyleBackColor = true;
			this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
			// 
			// FormMovie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 313);
			this.Controls.Add(this.buttonGo);
			this.Controls.Add(this.checkBoxForeign);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxQuality);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBoxChapter);
			this.Controls.Add(this.listBoxTitle);
			this.Name = "FormMovie";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Movie Options";
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
		private System.Windows.Forms.CheckBox checkBoxForeign;
		private System.Windows.Forms.Button buttonGo;
	}
}