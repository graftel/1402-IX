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
    public partial class DisplayDecimals : DisplayBack {
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button2;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text6;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text7;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button5;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text8;
        
        private Neo.ApplicationFramework.Controls.Controls.AnalogNumeric m_AnalogNumeric;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button3;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button4;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text;
        
        private Neo.ApplicationFramework.Controls.Controls.Line m_Line;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button8;
        
        private bool m_Initialized_DisplayDecimals;
        
        public DisplayDecimals() {
            this.InitializeComponent();
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            this.Adapter.Opened += new System.EventHandler(this.DisplayDecimals_Opened);
            this.Opened += new System.EventHandler(this.DisplayDecimals_Action_Opened);
            this.m_Button2.Click += new System.EventHandler(this.m_Button2_Action_Click);
            this.m_Button5.Click += new System.EventHandler(this.m_Button5_Action_Click);
            this.m_Button3.Click += new System.EventHandler(this.m_Button3_Action_Click);
            this.m_Button4.Click += new System.EventHandler(this.m_Button4_Action_Click);
            this.m_Button8.Click += new System.EventHandler(this.m_Button8_Action_Click);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button2);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text6 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text6);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text7 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text7);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button5 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button5);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text8 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text8);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter AnalogNumeric {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter>(this.m_AnalogNumeric);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button3 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button3);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button4 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button4);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.LineCFAdapter Line {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.LineCFAdapter>(this.m_Line);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button8 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button8);
            }
        }
        
        private void InitializeComponent() {
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper2 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper3 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper4 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper5 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            this.m_Button2 = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Text6 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text7 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Button5 = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Text8 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_AnalogNumeric = new Neo.ApplicationFramework.Controls.Controls.AnalogNumeric();
            this.m_Button3 = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Button4 = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Text = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Line = new Neo.ApplicationFramework.Controls.Controls.Line();
            this.m_Button8 = new Neo.ApplicationFramework.Controls.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_AnalogNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button8)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayDecimals
            // 
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.ThreeDBorder;
            this.ControlBox = false;
            // 
            // m_Button2
            // 
            this.m_Button2.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button2.BlinkDynamicsValue = false;
            this.m_Button2.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button2.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_Button2.EnabledDynamicsValue = true;
            this.m_Button2.FontSizePixels = 20;
            this.m_Button2.ForceTransparency = true;
            this.m_Button2.Height = 54;
            this.m_Button2.IndicatorMargin = null;
            this.m_Button2.Left = 146;
            this.m_Button2.MultiLine = true;
            this.m_Button2.Name = "m_Button2";
            this.m_Button2.RequiresTransparency = true;
            this.m_Button2.ScreenOwnerName = "DisplayDecimals";
            this.m_Button2.StyleName = "Glossy";
            this.m_Button2.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_Button2.TextHeight = 24;
            this.m_Button2.TextValue = 0D;
            this.m_Button2.TextWidth = 132;
            this.m_Button2.Top = 109;
            this.m_Button2.Value = 0D;
            this.m_Button2.VisibleDynamicsValue = true;
            this.m_Button2.VisualPropertiesHashCode = -1604088391;
            this.m_Button2.Width = 138;
            // 
            // m_Text6
            // 
            this.m_Text6.AutoSize = false;
            this.m_Text6.BlinkDynamicsValue = false;
            this.m_Text6.EnabledDynamicsValue = true;
            this.m_Text6.FontSizePixels = 14;
            this.m_Text6.Height = 22;
            this.m_Text6.Left = 158;
            this.m_Text6.Name = "m_Text6";
            this.m_Text6.ScreenOwnerName = "DisplayDecimals";
            this.m_Text6.TextHorizontalAlignment = "Center";
            this.m_Text6.Top = 83;
            this.m_Text6.VisibleDynamicsValue = true;
            this.m_Text6.Width = 119;
            // 
            // m_Text7
            // 
            this.m_Text7.AutoSize = false;
            this.m_Text7.BlinkDynamicsValue = false;
            this.m_Text7.EnabledDynamicsValue = true;
            this.m_Text7.FontSizePixels = 14;
            this.m_Text7.Height = 28;
            this.m_Text7.Left = 163;
            this.m_Text7.Name = "m_Text7";
            this.m_Text7.ScreenOwnerName = "DisplayDecimals";
            this.m_Text7.TextHorizontalAlignment = "Center";
            this.m_Text7.Top = 171;
            this.m_Text7.VisibleDynamicsValue = true;
            this.m_Text7.Width = 166;
            // 
            // m_Button5
            // 
            this.m_Button5.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button5.BlinkDynamicsValue = false;
            this.m_Button5.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button5.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_Button5.EnabledDynamicsValue = true;
            this.m_Button5.FontSizePixels = 24;
            this.m_Button5.ForceTransparency = true;
            this.m_Button5.Height = 54;
            this.m_Button5.IndicatorMargin = null;
            this.m_Button5.Left = 305;
            this.m_Button5.MultiLine = true;
            this.m_Button5.Name = "m_Button5";
            this.m_Button5.RequiresTransparency = true;
            this.m_Button5.ScreenOwnerName = "DisplayDecimals";
            this.m_Button5.StyleName = "Glossy";
            this.m_Button5.SymbolIntervalMapper = symbolintervalmapper2;
            this.m_Button5.TextHeight = 29;
            this.m_Button5.TextValue = 0D;
            this.m_Button5.TextWidth = 132;
            this.m_Button5.Top = 109;
            this.m_Button5.Value = 0D;
            this.m_Button5.VisibleDynamicsValue = true;
            this.m_Button5.VisualPropertiesHashCode = -1604088391;
            this.m_Button5.Width = 138;
            // 
            // m_Text8
            // 
            this.m_Text8.AutoSize = false;
            this.m_Text8.BlinkDynamicsValue = false;
            this.m_Text8.EnabledDynamicsValue = true;
            this.m_Text8.FontSizePixels = 14;
            this.m_Text8.Height = 21;
            this.m_Text8.Left = 318;
            this.m_Text8.Name = "m_Text8";
            this.m_Text8.ScreenOwnerName = "DisplayDecimals";
            this.m_Text8.TextHorizontalAlignment = "Center";
            this.m_Text8.Top = 85;
            this.m_Text8.VisibleDynamicsValue = true;
            this.m_Text8.Width = 109;
            // 
            // m_AnalogNumeric
            // 
            this.m_AnalogNumeric.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AnalogNumeric.BitmapEffect = new Neo.ApplicationFramework.Common.Graphics.Logic.BitmapEffectCF(2, 0, Neo.ApplicationFramework.Common.Graphics.Logic.LightAngle.LowerRight);
            this.m_AnalogNumeric.BlinkDynamicsValue = false;
            this.m_AnalogNumeric.Bold = true;
            this.m_AnalogNumeric.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AnalogNumeric.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_AnalogNumeric.EnabledDynamicsValue = true;
            this.m_AnalogNumeric.FontSizePixels = 20;
            this.m_AnalogNumeric.Height = 50;
            this.m_AnalogNumeric.Left = 210;
            this.m_AnalogNumeric.LimitNumberOfCharacters = true;
            this.m_AnalogNumeric.MaxNumberOfCharacters = 1;
            this.m_AnalogNumeric.Name = "m_AnalogNumeric";
            this.m_AnalogNumeric.NumberOfDecimals = 0;
            this.m_AnalogNumeric.ReadOnly = true;
            this.m_AnalogNumeric.ScreenOwnerName = "DisplayDecimals";
            this.m_AnalogNumeric.Top = 198;
            this.m_AnalogNumeric.VisibleDynamicsValue = true;
            this.m_AnalogNumeric.Width = 69;
            // 
            // m_Button3
            // 
            this.m_Button3.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button3.BlinkDynamicsValue = false;
            this.m_Button3.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button3.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_Button3.EnabledDynamicsValue = true;
            this.m_Button3.FontSizePixels = 9;
            this.m_Button3.ForceTransparency = true;
            this.m_Button3.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_Button3.Height = 50;
            this.m_Button3.IndicatorMargin = null;
            this.m_Button3.Left = 279;
            this.m_Button3.Name = "m_Button3";
            this.m_Button3.RequiresTransparency = true;
            this.m_Button3.ScreenOwnerName = "DisplayDecimals";
            this.m_Button3.StyleName = "Glossy";
            this.m_Button3.SymbolHeight = 44;
            this.m_Button3.SymbolIntervalMapper = symbolintervalmapper3;
            this.m_Button3.SymbolName = "path2985";
            this.m_Button3.SymbolWidth = 38;
            this.m_Button3.TextHeight = 11;
            this.m_Button3.TextValue = 0D;
            this.m_Button3.TextWidth = 58;
            this.m_Button3.Top = 198;
            this.m_Button3.Value = 0D;
            this.m_Button3.VisibleDynamicsValue = true;
            this.m_Button3.VisualPropertiesHashCode = 1899110906;
            this.m_Button3.Width = 64;
            // 
            // m_Button4
            // 
            this.m_Button4.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button4.BlinkDynamicsValue = false;
            this.m_Button4.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button4.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_Button4.EnabledDynamicsValue = true;
            this.m_Button4.FontSizePixels = 9;
            this.m_Button4.ForceTransparency = true;
            this.m_Button4.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_Button4.Height = 50;
            this.m_Button4.IndicatorMargin = null;
            this.m_Button4.Left = 146;
            this.m_Button4.Name = "m_Button4";
            this.m_Button4.RequiresTransparency = true;
            this.m_Button4.ScreenOwnerName = "DisplayDecimals";
            this.m_Button4.StyleName = "Glossy";
            this.m_Button4.SymbolHeight = 44;
            this.m_Button4.SymbolIntervalMapper = symbolintervalmapper4;
            this.m_Button4.SymbolName = "path29851";
            this.m_Button4.SymbolWidth = 38;
            this.m_Button4.TextHeight = 11;
            this.m_Button4.TextValue = 0D;
            this.m_Button4.TextWidth = 58;
            this.m_Button4.Top = 198;
            this.m_Button4.Value = 0D;
            this.m_Button4.VisibleDynamicsValue = true;
            this.m_Button4.VisualPropertiesHashCode = 1258192906;
            this.m_Button4.Width = 64;
            // 
            // m_Text
            // 
            this.m_Text.BlinkDynamicsValue = false;
            this.m_Text.EnabledDynamicsValue = true;
            this.m_Text.FontSizePixels = 14;
            this.m_Text.Height = 21;
            this.m_Text.Left = 134;
            this.m_Text.Name = "m_Text";
            this.m_Text.ScreenOwnerName = "DisplayDecimals";
            this.m_Text.Top = 41;
            this.m_Text.VisibleDynamicsValue = true;
            this.m_Text.Width = 108;
            // 
            // m_Line
            // 
            this.m_Line.BlinkDynamicsValue = false;
            this.m_Line.EnabledDynamicsValue = true;
            this.m_Line.Fill = null;
            this.m_Line.Name = "m_Line";
            this.m_Line.ScreenOwnerName = "DisplayDecimals";
            this.m_Line.Stroke = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Line.VisibleDynamicsValue = true;
            this.m_Line.X1 = 136;
            this.m_Line.X2 = 466;
            this.m_Line.Y1 = 67;
            this.m_Line.Y2 = 67;
            // 
            // m_Button8
            // 
            this.m_Button8.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(119)))), ((int)(((byte)(119))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button8.BlinkDynamicsValue = false;
            this.m_Button8.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button8.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_Button8.EnabledDynamicsValue = true;
            this.m_Button8.FontSizePixels = 14;
            this.m_Button8.ForceTransparency = true;
            this.m_Button8.Height = 76;
            this.m_Button8.IndicatorMargin = null;
            this.m_Button8.Left = 367;
            this.m_Button8.MultiLine = true;
            this.m_Button8.Name = "m_Button8";
            this.m_Button8.RequiresTransparency = true;
            this.m_Button8.ScreenOwnerName = "DisplayDecimals";
            this.m_Button8.StyleName = "Eclipse";
            this.m_Button8.SymbolIntervalMapper = symbolintervalmapper5;
            this.m_Button8.TextHeight = 34;
            this.m_Button8.TextValue = 0D;
            this.m_Button8.TextWidth = 70;
            this.m_Button8.Top = 171;
            this.m_Button8.Value = 0D;
            this.m_Button8.VisibleDynamicsValue = true;
            this.m_Button8.VisualPropertiesHashCode = -1559112465;
            this.m_Button8.Width = 76;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(480, 272);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "DisplayDecimals";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_DisplayDecimals = true;
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
            if (!m_Initialized_DisplayDecimals) {
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
            this.DrawingPrimitives.Add(this.m_Button2);
            this.DrawingPrimitives.Add(this.m_Text6);
            this.DrawingPrimitives.Add(this.m_Text7);
            this.DrawingPrimitives.Add(this.m_Button5);
            this.DrawingPrimitives.Add(this.m_Text8);
            this.DrawingPrimitives.Add(this.m_AnalogNumeric);
            this.DrawingPrimitives.Add(this.m_Button3);
            this.DrawingPrimitives.Add(this.m_Button4);
            this.DrawingPrimitives.Add(this.m_Text);
            this.DrawingPrimitives.Add(this.m_Line);
            this.DrawingPrimitives.Add(this.m_Button8);
            ((System.ComponentModel.ISupportInitialize)(this.m_Button2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_AnalogNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button8)).EndInit();
        }
        
        private void DisplayDecimals_Action_Opened(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("DisplayDecimals", "Opened", "Set Analog", "Tags.CurrentScreen", "");
            Neo.ApplicationFramework.Generated.Globals.Tags.CurrentScreen.SetAnalog(14);
        }
        
        private void m_Button2_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button2", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_Button5_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button5", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_Button3_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button3", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_Button4_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button4", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_Button8_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button8", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(DisplayDecimals));
            this.m_Button2.Text = resources.GetText("DisplayDecimals.Button2.Text", "LOW FLOW");
            this.m_Text6.Text = resources.GetText("DisplayDecimals.Text6.Text", "TOGGLE METER");
            this.m_Text7.Text = resources.GetText("DisplayDecimals.Text7.Text", "NUMBER OF DECIMALS");
            this.m_Button5.Text = resources.GetText("DisplayDecimals.Button5.Text", "sccm");
            this.m_Text8.Text = resources.GetText("DisplayDecimals.Text8.Text", "TOGGLE UNIT");
            this.m_Text.Text = resources.GetText("DisplayDecimals.Text.Text", "Set demicals for unit");
            this.m_Button8.Text = resources.GetText("DisplayDecimals.Button8.Text", "RESTORE\nDEFAULT");
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
            if (!m_Initialized_DisplayDecimals) {
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
