namespace ParkingBrake
{
	partial class FormMain
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
			this.listBoxMovies = new System.Windows.Forms.ListBox();
			this.buttonMovie = new System.Windows.Forms.Button();
			this.buttonTV = new System.Windows.Forms.Button();
			this.buttonLoadInput = new System.Windows.Forms.Button();
			this.textBoxFolderPath = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.buttonLoadOutput = new System.Windows.Forms.Button();
			this.textBoxOutputPath = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// listBoxMovies
			// 
			this.listBoxMovies.FormattingEnabled = true;
			this.listBoxMovies.Location = new System.Drawing.Point(12, 41);
			this.listBoxMovies.Name = "listBoxMovies";
			this.listBoxMovies.Size = new System.Drawing.Size(250, 238);
			this.listBoxMovies.TabIndex = 0;
			this.listBoxMovies.DoubleClick += new System.EventHandler(this.listBoxMovies_DoubleClick);
			// 
			// buttonMovie
			// 
			this.buttonMovie.Location = new System.Drawing.Point(12, 314);
			this.buttonMovie.Name = "buttonMovie";
			this.buttonMovie.Size = new System.Drawing.Size(121, 23);
			this.buttonMovie.TabIndex = 1;
			this.buttonMovie.Text = "Movie";
			this.buttonMovie.UseVisualStyleBackColor = true;
			this.buttonMovie.Click += new System.EventHandler(this.buttonMovie_Click);
			// 
			// buttonTV
			// 
			this.buttonTV.Location = new System.Drawing.Point(141, 314);
			this.buttonTV.Name = "buttonTV";
			this.buttonTV.Size = new System.Drawing.Size(121, 23);
			this.buttonTV.TabIndex = 2;
			this.buttonTV.Text = "TV Show";
			this.buttonTV.UseVisualStyleBackColor = true;
			this.buttonTV.Click += new System.EventHandler(this.buttonTV_Click);
			// 
			// buttonLoadInput
			// 
			this.buttonLoadInput.Location = new System.Drawing.Point(12, 12);
			this.buttonLoadInput.Name = "buttonLoadInput";
			this.buttonLoadInput.Size = new System.Drawing.Size(48, 23);
			this.buttonLoadInput.TabIndex = 3;
			this.buttonLoadInput.Text = "Input";
			this.buttonLoadInput.UseVisualStyleBackColor = true;
			this.buttonLoadInput.Click += new System.EventHandler(this.buttonLoadInput_Click);
			// 
			// textBoxFolderPath
			// 
			this.textBoxFolderPath.Location = new System.Drawing.Point(66, 14);
			this.textBoxFolderPath.Name = "textBoxFolderPath";
			this.textBoxFolderPath.Size = new System.Drawing.Size(196, 20);
			this.textBoxFolderPath.TabIndex = 4;
			// 
			// folderBrowserDialog
			// 
			this.folderBrowserDialog.SelectedPath = "F:\\smalltest";
			// 
			// buttonLoadOutput
			// 
			this.buttonLoadOutput.Location = new System.Drawing.Point(12, 285);
			this.buttonLoadOutput.Name = "buttonLoadOutput";
			this.buttonLoadOutput.Size = new System.Drawing.Size(48, 23);
			this.buttonLoadOutput.TabIndex = 5;
			this.buttonLoadOutput.Text = "Output";
			this.buttonLoadOutput.UseVisualStyleBackColor = true;
			this.buttonLoadOutput.Click += new System.EventHandler(this.buttonLoadOutput_Click);
			// 
			// textBoxOutputPath
			// 
			this.textBoxOutputPath.Location = new System.Drawing.Point(66, 287);
			this.textBoxOutputPath.Name = "textBoxOutputPath";
			this.textBoxOutputPath.Size = new System.Drawing.Size(196, 20);
			this.textBoxOutputPath.TabIndex = 6;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 345);
			this.Controls.Add(this.textBoxOutputPath);
			this.Controls.Add(this.buttonLoadOutput);
			this.Controls.Add(this.textBoxFolderPath);
			this.Controls.Add(this.buttonLoadInput);
			this.Controls.Add(this.buttonTV);
			this.Controls.Add(this.buttonMovie);
			this.Controls.Add(this.listBoxMovies);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ParkingBrake";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxMovies;
		private System.Windows.Forms.Button buttonMovie;
		private System.Windows.Forms.Button buttonTV;
		private System.Windows.Forms.Button buttonLoadInput;
		private System.Windows.Forms.TextBox textBoxFolderPath;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.Button buttonLoadOutput;
		private System.Windows.Forms.TextBox textBoxOutputPath;
	}
}

