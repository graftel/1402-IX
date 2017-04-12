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
    
    public partial class WifiConnectToAP
    {
		
		void WifiConnectToAP_Opened(System.Object sender, System.EventArgs e)
		{
			btnOK.Visible = false;
			LinearMeter.Visible = true;
			Text2.Visible = true;	
			Thread connectAP = new Thread(new ThreadStart(update));
			Globals.Tags.wifiConnectionStatus.Value = "Initializing";
			Globals.Tags.wifiConnectAPProgress.Value = 0;
			
			connectAP.Start();
		}
		
		
		void update()
		{
			
			
			byte[] ssid = System.Text.Encoding.ASCII.GetBytes(Globals.Tags.wifiSSID.Value.String);
			
			Globals.Comm.XBee.WaitForWriteAtCmd("ID",ssid,ssid.Length);
			Globals.Tags.wifiConnectionStatus.Value = "Setup up SSID";
			Globals.Tags.wifiConnectAPProgress.Value++;
			if (Globals.Tags.wifiSecurity.Value != 0)
			{
				byte[] password = System.Text.Encoding.ASCII.GetBytes(Globals.Tags.wifiPassword.Value.String);
				Globals.Comm.XBee.WaitForWriteAtCmd("PK",password,password.Length);
				Globals.Tags.wifiConnectionStatus.Value = "Setup up password";
				Globals.Tags.wifiConnectAPProgress.Value++;
			}
			byte[] security = {(byte)Globals.Tags.wifiSecurity.Value.Int}; 
			Globals.Comm.XBee.WaitForWriteAtCmd("EE",security,1);
			Globals.Tags.wifiConnectionStatus.Value = "Setup up security";
			Globals.Tags.wifiConnectAPProgress.Value++;
			
			
			Globals.Comm.XBee.WaitForAtCmd("WR");
			Globals.Tags.wifiConnectAPProgress.Value++;
			Globals.Comm.XBee.WaitForAtCmd("AC");
			Globals.Tags.wifiConnectAPProgress.Value++;
			
			
			int retry_count = 0;
			int MAX_RETRY_COUNT = 50;
			
			Globals.Comm.XBee.WaitForAtCmd("AI");
			
			while (Globals.Comm.XBee.GetATcmd("AI").mRawData[0] != 0x00)
			{
				Globals.Tags.wifiConnectionStatus.Value =  Globals.Comm.XBee.GetAIStatus(Globals.Comm.XBee.GetATcmd("AI").mRawData[0]);
				Globals.Comm.XBee.WaitForAtCmd("AI");
				retry_count++;
				if (Globals.Tags.wifiConnectAPProgress.Value < 100)
				{
					Globals.Tags.wifiConnectAPProgress.Value+=5;
				}
				if (retry_count > MAX_RETRY_COUNT || Globals.Comm.XBee.GetATcmd("AI").mRawData[0] == 0x40)
				{
					break;
				}
				
				Thread.Sleep(500);
			}
			
			Text2.Visible = false;	
			
			if (retry_count > MAX_RETRY_COUNT)
			{
				
				Globals.Tags.wifiConnectionStatus.Value = "Time out, could not establish connection, please retry or change another access point";
				LinearMeter.Visible = false;
				btnOK.Visible = true;
			}
			else if (Globals.Comm.XBee.GetATcmd("AI").mRawData[0] == 0x40)
			{
				Globals.Tags.wifiConnectionStatus.Value = "Wrong Wi-Fi password, please try again";
				LinearMeter.Visible = false;
				btnOK.Visible = true;
			}
			else
			{
				Globals.Tags.wifiConnectionStatus.Value = "Successfully connect to \"" + Globals.Tags.wifiSSID.Value + "\"";
				LinearMeter.Visible = false;
				btnOK.Visible = true;
				
			}
		}
    }
}
