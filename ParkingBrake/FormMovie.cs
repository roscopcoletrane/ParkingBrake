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

			//Populate title list
			listBoxTitle.DataSource = PB.currentMovie.titleList;
			listBoxTitle.SelectedIndex = PB.currentMovie.mainFeatureTitleIndex;

			//Populate chapter list and assign current title
			if (listBoxTitle.SelectedItem != null)
			{
				PB.currentTitle = PB.currentMovie.titleList[listBoxTitle.SelectedIndex];
				listBoxChapter.DataSource = PB.currentTitle.chapterList;
			}

			//MessageBox.Show(currentMovie.mainFeatureTitleNumber + "/" + currentMovie.mainFeatureTitleIndex.ToString());
		}

		private void listBoxTitle_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Populate chapter list and assign current title
			if (listBoxTitle.SelectedIndex >= 0)
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
			//Add to progress
			if (PB.sub)
			{
				//Create subbed job

				//Create dubbed job

			}
			else
			{
				//Create regular job
			}
			this.Close();
		}
	}
}
