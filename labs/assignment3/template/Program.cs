using System;
using System.Windows.Forms;

namespace Lab3
{
	class MainClass
	{
		[STAThread]
		public static void Main (string[] args)
		{
			var ui = new UI ();
			Application.Run (ui);
		}
	}
}
