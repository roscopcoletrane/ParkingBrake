namespace ParkingBrake
{
	partial class FormTV
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
			this.label4 = new System.Windows.Forms.Label();
			this.listBoxAudio = new System.Windows.Forms.ListBox();
			this.buttonForeign = new System.Windows.Forms.Button();
			this.buttonDone = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxQuality = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.listBoxChapter = new System.Windows.Forms.ListBox();
			this.listBoxTitle = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioButtonTitle = new System.Windows.Forms.RadioButton();
			this.radioButtonChapter = new System.Windows.Forms.RadioButton();
			this.checkBoxRemoveCredits = new System.Windows.Forms.CheckBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.textBoxTVEpisode = new System.Windows.Forms.TextBox();
			this.textBoxTVSeason = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 266);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 13);
			this.label4.TabIndex = 22;
			this.label4.Text = "Audio Tracks";
			// 
			// listBoxAudio
			// 
			this.listBoxAudio.FormattingEnabled = true;
			this.listBoxAudio.Location = new System.Drawing.Point(12, 282);
			this.listBoxAudio.Name = "listBoxAudio";
			this.listBoxAudio.Size = new System.Drawing.Size(332, 95);
			this.listBoxAudio.TabIndex = 21;
			// 
			// buttonForeign
			// 
			this.buttonForeign.Location = new System.Drawing.Point(181, 458);
			this.buttonForeign.Name = "buttonForeign";
			this.buttonForeign.Size = new System.Drawing.Size(104, 23);
			this.buttonForeign.TabIndex = 20;
			this.buttonForeign.Text = "Subtitle Options";
			this.buttonForeign.UseVisualStyleBackColor = true;
			this.buttonForeign.Click += new System.EventHandler(this.buttonForeign_Click);
			// 
			// buttonDone
			// 
			this.buttonDone.Location = new System.Drawing.Point(291, 458);
			this.buttonDone.Name = "buttonDone";
			this.buttonDone.Size = new System.Drawing.Size(53, 23);
			this.buttonDone.TabIndex = 19;
			this.buttonDone.Text = "Done";
			this.buttonDone.UseVisualStyleBackColor = true;
			this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 463);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "Quality (18-21):";
			// 
			// textBoxQuality
			// 
			this.textBoxQuality.Location = new System.Drawing.Point(96, 460);
			this.textBoxQuality.Name = "textBoxQuality";
			this.textBoxQuality.Size = new System.Drawing.Size(36, 20);
			this.textBoxQuality.TabIndex = 17;
			this.textBoxQuality.Text = "20";
			this.textBoxQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(178, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Chapter Tracks";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Title Tracks";
			// 
			// listBoxChapter
			// 
			this.listBoxChapter.FormattingEnabled = true;
			this.listBoxChapter.Location = new System.Drawing.Point(181, 25);
			this.listBoxChapter.Name = "listBoxChapter";
			this.listBoxChapter.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBoxChapter.Size = new System.Drawing.Size(163, 238);
			this.listBoxChapter.TabIndex = 14;
			// 
			// listBoxTitle
			// 
			this.listBoxTitle.FormattingEnabled = true;
			this.listBoxTitle.Location = new System.Drawing.Point(12, 25);
			this.listBoxTitle.Name = "listBoxTitle";
			this.listBoxTitle.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBoxTitle.Size = new System.Drawing.Size(163, 238);
			this.listBoxTitle.TabIndex = 13;
			this.listBoxTitle.SelectedIndexChanged += new System.EventHandler(this.listBoxTitle_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.checkBoxRemoveCredits);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.textBoxTVEpisode);
			this.panel1.Controls.Add(this.textBoxTVSeason);
			this.panel1.Controls.Add(this.radioButtonChapter);
			this.panel1.Controls.Add(this.radioButtonTitle);
			this.panel1.Location = new System.Drawing.Point(12, 384);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(335, 68);
			this.panel1.TabIndex = 23;
			// 
			// radioButtonTitle
			// 
			this.radioButtonTitle.AutoSize = true;
			this.radioButtonTitle.Checked = true;
			this.radioButtonTitle.Location = new System.Drawing.Point(3, 3);
			this.radioButtonTitle.Name = "radioButtonTitle";
			this.radioButtonTitle.Size = new System.Drawing.Size(78, 17);
			this.radioButtonTitle.TabIndex = 0;
			this.radioButtonTitle.TabStop = true;
			this.radioButtonTitle.Text = "Title Based";
			this.radioButtonTitle.UseVisualStyleBackColor = true;
			// 
			// radioButtonChapter
			// 
			this.radioButtonChapter.AutoSize = true;
			this.radioButtonChapter.Location = new System.Drawing.Point(3, 26);
			this.radioButtonChapter.Name = "radioButtonChapter";
			this.radioButtonChapter.Size = new System.Drawing.Size(95, 17);
			this.radioButtonChapter.TabIndex = 1;
			this.radioButtonChapter.TabStop = true;
			this.radioButtonChapter.Text = "Chapter Based";
			this.radioButtonChapter.UseVisualStyleBackColor = true;
			this.radioButtonChapter.CheckedChanged += new System.EventHandler(this.radioButtonChapter_CheckedChanged);
			// 
			// checkBoxRemoveCredits
			// 
			this.checkBoxRemoveCredits.AutoSize = true;
			this.checkBoxRemoveCredits.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxRemoveCredits.Enabled = false;
			this.checkBoxRemoveCredits.Location = new System.Drawing.Point(3, 49);
			this.checkBoxRemoveCredits.Name = "checkBoxRemoveCredits";
			this.checkBoxRemoveCredits.Size = new System.Drawing.Size(101, 17);
			this.checkBoxRemoveCredits.TabIndex = 44;
			this.checkBoxRemoveCredits.Text = "Remove Credits";
			this.checkBoxRemoveCredits.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(230, 5);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 13);
			this.label11.TabIndex = 42;
			this.label11.Text = "Season #:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(230, 29);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(77, 13);
			this.label12.TabIndex = 43;
			this.label12.Text = "First Episode #";
			// 
			// textBoxTVEpisode
			// 
			this.textBoxTVEpisode.Location = new System.Drawing.Point(292, 45);
			this.textBoxTVEpisode.Name = "textBoxTVEpisode";
			this.textBoxTVEpisode.Size = new System.Drawing.Size(40, 20);
			this.textBoxTVEpisode.TabIndex = 40;
			this.textBoxTVEpisode.Text = "1";
			this.textBoxTVEpisode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBoxTVSeason
			// 
			this.textBoxTVSeason.Location = new System.Drawing.Point(292, 2);
			this.textBoxTVSeason.Name = "textBoxTVSeason";
			this.textBoxTVSeason.Size = new System.Drawing.Size(40, 20);
			this.textBoxTVSeason.TabIndex = 39;
			this.textBoxTVSeason.Text = "1";
			this.textBoxTVSeason.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(240, 48);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(46, 13);
			this.label13.TabIndex = 41;
			this.label13.Text = "on Disc:";
			// 
			// FormTV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 489);
			this.Controls.Add(this.panel1);
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FormTV";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormTV";
			this.Load += new System.EventHandler(this.FormTV_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox listBoxAudio;
		private System.Windows.Forms.Button buttonForeign;
		private System.Windows.Forms.Button buttonDone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxQuality;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBoxChapter;
		private System.Windows.Forms.ListBox listBoxTitle;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox checkBoxRemoveCredits;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBoxTVEpisode;
		private System.Windows.Forms.TextBox textBoxTVSeason;
		private System.Windows.Forms.RadioButton radioButtonChapter;
		private System.Windows.Forms.RadioButton radioButtonTitle;
	}
}