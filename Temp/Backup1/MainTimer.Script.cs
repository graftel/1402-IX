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
    using System.IO;
    
    public partial class MainTimer
    {	private static Timer m_timer;
		private int message_count = 0;
		private int rcrdcount = 0;
		
		public void Start()
		{
			m_timer = new Timer();
			m_timer.Interval = 500;  //fire off timer every 1 second
			m_timer.Tick += TimerTick;
			m_timer.Enabled = true;		
		}
		
		public void Stop()
		{
			m_timer.Tick -= TimerTick;
			m_timer.Enabled = false;
		}
		
		private void TimerTick(System.Object sender, System.EventArgs e)
		{
	//		Globals.Tags.MainPressDecimal.Value = 5;
	//		Globals.Tags.MainFlowRateDecimal.Value = 5;
			
			// Every 500ms
			if(Directory.Exists("\\Hard Disk"))
			{
				Globals.Tags.USBStatus.Value = 1;
			}
			else
			{
				Globals.Tags.USBStatus.Value = 0;
			}
			
			// Message on main display display after 5 seconds
			if ((int)Globals.Tags.RcrdStatus.Value == 1)
			{
				Globals.Tags.MainDisplayMessage.Value = 0;
				if (Globals.Tags.RcrdInterval.Value.Int == 1)
				{
					Globals.Tags.MainRecordMessage.Value = "Recording every " + Globals.Tags.RcrdInterval.Value.ToString() + " second";
				}
				else
				{
					Globals.Tags.MainRecordMessage.Value = "Recording every " + Globals.Tags.RcrdInterval.Value.ToString() + " seconds";
				}
				
				Globals.Tags.currentDataSetStr.Value = "Data Sets: " + Globals.Tags.currentDataSet.Value.Int.ToString();
				
			}
			else
			{
				if ((int)Globals.Tags.MainDisplayMessage.Value != 0)
				{
					message_count++;
					if (message_count >= 10)
					{
						Globals.Tags.MainDisplayMessage.Value = 0;
						message_count = 0;
					}
				
				}
			}

			
			if ((int)Globals.Tags.RcrdStatus.Value == 1)
			{
				if (rcrdcount == 0)
				{
					Globals.Recording.RecordDataPoint();
				}
				
				rcrdcount ++;
				
				if (rcrdcount >= (int)Globals.Tags.RcrdInterval.Value * 2)
				{
					rcrdcount = 0;
				}
					
			}
			
			if (Globals.Tags.CurrentScreen.Value.Int == 1)
			{
				Globals.Tags.CalDueDateVisible.Value = 	Globals.Tags.calDueDateShow.Value.Int;

				Globals.Tags.calDueDate.Value = Globals.Tags.calDueDatePers.Value.DateTime.ToString("MM/dd/yyyy");
				
				if (Globals.Tags.SystemTagDateTime.Value.DateTime.Year > Globals.Tags.calDueDatePers.Value.DateTime.Year)
				{
					Globals.Tags.calDueDateIndi.Value = 1;
				}
				else if (Globals.Tags.SystemTagDateTime.Value.DateTime.Year < Globals.Tags.calDueDatePers.Value.DateTime.Year)
				{
					Globals.Tags.calDueDateIndi.Value = 0;
				}
				else if (Globals.Tags.SystemTagDateTime.Value.DateTime.Year == Globals.Tags.calDueDatePers.Value.DateTime.Year)
				{
					if (Globals.Tags.SystemTagDateTime.Value.DateTime.Month > Globals.Tags.calDueDatePers.Value.DateTime.Month)
					{
						Globals.Tags.calDueDateIndi.Value = 1;
					}
					else if (Globals.Tags.SystemTagDateTime.Value.DateTime.Month < Globals.Tags.calDueDatePers.Value.DateTime.Month)
					{
						Globals.Tags.calDueDateIndi.Value = 0;
					}
					else if (Globals.Tags.SystemTagDateTime.Value.DateTime.Month == Globals.Tags.calDueDatePers.Value.DateTime.Month)
					{
						if (Globals.Tags.SystemTagDateTime.Value.DateTime.Day >= Globals.Tags.calDueDatePers.Value.DateTime.Day)
						{
							Globals.Tags.calDueDateIndi.Value = 1;
						}
						else if (Globals.Tags.SystemTagDateTime.Value.DateTime.Day < Globals.Tags.calDueDatePers.Value.DateTime.Day)
						{
							Globals.Tags.calDueDateIndi.Value = 0;
						}
					
					}
				}
				
				Globals.Tags.CalDueDateCheck.Value = Globals.Tags.calDueDateIndi.Value.Int;
			}
			
			
		}
    }
}
