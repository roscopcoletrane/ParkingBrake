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
			this.buttonLoad = new System.Windows.Forms.Button();
			this.textBoxFolderPath = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// listBoxMovies
			// 
			this.listBoxMovies.FormattingEnabled = true;
			this.listBoxMovies.Location = new System.Drawing.Point(12, 41);
			this.listBoxMovies.Name = "listBoxMovies";
			this.listBoxMovies.Size = new System.Drawing.Size(250, 238);
			this.listBoxMovies.TabIndex = 0;
			// 
			// buttonMovie
			// 
			this.buttonMovie.Location = new System.Drawing.Point(12, 285);
			this.buttonMovie.Name = "buttonMovie";
			this.buttonMovie.Size = new System.Drawing.Size(121, 23);
			this.buttonMovie.TabIndex = 1;
			this.buttonMovie.Text = "Movie";
			this.buttonMovie.UseVisualStyleBackColor = true;
			// 
			// buttonTV
			// 
			this.buttonTV.Location = new System.Drawing.Point(141, 285);
			this.buttonTV.Name = "buttonTV";
			this.buttonTV.Size = new System.Drawing.Size(121, 23);
			this.buttonTV.TabIndex = 2;
			this.buttonTV.Text = "TV Show";
			this.buttonTV.UseVisualStyleBackColor = true;
			// 
			// buttonLoad
			// 
			this.buttonLoad.Location = new System.Drawing.Point(12, 12);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(39, 23);
			this.buttonLoad.TabIndex = 3;
			this.buttonLoad.Text = "Load";
			this.buttonLoad.UseVisualStyleBackColor = true;
			this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
			// 
			// textBoxFolderPath
			// 
			this.textBoxFolderPath.Location = new System.Drawing.Point(57, 14);
			this.textBoxFolderPath.Name = "textBoxFolderPath";
			this.textBoxFolderPath.Size = new System.Drawing.Size(205, 20);
			this.textBoxFolderPath.TabIndex = 4;
			// 
			// folderBrowserDialog
			// 
			this.folderBrowserDialog.SelectedPath = "F:\\TEST";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 314);
			this.Controls.Add(this.textBoxFolderPath);
			this.Controls.Add(this.buttonLoad);
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
		private System.Windows.Forms.Button buttonLoad;
		private System.Windows.Forms.TextBox textBoxFolderPath;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
	}
}

