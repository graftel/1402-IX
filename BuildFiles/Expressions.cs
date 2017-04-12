//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
	using Neo.ApplicationFramework.Tools.Actions;
	
	
	public partial class Expressions : Neo.ApplicationFramework.Tools.Expressions.ExpressionManager
	{
		
		public Expressions()
		{
			this.InitializeComponent();
			this.ApplyLanguageInternal();
		}
		
		private void InitializeComponent()
		{
			this.ConnectDataBindings();
		}
		
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		public override void ConnectDataBindings()
		{
			base.ConnectDataBindings();
		}
		
		private void InitializeObjectCreations()
		{
		}
		
		private void InitializeBeginInits()
		{
		}
		
		private void InitializeEndInits()
		{
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue AddText(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return "FIRMWARE" + value;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue CelsiusToFahrenheit(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return (value*(9F/5F))+32;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue Cosinus(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue Log(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return System.Math.Sqrt(value);
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue ddd(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue aaa(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = "SERIAL#" + Globals.Tags.serial.Value;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue firmware(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = "FIRMWARE " + Globals.Tags.firmware.Value;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue zzz(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = "SERIAL# " + Globals.Tags.serial.Value;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue GetPressDecimal(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue selet_name(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue FahrenheitToCelsius(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return (value-32)*5F/9F;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue aaaa(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = (int)Globals.Tags.InletPressIndicator.Value == 1 ? "Inlet Pressure" : "Test Pressure";
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue low_limit(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = (double)Globals.Tags.Stab_low_green.Value + 0.01;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue lowerLimit(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = 0.01;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue upperlimit(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = 99.96;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue diaggif1(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = Globals.Tags.DiagProgress.Value >= 6 && Globals.Tags.DiagProgress.Value <= 15 ? 1 : 0;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue diaggif2(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = Globals.Tags.DiagProgress.Value >= 16 && Globals.Tags.DiagProgress.Value <= 25 ? 1 : 0;;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue diaggif3(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = Globals.Tags.DiagProgress.Value >= 26 && Globals.Tags.DiagProgress.Value <= 31 ? 1 : 0;;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue stage3(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = Globals.Tags.DiagProgress.Value >= 26 && Globals.Tags.DiagProgress.Value <= 31 ? 1 : 0;;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue diagpic2(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = Globals.Tags.DiagProgress.Value >= 26 ? 1 : 0;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue diagpic3(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = Globals.Tags.DiagProgress.Value >= 32 ? 1 : 0;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue diagpic1(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = Globals.Tags.DiagStage.Value > 0 ? 1 : 0;;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue stage1(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = Globals.Tags.DiagStage.Value > 0 ? 1 : 0;;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue stage2(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = Globals.Tags.DiagStage.Value > 2 ? 1 : 0;;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue usbstatuscheck(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = Globals.Tags.USBStatus.Value == 1 ? "USB ON" : "USB OFF";
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue MaximumFontSize(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = (Globals.Tags.BackFlowIndicator.Value == 1) || (Globals.Tags.MainUnderRangeEnable.Value == 1) ? 26 : 38;;
		}
		
		public Neo.ApplicationFramework.Interfaces.VariantValue ZeroButtonText(Neo.ApplicationFramework.Interfaces.VariantValue value)
		{
			return value = Globals.Tags.selMode.Value == 0 ? "Zero\nPressure" : (Globals.Tags.selMode.Value == 1 ? "Zero\nLow" : "Zero\nHigh");
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(Expressions));
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected override void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
			base.ApplyLanguage();
		}
	}
}
