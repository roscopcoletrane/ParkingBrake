using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HandBrake_API;

namespace ParkingBrake
{
	public partial class FormMain : Form
	{
		private BackgroundWorker SecondaryThread;
		public List<Movie> movieList;

		FormMovie frmMovie;
		FormTV frmTV;

		public FormMain()
		{
			InitializeComponent();
			frmMovie = new FormMovie();
			frmTV = new FormTV();
			PB.frmProgress = new FormProgress();
			PB.quality = "20";
		}

		private void buttonLoadInput_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				textBoxFolderPath.Text = folderBrowserDialog.SelectedPath;
				PB.inputPath = folderBrowserDialog.SelectedPath;

				if (textBoxOutputPath.Text.Equals(""))
				{
					textBoxOutputPath.Text = folderBrowserDialog.SelectedPath;
					PB.outputPath = folderBrowserDialog.SelectedPath;
				}

				//Load Movies
				InitMovieList(folderBrowserDialog.SelectedPath);
			}
		}

		private void buttonLoadOutput_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				textBoxOutputPath.Text = folderBrowserDialog.SelectedPath;
				PB.outputPath = folderBrowserDialog.SelectedPath;
			}
		}

		#region Load Movie List

		private void InitMovieList(string path)
		{
			//If list/ListBox is already populated, clear it out
			listBoxMovies.DataSource = null;
			listBoxMovies.DataSource = movieList;
			listBoxMovies.Refresh();

			textBoxFolderPath.Text = path;

			movieList = new List<Movie>();

			SecondaryThread = new BackgroundWorker();
			SecondaryThread.DoWork += new DoWorkEventHandler(delegate { LoadMovies(path); });
			SecondaryThread.WorkerReportsProgress = true;

			if (!SecondaryThread.IsBusy)
				SecondaryThread.RunWorkerAsync();

			SecondaryThread.ProgressChanged += new ProgressChangedEventHandler(SecondaryThread_ProgressChanged);
			SecondaryThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(SecondaryThread_RunWorkerCompleted);
		}

		private void LoadMovies(string path)
		{
			DirectoryInfo pathDirInfo = new DirectoryInfo(path);
			DirectoryInfo[] movieFolders = null;

			if (pathDirInfo.Exists == true)
			{
				movieFolders = pathDirInfo.GetDirectories();
				int progress = 0;
				int progMax = movieFolders.Length;

				foreach (DirectoryInfo i in movieFolders)
				{
					Movie mov = new Movie(i.Name, path + "\\");

					if (mov.GatherInfo())
						movieList.Add(mov);

					progress++;
					SecondaryThread.ReportProgress(progress / progMax);
				}
			}
		}

		private void SecondaryThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			listBoxMovies.DataSource = null;
			listBoxMovies.DataSource = movieList;
			listBoxMovies.Refresh();
		}

		private void SecondaryThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			//MessageBox.Show("Loading Complete!");

			listBoxMovies.DataSource = null;
			listBoxMovies.DataSource = movieList;
			listBoxMovies.Refresh();
		}

		#endregion

		private void buttonMovie_Click(object sender, EventArgs e)
		{
			if ((listBoxMovies.SelectedIndex >= 0) && (!frmMovie.Visible) && (!frmTV.Visible))
			{
				PB.currentMovie = movieList[listBoxMovies.SelectedIndex];
				PB.SetDefault();

				//Load movie dialog
				frmMovie = new FormMovie();
				frmMovie.Show();
			}
		}

		private void buttonTV_Click(object sender, EventArgs e)
		{
			if ((listBoxMovies.SelectedIndex >= 0) && (!frmMovie.Visible) && (!frmTV.Visible))
			{
				PB.currentMovie = movieList[listBoxMovies.SelectedIndex];
				PB.SetDefault();

				//Load TV dialog
				frmTV = new FormTV();
				frmTV.Show();
			}
		}

		private void listBoxMovies_DoubleClick(object sender, EventArgs e)
		{
			if (listBoxMovies.SelectedIndex >= 0)
			{
				PB.PlayMovieWithVLC(movieList[listBoxMovies.SelectedIndex]);
			}
		}
	}
}
