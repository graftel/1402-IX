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
    public partial class RcrdInterval : BackRcrd {
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text2;
        
        private Neo.ApplicationFramework.Controls.Controls.Line m_Line;
        
        private Neo.ApplicationFramework.Controls.Controls.AnalogNumeric m_lblMin;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button22;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button23;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text15;
        
        private Neo.ApplicationFramework.Controls.Controls.AnalogNumeric m_lblSec;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button1;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text;
        
        private bool m_Initialized_RcrdInterval;
        
        public RcrdInterval() {
            this.InitializeComponent();
            this.Button22.Click += new System.EventHandler(this.Button22_Click);
            this.Button23.Click += new System.EventHandler(this.Button23_Click);
            this.Button.Click += new System.EventHandler(this.Button_Click);
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            this.Adapter.Closed += new System.EventHandler(this.RcrdInterval_Closed);
            this.Adapter.Opened += new System.EventHandler(this.RcrdInterval_Opened);
            this.Opened += new System.EventHandler(this.RcrdInterval_Action_Opened);
            this.m_Button22.Click += new System.EventHandler(this.m_Button22_Action_Click);
            this.m_Button23.Click += new System.EventHandler(this.m_Button23_Action_Click);
            this.m_Button.Click += new System.EventHandler(this.m_Button_Action_Click);
            this.m_Button1.Click += new System.EventHandler(this.m_Button1_Action_Click);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text2);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.LineCFAdapter Line {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.LineCFAdapter>(this.m_Line);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter lblMin {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter>(this.m_lblMin);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button22 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button22);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button23 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button23);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text15 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text15);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter lblSec {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter>(this.m_lblSec);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text);
            }
        }
        
        private void InitializeComponent() {
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper2 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper3 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper4 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            this.m_Text2 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Line = new Neo.ApplicationFramework.Controls.Controls.Line();
            this.m_lblMin = new Neo.ApplicationFramework.Controls.Controls.AnalogNumeric();
            this.m_Button22 = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Button23 = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Text15 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_lblSec = new Neo.ApplicationFramework.Controls.Controls.AnalogNumeric();
            this.m_Button = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Button1 = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Text = new Neo.ApplicationFramework.Controls.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lblMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lblSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).BeginInit();
            this.SuspendLayout();
            // 
            // RcrdInterval
            // 
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.ThreeDBorder;
            this.ControlBox = false;
            // 
            // m_Text2
            // 
            this.m_Text2.AutoSize = false;
            this.m_Text2.BlinkDynamicsValue = false;
            this.m_Text2.EnabledDynamicsValue = true;
            this.m_Text2.FontFamily = "Arial";
            this.m_Text2.FontSizePixels = 18;
            this.m_Text2.Height = 27;
            this.m_Text2.Left = 125;
            this.m_Text2.Name = "m_Text2";
            this.m_Text2.ScreenOwnerName = "RcrdInterval";
            this.m_Text2.TextVerticalAlignment = "Center";
            this.m_Text2.Top = 38;
            this.m_Text2.VisibleDynamicsValue = true;
            this.m_Text2.Width = 341;
            // 
            // m_Line
            // 
            this.m_Line.BlinkDynamicsValue = false;
            this.m_Line.EnabledDynamicsValue = true;
            this.m_Line.Fill = null;
            this.m_Line.Name = "m_Line";
            this.m_Line.ScreenOwnerName = "RcrdInterval";
            this.m_Line.Stroke = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Line.VisibleDynamicsValue = true;
            this.m_Line.X1 = 134;
            this.m_Line.X2 = 466;
            this.m_Line.Y1 = 65;
            this.m_Line.Y2 = 65;
            // 
            // m_lblMin
            // 
            this.m_lblMin.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_lblMin.BitmapEffect = new Neo.ApplicationFramework.Common.Graphics.Logic.BitmapEffectCF(2, 0, Neo.ApplicationFramework.Common.Graphics.Logic.LightAngle.LowerRight);
            this.m_lblMin.BlinkDynamicsValue = false;
            this.m_lblMin.Bold = true;
            this.m_lblMin.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_lblMin.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_lblMin.EnabledDynamicsValue = true;
            this.m_lblMin.FontSizePixels = 20;
            this.m_lblMin.Height = 48;
            this.m_lblMin.Left = 227;
            this.m_lblMin.MaxValue = 60D;
            this.m_lblMin.Name = "m_lblMin";
            this.m_lblMin.NumberOfDecimals = 0;
            this.m_lblMin.ScreenOwnerName = "RcrdInterval";
            this.m_lblMin.Top = 97;
            this.m_lblMin.ValidateValueOnInput = true;
            this.m_lblMin.VisibleDynamicsValue = true;
            this.m_lblMin.Width = 117;
            // 
            // m_Button22
            // 
            this.m_Button22.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button22.BlinkDynamicsValue = false;
            this.m_Button22.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button22.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_Button22.EnabledDynamicsValue = true;
            this.m_Button22.FontSizePixels = 9;
            this.m_Button22.ForceTransparency = true;
            this.m_Button22.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_Button22.Height = 48;
            this.m_Button22.IndicatorMargin = null;
            this.m_Button22.Left = 344;
            this.m_Button22.Name = "m_Button22";
            this.m_Button22.RequiresTransparency = true;
            this.m_Button22.ScreenOwnerName = "RcrdInterval";
            this.m_Button22.StyleName = "Glossy";
            this.m_Button22.SymbolHeight = 42;
            this.m_Button22.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_Button22.SymbolName = "path2985";
            this.m_Button22.SymbolWidth = 36;
            this.m_Button22.TextHeight = 11;
            this.m_Button22.TextValue = 0D;
            this.m_Button22.TextWidth = 50;
            this.m_Button22.Top = 97;
            this.m_Button22.Value = 0D;
            this.m_Button22.VisibleDynamicsValue = true;
            this.m_Button22.VisualPropertiesHashCode = 1363860157;
            this.m_Button22.Width = 56;
            // 
            // m_Button23
            // 
            this.m_Button23.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button23.BlinkDynamicsValue = false;
            this.m_Button23.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button23.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_Button23.EnabledDynamicsValue = true;
            this.m_Button23.FontSizePixels = 9;
            this.m_Button23.ForceTransparency = true;
            this.m_Button23.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_Button23.Height = 48;
            this.m_Button23.IndicatorMargin = null;
            this.m_Button23.Left = 171;
            this.m_Button23.Name = "m_Button23";
            this.m_Button23.RequiresTransparency = true;
            this.m_Button23.ScreenOwnerName = "RcrdInterval";
            this.m_Button23.StyleName = "Glossy";
            this.m_Button23.SymbolHeight = 42;
            this.m_Button23.SymbolIntervalMapper = symbolintervalmapper2;
            this.m_Button23.SymbolName = "path29851";
            this.m_Button23.SymbolWidth = 36;
            this.m_Button23.TextHeight = 11;
            this.m_Button23.TextValue = 0D;
            this.m_Button23.TextWidth = 50;
            this.m_Button23.Top = 97;
            this.m_Button23.Value = 0D;
            this.m_Button23.VisibleDynamicsValue = true;
            this.m_Button23.VisualPropertiesHashCode = -1538366071;
            this.m_Button23.Width = 56;
            // 
            // m_Text15
            // 
            this.m_Text15.AutoSize = false;
            this.m_Text15.BlinkDynamicsValue = false;
            this.m_Text15.EnabledDynamicsValue = true;
            this.m_Text15.FontSizePixels = 14;
            this.m_Text15.Height = 37;
            this.m_Text15.Left = 249;
            this.m_Text15.Name = "m_Text15";
            this.m_Text15.ScreenOwnerName = "RcrdInterval";
            this.m_Text15.TextVerticalAlignment = "Center";
            this.m_Text15.Top = 64;
            this.m_Text15.VisibleDynamicsValue = true;
            this.m_Text15.Width = 107;
            // 
            // m_lblSec
            // 
            this.m_lblSec.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_lblSec.BitmapEffect = new Neo.ApplicationFramework.Common.Graphics.Logic.BitmapEffectCF(2, 0, Neo.ApplicationFramework.Common.Graphics.Logic.LightAngle.LowerRight);
            this.m_lblSec.BlinkDynamicsValue = false;
            this.m_lblSec.Bold = true;
            this.m_lblSec.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_lblSec.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_lblSec.EnabledDynamicsValue = true;
            this.m_lblSec.FontSizePixels = 20;
            this.m_lblSec.Height = 47;
            this.m_lblSec.Left = 228;
            this.m_lblSec.MaxValue = 59D;
            this.m_lblSec.Name = "m_lblSec";
            this.m_lblSec.NumberOfDecimals = 0;
            this.m_lblSec.ScreenOwnerName = "RcrdInterval";
            this.m_lblSec.Top = 192;
            this.m_lblSec.ValidateValueOnInput = true;
            this.m_lblSec.VisibleDynamicsValue = true;
            this.m_lblSec.Width = 117;
            // 
            // m_Button
            // 
            this.m_Button.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button.BlinkDynamicsValue = false;
            this.m_Button.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_Button.EnabledDynamicsValue = true;
            this.m_Button.FontSizePixels = 9;
            this.m_Button.ForceTransparency = true;
            this.m_Button.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_Button.Height = 47;
            this.m_Button.IndicatorMargin = null;
            this.m_Button.Left = 345;
            this.m_Button.Name = "m_Button";
            this.m_Button.RequiresTransparency = true;
            this.m_Button.ScreenOwnerName = "RcrdInterval";
            this.m_Button.StyleName = "Glossy";
            this.m_Button.SymbolHeight = 41;
            this.m_Button.SymbolIntervalMapper = symbolintervalmapper3;
            this.m_Button.SymbolName = "path2985";
            this.m_Button.SymbolWidth = 35;
            this.m_Button.TextHeight = 11;
            this.m_Button.TextValue = 0D;
            this.m_Button.TextWidth = 50;
            this.m_Button.Top = 192;
            this.m_Button.Value = 0D;
            this.m_Button.VisibleDynamicsValue = true;
            this.m_Button.VisualPropertiesHashCode = -392000978;
            this.m_Button.Width = 56;
            // 
            // m_Button1
            // 
            this.m_Button1.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button1.BlinkDynamicsValue = false;
            this.m_Button1.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button1.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_Button1.EnabledDynamicsValue = true;
            this.m_Button1.FontSizePixels = 9;
            this.m_Button1.ForceTransparency = true;
            this.m_Button1.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_Button1.Height = 47;
            this.m_Button1.IndicatorMargin = null;
            this.m_Button1.Left = 172;
            this.m_Button1.Name = "m_Button1";
            this.m_Button1.RequiresTransparency = true;
            this.m_Button1.ScreenOwnerName = "RcrdInterval";
            this.m_Button1.StyleName = "Glossy";
            this.m_Button1.SymbolHeight = 41;
            this.m_Button1.SymbolIntervalMapper = symbolintervalmapper4;
            this.m_Button1.SymbolName = "path29851";
            this.m_Button1.SymbolWidth = 35;
            this.m_Button1.TextHeight = 11;
            this.m_Button1.TextValue = 0D;
            this.m_Button1.TextWidth = 50;
            this.m_Button1.Top = 192;
            this.m_Button1.Value = 0D;
            this.m_Button1.VisibleDynamicsValue = true;
            this.m_Button1.VisualPropertiesHashCode = 24033907;
            this.m_Button1.Width = 56;
            // 
            // m_Text
            // 
            this.m_Text.AutoSize = false;
            this.m_Text.BlinkDynamicsValue = false;
            this.m_Text.EnabledDynamicsValue = true;
            this.m_Text.FontSizePixels = 14;
            this.m_Text.Height = 37;
            this.m_Text.Left = 247;
            this.m_Text.Name = "m_Text";
            this.m_Text.ScreenOwnerName = "RcrdInterval";
            this.m_Text.TextVerticalAlignment = "Center";
            this.m_Text.Top = 157;
            this.m_Text.VisibleDynamicsValue = true;
            this.m_Text.Width = 107;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(480, 272);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "RcrdInterval";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_RcrdInterval = true;
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
            if (!m_Initialized_RcrdInterval) {
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
            this.DrawingPrimitives.Add(this.m_Line);
            this.DrawingPrimitives.Add(this.m_lblMin);
            this.DrawingPrimitives.Add(this.m_Button22);
            this.DrawingPrimitives.Add(this.m_Button23);
            this.DrawingPrimitives.Add(this.m_Text15);
            this.DrawingPrimitives.Add(this.m_lblSec);
            this.DrawingPrimitives.Add(this.m_Button);
            this.DrawingPrimitives.Add(this.m_Button1);
            this.DrawingPrimitives.Add(this.m_Text);
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lblMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lblSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).EndInit();
        }
        
        private void RcrdInterval_Action_Opened(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("RcrdInterval", "Opened", "Set Analog", "Tags.CurrentScreen", "");
            Neo.ApplicationFramework.Generated.Globals.Tags.CurrentScreen.SetAnalog(32);
        }
        
        private void m_Button22_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button22", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_Button23_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button23", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_Button_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_Button1_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button1", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(RcrdInterval));
            this.m_Text2.Text = resources.GetText("RcrdInterval.Text2.Text", "Recording Interval");
            this.m_Text15.Text = resources.GetText("RcrdInterval.Text15.Text", "MINUTES");
            this.m_Text.Text = resources.GetText("RcrdInterval.Text.Text", "SECONDS");
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
            if (!m_Initialized_RcrdInterval) {
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
