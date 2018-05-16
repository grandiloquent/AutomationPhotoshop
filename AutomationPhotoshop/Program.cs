
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using Photoshop;
using Helpers;

namespace AutomationPhotoshop
{
	class Program
	{
		public static void Main(string[] args)
		{
//			var element=@"D:\Documents\SharpDevelop Projects\AutomationPhotoshop\AutomationPhotoshop\bin\Debug\1.JPG";
//					RunAction(element,element,"psycho.atn".GetCommandLinePath(),"Auto White Balance","psycho");
//		
			foreach (var element in args) {
				if(element.IsJPGFile())
					// Burned Face Tone
					// Auto White Balance
					RunAction(element,element.ChangeParentName("Processed"),"psycho.atn".GetCommandLinePath(),"Burned Face Tone","psycho");
			}
		}
		public static void RunAction(string orig, string target, string actionFileName,string action, string group)
		{

			ApplicationClass app = new ApplicationClass();
			app.DisplayDialogs=PsDialogModes.psDisplayNoDialogs;
			
			//app.Load(actionFileName);
			var doc = app.Open(orig);
		
			app.DoAction(action, group);
			var options = new JPEGSaveOptions();
			options.Quality=9;
			
			doc.SaveAs(target, options, true, PsExtensionType.psLowercase);
			doc.Close(PsSaveOptions.psDoNotSaveChanges);
			//doc.Close(PsSaveOptions.psSaveChanges);
		}
	}
	
	 

}