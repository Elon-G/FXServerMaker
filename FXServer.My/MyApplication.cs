    using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace FXServer.My
{
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		[STAThread]
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static void Main(string[] Args)
		{
			try
			{
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
			}
			finally
			{
			}
			((WindowsFormsApplicationBase)MyProject.Application).Run(Args);
		}

		[DebuggerStepThrough]
		public MyApplication()
			: this((AuthenticationMode)0)
		{
			((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
			((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
			((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
			((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
		}

		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)MyProject.Forms.FXServer);
		}
	}
}
    