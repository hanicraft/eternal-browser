using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Eternals_WebBrowser.My
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		[DebuggerStepThrough]
		public MyApplication() : base(AuthenticationMode.Windows)
		{
			this.IsSingleInstance = false;
			this.EnableVisualStyles = true;
			this.SaveMySettingsOnExit = true;
			this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[STAThread]
		internal static void Main(string[] Args)
		{
			try
			{
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			}
			finally
			{
			}
			MyProject.Application.Run(Args);
		}

		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			this.MainForm = MyProject.Forms.Form1;
		}
	}
}