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

		public static bool needsSubtitles;
		public static Arg foreignAudioArg;
		public static Arg foreignSubtitleArg;
		public static string quality;

		public static string inputPath;
		public static string outputPath;

		public static void SetDefault()
		{
			currentTitle = null;
			needsSubtitles = false;
			foreignAudioArg = null;
			foreignSubtitleArg = null;
		}

		public static void ShowProgress()
		{
			frmProgress.Show();
		}

		public static void AddJobToQueue(Job job)
		{
			frmProgress.AddToQueue(job);
		}

		public static List<Arg> BuildDefaultArgList(string outputSuffix = "")
		{
			List<Arg> argList = new List<Arg>();

			//Adds leading space to suffix if needed
			if ((!outputSuffix.Equals("")) && (!outputSuffix.StartsWith(" ")))
				outputSuffix = " " + outputSuffix;

			argList.Add(new Arg("-q", quality));
			argList.Add(new Arg("-e", "x264"));
			argList.Add(new Arg("-m"));	//Chapter markers
			argList.Add(new Arg("-5"));	//decomb filter
			argList.Add(new Arg("-t", currentTitle.number));
			argList.Add(new Arg("-i", "\"" + inputPath + "\\" + currentMovie.name + "\""));
			argList.Add(new Arg("-o", "\"" + outputPath + "\\" + currentMovie.name + outputSuffix + ".mp4\""));

			return argList;
		}
	}
}
