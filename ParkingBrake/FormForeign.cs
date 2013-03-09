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
	public partial class FormForeign : Form
	{
		public FormForeign()
		{
			InitializeComponent();
		}

		private void FormForeign_Load(object sender, EventArgs e)
		{
			listBoxForeignAudio.DataSource = PB.currentTitle.audioTrackList;
			listBoxForeignSubtitle.DataSource = PB.currentTitle.subtitleTrackList;
		}

		private void checkBoxSub_CheckedChanged(object sender, EventArgs e)
		{
			panelSub.Enabled = checkBoxSub.Checked;
			PB.needsSubtitles = checkBoxSub.Checked;
		}

		private void buttonDone_Click(object sender, EventArgs e)
		{
			if (checkBoxSub.Checked)
			{
				PB.foreignAudioArg = new Arg("-a", PB.currentTitle.audioTrackList[listBoxForeignAudio.SelectedIndex].number);
				PB.foreignSubtitleArg = new Arg("-s", PB.currentTitle.subtitleTrackList[listBoxForeignSubtitle.SelectedIndex].number);
			}
			else
			{
				PB.foreignAudioArg = null;
				PB.foreignSubtitleArg = null;
			}
			this.Close();
		}
	}
}
