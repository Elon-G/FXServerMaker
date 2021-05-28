    using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FXServer.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace FXServer
{
	[DesignerGenerated]
	public class FXServer : Form
	{
		private string str;

		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtserverfoldername")]
		private TextBox _txtserverfoldername;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtdrive")]
		private TextBox _txtdrive;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtserverport")]
		private TextBox _txtserverport;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtrconpass")]
		private TextBox _txtrconpass;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtservername")]
		private TextBox _txtservername;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtservermaxclients")]
		private TextBox _txtservermaxclients;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtlicensekey")]
		private TextBox _txtlicensekey;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("licensekeylink")]
		private Label _licensekeylink;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Panel3")]
		private Panel _Panel3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtname")]
		private Label _txtname;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Csign")]
		private Label _Csign;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("bresetall")]
		private Label _bresetall;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("bshv")]
		private NumericUpDown _bshv;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("bcreateserver")]
		private Button _bcreateserver;

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox txtserverfoldername
		{
			[CompilerGenerated]
			get
			{
				return _txtserverfoldername;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler eventHandler = txtserverfoldername_TextChanged;
				TextBox txtserverfoldername = _txtserverfoldername;
				if (txtserverfoldername != null)
				{
					((Control)txtserverfoldername).remove_TextChanged(eventHandler);
				}
				_txtserverfoldername = value;
				txtserverfoldername = _txtserverfoldername;
				if (txtserverfoldername != null)
				{
					((Control)txtserverfoldername).add_TextChanged(eventHandler);
				}
			}
		}

		[field: AccessedThroughProperty("txtdrive")]
		internal virtual TextBox txtdrive
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtserverport")]
		internal virtual TextBox txtserverport
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtrconpass")]
		internal virtual TextBox txtrconpass
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label4")]
		internal virtual Label Label4
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtservername")]
		internal virtual TextBox txtservername
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtservermaxclients")]
		internal virtual TextBox txtservermaxclients
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label6")]
		internal virtual Label Label6
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Panel2")]
		internal virtual Panel Panel2
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtlicensekey")]
		internal virtual TextBox txtlicensekey
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label licensekeylink
		{
			[CompilerGenerated]
			get
			{
				return _licensekeylink;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler eventHandler = licensekeylink_Click;
				Label licensekeylink = _licensekeylink;
				if (licensekeylink != null)
				{
					((Control)licensekeylink).remove_Click(eventHandler);
				}
				_licensekeylink = value;
				licensekeylink = _licensekeylink;
				if (licensekeylink != null)
				{
					((Control)licensekeylink).add_Click(eventHandler);
				}
			}
		}

		[field: AccessedThroughProperty("Panel3")]
		internal virtual Panel Panel3
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label txtname
		{
			[CompilerGenerated]
			get
			{
				return _txtname;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler eventHandler = txtname_Click;
				Label txtname = _txtname;
				if (txtname != null)
				{
					((Control)txtname).remove_Click(eventHandler);
				}
				_txtname = value;
				txtname = _txtname;
				if (txtname != null)
				{
					((Control)txtname).add_Click(eventHandler);
				}
			}
		}

		[field: AccessedThroughProperty("Csign")]
		internal virtual Label Csign
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Label bresetall
		{
			[CompilerGenerated]
			get
			{
				return _bresetall;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler eventHandler = bresetall_Click;
				Label bresetall = _bresetall;
				if (bresetall != null)
				{
					((Control)bresetall).remove_Click(eventHandler);
				}
				_bresetall = value;
				bresetall = _bresetall;
				if (bresetall != null)
				{
					((Control)bresetall).add_Click(eventHandler);
				}
			}
		}

		[field: AccessedThroughProperty("bshv")]
		internal virtual NumericUpDown bshv
		{
			get;
			[MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button bcreateserver
		{
			[CompilerGenerated]
			get
			{
				return _bcreateserver;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler eventHandler = bcreateserver_Click;
				Button bcreateserver = _bcreateserver;
				if (bcreateserver != null)
				{
					((Control)bcreateserver).remove_Click(eventHandler);
				}
				_bcreateserver = value;
				bcreateserver = _bcreateserver;
				if (bcreateserver != null)
				{
					((Control)bcreateserver).add_Click(eventHandler);
				}
			}
		}

		public FXServer()
			: this()
		{
			((Form)this).add_Load((EventHandler)Form1_Load);
			str = Environment.CurrentDirectory.ToString() + "\\";
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			((Form)this).set_Icon(new Icon(str + "fx\\fxicon.ico"));
		}

		private void txtserverfoldername_TextChanged(object sender, EventArgs e)
		{
			txtserverfoldername.set_Text(txtserverfoldername.get_Text().Replace(" ", ""));
			((TextBoxBase)txtserverfoldername).set_SelectionStart(checked(txtserverfoldername.get_Text().Length + 1));
		}

		private void licensekeylink_Click(object sender, EventArgs e)
		{
			Process.Start("https://keymaster.fivem.net/");
		}

		private void bresetall_Click(object sender, EventArgs e)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Invalid comparison between Unknown and I4
			if ((int)Interaction.MsgBox((object)"Reset all?", (MsgBoxStyle)4, (object)((Form)this).get_Text()) == 6)
			{
				txtserverfoldername.set_Text("ServerNameWithoutSpaces");
				txtserverport.set_Text("30120");
				txtrconpass.set_Text("changeme");
				txtservername.set_Text("Created Using FXServer Creator");
				txtservermaxclients.set_Text("32");
				txtlicensekey.set_Text("changeme");
				bshv.set_Value(Conversions.ToDecimal("0"));
			}
		}

		private void bcreateserver_Click(object sender, EventArgs e)
		{
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Invalid comparison between Unknown and I4
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			if ((int)Interaction.MsgBox((object)("Create server '" + txtservername.get_Text() + "' called '" + txtserverfoldername.get_Text() + "' in '" + txtdrive.get_Text() + "'?"), (MsgBoxStyle)4, (object)((Form)this).get_Text()) == 6)
			{
				if (Directory.Exists(txtdrive.get_Text() + txtserverfoldername.get_Text()))
				{
					Interaction.MsgBox((object)"That directory already exists?", (MsgBoxStyle)0, (object)null);
					return;
				}
				string text = str + "Main\\Server";
				string text2 = str + "Main\\cfx\\cfx-server-data-master";
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyDirectory(text, txtdrive.get_Text() + txtserverfoldername.get_Text());
				Directory.CreateDirectory(txtdrive.get_Text() + txtserverfoldername.get_Text() + "\\cfx-server-data-master");
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyDirectory(text2, txtdrive.get_Text() + txtserverfoldername.get_Text() + "\\cfx-server-data-master");
				File.Create(txtdrive.get_Text() + txtserverfoldername.get_Text() + "\\runserver.bat").Dispose();
				File.AppendAllText(txtdrive.get_Text() + txtserverfoldername.get_Text() + "\\runserver.bat", "cd /d " + txtdrive.get_Text() + txtserverfoldername.get_Text() + "\\cfx-server-data-master\r\n" + txtdrive.get_Text() + txtserverfoldername.get_Text() + "\\run.cmd +exec server.cfg");
				File.Create(txtdrive.get_Text() + txtserverfoldername.get_Text() + "\\cfx-server-data-master\\server.cfg").Dispose();
				File.AppendAllText(txtdrive.get_Text() + txtserverfoldername.get_Text() + "\\cfx-server-data-master\\server.cfg", string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("# you probably don't want to change these!\r\n# only change them if you're using a server with multiple network interfaces\r\nendpoint_add_tcp \"0.0.0.0:" + txtserverport.get_Text() + "\"\r\nendpoint_add_udp \"0.0.0.0:" + txtserverport.get_Text() + "\"\r\n", "\r\nstart mapmanager\r\nstart chat\r\nstart spawnmanager\r\nstart sessionmanager\r\nstart fivem\r\nstart hardcap\r\nstart rconlog\r\nstart scoreboard\r\nstart playernames\r\n"), "\r\nsv_scriptHookAllowed ", bshv.get_Value().ToString()), "\r\n"), "\r\n# change this\r\nrcon_password ", txtrconpass.get_Text()), "\r\n"), "\r\nsv_hostname \"", txtservername.get_Text(), "\"\r\n"), "\r\n# nested configs!\r\n#exec server_internal.cfg\r\n"), "\r\n# loading a server icon (96x96 PNG file)\r\n#load_server_icon myLogo.png\r\n"), "\r\n# convars for use from script\r\nset temp_convar \"hey world!\"\r\n"), "\r\n# disable announcing? clear out the master by uncommenting this\r\n#sv_master1 \"\r\n"), "\r\n# want to only allow players authenticated with a third-party provider like Steam?\r\n#sv_authMaxVariance 1\r\n#sv_authMinTrust 5\r\n"), "\r\n# add system admins\r\nadd_ace group.admin command allow # allow all commands\r\nadd_ace group.admin command.quit deny # but don't allow quit\r\nadd_principal identifier.steam:110000112345678 group.admin # add the admin to the group\r\n"), "\r\n# remove the # to hide player endpoints in external log output\r\n#sv_endpointprivacy true\r\n"), "\r\n# server slots limit (must be between 1 and 31)\r\nsv_maxclients ", txtservermaxclients.get_Text()), "\r\n"), "\r\n# license key for server (https://keymaster.fivem.net)\r\nsv_licensekey \"", txtlicensekey.get_Text(), "\""));
			}
		}

		private void txtname_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.gta5-mods.com/users/Remexy_");
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					((IDisposable)components).Dispose();
				}
			}
			finally
			{
				((Form)this).Dispose(disposing);
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected O, but got Unknown
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected O, but got Unknown
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected O, but got Unknown
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected O, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Expected O, but got Unknown
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected O, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected O, but got Unknown
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected O, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected O, but got Unknown
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected O, but got Unknown
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Unknown result type (might be due to invalid IL or missing references)
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			//IL_026f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0340: Unknown result type (might be due to invalid IL or missing references)
			//IL_034a: Expected O, but got Unknown
			//IL_0355: Unknown result type (might be due to invalid IL or missing references)
			//IL_037b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03be: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_041d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0470: Unknown result type (might be due to invalid IL or missing references)
			//IL_047a: Expected O, but got Unknown
			//IL_0488: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0512: Unknown result type (might be due to invalid IL or missing references)
			//IL_052d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0556: Unknown result type (might be due to invalid IL or missing references)
			//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b4: Expected O, but got Unknown
			//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_062f: Unknown result type (might be due to invalid IL or missing references)
			//IL_064d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0668: Unknown result type (might be due to invalid IL or missing references)
			//IL_0691: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ef: Expected O, but got Unknown
			//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0726: Unknown result type (might be due to invalid IL or missing references)
			//IL_076a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0788: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0820: Unknown result type (might be due to invalid IL or missing references)
			//IL_082a: Expected O, but got Unknown
			//IL_0838: Unknown result type (might be due to invalid IL or missing references)
			//IL_0861: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_08db: Unknown result type (might be due to invalid IL or missing references)
			//IL_090d: Unknown result type (might be due to invalid IL or missing references)
			//IL_092b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0946: Unknown result type (might be due to invalid IL or missing references)
			//IL_096f: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_09cd: Expected O, but got Unknown
			//IL_09db: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a74: Expected O, but got Unknown
			//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
			//IL_0abf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b11: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b97: Expected O, but got Unknown
			//IL_0ba5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bcb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c29: Expected O, but got Unknown
			//IL_0c37: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ccd: Expected O, but got Unknown
			//IL_0cd4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d12: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d56: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d67: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d82: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dc6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0df8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e32: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ecd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1084: Unknown result type (might be due to invalid IL or missing references)
			//IL_108e: Expected O, but got Unknown
			//IL_1090: Unknown result type (might be due to invalid IL or missing references)
			//IL_109d: Unknown result type (might be due to invalid IL or missing references)
			//IL_10bb: Unknown result type (might be due to invalid IL or missing references)
			Label1 = new Label();
			txtserverfoldername = new TextBox();
			txtdrive = new TextBox();
			Panel1 = new Panel();
			Label2 = new Label();
			txtserverport = new TextBox();
			Label3 = new Label();
			txtrconpass = new TextBox();
			Label4 = new Label();
			txtservername = new TextBox();
			Label5 = new Label();
			txtservermaxclients = new TextBox();
			Label6 = new Label();
			Panel2 = new Panel();
			txtlicensekey = new TextBox();
			Label7 = new Label();
			licensekeylink = new Label();
			Panel3 = new Panel();
			txtname = new Label();
			Csign = new Label();
			bresetall = new Label();
			bshv = new NumericUpDown();
			bcreateserver = new Button();
			((ISupportInitialize)bshv).BeginInit();
			((Control)this).SuspendLayout();
			Label1.set_AutoSize(true);
			((Control)Label1).set_Location(new Point(12, 17));
			((Control)Label1).set_Name("Label1");
			((Control)Label1).set_Size(new Size(170, 18));
			((Control)Label1).set_TabIndex(0);
			Label1.set_Text("Server Folder Name");
			((Control)txtserverfoldername).set_Anchor((AnchorStyles)13);
			((TextBoxBase)txtserverfoldername).set_BackColor(Color.FromArgb(55, 55, 55));
			((TextBoxBase)txtserverfoldername).set_BorderStyle((BorderStyle)1);
			((TextBoxBase)txtserverfoldername).set_ForeColor(Color.get_Silver());
			((Control)txtserverfoldername).set_Location(new Point(52, 42));
			((Control)txtserverfoldername).set_Name("txtserverfoldername");
			((Control)txtserverfoldername).set_Size(new Size(763, 25));
			((Control)txtserverfoldername).set_TabIndex(1);
			txtserverfoldername.set_Text("ServerNameWithoutSpaces");
			((TextBoxBase)txtdrive).set_BackColor(Color.FromArgb(55, 55, 55));
			((TextBoxBase)txtdrive).set_BorderStyle((BorderStyle)1);
			((TextBoxBase)txtdrive).set_ForeColor(Color.get_Silver());
			((Control)txtdrive).set_Location(new Point(15, 42));
			((Control)txtdrive).set_Name("txtdrive");
			((Control)txtdrive).set_Size(new Size(38, 25));
			((Control)txtdrive).set_TabIndex(2);
			txtdrive.set_Text("C:\\");
			((Control)Panel1).set_Anchor((AnchorStyles)13);
			Panel1.set_BorderStyle((BorderStyle)1);
			((Control)Panel1).set_Location(new Point(15, 83));
			((Control)Panel1).set_Name("Panel1");
			((Control)Panel1).set_Size(new Size(800, 2));
			((Control)Panel1).set_TabIndex(3);
			Label2.set_AutoSize(true);
			((Control)Label2).set_Font(new Font("Unispace", 10f));
			((Control)Label2).set_Location(new Point(12, 99));
			((Control)Label2).set_Name("Label2");
			((Control)Label2).set_Size(new Size(107, 16));
			((Control)Label2).set_TabIndex(4);
			Label2.set_Text("Server Port");
			((Control)txtserverport).set_Anchor((AnchorStyles)9);
			((TextBoxBase)txtserverport).set_BackColor(Color.FromArgb(55, 55, 55));
			((TextBoxBase)txtserverport).set_BorderStyle((BorderStyle)1);
			((TextBoxBase)txtserverport).set_ForeColor(Color.get_Silver());
			((Control)txtserverport).set_Location(new Point(426, 95));
			((Control)txtserverport).set_Name("txtserverport");
			((Control)txtserverport).set_Size(new Size(330, 25));
			((Control)txtserverport).set_TabIndex(5);
			txtserverport.set_Text("30120");
			txtserverport.set_TextAlign((HorizontalAlignment)2);
			Label3.set_AutoSize(true);
			((Control)Label3).set_Font(new Font("Unispace", 10f));
			((Control)Label3).set_Location(new Point(12, 133));
			((Control)Label3).set_Name("Label3");
			((Control)Label3).set_Size(new Size(305, 16));
			((Control)Label3).set_TabIndex(6);
			Label3.set_Text("Server ScriptHookV (1 by default)");
			((Control)txtrconpass).set_Anchor((AnchorStyles)9);
			((TextBoxBase)txtrconpass).set_BackColor(Color.FromArgb(55, 55, 55));
			((TextBoxBase)txtrconpass).set_BorderStyle((BorderStyle)1);
			((TextBoxBase)txtrconpass).set_ForeColor(Color.get_Salmon());
			((Control)txtrconpass).set_Location(new Point(426, 162));
			((Control)txtrconpass).set_Name("txtrconpass");
			((Control)txtrconpass).set_Size(new Size(330, 25));
			((Control)txtrconpass).set_TabIndex(10);
			txtrconpass.set_Text("changeme");
			txtrconpass.set_TextAlign((HorizontalAlignment)2);
			Label4.set_AutoSize(true);
			((Control)Label4).set_Font(new Font("Unispace", 10f));
			((Control)Label4).set_Location(new Point(12, 166));
			((Control)Label4).set_Name("Label4");
			((Control)Label4).set_Size(new Size(188, 16));
			((Control)Label4).set_TabIndex(9);
			Label4.set_Text("Server Rcon Password");
			((Control)txtservername).set_Anchor((AnchorStyles)9);
			((TextBoxBase)txtservername).set_BackColor(Color.FromArgb(55, 55, 55));
			((TextBoxBase)txtservername).set_BorderStyle((BorderStyle)1);
			((TextBoxBase)txtservername).set_ForeColor(Color.get_Silver());
			((Control)txtservername).set_Location(new Point(426, 195));
			((Control)txtservername).set_Name("txtservername");
			((Control)txtservername).set_Size(new Size(330, 25));
			((Control)txtservername).set_TabIndex(12);
			txtservername.set_Text("Created Using FXServer Creator");
			txtservername.set_TextAlign((HorizontalAlignment)2);
			Label5.set_AutoSize(true);
			((Control)Label5).set_Font(new Font("Unispace", 10f));
			((Control)Label5).set_Location(new Point(12, 199));
			((Control)Label5).set_Name("Label5");
			((Control)Label5).set_Size(new Size(368, 16));
			((Control)Label5).set_TabIndex(11);
			Label5.set_Text("Server Name (shows up in the serverlist)");
			((Control)txtservermaxclients).set_Anchor((AnchorStyles)9);
			((TextBoxBase)txtservermaxclients).set_BackColor(Color.FromArgb(55, 55, 55));
			((TextBoxBase)txtservermaxclients).set_BorderStyle((BorderStyle)1);
			((TextBoxBase)txtservermaxclients).set_ForeColor(Color.get_Silver());
			((Control)txtservermaxclients).set_Location(new Point(426, 228));
			((Control)txtservermaxclients).set_Name("txtservermaxclients");
			((Control)txtservermaxclients).set_Size(new Size(330, 25));
			((Control)txtservermaxclients).set_TabIndex(14);
			txtservermaxclients.set_Text("32");
			txtservermaxclients.set_TextAlign((HorizontalAlignment)2);
			Label6.set_AutoSize(true);
			((Control)Label6).set_Font(new Font("Unispace", 10f));
			((Control)Label6).set_Location(new Point(12, 232));
			((Control)Label6).set_Name("Label6");
			((Control)Label6).set_Size(new Size(314, 16));
			((Control)Label6).set_TabIndex(13);
			Label6.set_Text("Server Max Clients (32 by default)");
			((Control)Panel2).set_Anchor((AnchorStyles)13);
			Panel2.set_BorderStyle((BorderStyle)1);
			((Control)Panel2).set_Location(new Point(15, 268));
			((Control)Panel2).set_Name("Panel2");
			((Control)Panel2).set_Size(new Size(800, 2));
			((Control)Panel2).set_TabIndex(4);
			((Control)txtlicensekey).set_Anchor((AnchorStyles)9);
			((TextBoxBase)txtlicensekey).set_BackColor(Color.FromArgb(55, 55, 55));
			((TextBoxBase)txtlicensekey).set_BorderStyle((BorderStyle)1);
			((TextBoxBase)txtlicensekey).set_ForeColor(Color.get_DodgerBlue());
			((Control)txtlicensekey).set_Location(new Point(426, 284));
			((Control)txtlicensekey).set_Name("txtlicensekey");
			((Control)txtlicensekey).set_Size(new Size(330, 25));
			((Control)txtlicensekey).set_TabIndex(16);
			txtlicensekey.set_Text("changeme");
			txtlicensekey.set_TextAlign((HorizontalAlignment)2);
			Label7.set_AutoSize(true);
			((Control)Label7).set_Font(new Font("Unispace", 10f));
			((Control)Label7).set_Location(new Point(12, 288));
			((Control)Label7).set_Name("Label7");
			((Control)Label7).set_Size(new Size(170, 16));
			((Control)Label7).set_TabIndex(15);
			Label7.set_Text("Server License Key");
			((Control)licensekeylink).set_Anchor((AnchorStyles)9);
			licensekeylink.set_AutoSize(true);
			((Control)licensekeylink).set_Cursor(Cursors.get_Hand());
			((Control)licensekeylink).set_Font(new Font("Unispace", 8f));
			((Control)licensekeylink).set_ForeColor(Color.get_DodgerBlue());
			((Control)licensekeylink).set_Location(new Point(423, 316));
			((Control)licensekeylink).set_Name("licensekeylink");
			((Control)licensekeylink).set_Size(new Size(259, 14));
			((Control)licensekeylink).set_TabIndex(17);
			licensekeylink.set_Text("click here to register a licensekey!");
			((Control)Panel3).set_Anchor((AnchorStyles)13);
			Panel3.set_BorderStyle((BorderStyle)1);
			((Control)Panel3).set_Location(new Point(15, 342));
			((Control)Panel3).set_Name("Panel3");
			((Control)Panel3).set_Size(new Size(800, 2));
			((Control)Panel3).set_TabIndex(5);
			((Control)txtname).set_Anchor((AnchorStyles)6);
			txtname.set_AutoSize(true);
			((Control)txtname).set_Cursor(Cursors.get_Hand());
			((Control)txtname).set_Font(new Font("Unispace", 9f, (FontStyle)2));
			((Control)txtname).set_Location(new Point(35, 369));
			((Control)txtname).set_Name("txtname");
			((Control)txtname).set_Size(new Size(63, 14));
			((Control)txtname).set_TabIndex(19);
			txtname.set_Text("Remexy64");
			((Control)Csign).set_Anchor((AnchorStyles)6);
			Csign.set_AutoSize(true);
			((Control)Csign).set_Font(new Font("Microsoft YaHei UI", 11f));
			((Control)Csign).set_Location(new Point(11, 363));
			((Control)Csign).set_Name("Csign");
			((Control)Csign).set_Size(new Size(23, 20));
			((Control)Csign).set_TabIndex(20);
			Csign.set_Text("©");
			((Control)bresetall).set_Anchor((AnchorStyles)9);
			bresetall.set_AutoSize(true);
			((Control)bresetall).set_Cursor(Cursors.get_Hand());
			((Control)bresetall).set_Font(new Font("Unispace", 8f));
			((Control)bresetall).set_ForeColor(Color.get_DodgerBlue());
			((Control)bresetall).set_Location(new Point(748, 20));
			((Control)bresetall).set_Name("bresetall");
			((Control)bresetall).set_Size(new Size(70, 14));
			((Control)bresetall).set_TabIndex(21);
			bresetall.set_Text("reset all");
			((Control)bshv).set_Anchor((AnchorStyles)9);
			((UpDownBase)bshv).set_BackColor(Color.FromArgb(55, 55, 55));
			((UpDownBase)bshv).set_ForeColor(Color.get_Silver());
			((Control)bshv).set_Location(new Point(426, 129));
			bshv.set_Maximum(new decimal(new int[4]
			{
				1,
				0,
				0,
				0
			}));
			((Control)bshv).set_Name("bshv");
			((Control)bshv).set_Size(new Size(330, 25));
			((Control)bshv).set_TabIndex(22);
			((UpDownBase)bshv).set_TextAlign((HorizontalAlignment)2);
			((ButtonBase)bcreateserver).set_BackColor(Color.FromArgb(77, 77, 77));
			((ButtonBase)bcreateserver).get_FlatAppearance().set_BorderSize(0);
			((ButtonBase)bcreateserver).set_FlatStyle((FlatStyle)0);
			((Control)bcreateserver).set_Location(new Point(552, 358));
			((Control)bcreateserver).set_Name("bcreateserver");
			((Control)bcreateserver).set_Size(new Size(204, 32));
			((Control)bcreateserver).set_TabIndex(23);
			((ButtonBase)bcreateserver).set_Text("Create Server");
			((ButtonBase)bcreateserver).set_UseVisualStyleBackColor(false);
			((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 18f));
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
			((Form)this).set_BackColor(Color.FromArgb(55, 55, 55));
			((Form)this).set_ClientSize(new Size(830, 406));
			((Control)this).get_Controls().Add((Control)(object)bcreateserver);
			((Control)this).get_Controls().Add((Control)(object)bshv);
			((Control)this).get_Controls().Add((Control)(object)bresetall);
			((Control)this).get_Controls().Add((Control)(object)Csign);
			((Control)this).get_Controls().Add((Control)(object)txtname);
			((Control)this).get_Controls().Add((Control)(object)Panel3);
			((Control)this).get_Controls().Add((Control)(object)licensekeylink);
			((Control)this).get_Controls().Add((Control)(object)txtlicensekey);
			((Control)this).get_Controls().Add((Control)(object)Label7);
			((Control)this).get_Controls().Add((Control)(object)Panel2);
			((Control)this).get_Controls().Add((Control)(object)txtservermaxclients);
			((Control)this).get_Controls().Add((Control)(object)Label6);
			((Control)this).get_Controls().Add((Control)(object)txtservername);
			((Control)this).get_Controls().Add((Control)(object)Label5);
			((Control)this).get_Controls().Add((Control)(object)txtrconpass);
			((Control)this).get_Controls().Add((Control)(object)Label4);
			((Control)this).get_Controls().Add((Control)(object)Label3);
			((Control)this).get_Controls().Add((Control)(object)txtserverport);
			((Control)this).get_Controls().Add((Control)(object)Label2);
			((Control)this).get_Controls().Add((Control)(object)Panel1);
			((Control)this).get_Controls().Add((Control)(object)txtdrive);
			((Control)this).get_Controls().Add((Control)(object)txtserverfoldername);
			((Control)this).get_Controls().Add((Control)(object)Label1);
			((Control)this).set_Font(new Font("Unispace", 11f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)this).set_ForeColor(Color.get_Silver());
			((Form)this).set_Margin(new Padding(4));
			((Form)this).set_MaximizeBox(false);
			((Form)this).set_MinimumSize(new Size(846, 445));
			((Control)this).set_Name("FXServer");
			((Form)this).set_StartPosition((FormStartPosition)1);
			((Form)this).set_Text("FXServer Creator");
			((ISupportInitialize)bshv).EndInit();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
    