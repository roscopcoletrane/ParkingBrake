using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
			SecondaryThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(SecondaryThread_RunWorkerCompleted);
			SecondaryThread.WorkerReportsProgress = true;

			SecondaryThread.ProgressChanged += new ProgressChangedEventHandler(SecondaryThread_ProgressChanged);
			SecondaryThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(SecondaryThread_RunWorkerCompleted);
		}

		public void AddToQueue(Job job)
		{
			queue.Add(job);
			listBoxQueue.DataSource = queue;

			if (!SecondaryThread.IsBusy)
				SecondaryThread.RunWorkerAsync();
		}

		private void RunJobs()
		{
			while (queue.Count > 0)
			{
				//Do work, son
			}
		}

		private void SecondaryThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			//progBarQueue.Value = e.ProgressPercentage;
			if (queue.Count < listBoxQueue.Items.Count)
				queue.RemoveAt(0);
			listBoxQueue.DataSource = queue;
		}
		private void SecondaryThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (queue.Count < listBoxQueue.Items.Count)
				queue.RemoveAt(0);
			listBoxQueue.DataSource = queue;
			//progBarQueue.Value = 0;
		}
	}
}
