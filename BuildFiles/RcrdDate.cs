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
    public partial class RcrdDate : BackRcrd {
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text2;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_lblFormat;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text5;
        
        private Neo.ApplicationFramework.Controls.Controls.Line m_Line;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_lblCurrentDate;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text20;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnClear;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnBack;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnDash;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnSlash;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnY;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnD;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnM;
        
        private bool m_Initialized_RcrdDate;
        
        public RcrdDate() {
            this.InitializeComponent();
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            this.btnSlash.Click += new System.EventHandler(this.btnSlash_Click);
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            this.Adapter.Closed += new System.EventHandler(this.RcrdDate_Closed);
            this.Adapter.Opened += new System.EventHandler(this.RcrdDate_Opened);
            this.Opened += new System.EventHandler(this.RcrdDate_Action_Opened);
            this.m_btnClear.Click += new System.EventHandler(this.m_btnClear_Action_Click);
            this.m_btnBack.Click += new System.EventHandler(this.m_btnBack_Action_Click);
            this.m_btnDash.Click += new System.EventHandler(this.m_btnDash_Action_Click);
            this.m_btnSlash.Click += new System.EventHandler(this.m_btnSlash_Action_Click);
            this.m_btnY.Click += new System.EventHandler(this.m_btnY_Action_Click);
            this.m_btnD.Click += new System.EventHandler(this.m_btnD_Action_Click);
            this.m_btnM.Click += new System.EventHandler(this.m_btnM_Action_Click);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text2);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter lblFormat {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_lblFormat);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text5 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text5);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.LineCFAdapter Line {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.LineCFAdapter>(this.m_Line);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter lblCurrentDate {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_lblCurrentDate);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text20 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text20);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter btnClear {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_btnClear);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter btnBack {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_btnBack);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter btnDash {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_btnDash);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter btnSlash {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_btnSlash);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter btnY {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_btnY);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter btnD {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_btnD);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter btnM {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_btnM);
            }
        }
        
        private void InitializeComponent() {
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper2 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper3 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper4 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper5 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper6 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper7 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            this.m_Text2 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_lblFormat = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text5 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Line = new Neo.ApplicationFramework.Controls.Controls.Line();
            this.m_lblCurrentDate = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text20 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_btnClear = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_btnBack = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_btnDash = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_btnSlash = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_btnY = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_btnD = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_btnM = new Neo.ApplicationFramework.Controls.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lblFormat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lblCurrentDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnDash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnSlash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnM)).BeginInit();
            this.SuspendLayout();
            // 
            // RcrdDate
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
            this.m_Text2.Height = 30;
            this.m_Text2.Left = 127;
            this.m_Text2.Name = "m_Text2";
            this.m_Text2.ScreenOwnerName = "RcrdDate";
            this.m_Text2.TextVerticalAlignment = "Center";
            this.m_Text2.Top = 36;
            this.m_Text2.VisibleDynamicsValue = true;
            this.m_Text2.Width = 340;
            // 
            // m_lblFormat
            // 
            this.m_lblFormat.AutoSize = false;
            this.m_lblFormat.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(237)))), ((int)(((byte)(242))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_lblFormat.BlinkDynamicsValue = false;
            this.m_lblFormat.EnabledDynamicsValue = true;
            this.m_lblFormat.FontFamily = "Arial";
            this.m_lblFormat.FontSizePixels = 18;
            this.m_lblFormat.Height = 39;
            this.m_lblFormat.Left = 205;
            this.m_lblFormat.Name = "m_lblFormat";
            this.m_lblFormat.ScreenOwnerName = "RcrdDate";
            this.m_lblFormat.TextHorizontalAlignment = "Center";
            this.m_lblFormat.TextVerticalAlignment = "Center";
            this.m_lblFormat.Top = 142;
            this.m_lblFormat.VisibleDynamicsValue = true;
            this.m_lblFormat.Width = 179;
            // 
            // m_Text5
            // 
            this.m_Text5.AutoSize = false;
            this.m_Text5.BlinkDynamicsValue = false;
            this.m_Text5.EnabledDynamicsValue = true;
            this.m_Text5.FontFamily = "Arial";
            this.m_Text5.FontSizePixels = 14;
            this.m_Text5.Height = 34;
            this.m_Text5.Left = 135;
            this.m_Text5.MultiLine = true;
            this.m_Text5.Name = "m_Text5";
            this.m_Text5.ScreenOwnerName = "RcrdDate";
            this.m_Text5.TextHorizontalAlignment = "Center";
            this.m_Text5.TextVerticalAlignment = "Center";
            this.m_Text5.Top = 144;
            this.m_Text5.VisibleDynamicsValue = true;
            this.m_Text5.Width = 62;
            // 
            // m_Line
            // 
            this.m_Line.BlinkDynamicsValue = false;
            this.m_Line.EnabledDynamicsValue = true;
            this.m_Line.Fill = null;
            this.m_Line.Name = "m_Line";
            this.m_Line.ScreenOwnerName = "RcrdDate";
            this.m_Line.Stroke = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Line.VisibleDynamicsValue = true;
            this.m_Line.X1 = 135;
            this.m_Line.X2 = 467;
            this.m_Line.Y1 = 66;
            this.m_Line.Y2 = 66;
            // 
            // m_lblCurrentDate
            // 
            this.m_lblCurrentDate.AutoSize = false;
            this.m_lblCurrentDate.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(237)))), ((int)(((byte)(242))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_lblCurrentDate.BlinkDynamicsValue = false;
            this.m_lblCurrentDate.EnabledDynamicsValue = true;
            this.m_lblCurrentDate.FontFamily = "Arial";
            this.m_lblCurrentDate.FontSizePixels = 18;
            this.m_lblCurrentDate.Height = 39;
            this.m_lblCurrentDate.Left = 205;
            this.m_lblCurrentDate.Name = "m_lblCurrentDate";
            this.m_lblCurrentDate.ScreenOwnerName = "RcrdDate";
            this.m_lblCurrentDate.TextHorizontalAlignment = "Center";
            this.m_lblCurrentDate.TextVerticalAlignment = "Center";
            this.m_lblCurrentDate.Top = 84;
            this.m_lblCurrentDate.VisibleDynamicsValue = true;
            this.m_lblCurrentDate.Width = 179;
            // 
            // m_Text20
            // 
            this.m_Text20.AutoSize = false;
            this.m_Text20.BlinkDynamicsValue = false;
            this.m_Text20.EnabledDynamicsValue = true;
            this.m_Text20.FontFamily = "Arial";
            this.m_Text20.FontSizePixels = 14;
            this.m_Text20.Height = 41;
            this.m_Text20.Left = 135;
            this.m_Text20.MultiLine = true;
            this.m_Text20.Name = "m_Text20";
            this.m_Text20.ScreenOwnerName = "RcrdDate";
            this.m_Text20.TextHorizontalAlignment = "Center";
            this.m_Text20.TextVerticalAlignment = "Center";
            this.m_Text20.Top = 83;
            this.m_Text20.VisibleDynamicsValue = true;
            this.m_Text20.Width = 62;
            // 
            // m_btnClear
            // 
            this.m_btnClear.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnClear.BlinkDynamicsValue = false;
            this.m_btnClear.Bold = true;
            this.m_btnClear.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnClear.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_btnClear.EnabledDynamicsValue = true;
            this.m_btnClear.FontSizePixels = 16;
            this.m_btnClear.ForceTransparency = true;
            this.m_btnClear.Height = 39;
            this.m_btnClear.IndicatorMargin = null;
            this.m_btnClear.Left = 392;
            this.m_btnClear.Name = "m_btnClear";
            this.m_btnClear.RequiresTransparency = true;
            this.m_btnClear.ScreenOwnerName = "RcrdDate";
            this.m_btnClear.StyleName = "Glossy";
            this.m_btnClear.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_btnClear.TextHeight = 19;
            this.m_btnClear.TextValue = 0D;
            this.m_btnClear.TextWidth = 69;
            this.m_btnClear.Top = 84;
            this.m_btnClear.Value = 0D;
            this.m_btnClear.VisibleDynamicsValue = true;
            this.m_btnClear.VisualPropertiesHashCode = 132442234;
            this.m_btnClear.Width = 75;
            // 
            // m_btnBack
            // 
            this.m_btnBack.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnBack.BlinkDynamicsValue = false;
            this.m_btnBack.Bold = true;
            this.m_btnBack.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnBack.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_btnBack.EnabledDynamicsValue = true;
            this.m_btnBack.FontSizePixels = 16;
            this.m_btnBack.ForceTransparency = true;
            this.m_btnBack.Height = 39;
            this.m_btnBack.IndicatorMargin = null;
            this.m_btnBack.Left = 392;
            this.m_btnBack.Name = "m_btnBack";
            this.m_btnBack.RequiresTransparency = true;
            this.m_btnBack.ScreenOwnerName = "RcrdDate";
            this.m_btnBack.StyleName = "Glossy";
            this.m_btnBack.SymbolIntervalMapper = symbolintervalmapper2;
            this.m_btnBack.TextHeight = 19;
            this.m_btnBack.TextValue = 0D;
            this.m_btnBack.TextWidth = 69;
            this.m_btnBack.Top = 142;
            this.m_btnBack.Value = 0D;
            this.m_btnBack.VisibleDynamicsValue = true;
            this.m_btnBack.VisualPropertiesHashCode = 132442234;
            this.m_btnBack.Width = 75;
            // 
            // m_btnDash
            // 
            this.m_btnDash.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnDash.BlinkDynamicsValue = false;
            this.m_btnDash.Bold = true;
            this.m_btnDash.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnDash.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_btnDash.Enabled = false;
            this.m_btnDash.EnabledDynamicsValue = false;
            this.m_btnDash.FontSizePixels = 18;
            this.m_btnDash.ForceTransparency = true;
            this.m_btnDash.Height = 45;
            this.m_btnDash.IndicatorMargin = null;
            this.m_btnDash.Left = 407;
            this.m_btnDash.Name = "m_btnDash";
            this.m_btnDash.RequiresTransparency = true;
            this.m_btnDash.ScreenOwnerName = "RcrdDate";
            this.m_btnDash.StyleName = "Glossy";
            this.m_btnDash.SymbolIntervalMapper = symbolintervalmapper3;
            this.m_btnDash.TextHeight = 22;
            this.m_btnDash.TextValue = 0D;
            this.m_btnDash.TextWidth = 54;
            this.m_btnDash.Top = 203;
            this.m_btnDash.Value = 0D;
            this.m_btnDash.VisibleDynamicsValue = true;
            this.m_btnDash.VisualPropertiesHashCode = 622842081;
            this.m_btnDash.Width = 60;
            // 
            // m_btnSlash
            // 
            this.m_btnSlash.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnSlash.BlinkDynamicsValue = false;
            this.m_btnSlash.Bold = true;
            this.m_btnSlash.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnSlash.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_btnSlash.Enabled = false;
            this.m_btnSlash.EnabledDynamicsValue = false;
            this.m_btnSlash.FontSizePixels = 18;
            this.m_btnSlash.ForceTransparency = true;
            this.m_btnSlash.Height = 45;
            this.m_btnSlash.IndicatorMargin = null;
            this.m_btnSlash.Left = 339;
            this.m_btnSlash.Name = "m_btnSlash";
            this.m_btnSlash.RequiresTransparency = true;
            this.m_btnSlash.ScreenOwnerName = "RcrdDate";
            this.m_btnSlash.StyleName = "Glossy";
            this.m_btnSlash.SymbolIntervalMapper = symbolintervalmapper4;
            this.m_btnSlash.TextHeight = 22;
            this.m_btnSlash.TextValue = 0D;
            this.m_btnSlash.TextWidth = 54;
            this.m_btnSlash.Top = 203;
            this.m_btnSlash.Value = 0D;
            this.m_btnSlash.VisibleDynamicsValue = true;
            this.m_btnSlash.VisualPropertiesHashCode = 622842081;
            this.m_btnSlash.Width = 60;
            // 
            // m_btnY
            // 
            this.m_btnY.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnY.BlinkDynamicsValue = false;
            this.m_btnY.Bold = true;
            this.m_btnY.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnY.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_btnY.Enabled = false;
            this.m_btnY.EnabledDynamicsValue = false;
            this.m_btnY.FontSizePixels = 18;
            this.m_btnY.ForceTransparency = true;
            this.m_btnY.Height = 45;
            this.m_btnY.IndicatorMargin = null;
            this.m_btnY.Left = 271;
            this.m_btnY.Name = "m_btnY";
            this.m_btnY.RequiresTransparency = true;
            this.m_btnY.ScreenOwnerName = "RcrdDate";
            this.m_btnY.StyleName = "Glossy";
            this.m_btnY.SymbolIntervalMapper = symbolintervalmapper5;
            this.m_btnY.TextHeight = 22;
            this.m_btnY.TextValue = 0D;
            this.m_btnY.TextWidth = 54;
            this.m_btnY.Top = 203;
            this.m_btnY.Value = 0D;
            this.m_btnY.VisibleDynamicsValue = true;
            this.m_btnY.VisualPropertiesHashCode = 622842081;
            this.m_btnY.Width = 60;
            // 
            // m_btnD
            // 
            this.m_btnD.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnD.BlinkDynamicsValue = false;
            this.m_btnD.Bold = true;
            this.m_btnD.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnD.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_btnD.Enabled = false;
            this.m_btnD.EnabledDynamicsValue = false;
            this.m_btnD.FontSizePixels = 18;
            this.m_btnD.ForceTransparency = true;
            this.m_btnD.Height = 45;
            this.m_btnD.IndicatorMargin = null;
            this.m_btnD.Left = 203;
            this.m_btnD.Name = "m_btnD";
            this.m_btnD.RequiresTransparency = true;
            this.m_btnD.ScreenOwnerName = "RcrdDate";
            this.m_btnD.StyleName = "Glossy";
            this.m_btnD.SymbolIntervalMapper = symbolintervalmapper6;
            this.m_btnD.TextHeight = 22;
            this.m_btnD.TextValue = 0D;
            this.m_btnD.TextWidth = 54;
            this.m_btnD.Top = 203;
            this.m_btnD.Value = 0D;
            this.m_btnD.VisibleDynamicsValue = true;
            this.m_btnD.VisualPropertiesHashCode = 622842081;
            this.m_btnD.Width = 60;
            // 
            // m_btnM
            // 
            this.m_btnM.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnM.BlinkDynamicsValue = false;
            this.m_btnM.Bold = true;
            this.m_btnM.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnM.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_btnM.Enabled = false;
            this.m_btnM.EnabledDynamicsValue = false;
            this.m_btnM.FontSizePixels = 18;
            this.m_btnM.ForceTransparency = true;
            this.m_btnM.Height = 45;
            this.m_btnM.IndicatorMargin = null;
            this.m_btnM.Left = 135;
            this.m_btnM.Name = "m_btnM";
            this.m_btnM.RequiresTransparency = true;
            this.m_btnM.ScreenOwnerName = "RcrdDate";
            this.m_btnM.StyleName = "Glossy";
            this.m_btnM.SymbolIntervalMapper = symbolintervalmapper7;
            this.m_btnM.TextHeight = 22;
            this.m_btnM.TextValue = 0D;
            this.m_btnM.TextWidth = 54;
            this.m_btnM.Top = 203;
            this.m_btnM.Value = 0D;
            this.m_btnM.VisibleDynamicsValue = true;
            this.m_btnM.VisualPropertiesHashCode = 622842081;
            this.m_btnM.Width = 60;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(480, 272);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "RcrdDate";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_RcrdDate = true;
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
            if (!m_Initialized_RcrdDate) {
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
            this.DrawingPrimitives.Add(this.m_lblFormat);
            this.DrawingPrimitives.Add(this.m_Text5);
            this.DrawingPrimitives.Add(this.m_Line);
            this.DrawingPrimitives.Add(this.m_lblCurrentDate);
            this.DrawingPrimitives.Add(this.m_Text20);
            this.DrawingPrimitives.Add(this.m_btnClear);
            this.DrawingPrimitives.Add(this.m_btnBack);
            this.DrawingPrimitives.Add(this.m_btnDash);
            this.DrawingPrimitives.Add(this.m_btnSlash);
            this.DrawingPrimitives.Add(this.m_btnY);
            this.DrawingPrimitives.Add(this.m_btnD);
            this.DrawingPrimitives.Add(this.m_btnM);
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lblFormat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lblCurrentDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnDash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnSlash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnM)).EndInit();
        }
        
        private void RcrdDate_Action_Opened(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("RcrdDate", "Opened", "Set Analog", "Tags.CurrentScreen", "");
            Neo.ApplicationFramework.Generated.Globals.Tags.CurrentScreen.SetAnalog(30);
        }
        
        private void m_btnClear_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnClear", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_btnBack_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnBack", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_btnDash_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnDash", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_btnSlash_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnSlash", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_btnY_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnY", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_btnD_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnD", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_btnM_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnM", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(RcrdDate));
            this.m_Text2.Text = resources.GetText("RcrdDate.Text2.Text", "Date Format");
            this.m_lblFormat.Text = resources.GetText("RcrdDate.lblFormat.Text", "MM/DD/YYYY");
            this.m_Text5.Text = resources.GetText("RcrdDate.Text5.Text", "Format");
            this.m_lblCurrentDate.Text = resources.GetText("RcrdDate.lblCurrentDate.Text", "06/09/2015");
            this.m_Text20.Text = resources.GetText("RcrdDate.Text20.Text", "Today\'s\nDate");
            this.m_btnClear.Text = resources.GetText("RcrdDate.btnClear.Text", "Clear");
            this.m_btnBack.Text = resources.GetText("RcrdDate.btnBack.Text", "Back");
            this.m_btnDash.Text = resources.GetText("RcrdDate.btnDash.Text", "-");
            this.m_btnSlash.Text = resources.GetText("RcrdDate.btnSlash.Text", "/");
            this.m_btnY.Text = resources.GetText("RcrdDate.btnY.Text", "Y");
            this.m_btnD.Text = resources.GetText("RcrdDate.btnD.Text", "D");
            this.m_btnM.Text = resources.GetText("RcrdDate.btnM.Text", "M");
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
            if (!m_Initialized_RcrdDate) {
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
