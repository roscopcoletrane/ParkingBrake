using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingBrake
{
	public partial class FormMovie : Form
	{
		public FormMovie()
		{
			InitializeComponent();
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
	}
}
