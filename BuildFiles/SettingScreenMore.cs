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
    public partial class SettingScreenMore : Neo.ApplicationFramework.Controls.Controls.Form {
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button5;
        
        private Neo.ApplicationFramework.Controls.Controls.RectangleCF m_Rectangle;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button11;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button3;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button;
        
        private bool m_Initialized_SettingScreenMore;
        
        public SettingScreenMore() {
            this.InitializeComponent();
            this.Opened += new System.EventHandler(this.SettingScreenMore_Action_Opened);
            this.m_Button5.Click += new System.EventHandler(this.m_Button5_Action_Click);
            this.m_Button11.Click += new System.EventHandler(this.m_Button11_Action_Click);
            this.m_Button3.Click += new System.EventHandler(this.m_Button3_Action_Click);
            this.m_Button.Click += new System.EventHandler(this.m_Button_Action_Click);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button5 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button5);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ShapeCFAdapter Rectangle {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ShapeCFAdapter>(this.m_Rectangle);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button11 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button11);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button3 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button3);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button);
            }
        }
        
        private void InitializeComponent() {
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper2 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper3 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper4 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            this.m_Button5 = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Rectangle = new Neo.ApplicationFramework.Controls.Controls.RectangleCF();
            this.m_Text = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Button11 = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Button3 = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Button = new Neo.ApplicationFramework.Controls.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingScreenMore
            // 
            this.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), Neo.ApplicationFramework.Interfaces.FillDirection.VerticalWithMiddleStop);
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.ThreeDBorder;
            this.ControlBox = false;
            // 
            // m_Button5
            // 
            this.m_Button5.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button5.BlinkDynamicsValue = false;
            this.m_Button5.Bold = true;
            this.m_Button5.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button5.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_Button5.EnabledDynamicsValue = true;
            this.m_Button5.FontFamily = "Arial";
            this.m_Button5.FontSizePixels = 16;
            this.m_Button5.ForceTransparency = true;
            this.m_Button5.Height = 71;
            this.m_Button5.IndicatorMargin = null;
            this.m_Button5.Left = 240;
            this.m_Button5.Name = "m_Button5";
            this.m_Button5.RequiresTransparency = true;
            this.m_Button5.ScreenOwnerName = "SettingScreenMore";
            this.m_Button5.StyleName = "Chrome";
            this.m_Button5.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_Button5.TextHeight = 38;
            this.m_Button5.TextValue = 0D;
            this.m_Button5.TextWidth = 142;
            this.m_Button5.Top = 128;
            this.m_Button5.Value = 0D;
            this.m_Button5.Visible = false;
            this.m_Button5.VisualPropertiesHashCode = -980272093;
            this.m_Button5.Width = 148;
            this.m_Button5.WordWrap = true;
            // 
            // m_Rectangle
            // 
            this.m_Rectangle.BitmapEffect = new Neo.ApplicationFramework.Common.Graphics.Logic.BitmapEffectCF();
            this.m_Rectangle.BlinkDynamicsValue = false;
            this.m_Rectangle.EnabledDynamicsValue = true;
            this.m_Rectangle.Fill = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Rectangle.Height = 42;
            this.m_Rectangle.Left = -3;
            this.m_Rectangle.Name = "m_Rectangle";
            this.m_Rectangle.ScreenOwnerName = "SettingScreenMore";
            this.m_Rectangle.Stroke = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Rectangle.Top = -5;
            this.m_Rectangle.VisibleDynamicsValue = true;
            this.m_Rectangle.Width = 485;
            // 
            // m_Text
            // 
            this.m_Text.BlinkDynamicsValue = false;
            this.m_Text.Bold = true;
            this.m_Text.EnabledDynamicsValue = true;
            this.m_Text.FontFamily = "Arial";
            this.m_Text.FontSizePixels = 20;
            this.m_Text.Height = 21;
            this.m_Text.Left = 131;
            this.m_Text.Name = "m_Text";
            this.m_Text.ScreenOwnerName = "SettingScreenMore";
            this.m_Text.Top = 3;
            this.m_Text.VisibleDynamicsValue = true;
            this.m_Text.Width = 109;
            // 
            // m_Button11
            // 
            this.m_Button11.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button11.BlinkDynamicsValue = false;
            this.m_Button11.Bold = true;
            this.m_Button11.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button11.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_Button11.EnabledDynamicsValue = true;
            this.m_Button11.FontFamily = "Arial";
            this.m_Button11.FontSizePixels = 16;
            this.m_Button11.ForceTransparency = true;
            this.m_Button11.Height = 65;
            this.m_Button11.IndicatorMargin = null;
            this.m_Button11.Left = 12;
            this.m_Button11.Name = "m_Button11";
            this.m_Button11.RequiresTransparency = true;
            this.m_Button11.ScreenOwnerName = "SettingScreenMore";
            this.m_Button11.StyleName = "Chrome";
            this.m_Button11.SymbolIntervalMapper = symbolintervalmapper2;
            this.m_Button11.TextHeight = 19;
            this.m_Button11.TextValue = 0D;
            this.m_Button11.TextWidth = 126;
            this.m_Button11.Top = 200;
            this.m_Button11.Value = 0D;
            this.m_Button11.VisibleDynamicsValue = true;
            this.m_Button11.VisualPropertiesHashCode = 1150685811;
            this.m_Button11.Width = 132;
            // 
            // m_Button3
            // 
            this.m_Button3.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button3.BlinkDynamicsValue = false;
            this.m_Button3.Bold = true;
            this.m_Button3.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button3.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_Button3.EnabledDynamicsValue = true;
            this.m_Button3.FontFamily = "Arial";
            this.m_Button3.FontSizePixels = 14;
            this.m_Button3.ForceTransparency = true;
            this.m_Button3.Height = 65;
            this.m_Button3.IndicatorMargin = null;
            this.m_Button3.Left = 169;
            this.m_Button3.Name = "m_Button3";
            this.m_Button3.RequiresTransparency = true;
            this.m_Button3.ScreenOwnerName = "SettingScreenMore";
            this.m_Button3.StyleName = "Chrome";
            this.m_Button3.SymbolIntervalMapper = symbolintervalmapper3;
            this.m_Button3.TextHeight = 16;
            this.m_Button3.TextValue = 0D;
            this.m_Button3.TextWidth = 126;
            this.m_Button3.Top = 45;
            this.m_Button3.Value = 0D;
            this.m_Button3.VisibleDynamicsValue = true;
            this.m_Button3.VisualPropertiesHashCode = 215664303;
            this.m_Button3.Width = 132;
            // 
            // m_Button
            // 
            this.m_Button.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button.BlinkDynamicsValue = false;
            this.m_Button.Bold = true;
            this.m_Button.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_Button.EnabledDynamicsValue = true;
            this.m_Button.FontFamily = "Arial";
            this.m_Button.FontSizePixels = 14;
            this.m_Button.ForceTransparency = true;
            this.m_Button.Height = 65;
            this.m_Button.IndicatorMargin = null;
            this.m_Button.Left = 12;
            this.m_Button.Name = "m_Button";
            this.m_Button.RequiresTransparency = true;
            this.m_Button.ScreenOwnerName = "SettingScreenMore";
            this.m_Button.StyleName = "Chrome";
            this.m_Button.SymbolIntervalMapper = symbolintervalmapper4;
            this.m_Button.TextHeight = 16;
            this.m_Button.TextValue = 0D;
            this.m_Button.TextWidth = 126;
            this.m_Button.Top = 45;
            this.m_Button.Value = 0D;
            this.m_Button.VisibleDynamicsValue = true;
            this.m_Button.VisualPropertiesHashCode = 215664303;
            this.m_Button.Width = 132;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(480, 272);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "SettingScreenMore";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_SettingScreenMore = true;
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
            if (!m_Initialized_SettingScreenMore) {
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
            this.DrawingPrimitives.Add(this.m_Button5);
            this.DrawingPrimitives.Add(this.m_Rectangle);
            this.DrawingPrimitives.Add(this.m_Text);
            this.DrawingPrimitives.Add(this.m_Button11);
            this.DrawingPrimitives.Add(this.m_Button3);
            this.DrawingPrimitives.Add(this.m_Button);
            ((System.ComponentModel.ISupportInitialize)(this.m_Button5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button)).EndInit();
        }
        
        private void SettingScreenMore_Action_Opened(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("SettingScreenMore", "Opened", "Set Analog", "Tags.CurrentScreen", "");
            Neo.ApplicationFramework.Generated.Globals.Tags.CurrentScreen.SetAnalog(37);
        }
        
        private void m_Button5_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button5", "Click", "Show Screen", "PressDecayScreen", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.PressDecayScreen.Show();
        }
        
        private void m_Button11_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button11", "Click", "Show Screen", "SettingScreen", "");
            Neo.ApplicationFramework.Generated.Globals.SettingScreen.Show();
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button11", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_Button3_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button3", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button3", "Click", "Show Screen", "BuzzerConfig", "");
            Neo.ApplicationFramework.Generated.Globals.BuzzerConfig.Show();
        }
        
        private void m_Button_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button", "Click", "Show Screen", "WifiSetting", "");
            Neo.ApplicationFramework.Generated.Globals.WifiSetting.Show();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(SettingScreenMore));
            this.m_Button5.Text = resources.GetText("SettingScreenMore.Button5.Text", "PRESSURE DECAY");
            this.m_Text.Text = resources.GetText("SettingScreenMore.Text.Text", "ADVANCE SETTINGS");
            this.m_Button11.Text = resources.GetText("SettingScreenMore.Button11.Text", "BACK");
            this.m_Button3.Text = resources.GetText("SettingScreenMore.Button3.Text", "MISC");
            this.m_Button.Text = resources.GetText("SettingScreenMore.Button.Text", "WI-FI");
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
            if (!m_Initialized_SettingScreenMore) {
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