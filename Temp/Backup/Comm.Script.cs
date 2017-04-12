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
	using System.IO.Ports;
	using System.IO;
	using Neo.ApplicationFramework.Tools.MessageLibrary;
	using System.Collections.Generic;
	
	public partial class Comm
	{
		public SerialPort port232;
		public SerialPort port485;
		private Timer tmr232;
		private Timer tmr485;
		private Timer tmrExpire;
		public List<AlicatFlowMeter> FlowMeters;
		public List<TrafagPressureSensor> PressSensors;
		public List<SolenoidValveController> SolenoidValves;
		public XBeeModule XBee;

		private byte[] mPacket;
		private int[] mCheckHeader = {0,0,0,0};
		private int[] mCheckHeaderFix = {255,255,255,255};
		private int _pos = 0;
		private int _totalCheckSum = 0;
		private int _msbLength = 0;
		private int _lsbLength = 0;
		private int _header = 0;
		private const int MAX_FRAME_DATA_SIZE = 256;
		private const int XB_START_BYTE = 0x7e;
		private const int PRESS_START_BYTE = 0x7f;
		private const int SOLENOID_START_BYTE = 0x80;
		Random rnd_num;
		//	private int valve_control_time_out = 0;
		public void Inilialize()
		{
			port232 = new SerialPort("COM4", 19200, Parity.None, 8, StopBits.One);
			port485 = new SerialPort("COM3", 57600, Parity.None, 8, StopBits.One);
			port485.DtrEnable = true;
			port485.RtsEnable = true;
			port485.Handshake = Handshake.None;
			tmr232 = new Timer();
			tmr485 = new Timer();
			rnd_num = new Random();
			tmrExpire = new Timer();
			tmr232.Interval = 500;
			tmr485.Interval = 500;
			tmrExpire.Interval = 2000;
			mPacket = new byte[MAX_FRAME_DATA_SIZE];
			//tmrExpire.Tick += EXPIRE_TICK;
			//tmrExpire.Enabled = false;
			tmr232.Tick += new EventHandler(RS232_TICK);
			tmr485.Tick += new EventHandler(RS485_TICK);
				
			port232.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(Receive_232);
			port485.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(Receive_485);
				
			
			FlowMeters = new List<AlicatFlowMeter>();
			PressSensors = new List<TrafagPressureSensor>();
			SolenoidValves = new List<SolenoidValveController>();	
			
			FlowMeters.Add(new AlicatFlowMeter(
				Globals.TextLibrary.FlowMeterName.Messages[0].Message,
				port232,
				Globals.Tags.meter_unit_low.Value.String,
				Globals.TextLibrary.FlowMeterAddr.Messages[0].Message,
				Globals.Tags.LowRangeMin.Value.Double,
				Globals.Tags.LowRangeMax.Value.Double));
			
			FlowMeters.Add(new AlicatFlowMeter(
				Globals.TextLibrary.FlowMeterName.Messages[1].Message,
				port232,
				Globals.Tags.meter_unit_mid.Value.String,
				Globals.TextLibrary.FlowMeterAddr.Messages[1].Message,
				Globals.Tags.MidRangeMin.Value.Double,
				Globals.Tags.MidRangeMax.Value.Double));
			
			PressSensors.Add(new TrafagPressureSensor(
				Globals.TextLibrary.PressSensorName.Messages[0].Message,
				port485,
				Globals.Tags.press_meter_unit.Value.String,
				Globals.TextLibrary.PressSensorAddr.Messages[0].Message,
				-1.0,
				Globals.Tags.Inlet_Press_Max.Value));
			
			PressSensors.Add(new TrafagPressureSensor(
				Globals.TextLibrary.PressSensorName.Messages[1].Message,
				port485,
				Globals.Tags.press_meter_unit.Value.String,
				Globals.TextLibrary.PressSensorAddr.Messages[1].Message,
				-1.0,
				Globals.Tags.Test_Press_Max.Value));
				
			SolenoidValves.Add(new SolenoidValveController(
				Globals.TextLibrary.SolenoidValveName.Messages[0].Message,
				port485,
				Globals.TextLibrary.SolenoidValveAddr.Messages[0].Message));

			SolenoidValves.Add(new SolenoidValveController(
				Globals.TextLibrary.SolenoidValveName.Messages[1].Message,
				port485,
				Globals.TextLibrary.SolenoidValveAddr.Messages[1].Message));
			
			SolenoidValves.Add(new SolenoidValveController(
				Globals.TextLibrary.SolenoidValveName.Messages[2].Message,
				port485,
				Globals.TextLibrary.SolenoidValveAddr.Messages[2].Message));	
			
			XBee = new XBeeModule("XBeeWiFi",port485);
			
			try
			{
				port232.Open();
				port485.Open();
				Globals.Tags.IsTouchScreen.Value = true;
			}
			catch
			{

                Stop();
				Globals.Tags.StartBtnEnable.Value = 1;
				MessageBox.Show("Cannot open comports, enter demo mode!");	
				Globals.Tags.IsTouchScreen.Value = false;
			}
			

			
		}
		
		public void Start()
		{
			tmr232.Enabled = true;
			tmr485.Enabled = true;
		}
		
		public void Stop()
		{
			tmr485.Enabled = false;
			tmr232.Enabled = false;
		}
		
		public void End()
		{
			port232.Close();
			port232.Close();
		}
	
		private void RS232_TICK(Object myObject, EventArgs myEventArgs) 
		{

			
			if (Globals.Tags.CurrentScreen.Value == 2)
			{
				switch((int)Globals.Tags.tmr232_control.Value)
				{
					case 0:
//						FlowMeters[0].RequestData();
						FlowMeters[0].dMassFlowRate = rnd_num.NextDouble() * 100 + 500;
						Globals.CalAndUpdate.UpdateFlowRateTag();
						Globals.Tags.tmr232_control.Value++;
						break;
					case 1:
//						FlowMeters[1].RequestData();
						FlowMeters[1].dMassFlowRate = rnd_num.NextDouble() / 10 + 0.5;
						Globals.CalAndUpdate.UpdateFlowRateTag();
						Globals.Tags.tmr232_control.Value = 0;
						break;
					case 2:
						FlowMeters[0].Zero();
						Globals.Tags.tmr232_control.Value = 0;
						break;
					case 3:
						FlowMeters[1].Zero();
						Globals.Tags.tmr232_control.Value = 0;
						break;
				}
			}
		}
		
		private void Receive_232(Object myObject, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			string strRcv = "";
			bool isError = false;
			try
			{
				strRcv = port232.ReadTo("\r");
			}
			catch
			{
				isError = true;
			}
			
			if (!isError)
			{
				for (int i = 0; i < FlowMeters.Count; i++)
				{
					FlowMeters[i].Receive(strRcv);
					
					if ((int)Globals.Tags.CurrentScreen.Value == 2)
					{
						switch(i)
						{
							case 0:

								if (FlowMeters[i].iRegResult[0].para_value > Globals.Tags.DiagMaxValueFlow11.Value.Double)
								{
									Globals.Tags.DiagMaxValueFlow11.Value = FlowMeters[i].iRegResult[0].para_value;
									Globals.Tags.DiagMaxValueFlow11Time.Value = DateTime.Now;
									Globals.PersistentVariables.SaveRecipe("Current",false);
								}

								if (FlowMeters[i].iRegResult[1].para_value > Globals.Tags.DiagMaxValueFlow12.Value.Double)
								{
									Globals.Tags.DiagMaxValueFlow12.Value = FlowMeters[i].iRegResult[1].para_value;
									Globals.Tags.DiagMaxValueFlow12Time.Value = DateTime.Now;
									Globals.PersistentVariables.SaveRecipe("Current",false);
								}
								
								if (FlowMeters[i].GetVolFlowRate() > Globals.Tags.DiagMaxValueFlow13.Value.Double)
								{
									Globals.Tags.DiagMaxValueFlow13.Value = FlowMeters[i].GetVolFlowRate();
									Globals.Tags.DiagMaxValueFlow13Time.Value = DateTime.Now;
									Globals.PersistentVariables.SaveRecipe("Current",false);
								}
								
								if (FlowMeters[i].GetMassFlowRate() > Globals.Tags.DiagMaxValueFlow14.Value.Double)
								{
									Globals.Tags.DiagMaxValueFlow14.Value = FlowMeters[i].GetMassFlowRate();
									Globals.Tags.DiagMaxValueFlow14Time.Value = DateTime.Now;
									Globals.PersistentVariables.SaveRecipe("Current",false);
								}

								if ((int)Globals.Tags.selMeter.Value == 0)
								{
									Globals.CalAndUpdate.UpdateFlowRateTag();
								}
								break;
							case 1:

								
								if (Math.Abs(Globals.Tags.RawFlowRateMid.Value.Double) < Globals.Tags.HighRangeZeroBand.Value.Double * Globals.Tags.MidRangeMax.Value.Double / 100)
								{
									Globals.Tags.RawFlowRateMid.Value = 0;
								}
								
								if (FlowMeters[i].iRegResult[0].para_value > Globals.Tags.DiagMaxValueFlow21.Value.Double)
								{
									Globals.Tags.DiagMaxValueFlow21.Value = FlowMeters[i].iRegResult[0].para_value;
									Globals.Tags.DiagMaxValueFlow21Time.Value = DateTime.Now;
									Globals.PersistentVariables.SaveRecipe("Current",false);
								}

								if (FlowMeters[i].iRegResult[1].para_value > Globals.Tags.DiagMaxValueFlow22.Value.Double)
								{
									Globals.Tags.DiagMaxValueFlow22.Value = FlowMeters[i].iRegResult[1].para_value;
									Globals.Tags.DiagMaxValueFlow22Time.Value = DateTime.Now;
									Globals.PersistentVariables.SaveRecipe("Current",false);
								}
								
								if (FlowMeters[i].GetVolFlowRate() > Globals.Tags.DiagMaxValueFlow23.Value.Double)
								{
									Globals.Tags.DiagMaxValueFlow23.Value = FlowMeters[i].GetVolFlowRate();
									Globals.Tags.DiagMaxValueFlow23Time.Value = DateTime.Now;
									Globals.PersistentVariables.SaveRecipe("Current",false);
								}
								
								if (FlowMeters[i].GetMassFlowRate() > Globals.Tags.DiagMaxValueFlow24.Value.Double)
								{
									Globals.Tags.DiagMaxValueFlow24.Value = FlowMeters[i].GetMassFlowRate();
									Globals.Tags.DiagMaxValueFlow24Time.Value = DateTime.Now;
									Globals.PersistentVariables.SaveRecipe("Current",false);
								}
								
								if ((int)Globals.Tags.selMeter.Value == 1)
								{
									Globals.CalAndUpdate.UpdateFlowRateTag();
								}
								break;
						}
					}
				}
					
			}
			
		}
		
		private void RS485_TICK(Object myObject, EventArgs myEventArgs) 
		{	
			Globals.Tags.gTimerCount.Value++;
			
			if (Globals.Tags.gTimerCount.Value.Int > 10)
			{
				Globals.Tags.RemoteDesktopIcon.Value = 0;
			}
			
			if (Globals.Tags.CurrentScreen.Value == 41 ||
                Globals.Tags.CurrentScreen.Value == 23 || 
				(Globals.Tags.CurrentScreen.Value >= 25 && Globals.Tags.CurrentScreen.Value <= 28))
			{
				switch((int)Globals.Tags.tmr485_control.Value)
				{
					case 0:
						SolenoidValves[0].Close();
						if (Globals.Tags.SolenoidCountA.Value.Int < Globals.Tags.MAXSOLENOIDCOUNT.Value.Int)
						{
							Globals.Tags.SolenoidCountA.Value++;
						}
						Globals.Tags.tmr485_control.Value++;
						break;
					case 1:
						SolenoidValves[1].Close();
						if (Globals.Tags.SolenoidCountB.Value.Int < Globals.Tags.MAXSOLENOIDCOUNT.Value.Int)
						{
							Globals.Tags.SolenoidCountB.Value++;
						}
						Globals.Tags.tmr485_control.Value++;
						break;
					case 2:
						SolenoidValves[2].Close();
						if (Globals.Tags.SolenoidCountC.Value.Int < Globals.Tags.MAXSOLENOIDCOUNT.Value.Int)
						{
							Globals.Tags.SolenoidCountC.Value++;
						}
						Globals.Tags.tmr485_control.Value = 0;
						break;
					case 4:
			     //		PressSensors[0].SendToPort(PressRequestType.Read, PressDataType.Pressure);
						Globals.Tags.tmr485_control.Value++;
						PressSensors[0].dPressure = rnd_num.NextDouble() * 20 + 100;
						Globals.CalAndUpdate.UpdateInletPressureTag();
						break;
					case 5:
				//		PressSensors[1].SendToPort(PressRequestType.Read, PressDataType.Pressure);
						PressSensors[1].dPressure = rnd_num.NextDouble() * 20 + 50;
						Globals.CalAndUpdate.UpdateTestPressureTag();
						
						Globals.Tags.tmr485_control.Value = 4;
						break;
					case 6:
						SolenoidValves[0].Close();
						if (Globals.Tags.SolenoidCountA.Value.Int < Globals.Tags.MAXSOLENOIDCOUNT.Value.Int)
						{
							Globals.Tags.SolenoidCountA.Value++;
						}
						Globals.Tags.tmr485_control.Value = 4;
						break;
					case 7:
						SolenoidValves[1].Close();
						if (Globals.Tags.SolenoidCountB.Value.Int < Globals.Tags.MAXSOLENOIDCOUNT.Value.Int)
						{
							Globals.Tags.SolenoidCountB.Value++;
						}
						Globals.Tags.tmr485_control.Value = 4;
						break;
					case 8:
						SolenoidValves[2].Close();
						
						if (Globals.Tags.SolenoidCountC.Value.Int < Globals.Tags.MAXSOLENOIDCOUNT.Value.Int)
						{
							Globals.Tags.SolenoidCountC.Value++;
						}
						Globals.Tags.tmr485_control.Value = 4;
						break;
					case 9:
						SolenoidValves[0].Open();
						if (Globals.Tags.SolenoidCountA.Value.Int < Globals.Tags.MAXSOLENOIDCOUNT.Value.Int)
						{
							Globals.Tags.SolenoidCountA.Value++;
						}
						Globals.Tags.tmr485_control.Value = 4;
						break;
					case 10:
						SolenoidValves[1].Open();
						if (Globals.Tags.SolenoidCountB.Value.Int < Globals.Tags.MAXSOLENOIDCOUNT.Value.Int)
						{
							Globals.Tags.SolenoidCountB.Value++;
						}
						Globals.Tags.tmr485_control.Value = 4;
						break;
					case 11:
						SolenoidValves[2].Open();
						if (Globals.Tags.SolenoidCountC.Value.Int < Globals.Tags.MAXSOLENOIDCOUNT.Value.Int)
						{
							Globals.Tags.SolenoidCountC.Value++;
						}
						Globals.Tags.tmr485_control.Value = 4;
						break;
					case 12:
						PressSensors[0].Zero();
						Globals.Tags.tmr485_control.Value = 4;
						break;
					case 13:
						PressSensors[1].Zero();
						Globals.Tags.tmr485_control.Value = 4;
						break;
				}
			}
			
		}
		
		private void Receive_485(Object myObject, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			int sr = 0;
                     
			while (sr != -1)
			{
				sr = port485.ReadByte();
                    

				switch (_pos)
				{
					case 0:
						if (sr == XB_START_BYTE || sr == PRESS_START_BYTE || sr == SOLENOID_START_BYTE)
						{
							Array.Clear(mPacket,0,mPacket.Length);
							_header = sr;
							_totalCheckSum = 0;
							_pos++;
						}
						else
						{
							_pos = 0;
							port485.DiscardInBuffer();
							return;
						}
						break;
					case 1:
						_msbLength = sr;
						_pos++;
						break;
					case 2:
						_lsbLength = sr;
						_pos++;
						break;
					default:
                 
						if (_pos > MAX_FRAME_DATA_SIZE)
						{
							_pos = 0;
							port485.DiscardInBuffer();
							return;
						}

						if (_pos >= (getPacketLength(_msbLength,_lsbLength) + 3))
						{
							_totalCheckSum = 0xff - _totalCheckSum & 0xff;

							if (_totalCheckSum == sr)
							{
								switch (_header)
								{
									case XB_START_BYTE:
											
										XBee.Receive(mPacket, getPacketLength(_msbLength,_lsbLength));
										_pos = 0;
										return;
									case PRESS_START_BYTE:
										PressSensors[(int)mPacket[0] - 1].Receive(mPacket, getPacketLength(_msbLength, _lsbLength));
										_pos = 0;
										return;
									case SOLENOID_START_BYTE:
										SolenoidValves[(int)mPacket[0]].Receive(mPacket, getPacketLength(_msbLength,_lsbLength));
										_pos = 0;
										return;
								}
							}
							else
							{
								_pos = 0;
							}
						}
						else
						{
							mPacket[_pos - 3] = (byte)sr;
							_totalCheckSum += sr;
							_pos++;
						}

						break;
				}

			}
			
		}
		
		static int getPacketLength(int msbL, int lsbL)
		{
			return ((msbL << 8) & 0xff) + (lsbL & 0xff);
		}
 
		static bool ArraysEqual<T>(T[] a1, T[] a2)
		{
			if (ReferenceEquals(a1, a2))
				return true;

			if (a1 == null || a2 == null)
				return false;

			if (a1.Length != a2.Length)
				return false;

			EqualityComparer<T> comparer = EqualityComparer<T>.Default;
			for (int i = 0; i < a1.Length; i++)
			{
				if (!comparer.Equals(a1[i], a2[i])) return false;
			}
			return true;
		}
		
		
	}
}
