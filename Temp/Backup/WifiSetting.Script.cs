//--------------------------------------------------------------
// Press F1 to get help about using script.
// To access an object that is not located in the current class, start the call with Globals.
// When using events and timers be cautious not to generate memoryleaks,
// please see the help for more information.
//---------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
	using System.Windows.Forms;
	using System;
	using System.Drawing;
	using Neo.ApplicationFramework.Tools;
	using Neo.ApplicationFramework.Common.Graphics.Logic;
	using Neo.ApplicationFramework.Controls;
	using Neo.ApplicationFramework.Interfaces;
	using System.Threading;
    
	public partial class WifiSetting
	{
		private Thread dataPoll;
		
		void WifiSetting_Opened(System.Object sender, System.EventArgs e)
		{

			Globals.Tags.wifiStatus.Value = "";
			Globals.Tags.wifiSignal.Value = 0;
			// Reset all data status
			foreach (ATcmd atCmd in Globals.Comm.XBee.atCmdSets)
			{
				atCmd.dataStatus = DataStatus.NotAvailable;
			}
			dataPoll = null;
			dataPoll = new Thread(new ThreadStart(Status_Update));
			
			dataPoll.Start();

			
		}
				
		void Status_Update()
		{
			Thread.Sleep(100);
			if (!Globals.Comm.XBee.WaitForAtCmd("AI"))
			{
				Globals.Tags.wifiStatus.Value = "Cannot connect to WiFi module";
			}
			else
			{
					switch(Globals.Comm.XBee.GetATcmd("AI").mRawData[0])
					{
						case 0x00:	 // Associated, get SSID and signal strength
							if (Globals.Comm.XBee.WaitForAtCmd("ID"))
							{
								Globals.Tags.wifiStatus.Value = "Connected to \"" + System.Text.Encoding.ASCII.GetString(Globals.Comm.XBee.GetATcmd("ID").mRawData,0,Globals.Comm.XBee.GetATcmd("ID").mRawDataLen) + "\"";
							}
						
							if (Globals.Comm.XBee.WaitForAtCmd("LM"))
							{
								byte dbValue = Globals.Comm.XBee.GetATcmd("LM").mRawData[0];
							
								int valuedb = (int)dbValue;
							
								if (dbValue == 0xff)
								{
									Globals.Tags.wifiSignal.Value = 0;
								}
								else
								{
									Globals.Tags.wifiSignal.Value = (int)dbValue * 2;
								}
							
							
							}
						
						
							break;
						default:
							Globals.Tags.wifiStatus.Value = Globals.Comm.XBee.GetAIStatus(Globals.Comm.XBee.GetATcmd("AI").mRawData[0]);
							break;				
					}
				}
			
		}
			
		
		
		void btnOK_Click(System.Object sender, System.EventArgs e)
		{
			if (Globals.Comm.XBee.GetATcmd("AI").mRawData[0] == 0x00)
			{
				Globals.Tags.GeneralConfirmMsg.Value = "WiFi module is currently connected to \"" + System.Text.Encoding.ASCII.GetString(Globals.Comm.XBee.GetATcmd("ID").mRawData,0,Globals.Comm.XBee.GetATcmd("ID").mRawDataLen) + "\", are you sure you want to disconnect it?";
				Globals.Tags.ConfirmAction.Value = 2;
				Globals.popConfirm.Show();
			}
			else
			{
				Globals.wifiSearchSSID.Show();
			}
						
		}
		

	}
}
