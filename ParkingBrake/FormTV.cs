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
	public partial class FormTV : Form
	{
		public FormTV()
		{
			InitializeComponent();
		}

		private void FormTV_Load(object sender, EventArgs e)
		{
			this.Text = PB.currentMovie.name;

			//Populate title list
			listBoxTitle.DataSource = PB.currentMovie.titleList;
			listBoxTitle.SelectedIndex = PB.currentMovie.mainFeatureTitleIndex;

			//Populate chapter list and assign current title
			if (listBoxTitle.SelectedItem != null)
			{
				PB.currentTitle = PB.currentMovie.titleList[listBoxTitle.SelectedIndex];
				listBoxChapter.DataSource = PB.currentTitle.chapterList;
				listBoxAudio.DataSource = PB.currentTitle.audioTrackList;
			}

			textBoxQuality.Text = PB.quality;
		}

		private void listBoxTitle_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Populate chapter list and assign current title
			if (listBoxTitle.SelectedItem != null)
			{
				PB.currentTitle = PB.currentMovie.titleList[listBoxTitle.SelectedIndex];
				listBoxChapter.DataSource = PB.currentTitle.chapterList;
			}
		}

		private void radioButtonChapter_CheckedChanged(object sender, EventArgs e)
		{
			checkBoxRemoveCredits.Enabled = radioButtonChapter.Checked;
		}

		private void buttonForeign_Click(object sender, EventArgs e)
		{
			FormForeign frmForeign = new FormForeign();
			frmForeign.Show();
		}

		private void buttonDone_Click(object sender, EventArgs e)
		{
			List<Job> jobList;

			if (radioButtonTitle.Checked)
			{
				jobList = BuildTVTitleJobs();
			}
			else //if (radioButtonChapter.Checked)
			{
				jobList = BuildTVChapterJobs();
			}

			foreach (Job job in jobList)
			{
				PB.AddJobToQueue(job);
			}

			this.Close();
		}

		private List<Job> BuildTVTitleJobs(string foreignSuffix = "")
		{
			List<Job> jobList = new List<Job>();
			List<Arg> argList;

			string season = textBoxTVSeason.Text;
			string episode = textBoxTVEpisode.Text;
			string suffix;

			if (!foreignSuffix.Equals(""))
				foreignSuffix = " - " + foreignSuffix;

			int episodeNumber;
			if (episode.Equals(""))
				episodeNumber = 1;
			else
				episodeNumber = Convert.ToInt16(episode);

			foreach (int index in listBoxTitle.SelectedIndices)
			{
				suffix = " - " + season;
				if (episodeNumber < 10)
					suffix += "0";
				suffix += episodeNumber.ToString() + foreignSuffix;

				argList = PB.BuildDefaultArgList(suffix);
				jobList.Add(new Job(argList));

				episodeNumber++;
			}

			return jobList;
		}

		private List<Job> BuildTVChapterJobs(string foreignSuffix = "")
		{
			List<Job> jobList = new List<Job>();
			List<Arg> argList;

			string season = textBoxTVSeason.Text;
			string episode = textBoxTVEpisode.Text;
			string suffix;

			if (!foreignSuffix.Equals(""))
				foreignSuffix = " - " + foreignSuffix;

			int episodeNumber;
			if (episode.Equals(""))
				episodeNumber = 1;
			else
				episodeNumber = Convert.ToInt16(episode);

			//This algorithm was mostly trial and error, so good luck if you need to change it!  :P
			int firstEpStart = Convert.ToInt16(PB.currentTitle.chapterList[listBoxChapter.SelectedIndices[0]].number);
			int epLength = listBoxChapter.SelectedIndices.Count;
			int endOfLastChapter = listBoxChapter.Items.Count - (listBoxChapter.Items.Count % epLength);
			int epStart = firstEpStart;
			int epEnd = epStart + epLength - 1;
			while (epEnd <= endOfLastChapter)
			{
				suffix = " - " + season;
				if (episodeNumber < 10)
					suffix += "0";
				suffix += episodeNumber.ToString() + foreignSuffix;

				argList = PB.BuildDefaultArgList(suffix);
				if (checkBoxRemoveCredits.Checked)
				{
					argList.Add(new Arg("-c", (epStart + 1).ToString() + "-" + (epStart + 2).ToString()));
				}
				else
				{
					argList.Add(new Arg("-c", epStart.ToString() + "-" + epEnd.ToString()));
				}
				jobList.Add(new Job(argList));

				epStart = epStart + epLength;
				epEnd = epStart + epLength - 1;
				episodeNumber++;
			}

			return jobList;
		}
	}
}
