using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HandBrake_API;

namespace ParkingBrake
{
	public partial class FormProgress : Form
	{
		private List<Job> queue;
		private BackgroundWorker SecondaryThread;

		public FormProgress()
		{
			InitializeComponent();
		}

		private void FormProgress_Load(object sender, EventArgs e)
		{
			queue = new List<Job>();

			SecondaryThread = new BackgroundWorker();
			SecondaryThread.DoWork += new DoWorkEventHandler(delegate { RunJobs(); });
			SecondaryThread.WorkerReportsProgress = true;

			SecondaryThread.ProgressChanged += new ProgressChangedEventHandler(SecondaryThread_ProgressChanged);
			SecondaryThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(SecondaryThread_RunWorkerCompleted);
		}

		public void AddToQueue(Job job)
		{
			this.Show();
			queue.Add(job);
			listBoxQueue.DataSource = null;
			listBoxQueue.DataSource = queue;

			if (!SecondaryThread.IsBusy)
				SecondaryThread.RunWorkerAsync();
		}

		private void RunJobs()
		{
			Job currentJob;
			while (queue.Count > 0)
			{
				//Do work, son
				currentJob = queue[0];
				queue.RemoveAt(0);
				SecondaryThread.ReportProgress(0);
				HandBrake.RunJob(currentJob);
			}
		}

		private void SecondaryThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			listBoxQueue.DataSource = null;
			listBoxQueue.DataSource = queue;
		}

		private void SecondaryThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Hide();
		}
	}
}
