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
    public partial class QuickFillScreen3 : Neo.ApplicationFramework.Controls.Controls.Form {
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture;
        
        private Neo.ApplicationFramework.Controls.Controls.LinearMeterCF m_LinearMeter;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture1;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture2;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture4;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture3;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_lblQuickFill;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text1;
        
        private Neo.ApplicationFramework.Controls.Controls.AnalogNumeric m_AnalogNumeric;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button1;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_lblStatus;
        
        private bool m_Initialized_QuickFillScreen3;
        
        private Neo.ApplicationFramework.Common.Dynamics.LinearConverterCF linearconvertercf1;
        
        private Neo.ApplicationFramework.Common.Dynamics.BrushDynamicsConverterCF brushdynamicsconvertercf1;
        
        public QuickFillScreen3() {
            this.InitializeComponent();
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            this.Adapter.Closed += new System.EventHandler(this.QuickFillScreen3_Closed);
            this.Adapter.Opened += new System.EventHandler(this.QuickFillScreen3_Opened);
            this.Opened += new System.EventHandler(this.QuickFillScreen3_Action_Opened);
            this.m_Button1.Click += new System.EventHandler(this.m_Button1_Action_Click);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.LinearMeterBaseCFAdapter LinearMeter {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.LinearMeterBaseCFAdapter>(this.m_LinearMeter);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture2);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture4 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture4);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture3 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture3);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter lblQuickFill {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_lblQuickFill);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter AnalogNumeric {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter>(this.m_AnalogNumeric);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter lblStatus {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_lblStatus);
            }
        }
        
        private void InitializeComponent() {
            this.brushdynamicsconvertercf1 = new Neo.ApplicationFramework.Common.Dynamics.BrushDynamicsConverterCF();
            this.linearconvertercf1 = new Neo.ApplicationFramework.Common.Dynamics.LinearConverterCF();
            Neo.ApplicationFramework.Common.Dynamics.BrushCFInterval brushcfinterval1 = new Neo.ApplicationFramework.Common.Dynamics.BrushCFInterval();
            Neo.ApplicationFramework.Common.Dynamics.BrushCFInterval brushcfinterval2 = new Neo.ApplicationFramework.Common.Dynamics.BrushCFInterval();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            this.m_Picture = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_LinearMeter = new Neo.ApplicationFramework.Controls.Controls.LinearMeterCF();
            this.m_Picture1 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Picture2 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Picture4 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Picture3 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_lblQuickFill = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text1 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_AnalogNumeric = new Neo.ApplicationFramework.Controls.Controls.AnalogNumeric();
            this.m_Button1 = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_lblStatus = new Neo.ApplicationFramework.Controls.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LinearMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lblQuickFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_AnalogNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lblStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // QuickFillScreen3
            // 
            this.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), Neo.ApplicationFramework.Interfaces.FillDirection.DiagonalBottomRightToTopLeft);
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.ThreeDBorder;
            this.ControlBox = false;
            // 
            // m_Picture
            // 
            this.m_Picture.BlinkDynamicsValue = false;
            this.m_Picture.EnabledDynamicsValue = true;
            this.m_Picture.Height = 148;
            this.m_Picture.Left = 124;
            this.m_Picture.Name = "m_Picture";
            this.m_Picture.ScreenOwnerName = "QuickFillScreen3";
            this.m_Picture.Stretch = true;
            this.m_Picture.SymbolName = "tank medium 1";
            this.m_Picture.Top = 77;
            this.m_Picture.VisibleDynamicsValue = true;
            this.m_Picture.Width = 100;
            // 
            // m_LinearMeter
            // 
            this.m_LinearMeter.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_LinearMeter.BlinkDynamicsValue = false;
            linearconvertercf1.EndDataValue = 100D;
            linearconvertercf1.EndPropertyValue = 100D;
            linearconvertercf1.StartDataValue = 0D;
            linearconvertercf1.StartPropertyValue = 0D;
            this.m_LinearMeter.EnabledDynamicsValue = true;
            this.m_LinearMeter.FontSizePixels = 7;
            this.m_LinearMeter.ForceTransparency = false;
            this.m_LinearMeter.Foreground = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_LinearMeter.Height = 104;
            this.m_LinearMeter.IndicatorColor = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_LinearMeter.IndicatorMargin = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(7D, 7D, 7D, 7D);
            this.m_LinearMeter.InvalidateAtValueChanged = true;
            this.m_LinearMeter.Left = 135;
            this.m_LinearMeter.MajorScaleMarginFirst = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(0D, 0D, 80D, 104D);
            this.m_LinearMeter.MajorScaleMarginSecond = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(double.NaN, double.NaN, double.NaN, double.NaN);
            this.m_LinearMeter.MajorTickCount = 6;
            this.m_LinearMeter.Maximum = 100D;
            this.m_LinearMeter.Minimum = 0D;
            this.m_LinearMeter.MinorScaleMarginFirst = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(0D, 0D, 80D, 104D);
            this.m_LinearMeter.MinorScaleMarginSecond = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(double.NaN, double.NaN, double.NaN, double.NaN);
            this.m_LinearMeter.MinorTickCount = 1;
            this.m_LinearMeter.Name = "m_LinearMeter";
            this.m_LinearMeter.Orientation = Neo.ApplicationFramework.Controls.Controls.OrientationCF.Vertical;
            this.m_LinearMeter.RequiresTransparency = true;
            this.m_LinearMeter.ScaleColor = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_LinearMeter.ScaleVisible = false;
            this.m_LinearMeter.ScreenOwnerName = "QuickFillScreen3";
            this.m_LinearMeter.TextScaleMargin = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(0D, 0D, 80D, 104D);
            this.m_LinearMeter.Top = 99;
            this.m_LinearMeter.VisibleDynamicsValue = true;
            this.m_LinearMeter.Width = 80;
            // 
            // m_Picture1
            // 
            this.m_Picture1.BlinkDynamicsValue = false;
            this.m_Picture1.EnabledDynamicsValue = true;
            this.m_Picture1.Height = 20;
            this.m_Picture1.Left = 162;
            this.m_Picture1.Name = "m_Picture1";
            this.m_Picture1.ScreenOwnerName = "QuickFillScreen3";
            this.m_Picture1.Stretch = true;
            this.m_Picture1.SymbolName = "pipe bend 4";
            this.m_Picture1.Top = 61;
            this.m_Picture1.VisibleDynamicsValue = true;
            this.m_Picture1.Width = 20;
            // 
            // m_Picture2
            // 
            this.m_Picture2.BlinkDynamicsValue = false;
            this.m_Picture2.EnabledDynamicsValue = true;
            this.m_Picture2.Height = 14;
            this.m_Picture2.Left = 86;
            this.m_Picture2.Name = "m_Picture2";
            this.m_Picture2.ScreenOwnerName = "QuickFillScreen3";
            this.m_Picture2.Stretch = true;
            this.m_Picture2.SymbolName = "pipe 1";
            this.m_Picture2.Top = 62;
            this.m_Picture2.VisibleDynamicsValue = true;
            this.m_Picture2.Width = 76;
            // 
            // m_Picture4
            // 
            this.m_Picture4.BlinkDynamicsValue = false;
            this.m_Picture4.EnabledDynamicsValue = true;
            this.m_Picture4.Height = 14;
            this.m_Picture4.Left = 6;
            this.m_Picture4.Name = "m_Picture4";
            this.m_Picture4.ScreenOwnerName = "QuickFillScreen3";
            this.m_Picture4.Stretch = true;
            this.m_Picture4.SymbolName = "pipe 1";
            this.m_Picture4.Top = 62;
            this.m_Picture4.VisibleDynamicsValue = true;
            this.m_Picture4.Width = 45;
            // 
            // m_Picture3
            // 
            this.m_Picture3.BlinkDynamicsValue = false;
            this.m_Picture3.EnabledDynamicsValue = true;
            this.m_Picture3.Height = 34;
            this.m_Picture3.Left = 40;
            this.m_Picture3.Name = "m_Picture3";
            this.m_Picture3.ScreenOwnerName = "QuickFillScreen3";
            this.m_Picture3.Stretch = true;
            this.m_Picture3.SymbolName = "valve 5 on";
            this.m_Picture3.Top = 44;
            this.m_Picture3.VisibleDynamicsValue = true;
            this.m_Picture3.Width = 54;
            // 
            // m_lblQuickFill
            // 
            this.m_lblQuickFill.AutoSize = false;
            this.m_lblQuickFill.BlinkDynamicsValue = false;
            this.m_lblQuickFill.BlinkInterval = 2000;
            this.m_lblQuickFill.EnabledDynamicsValue = true;
            this.m_lblQuickFill.FontSizePixels = 16;
            this.m_lblQuickFill.Height = 25;
            this.m_lblQuickFill.Left = 16;
            this.m_lblQuickFill.Name = "m_lblQuickFill";
            this.m_lblQuickFill.ScreenOwnerName = "QuickFillScreen3";
            this.m_lblQuickFill.TextHorizontalAlignment = "Center";
            this.m_lblQuickFill.TextVerticalAlignment = "Center";
            this.m_lblQuickFill.Top = 8;
            this.m_lblQuickFill.VisibleDynamicsValue = true;
            this.m_lblQuickFill.Width = 446;
            // 
            // m_Text1
            // 
            this.m_Text1.BlinkDynamicsValue = false;
            this.m_Text1.EnabledDynamicsValue = true;
            this.m_Text1.FontSizePixels = 18;
            this.m_Text1.Height = 21;
            this.m_Text1.Left = 248;
            this.m_Text1.Name = "m_Text1";
            this.m_Text1.ScreenOwnerName = "QuickFillScreen3";
            this.m_Text1.Top = 77;
            this.m_Text1.VisibleDynamicsValue = true;
            this.m_Text1.Width = 117;
            // 
            // m_AnalogNumeric
            // 
            this.m_AnalogNumeric.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200))))), Neo.ApplicationFramework.Interfaces.FillDirection.VerticalBottomToTop);
            this.m_AnalogNumeric.BitmapEffect = new Neo.ApplicationFramework.Common.Graphics.Logic.BitmapEffectCF(2, 0, Neo.ApplicationFramework.Common.Graphics.Logic.LightAngle.LowerRight);
            this.m_AnalogNumeric.BlinkDynamicsValue = false;
            this.m_AnalogNumeric.Bold = true;
            this.m_AnalogNumeric.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AnalogNumeric.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            brushdynamicsconvertercf1.BrushIntervalMapper.DefaultValue = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.Black, System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            brushcfinterval1.Value = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(20)))), ((int)(((byte)(25))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            brushcfinterval2.End = 1D;
            brushcfinterval2.Start = 1D;
            brushcfinterval2.Value = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            brushdynamicsconvertercf1.BrushIntervalMapper.Intervals.Add(brushcfinterval1);
            brushdynamicsconvertercf1.BrushIntervalMapper.Intervals.Add(brushcfinterval2);
            this.m_AnalogNumeric.DisplayFormat = Neo.ApplicationFramework.Interfaces.AnalogNumericDisplayFormat.String;
            this.m_AnalogNumeric.EnabledDynamicsValue = true;
            this.m_AnalogNumeric.FontSizePixels = 26;
            this.m_AnalogNumeric.Height = 57;
            this.m_AnalogNumeric.Left = 264;
            this.m_AnalogNumeric.Name = "m_AnalogNumeric";
            this.m_AnalogNumeric.ReadOnly = true;
            this.m_AnalogNumeric.ScreenOwnerName = "QuickFillScreen3";
            this.m_AnalogNumeric.Top = 110;
            this.m_AnalogNumeric.VisibleDynamicsValue = true;
            this.m_AnalogNumeric.Width = 171;
            // 
            // m_Button1
            // 
            this.m_Button1.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button1.BlinkDynamicsValue = false;
            this.m_Button1.Bold = true;
            this.m_Button1.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button1.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_Button1.EnabledDynamicsValue = true;
            this.m_Button1.FontSizePixels = 16;
            this.m_Button1.ForceTransparency = true;
            this.m_Button1.Height = 58;
            this.m_Button1.IndicatorMargin = null;
            this.m_Button1.Left = 279;
            this.m_Button1.Name = "m_Button1";
            this.m_Button1.RequiresTransparency = true;
            this.m_Button1.ScreenOwnerName = "QuickFillScreen3";
            this.m_Button1.StyleName = "Glossy";
            this.m_Button1.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_Button1.TextHeight = 19;
            this.m_Button1.TextValue = 0D;
            this.m_Button1.TextWidth = 136;
            this.m_Button1.Top = 177;
            this.m_Button1.Value = 0D;
            this.m_Button1.VisibleDynamicsValue = true;
            this.m_Button1.VisualPropertiesHashCode = 1614970727;
            this.m_Button1.Width = 142;
            // 
            // m_lblStatus
            // 
            this.m_lblStatus.AutoSize = false;
            this.m_lblStatus.BlinkDynamicsValue = false;
            this.m_lblStatus.BlinkInterval = 2000;
            this.m_lblStatus.EnabledDynamicsValue = true;
            this.m_lblStatus.FontSizePixels = 12;
            this.m_lblStatus.Height = 25;
            this.m_lblStatus.Left = 16;
            this.m_lblStatus.Name = "m_lblStatus";
            this.m_lblStatus.ScreenOwnerName = "QuickFillScreen3";
            this.m_lblStatus.TextHorizontalAlignment = "Center";
            this.m_lblStatus.TextVerticalAlignment = "Center";
            this.m_lblStatus.Top = 28;
            this.m_lblStatus.VisibleDynamicsValue = true;
            this.m_lblStatus.Width = 446;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(480, 272);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = false;
            this.Name = "QuickFillScreen3";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "Quick Fill";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_QuickFillScreen3 = true;
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
            if (!m_Initialized_QuickFillScreen3) {
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
            this.DrawingPrimitives.Add(this.m_Picture);
            this.DrawingPrimitives.Add(this.m_LinearMeter);
            this.DrawingPrimitives.Add(this.m_Picture1);
            this.DrawingPrimitives.Add(this.m_Picture2);
            this.DrawingPrimitives.Add(this.m_Picture4);
            this.DrawingPrimitives.Add(this.m_Picture3);
            this.DrawingPrimitives.Add(this.m_lblQuickFill);
            this.DrawingPrimitives.Add(this.m_Text1);
            this.DrawingPrimitives.Add(this.m_AnalogNumeric);
            this.DrawingPrimitives.Add(this.m_Button1);
            this.DrawingPrimitives.Add(this.m_lblStatus);
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LinearMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lblQuickFill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_AnalogNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lblStatus)).EndInit();
        }
        
        private void QuickFillScreen3_Action_Opened(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("QuickFillScreen3", "Opened", "Set Analog", "Tags.CurrentScreen", "");
            Neo.ApplicationFramework.Generated.Globals.Tags.CurrentScreen.SetAnalog(28);
        }
        
        private void m_Button1_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button1", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(QuickFillScreen3));
            this.m_lblQuickFill.Text = resources.GetText("QuickFillScreen3.lblQuickFill.Text", "Quick Filling in Progress");
            this.m_Text1.Text = resources.GetText("QuickFillScreen3.Text1.Text", "Test Pressure Reading");
            this.m_Button1.Text = resources.GetText("QuickFillScreen3.Button1.Text", "EXIT");
            this.m_lblStatus.Text = resources.GetText("QuickFillScreen3.lblStatus.Text", "20 min(s) left");
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
            if (!m_Initialized_QuickFillScreen3) {
                return;
            }
            base.ApplyLanguageInitialize();
            this.ApplyLanguageInternal();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ConnectDataBindings() {
            base.ConnectDataBindings();
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding1 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.PressReadingFull"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_AnalogNumeric.DataBindings.Add(dynamicBinding1);
            this.m_DynamicBindings.Add(dynamicBinding1);
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding2 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Foreground", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.QuickFillBracketIndicator"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, brushdynamicsconvertercf1);
            this.m_AnalogNumeric.DataBindings.Add(dynamicBinding2);
            this.m_DynamicBindings.Add(dynamicBinding2);
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding3 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("IsBlinkEnabled", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.QuickFillProgressBlink"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, Neo.ApplicationFramework.Common.Dynamics.BoolDynamicsConverterCF.TrueValueOne);
            this.m_lblQuickFill.DataBindings.Add(dynamicBinding3);
            this.m_DynamicBindings.Add(dynamicBinding3);
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding4 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Maximum", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.quickFillTargetPress"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, linearconvertercf1);
            this.m_LinearMeter.DataBindings.Add(dynamicBinding4);
            this.m_DynamicBindings.Add(dynamicBinding4);
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding5 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.RawTestPressure"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_LinearMeter.DataBindings.Add(dynamicBinding5);
            this.m_DynamicBindings.Add(dynamicBinding5);
        }
    }
}
