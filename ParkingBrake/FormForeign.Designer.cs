namespace ParkingBrake
{
	partial class FormForeign
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
			this.checkBoxSub = new System.Windows.Forms.CheckBox();
			this.panelSub = new System.Windows.Forms.Panel();
			this.listBoxForeignSubtitle = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.listBoxForeignAudio = new System.Windows.Forms.ListBox();
			this.buttonDone = new System.Windows.Forms.Button();
			this.panelSub.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkBoxSub
			// 
			this.checkBoxSub.AutoSize = true;
			this.checkBoxSub.Location = new System.Drawing.Point(15, 12);
			this.checkBoxSub.Name = "checkBoxSub";
			this.checkBoxSub.Size = new System.Drawing.Size(105, 17);
			this.checkBoxSub.TabIndex = 0;
			this.checkBoxSub.Text = "Subtitled Version";
			this.checkBoxSub.UseVisualStyleBackColor = true;
			this.checkBoxSub.CheckedChanged += new System.EventHandler(this.checkBoxSub_CheckedChanged);
			// 
			// panelSub
			// 
			this.panelSub.Controls.Add(this.listBoxForeignSubtitle);
			this.panelSub.Controls.Add(this.label2);
			this.panelSub.Controls.Add(this.label1);
			this.panelSub.Controls.Add(this.listBoxForeignAudio);
			this.panelSub.Enabled = false;
			this.panelSub.Location = new System.Drawing.Point(12, 35);
			this.panelSub.Name = "panelSub";
			this.panelSub.Size = new System.Drawing.Size(450, 229);
			this.panelSub.TabIndex = 2;
			// 
			// listBoxForeignSubtitle
			// 
			this.listBoxForeignSubtitle.FormattingEnabled = true;
			this.listBoxForeignSubtitle.Location = new System.Drawing.Point(3, 130);
			this.listBoxForeignSubtitle.Name = "listBoxForeignSubtitle";
			this.listBoxForeignSubtitle.Size = new System.Drawing.Size(444, 95);
			this.listBoxForeignSubtitle.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Subtitle Tracks";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Audio Tracks";
			// 
			// listBoxForeignAudio
			// 
			this.listBoxForeignAudio.FormattingEnabled = true;
			this.listBoxForeignAudio.Location = new System.Drawing.Point(3, 16);
			this.listBoxForeignAudio.Name = "listBoxForeignAudio";
			this.listBoxForeignAudio.Size = new System.Drawing.Size(444, 95);
			this.listBoxForeignAudio.TabIndex = 0;
			// 
			// buttonDone
			// 
			this.buttonDone.Location = new System.Drawing.Point(400, 270);
			this.buttonDone.Name = "buttonDone";
			this.buttonDone.Size = new System.Drawing.Size(59, 23);
			this.buttonDone.TabIndex = 10;
			this.buttonDone.Text = "Done";
			this.buttonDone.UseVisualStyleBackColor = true;
			this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
			// 
			// FormForeign
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 302);
			this.Controls.Add(this.buttonDone);
			this.Controls.Add(this.panelSub);
			this.Controls.Add(this.checkBoxSub);
			this.Name = "FormForeign";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormForeign";
			this.Load += new System.EventHandler(this.FormForeign_Load);
			this.panelSub.ResumeLayout(false);
			this.panelSub.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBoxSub;
		private System.Windows.Forms.Panel panelSub;
		private System.Windows.Forms.ListBox listBoxForeignSubtitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBoxForeignAudio;
		private System.Windows.Forms.Button buttonDone;

	}
}