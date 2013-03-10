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
	public partial class FormMovie : Form
	{
		public FormMovie()
		{
			InitializeComponent();
		}

		private void FormMovie_Load(object sender, EventArgs e)
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

		private void buttonForeign_Click(object sender, EventArgs e)
		{
			FormForeign frmForeign = new FormForeign();
			frmForeign.Show();
		}

		private void buttonDone_Click(object sender, EventArgs e)
		{
			List<Arg> argList;

			//Add to progress
			if (PB.needsSubtitles)
			{
				//Create subbed job
				argList = PB.BuildDefaultArgList("(sub)");
				argList.Add(PB.foreignAudioArg);
				argList.Add(PB.foreignSubtitleArg);
				argList.Add(new Arg("--subtitle-burn"));
				PB.AddJobToQueue(new Job(argList));

				//Create dubbed job
				argList = PB.BuildDefaultArgList("(dub)");
				argList.Add(new Arg("-a", PB.currentTitle.audioTrackList[listBoxAudio.SelectedIndex].number));
				PB.AddJobToQueue(new Job(argList));
			}
			else
			{
				//Create regular job
				argList = PB.BuildDefaultArgList();
				argList.Add(new Arg("-a", PB.currentTitle.audioTrackList[listBoxAudio.SelectedIndex].number));
				PB.AddJobToQueue(new Job(argList));
			}

			//string thing = "";
			//foreach (Job j in PB.currentMovie.jobList)
			//{
			//	thing += j.BuildArgString() + "|||||";
			//}
			//MessageBox.Show(thing);

			this.Close();
		}

		private void textBoxQuality_TextChanged(object sender, EventArgs e)
		{
			PB.quality = textBoxQuality.Text;
		}
	}
}
