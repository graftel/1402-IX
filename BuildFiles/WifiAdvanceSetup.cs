//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated {
    using Neo.ApplicationFramework.Controls.Controls;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
    using Neo.ApplicationFramework.Tools.Security;
    using Neo.ApplicationFramework.Tools.Actions;
    using Neo.ApplicationFramework.Common.MultiLanguage;
    
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class WifiAdvanceSetup : Neo.ApplicationFramework.Controls.Controls.Form {
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text1;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button1;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button2;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnPrev;
        
        private bool m_Initialized_WifiAdvanceSetup;
        
        public WifiAdvanceSetup() {
            this.InitializeComponent();
            this.Opened += new System.EventHandler(this.WifiAdvanceSetup_Action_Opened);
            this.m_Button1.Click += new System.EventHandler(this.m_Button1_Action_Click);
            this.m_Button2.Click += new System.EventHandler(this.m_Button2_Action_Click);
            this.m_btnPrev.Click += new System.EventHandler(this.m_btnPrev_Action_Click);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button2);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter btnPrev {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_btnPrev);
            }
        }
        
        private void InitializeComponent() {
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper2 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper3 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            this.m_Text1 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Button1 = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Button2 = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_btnPrev = new Neo.ApplicationFramework.Controls.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnPrev)).BeginInit();
            this.SuspendLayout();
            // 
            // WifiAdvanceSetup
            // 
            this.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), Neo.ApplicationFramework.Interfaces.FillDirection.VerticalWithMiddleStop);
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.ThreeDBorder;
            this.ControlBox = false;
            // 
            // m_Text1
            // 
            this.m_Text1.AutoSize = false;
            this.m_Text1.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Text1.BlinkDynamicsValue = false;
            this.m_Text1.EnabledDynamicsValue = true;
            this.m_Text1.FontSizePixels = 20;
            this.m_Text1.Height = 42;
            this.m_Text1.Left = -1;
            this.m_Text1.Name = "m_Text1";
            this.m_Text1.ScreenOwnerName = "WifiAdvanceSetup";
            this.m_Text1.TextHorizontalAlignment = "Center";
            this.m_Text1.TextVerticalAlignment = "Center";
            this.m_Text1.Top = -2;
            this.m_Text1.VisibleDynamicsValue = true;
            this.m_Text1.Width = 481;
            // 
            // m_Button1
            // 
            this.m_Button1.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button1.BlinkDynamicsValue = false;
            this.m_Button1.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button1.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_Button1.EnabledDynamicsValue = true;
            this.m_Button1.FontSizePixels = 18;
            this.m_Button1.ForceTransparency = true;
            this.m_Button1.Height = 84;
            this.m_Button1.IndicatorMargin = null;
            this.m_Button1.Left = 254;
            this.m_Button1.Name = "m_Button1";
            this.m_Button1.RequiresTransparency = true;
            this.m_Button1.ScreenOwnerName = "WifiAdvanceSetup";
            this.m_Button1.StyleName = "Chrome";
            this.m_Button1.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_Button1.TextHeight = 22;
            this.m_Button1.TextValue = 0D;
            this.m_Button1.TextWidth = 152;
            this.m_Button1.Top = 76;
            this.m_Button1.Value = 0D;
            this.m_Button1.VisibleDynamicsValue = true;
            this.m_Button1.VisualPropertiesHashCode = 103067543;
            this.m_Button1.Width = 158;
            // 
            // m_Button2
            // 
            this.m_Button2.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button2.BlinkDynamicsValue = false;
            this.m_Button2.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button2.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_Button2.EnabledDynamicsValue = true;
            this.m_Button2.FontSizePixels = 18;
            this.m_Button2.ForceTransparency = true;
            this.m_Button2.Height = 84;
            this.m_Button2.IndicatorMargin = null;
            this.m_Button2.Left = 66;
            this.m_Button2.Name = "m_Button2";
            this.m_Button2.RequiresTransparency = true;
            this.m_Button2.ScreenOwnerName = "WifiAdvanceSetup";
            this.m_Button2.StyleName = "Chrome";
            this.m_Button2.SymbolIntervalMapper = symbolintervalmapper2;
            this.m_Button2.TextHeight = 22;
            this.m_Button2.TextValue = 0D;
            this.m_Button2.TextWidth = 152;
            this.m_Button2.Top = 76;
            this.m_Button2.Value = 0D;
            this.m_Button2.VisibleDynamicsValue = true;
            this.m_Button2.VisualPropertiesHashCode = 103067543;
            this.m_Button2.Width = 158;
            // 
            // m_btnPrev
            // 
            this.m_btnPrev.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(146)))), ((int)(((byte)(214))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnPrev.BlinkDynamicsValue = false;
            this.m_btnPrev.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnPrev.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_btnPrev.EnabledDynamicsValue = true;
            this.m_btnPrev.FontSizePixels = 18;
            this.m_btnPrev.ForceTransparency = true;
            this.m_btnPrev.Height = 53;
            this.m_btnPrev.IndicatorMargin = null;
            this.m_btnPrev.Left = 15;
            this.m_btnPrev.Name = "m_btnPrev";
            this.m_btnPrev.RequiresTransparency = true;
            this.m_btnPrev.ScreenOwnerName = "WifiAdvanceSetup";
            this.m_btnPrev.StyleName = "Glossy";
            this.m_btnPrev.SymbolIntervalMapper = symbolintervalmapper3;
            this.m_btnPrev.TextHeight = 22;
            this.m_btnPrev.TextValue = 0D;
            this.m_btnPrev.TextWidth = 146;
            this.m_btnPrev.Top = 209;
            this.m_btnPrev.Value = 0D;
            this.m_btnPrev.VisibleDynamicsValue = true;
            this.m_btnPrev.VisualPropertiesHashCode = -1443624886;
            this.m_btnPrev.Width = 152;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(480, 272);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "WifiAdvanceSetup";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_WifiAdvanceSetup = true;
            this.AddControlsAndPrimitives();
            this.ResumeLayout(false);
        }
        
        protected override Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF CreateInstanceData() {
            System.Collections.Generic.List<Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF> instanceList = new System.Collections.Generic.List<Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF>(1);
            instanceList.Add(this.CreateInstanceData_Default());
            Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF aliasInstances = new Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF();
            aliasInstances.Instances = instanceList.ToArray();
            return aliasInstances;
        }
        
        private Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF CreateInstanceData_Default() {
            Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF aliasinstancecf1 = new Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF();
            aliasinstancecf1.Name = "Default";
            aliasinstancecf1.Values = new Neo.ApplicationFramework.Common.Alias.Entities.AliasValueCF[0];
            return aliasinstancecf1;
        }
        
        protected override void BindAliases() {
        }
        
        protected override void Dispose(bool disposing) {
            base.Dispose(disposing);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddControlsAndPrimitives() {
            if (!m_Initialized_WifiAdvanceSetup) {
                return;
            }
            this.AddControls();
            this.AddDrawingPrimitives();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddControls() {
            base.AddControls();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddDrawingPrimitives() {
            base.AddDrawingPrimitives();
            this.DrawingPrimitives.Add(this.m_Text1);
            this.DrawingPrimitives.Add(this.m_Button1);
            this.DrawingPrimitives.Add(this.m_Button2);
            this.DrawingPrimitives.Add(this.m_btnPrev);
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnPrev)).EndInit();
        }
        
        private void WifiAdvanceSetup_Action_Opened(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("WifiAdvanceSetup", "Opened", "Set Analog", "Tags.CurrentScreen", "");
            Neo.ApplicationFramework.Generated.Globals.Tags.CurrentScreen.SetAnalog(42);
        }
        
        private void m_Button1_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button1", "Click", "Show Screen", "WifiManualSetup", "");
            Neo.ApplicationFramework.Generated.Globals.WifiManualSetup.Show();
        }
        
        private void m_Button2_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button2", "Click", "Show Screen", "WifiSoftAPSetup", "");
            Neo.ApplicationFramework.Generated.Globals.WifiSoftAPSetup.Show();
        }
        
        private void m_btnPrev_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnPrev", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnPrev", "Click", "Show Screen", "WifiSetting", "");
            Neo.ApplicationFramework.Generated.Globals.WifiSetting.Show();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(WifiAdvanceSetup));
            this.m_Text1.Text = resources.GetText("WifiAdvanceSetup.Text1.Text", "Advance Setup");
            this.m_Button1.Text = resources.GetText("WifiAdvanceSetup.Button1.Text", "Manual Setup");
            this.m_Button2.Text = resources.GetText("WifiAdvanceSetup.Button2.Text", "Soft AP Mode");
            this.m_btnPrev.Text = resources.GetText("WifiAdvanceSetup.btnPrev.Text", "BACK");
            this.ApplyResourcesOnForm();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected override void ApplyLanguage() {
            if (((Neo.ApplicationFramework.Interfaces.IScreen)(this)).IsCachedDeactivated) {
                return;
            }
            this.ApplyLanguageInternal();
            base.ApplyLanguage();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ApplyLanguageInitialize() {
            if (!m_Initialized_WifiAdvanceSetup) {
                return;
            }
            base.ApplyLanguageInitialize();
            this.ApplyLanguageInternal();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ConnectDataBindings() {
            base.ConnectDataBindings();
        }
    }
}
