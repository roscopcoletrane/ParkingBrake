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
	public static class PB
	{
		public static FormProgress frmProgress;

		public static Movie currentMovie;
		public static Title currentTitle;

		public static bool sub;
		public static Arg foreignAudio;
		public static Arg foreignSubtitle;

		public static void SetDefault()
		{
			currentTitle = null;
			sub = false;
			foreignAudio = null;
			foreignSubtitle = null;
		}

		public static void ShowProgress()
		{
			frmProgress.Show();
		}

		public static void AddJobToQueue(Job job)
		{
			frmProgress.AddToQueue(job);
		}
	}
}
