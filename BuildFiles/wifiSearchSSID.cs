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
    public partial class wifiSearchSSID : Neo.ApplicationFramework.Controls.Controls.Form {
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text2;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnOK;
        
        private Neo.ApplicationFramework.Controls.Controls.LinearMeterCF m_LinearMeter;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text1;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text3;
        
        private bool m_Initialized_wifiSearchSSID;
        
        public wifiSearchSSID() {
            this.InitializeComponent();
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.Adapter.Closed += new System.EventHandler(this.wifiSearchSSID_Closed);
            this.Adapter.Opened += new System.EventHandler(this.wifiSearchSSID_Opened);
            this.Opened += new System.EventHandler(this.wifiSearchSSID_Action_Opened);
            this.m_btnOK.Click += new System.EventHandler(this.m_btnOK_Action_Click);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text2);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter btnOK {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_btnOK);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.LinearMeterBaseCFAdapter LinearMeter {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.LinearMeterBaseCFAdapter>(this.m_LinearMeter);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text3 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text3);
            }
        }
        
        private void InitializeComponent() {
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            this.m_Text2 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_btnOK = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_LinearMeter = new Neo.ApplicationFramework.Controls.Controls.LinearMeterCF();
            this.m_Text1 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text3 = new Neo.ApplicationFramework.Controls.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LinearMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text3)).BeginInit();
            this.SuspendLayout();
            // 
            // wifiSearchSSID
            // 
            this.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227))))), Neo.ApplicationFramework.Interfaces.FillDirection.VerticalWithMiddleStop);
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.ThreeDBorder;
            this.ControlBox = false;
            // 
            // m_Text2
            // 
            this.m_Text2.AutoSize = false;
            this.m_Text2.BlinkDynamicsValue = false;
            this.m_Text2.EnabledDynamicsValue = true;
            this.m_Text2.FontSizePixels = 14;
            this.m_Text2.Height = 23;
            this.m_Text2.Left = 104;
            this.m_Text2.Name = "m_Text2";
            this.m_Text2.ScreenOwnerName = "wifiSearchSSID";
            this.m_Text2.Top = 86;
            this.m_Text2.VisibleDynamicsValue = true;
            this.m_Text2.Width = 355;
            this.m_Text2.WordWrap = true;
            // 
            // m_btnOK
            // 
            this.m_btnOK.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnOK.BlinkDynamicsValue = false;
            this.m_btnOK.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnOK.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_btnOK.EnabledDynamicsValue = true;
            this.m_btnOK.FontSizePixels = 18;
            this.m_btnOK.ForceTransparency = true;
            this.m_btnOK.Height = 53;
            this.m_btnOK.IndicatorMargin = null;
            this.m_btnOK.Left = 162;
            this.m_btnOK.Name = "m_btnOK";
            this.m_btnOK.RequiresTransparency = true;
            this.m_btnOK.ScreenOwnerName = "wifiSearchSSID";
            this.m_btnOK.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_btnOK.TextHeight = 22;
            this.m_btnOK.TextValue = 0D;
            this.m_btnOK.TextWidth = 127;
            this.m_btnOK.Top = 150;
            this.m_btnOK.Value = 0D;
            this.m_btnOK.VisibleDynamicsValue = true;
            this.m_btnOK.VisualPropertiesHashCode = -92855451;
            this.m_btnOK.Width = 137;
            // 
            // m_LinearMeter
            // 
            this.m_LinearMeter.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_LinearMeter.BlinkDynamicsValue = false;
            this.m_LinearMeter.EnabledDynamicsValue = true;
            this.m_LinearMeter.FontSizePixels = 12;
            this.m_LinearMeter.ForceTransparency = false;
            this.m_LinearMeter.Foreground = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_LinearMeter.Height = 75;
            this.m_LinearMeter.IndicatorColor = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(255)))), ((int)(((byte)(26))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), Neo.ApplicationFramework.Interfaces.FillDirection.VerticalWithMiddleStop);
            this.m_LinearMeter.IndicatorMargin = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(10D, 11D, 10D, 11D);
            this.m_LinearMeter.InvalidateAtValueChanged = true;
            this.m_LinearMeter.Left = 55;
            this.m_LinearMeter.MajorScaleMarginFirst = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(0D, 0D, 358D, 75D);
            this.m_LinearMeter.MajorScaleMarginSecond = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(double.NaN, double.NaN, double.NaN, double.NaN);
            this.m_LinearMeter.MajorTickCount = 6;
            this.m_LinearMeter.Maximum = 100D;
            this.m_LinearMeter.Minimum = 0D;
            this.m_LinearMeter.MinorScaleMarginFirst = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(0D, 0D, 358D, 75D);
            this.m_LinearMeter.MinorScaleMarginSecond = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(double.NaN, double.NaN, double.NaN, double.NaN);
            this.m_LinearMeter.MinorTickCount = 1;
            this.m_LinearMeter.Name = "m_LinearMeter";
            this.m_LinearMeter.Orientation = Neo.ApplicationFramework.Controls.Controls.OrientationCF.Horizontal;
            this.m_LinearMeter.RequiresTransparency = true;
            this.m_LinearMeter.ScaleColor = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_LinearMeter.ScaleVisible = false;
            this.m_LinearMeter.ScreenOwnerName = "wifiSearchSSID";
            this.m_LinearMeter.TextScaleMargin = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(0D, 0D, 358D, 75D);
            this.m_LinearMeter.Top = 107;
            this.m_LinearMeter.VisibleDynamicsValue = true;
            this.m_LinearMeter.Width = 358;
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
            this.m_Text1.ScreenOwnerName = "wifiSearchSSID";
            this.m_Text1.TextHorizontalAlignment = "Center";
            this.m_Text1.TextVerticalAlignment = "Center";
            this.m_Text1.Top = -2;
            this.m_Text1.VisibleDynamicsValue = true;
            this.m_Text1.Width = 481;
            // 
            // m_Text3
            // 
            this.m_Text3.BlinkDynamicsValue = false;
            this.m_Text3.EnabledDynamicsValue = true;
            this.m_Text3.FontSizePixels = 14;
            this.m_Text3.Height = 21;
            this.m_Text3.Left = 55;
            this.m_Text3.Name = "m_Text3";
            this.m_Text3.ScreenOwnerName = "wifiSearchSSID";
            this.m_Text3.Top = 86;
            this.m_Text3.VisibleDynamicsValue = true;
            this.m_Text3.Width = 41;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(480, 272);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "wifiSearchSSID";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_wifiSearchSSID = true;
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
            if (!m_Initialized_wifiSearchSSID) {
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
            this.DrawingPrimitives.Add(this.m_Text2);
            this.DrawingPrimitives.Add(this.m_btnOK);
            this.DrawingPrimitives.Add(this.m_LinearMeter);
            this.DrawingPrimitives.Add(this.m_Text1);
            this.DrawingPrimitives.Add(this.m_Text3);
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LinearMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text3)).EndInit();
        }
        
        private void wifiSearchSSID_Action_Opened(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("wifiSearchSSID", "Opened", "Set Analog", "Tags.CurrentScreen", "");
            Neo.ApplicationFramework.Generated.Globals.Tags.CurrentScreen.SetAnalog(47);
        }
        
        private void m_btnOK_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnOK", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(wifiSearchSSID));
            this.m_Text2.Text = resources.GetText("wifiSearchSSID.Text2.Text", "Connecting to Access Point, please wait...");
            this.m_btnOK.Text = resources.GetText("wifiSearchSSID.btnOK.Text", "OK");
            this.m_Text1.Text = resources.GetText("wifiSearchSSID.Text1.Text", "Searching Access Points");
            this.m_Text3.Text = resources.GetText("wifiSearchSSID.Text3.Text", "Status:");
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
            if (!m_Initialized_wifiSearchSSID) {
                return;
            }
            base.ApplyLanguageInitialize();
            this.ApplyLanguageInternal();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ConnectDataBindings() {
            base.ConnectDataBindings();
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding1 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.wifiConnectAPProgress"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_LinearMeter.DataBindings.Add(dynamicBinding1);
            this.m_DynamicBindings.Add(dynamicBinding1);
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding2 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.wifiConnectionStatus"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_Text2.DataBindings.Add(dynamicBinding2);
            this.m_DynamicBindings.Add(dynamicBinding2);
        }
    }
}
