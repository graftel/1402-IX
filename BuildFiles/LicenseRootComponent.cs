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
	
	
	public partial class LicenseRootComponent : Neo.ApplicationFramework.Tools.License.LicenseRootComponent
	{
		
		public LicenseRootComponent()
		{
			this.InitializeComponent();
			this.ApplyLanguageInternal();
		}
		
		private void InitializeComponent()
		{
			Neo.ApplicationFramework.Tools.License.PanelHardwareIdList panelhardwareidlist1 = new Neo.ApplicationFramework.Tools.License.PanelHardwareIdList();
			Neo.ApplicationFramework.Tools.License.PanelHardwareIdList panelhardwareidlist2 = new Neo.ApplicationFramework.Tools.License.PanelHardwareIdList();
			Neo.ApplicationFramework.Tools.License.PanelHardwareIdList panelhardwareidlist3 = new Neo.ApplicationFramework.Tools.License.PanelHardwareIdList();
			Neo.ApplicationFramework.Tools.License.PanelHardwareIdList panelhardwareidlist4 = new Neo.ApplicationFramework.Tools.License.PanelHardwareIdList();
			Neo.ApplicationFramework.Tools.License.PanelHardwareIdList panelhardwareidlist5 = new Neo.ApplicationFramework.Tools.License.PanelHardwareIdList();
			Neo.ApplicationFramework.Tools.License.PanelHardwareIdList panelhardwareidlist6 = new Neo.ApplicationFramework.Tools.License.PanelHardwareIdList();
			// 
			// LicenseRootComponent
			// 
			panelhardwareidlist1.IdList.Add(23);
			panelhardwareidlist1.IdList.Add(24);
			panelhardwareidlist1.IdList.Add(25);
			panelhardwareidlist1.IdList.Add(32);
			panelhardwareidlist1.IdList.Add(33);
			panelhardwareidlist1.IdList.Add(34);
			panelhardwareidlist1.IdList.Add(37);
			panelhardwareidlist2.IdList.Add(26);
			panelhardwareidlist2.IdList.Add(27);
			panelhardwareidlist2.IdList.Add(28);
			panelhardwareidlist2.IdList.Add(38);
			panelhardwareidlist2.IdList.Add(39);
			panelhardwareidlist2.IdList.Add(40);
			panelhardwareidlist2.IdList.Add(47);
			panelhardwareidlist2.IdList.Add(48);
			panelhardwareidlist2.IdList.Add(48);
			panelhardwareidlist3.IdList.Add(29);
			panelhardwareidlist3.IdList.Add(30);
			panelhardwareidlist3.IdList.Add(31);
			panelhardwareidlist4.IdList.Add(20);
			panelhardwareidlist4.IdList.Add(21);
			panelhardwareidlist4.IdList.Add(22);
			panelhardwareidlist5.IdList.Add(74);
			panelhardwareidlist6.IdList.Add(18);
			panelhardwareidlist6.IdList.Add(19);
			this.PanelHardwareIDs.Add(Neo.ApplicationFramework.Interfaces.PanelTypeGroup.TxA, panelhardwareidlist1);
			this.PanelHardwareIDs.Add(Neo.ApplicationFramework.Interfaces.PanelTypeGroup.TxB, panelhardwareidlist2);
			this.PanelHardwareIDs.Add(Neo.ApplicationFramework.Interfaces.PanelTypeGroup.TxC, panelhardwareidlist3);
			this.PanelHardwareIDs.Add(Neo.ApplicationFramework.Interfaces.PanelTypeGroup.TAx, panelhardwareidlist4);
			this.PanelHardwareIDs.Add(Neo.ApplicationFramework.Interfaces.PanelTypeGroup.PC, panelhardwareidlist5);
			this.PanelHardwareIDs.Add(Neo.ApplicationFramework.Interfaces.PanelTypeGroup.QTermAx, panelhardwareidlist6);
			this.ProductFamilyRegistryPath = "SOFTWARE\\Beijer Electronics AB\\iX Developer 2\\Install";
			this.ProjectPanelName = "iX T4A";
			this.ProjectPanelTypeGroup = Neo.ApplicationFramework.Interfaces.PanelTypeGroup.TxA;
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
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(LicenseRootComponent));
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected override void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
			base.ApplyLanguage();
		}
	}
}
