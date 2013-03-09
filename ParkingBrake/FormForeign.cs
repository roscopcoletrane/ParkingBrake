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
		}

		private void checkBoxSub_CheckedChanged(object sender, EventArgs e)
		{
			panelSub.Enabled = checkBoxSub.Checked;
			PB.sub = checkBoxSub.Checked;
			if (PB.sub)
			{
				PB.foreignAudio = new Arg("-a", PB.currentTitle.audioTrackList[listBoxForeignAudio.SelectedIndex].number);
				PB.foreignSubtitle = new Arg("-s", PB.currentTitle.subtitleTrackList[listBoxForeignSubtitle.SelectedIndex].number);
			}
		}
	}
}
