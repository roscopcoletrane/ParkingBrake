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
			this.checkBoxDub = new System.Windows.Forms.CheckBox();
			this.panelSub = new System.Windows.Forms.Panel();
			this.panelDub = new System.Windows.Forms.Panel();
			this.listBoxSubAudio = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.listBoxSubSub = new System.Windows.Forms.ListBox();
			this.listBoxDubAudio = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonGo = new System.Windows.Forms.Button();
			this.panelSub.SuspendLayout();
			this.panelDub.SuspendLayout();
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
			// checkBoxDub
			// 
			this.checkBoxDub.AutoSize = true;
			this.checkBoxDub.Location = new System.Drawing.Point(15, 288);
			this.checkBoxDub.Name = "checkBoxDub";
			this.checkBoxDub.Size = new System.Drawing.Size(102, 17);
			this.checkBoxDub.TabIndex = 1;
			this.checkBoxDub.Text = "Dubbed Version";
			this.checkBoxDub.UseVisualStyleBackColor = true;
			this.checkBoxDub.CheckedChanged += new System.EventHandler(this.checkBoxDub_CheckedChanged);
			// 
			// panelSub
			// 
			this.panelSub.Controls.Add(this.listBoxSubSub);
			this.panelSub.Controls.Add(this.label2);
			this.panelSub.Controls.Add(this.label1);
			this.panelSub.Controls.Add(this.listBoxSubAudio);
			this.panelSub.Enabled = false;
			this.panelSub.Location = new System.Drawing.Point(12, 35);
			this.panelSub.Name = "panelSub";
			this.panelSub.Size = new System.Drawing.Size(450, 229);
			this.panelSub.TabIndex = 2;
			// 
			// panelDub
			// 
			this.panelDub.Controls.Add(this.label3);
			this.panelDub.Controls.Add(this.listBoxDubAudio);
			this.panelDub.Enabled = false;
			this.panelDub.Location = new System.Drawing.Point(12, 311);
			this.panelDub.Name = "panelDub";
			this.panelDub.Size = new System.Drawing.Size(450, 114);
			this.panelDub.TabIndex = 3;
			// 
			// listBoxSubAudio
			// 
			this.listBoxSubAudio.FormattingEnabled = true;
			this.listBoxSubAudio.Location = new System.Drawing.Point(3, 16);
			this.listBoxSubAudio.Name = "listBoxSubAudio";
			this.listBoxSubAudio.Size = new System.Drawing.Size(444, 95);
			this.listBoxSubAudio.TabIndex = 0;
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Subtitle Tracks";
			// 
			// listBoxSubSub
			// 
			this.listBoxSubSub.FormattingEnabled = true;
			this.listBoxSubSub.Location = new System.Drawing.Point(3, 130);
			this.listBoxSubSub.Name = "listBoxSubSub";
			this.listBoxSubSub.Size = new System.Drawing.Size(444, 95);
			this.listBoxSubSub.TabIndex = 3;
			// 
			// listBoxDubAudio
			// 
			this.listBoxDubAudio.FormattingEnabled = true;
			this.listBoxDubAudio.Location = new System.Drawing.Point(3, 16);
			this.listBoxDubAudio.Name = "listBoxDubAudio";
			this.listBoxDubAudio.Size = new System.Drawing.Size(444, 95);
			this.listBoxDubAudio.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Audio Tracks";
			// 
			// buttonGo
			// 
			this.buttonGo.Location = new System.Drawing.Point(403, 431);
			this.buttonGo.Name = "buttonGo";
			this.buttonGo.Size = new System.Drawing.Size(59, 23);
			this.buttonGo.TabIndex = 10;
			this.buttonGo.Text = "Go";
			this.buttonGo.UseVisualStyleBackColor = true;
			// 
			// FormForeign
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 462);
			this.Controls.Add(this.buttonGo);
			this.Controls.Add(this.panelDub);
			this.Controls.Add(this.panelSub);
			this.Controls.Add(this.checkBoxSub);
			this.Controls.Add(this.checkBoxDub);
			this.Name = "FormForeign";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormForeign";
			this.panelSub.ResumeLayout(false);
			this.panelSub.PerformLayout();
			this.panelDub.ResumeLayout(false);
			this.panelDub.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBoxSub;
		private System.Windows.Forms.CheckBox checkBoxDub;
		private System.Windows.Forms.Panel panelSub;
		private System.Windows.Forms.ListBox listBoxSubSub;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBoxSubAudio;
		private System.Windows.Forms.Panel panelDub;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listBoxDubAudio;
		private System.Windows.Forms.Button buttonGo;

	}
}