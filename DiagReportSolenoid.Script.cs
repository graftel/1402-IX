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
	using System.Reflection;
	using Neo.ApplicationFramework.Controls.Script;
    
    public partial class DiagReportSolenoid
    {
		
		
		void DiagReportSolenoid_Opened(System.Object sender, System.EventArgs e)
		{
			Globals.Tags.SettingSel.Value = 1;
			Display((int)Globals.Tags.SettingSel.Value);
		}
		
		
		void Group_MouseDown(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Globals.Tags.SettingSel.Value = 1;
			Display((int)Globals.Tags.SettingSel.Value);
		}
		
		void Group1_MouseDown(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Globals.Tags.SettingSel.Value = 2;
			Display((int)Globals.Tags.SettingSel.Value);
		}
		
		void Group2_MouseDown(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Globals.Tags.SettingSel.Value = 3;
			Display((int)Globals.Tags.SettingSel.Value);
		}
		
		
		void Display(int scrIndex)
		{
			
			for (int i = 1; i < 3; i++)
			{
				TextControlCFAdapter currentTextBox = GetTextBox("m_lblReport" + i.ToString());
				
				switch(Globals.Comm.SolenoidValves[scrIndex - 1].solenoidResult[i - 1].para_result)
				{
					case ParaStatus.NotAvailable:
						currentTextBox.Text = "-";
						currentTextBox.Fill = new BrushCF(Color.Red);
						lblReport0.Text = "-";
						lblReport0.Fill = new BrushCF(Color.Red);
						break;
					case ParaStatus.Pass:
						currentTextBox.Text = Globals.Comm.SolenoidValves[scrIndex - 1].solenoidResult[i - 1].para_value.ToString("F2") + " V";
						currentTextBox.Fill = new BrushCF(Color.Transparent);
						lblReport0.Text = "OK";
						lblReport0.Fill = new BrushCF(Color.Transparent);
						break;
					case ParaStatus.Warning:
						currentTextBox.Text = Globals.Comm.SolenoidValves[scrIndex - 1].solenoidResult[i - 1].para_value.ToString("F2") + " V";
						currentTextBox.Fill = new BrushCF(Color.Yellow);
						lblReport0.Text = "Warning";
						lblReport0.Fill = new BrushCF(Color.Yellow);
						break;
				}
			}
		}
		
		
		
		public TextControlCFAdapter GetTextBox(string txtName){
			//Get the type of this screen
			Type FormType = this.GetType();
         
			//Get the field from the type
			FieldInfo field = FormType.GetField(txtName,BindingFlags.NonPublic | BindingFlags.Instance);
			if( field != null ){
             
				//Use the instance of this screen to get the instance of the field
				Neo.ApplicationFramework.Controls.Controls.Label lb;
				lb = (Neo.ApplicationFramework.Controls.Controls.Label) field.GetValue(this);
               
				//Cast the Label into a Text control. This code was pulled from the TQTERM_A7 function and can be
				//found in the cs file associated with this screen.
				TextControlCFAdapter myTxt;
				myTxt = this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(lb);
				return myTxt;
			}
			return null;
		}
		

		



		
    }
}
