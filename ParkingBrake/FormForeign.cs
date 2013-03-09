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
	public partial class FormForeign : Form
	{
		public FormForeign()
		{
			InitializeComponent();
		}

		private void checkBoxSub_CheckedChanged(object sender, EventArgs e)
		{
			panelSub.Enabled = checkBoxSub.Checked;
		}

		private void checkBoxDub_CheckedChanged(object sender, EventArgs e)
		{
			panelDub.Enabled = checkBoxDub.Checked;
		}
	}
}
