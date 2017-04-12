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
    
    public partial class wifiSearchSSID
    {
		int searchStatus = 0;
		
		void wifiSearchSSID_Opened(System.Object sender, System.EventArgs e)
		{
			
			Globals.Comm.XBee.GetATcmd("NR").dataStatus = DataStatus.NotAvailable;
			Globals.Comm.XBee.GetATcmd("AS").dataStatus = DataStatus.NotAvailable;
			Globals.Comm.XBee.ssidInfo.Clear();
			
			
			btnOK.Visible = false;
			LinearMeter.Visible = true;
			Text2.Visible = true;	
			searchStatus = 0;
			Thread connectAP = new Thread(new ThreadStart(update));
			Globals.Tags.wifiConnectionStatus.Value = "Initializing";
			Globals.Tags.wifiConnectAPProgress.Value = 0;
			
			connectAP.Start();
		}
		
		void update()
		{
			
			int times_out = 0;
			int MAX_COUNT = 5;

			Globals.Comm.XBee.WaitForAtCmd("NR");
			
			Globals.Tags.wifiConnectionStatus.Value = "Reset";
			
			Globals.Tags.wifiConnectAPProgress.Value = Globals.Tags.wifiConnectAPProgress.Value + 2;
			
			while(searchStatus == 0)
			{		
				if(Globals.Comm.XBee.WaitForAtCmd("AI"))
				{
					if (Globals.Comm.XBee.GetATcmd("AI").mRawData[0] == 0x23)
					{
						searchStatus = 1;
						Globals.Tags.wifiConnectionStatus.Value = "Searching";
					}
				}

				Globals.Tags.wifiConnectAPProgress.Value = Globals.Tags.wifiConnectAPProgress.Value + 2;
				
				times_out++;
				
				Thread.Sleep(500);
				
				if (times_out > MAX_COUNT)
				{
					searchStatus = 2;
				}
			}
			
			
			switch (searchStatus)
			{
				case 1:
					if (Globals.Comm.XBee.WaitForAtCmd("AS"))
					{
						Thread.Sleep(500);
						if (Globals.Comm.XBee.ssidInfo.Count > 0)	
						{
							btnOK.Visible = true;
							LinearMeter.Visible = false;
							Globals.Tags.wifiConnectionStatus.Value = "Found " + Globals.Comm.XBee.ssidInfo.Count.ToString() + " access points";
						}
						else
						{
							Globals.Comm.XBee.WaitForAtCmd("FR");
							
							Globals.Comm.XBee.WaitForAtCmd("NR");
							
							Globals.Comm.XBee.WaitForAtCmd("AS");
							
							if (Globals.Comm.XBee.ssidInfo.Count > 0)	
							{
								btnOK.Visible = true;
								LinearMeter.Visible = false;
								Globals.Tags.wifiConnectionStatus.Value = "Found " + Globals.Comm.XBee.ssidInfo.Count.ToString() + " access points";
							}
							else
							{
								Globals.Tags.wifiConnectionStatus.Value = "Cannot find access point, click OK to go back";
							}
						}
				
						
					}
					break;
				case 2:
					
					btnOK.Visible = true;
					LinearMeter.Visible = false;
					
					Globals.Tags.wifiConnectionStatus.Value = "Cannot find access point, click OK to go back and retry";
					
					break;
				
			}
			
	
		}
		
		void btnOK_Click(System.Object sender, System.EventArgs e)
		{
			switch(searchStatus)
			{
				case 1:
					Globals.WifiQuickSetup.Show();
					break;
				case 2:
					Globals.WifiSetting.Show();
					break;
			}
		}
		
		
		
    }
}
