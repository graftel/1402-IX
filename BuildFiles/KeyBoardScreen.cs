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
    public partial class KeyBoardScreen : Neo.ApplicationFramework.Controls.Controls.Form {
        
        private Neo.ApplicationFramework.Controls.Controls.AnalogNumeric m_AnalogNumeric;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text;
        
        private bool m_Initialized_KeyBoardScreen;
        
        public KeyBoardScreen() {
            this.InitializeComponent();
            this.Button.Click += new System.EventHandler(this.Button_Click);
            this.Opened += new System.EventHandler(this.KeyBoardScreen_Action_Opened);
            this.m_Button.Click += new System.EventHandler(this.m_Button_Action_Click);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter AnalogNumeric {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter>(this.m_AnalogNumeric);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text);
            }
        }
        
        private void InitializeComponent() {
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            this.m_AnalogNumeric = new Neo.ApplicationFramework.Controls.Controls.AnalogNumeric();
            this.m_Button = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Text = new Neo.ApplicationFramework.Controls.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_AnalogNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).BeginInit();
            this.SuspendLayout();
            // 
            // KeyBoardScreen
            // 
            this.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.SingleBorder;
            this.ControlBox = false;
            // 
            // m_AnalogNumeric
            // 
            this.m_AnalogNumeric.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200))))), Neo.ApplicationFramework.Interfaces.FillDirection.VerticalBottomToTop);
            this.m_AnalogNumeric.BitmapEffect = new Neo.ApplicationFramework.Common.Graphics.Logic.BitmapEffectCF(2, 0, Neo.ApplicationFramework.Common.Graphics.Logic.LightAngle.LowerRight);
            this.m_AnalogNumeric.BlinkDynamicsValue = false;
            this.m_AnalogNumeric.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AnalogNumeric.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_AnalogNumeric.DisplayFormat = Neo.ApplicationFramework.Interfaces.AnalogNumericDisplayFormat.String;
            this.m_AnalogNumeric.EnabledDynamicsValue = true;
            this.m_AnalogNumeric.FontSizePixels = 18;
            this.m_AnalogNumeric.Height = 42;
            this.m_AnalogNumeric.Left = 31;
            this.m_AnalogNumeric.Name = "m_AnalogNumeric";
            this.m_AnalogNumeric.ScreenOwnerName = "KeyBoardScreen";
            this.m_AnalogNumeric.Top = 71;
            this.m_AnalogNumeric.VisibleDynamicsValue = true;
            this.m_AnalogNumeric.Width = 285;
            // 
            // m_Button
            // 
            this.m_Button.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200))))), Neo.ApplicationFramework.Interfaces.FillDirection.VerticalTopToBottom);
            this.m_Button.BlinkDynamicsValue = false;
            this.m_Button.Bold = true;
            this.m_Button.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_Button.EnabledDynamicsValue = true;
            this.m_Button.FontSizePixels = 20;
            this.m_Button.ForceTransparency = true;
            this.m_Button.Height = 42;
            this.m_Button.IndicatorMargin = null;
            this.m_Button.Left = 118;
            this.m_Button.Name = "m_Button";
            this.m_Button.RequiresTransparency = true;
            this.m_Button.ScreenOwnerName = "KeyBoardScreen";
            this.m_Button.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_Button.TextHeight = 24;
            this.m_Button.TextValue = 0D;
            this.m_Button.TextWidth = 98;
            this.m_Button.Top = 141;
            this.m_Button.Value = 0D;
            this.m_Button.VisibleDynamicsValue = true;
            this.m_Button.VisualPropertiesHashCode = 2000972380;
            this.m_Button.Width = 108;
            // 
            // m_Text
            // 
            this.m_Text.BlinkDynamicsValue = false;
            this.m_Text.EnabledDynamicsValue = true;
            this.m_Text.FontSizePixels = 18;
            this.m_Text.Height = 21;
            this.m_Text.Left = 37;
            this.m_Text.Name = "m_Text";
            this.m_Text.ScreenOwnerName = "KeyBoardScreen";
            this.m_Text.Top = 29;
            this.m_Text.VisibleDynamicsValue = true;
            this.m_Text.Width = 171;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ClientSize = new System.Drawing.Size(348, 195);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(60, 17);
            this.ModalScreen = true;
            this.Name = "KeyBoardScreen";
            this.PopupScreen = true;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "Default";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_KeyBoardScreen = true;
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
            if (!m_Initialized_KeyBoardScreen) {
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
            this.DrawingPrimitives.Add(this.m_AnalogNumeric);
            this.DrawingPrimitives.Add(this.m_Button);
            this.DrawingPrimitives.Add(this.m_Text);
            ((System.ComponentModel.ISupportInitialize)(this.m_AnalogNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).EndInit();
        }
        
        private void KeyBoardScreen_Action_Opened(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("KeyBoardScreen", "Opened", "Set Analog", "Tags.CurrentScreen", "");
            Neo.ApplicationFramework.Generated.Globals.Tags.CurrentScreen.SetAnalog(22);
        }
        
        private void m_Button_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(KeyBoardScreen));
            this.m_Button.Text = resources.GetText("KeyBoardScreen.Button.Text", "ADD");
            this.m_Text.Text = resources.GetText("KeyBoardScreen.Text.Text", "Press below textbox to enter text");
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
            if (!m_Initialized_KeyBoardScreen) {
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
