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
		private Movie currentMovie;

		public FormMovie()
		{
			InitializeComponent();
		}

		public FormMovie(Movie mov)
		{
			InitializeComponent();

			currentMovie = mov;

			//Populate title list
			listBoxTitle.DataSource = currentMovie.titleList;
			listBoxTitle.SelectedIndex = currentMovie.mainFeatureTitleIndex;

			//Populate chapter list
			if (listBoxTitle.SelectedItem != null)
				listBoxChapter.DataSource = currentMovie.titleList[listBoxTitle.SelectedIndex].chapterList;

			//MessageBox.Show(currentMovie.mainFeatureTitleNumber + "/" + currentMovie.mainFeatureTitleIndex.ToString());
		}

		private void buttonGo_Click(object sender, EventArgs e)
		{
			if (checkBoxForeign.Checked)
			{
				FormForeign frmForeign = new FormForeign();
				frmForeign.Show();
			}
			else
				this.Close();
		}

		private void listBoxTitle_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxTitle.SelectedIndex >= 0)
				listBoxChapter.DataSource = currentMovie.titleList[listBoxTitle.SelectedIndex].chapterList;
		}
	}
}
