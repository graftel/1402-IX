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
    public partial class RcrdTime : BackRcrd {
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text2;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_lblTimeFormat;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text5;
        
        private Neo.ApplicationFramework.Controls.Controls.Line m_Line;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_lblCurrentTime;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text20;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnClear;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnBack;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnDash;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnMao;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnS;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnM;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnH;
        
        private bool m_Initialized_RcrdTime;
        
        public RcrdTime() {
            this.InitializeComponent();
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            this.btnMao.Click += new System.EventHandler(this.btnMao_Click);
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            this.btnH.Click += new System.EventHandler(this.btnH_Click);
            this.Adapter.Closed += new System.EventHandler(this.RcrdTime_Closed);
            this.Adapter.Opened += new System.EventHandler(this.RcrdTime_Opened);
            this.Opened += new System.EventHandler(this.RcrdTime_Action_Opened);
            this.m_btnClear.Click += new System.EventHandler(this.m_btnClear_Action_Click);
            this.m_btnBack.Click += new System.EventHandler(this.m_btnBack_Action_Click);
            this.m_btnDash.Click += new System.EventHandler(this.m_btnDash_Action_Click);
            this.m_btnMao.Click += new System.EventHandler(this.m_btnMao_Action_Click);
            this.m_btnS.Click += new System.EventHandler(this.m_btnS_Action_Click);
            this.m_btnM.Click += new System.EventHandler(this.m_btnM_Action_Click);
            this.m_btnH.Click += new System.EventHandler(this.m_btnH_Action_Click);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text2);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter lblTimeFormat {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_lblTimeFormat);
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
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter lblCurrentTime {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_lblCurrentTime);
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
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter btnMao {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_btnMao);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter btnS {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_btnS);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter btnM {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_btnM);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter btnH {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_btnH);
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
            this.m_lblTimeFormat = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text5 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Line = new Neo.ApplicationFramework.Controls.Controls.Line();
            this.m_lblCurrentTime = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text20 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_btnClear = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_btnBack = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_btnDash = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_btnMao = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_btnS = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_btnM = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_btnH = new Neo.ApplicationFramework.Controls.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lblTimeFormat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lblCurrentTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnDash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnMao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnH)).BeginInit();
            this.SuspendLayout();
            // 
            // RcrdTime
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
            this.m_Text2.Height = 24;
            this.m_Text2.Left = 125;
            this.m_Text2.Name = "m_Text2";
            this.m_Text2.ScreenOwnerName = "RcrdTime";
            this.m_Text2.TextVerticalAlignment = "Center";
            this.m_Text2.Top = 38;
            this.m_Text2.VisibleDynamicsValue = true;
            this.m_Text2.Width = 342;
            // 
            // m_lblTimeFormat
            // 
            this.m_lblTimeFormat.AutoSize = false;
            this.m_lblTimeFormat.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(237)))), ((int)(((byte)(242))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_lblTimeFormat.BlinkDynamicsValue = false;
            this.m_lblTimeFormat.EnabledDynamicsValue = true;
            this.m_lblTimeFormat.FontFamily = "Arial";
            this.m_lblTimeFormat.FontSizePixels = 18;
            this.m_lblTimeFormat.Height = 39;
            this.m_lblTimeFormat.Left = 205;
            this.m_lblTimeFormat.Name = "m_lblTimeFormat";
            this.m_lblTimeFormat.ScreenOwnerName = "RcrdTime";
            this.m_lblTimeFormat.TextHorizontalAlignment = "Center";
            this.m_lblTimeFormat.TextVerticalAlignment = "Center";
            this.m_lblTimeFormat.Top = 142;
            this.m_lblTimeFormat.VisibleDynamicsValue = true;
            this.m_lblTimeFormat.Width = 179;
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
            this.m_Text5.ScreenOwnerName = "RcrdTime";
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
            this.m_Line.ScreenOwnerName = "RcrdTime";
            this.m_Line.Stroke = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Line.VisibleDynamicsValue = true;
            this.m_Line.X1 = 135;
            this.m_Line.X2 = 467;
            this.m_Line.Y1 = 63;
            this.m_Line.Y2 = 63;
            // 
            // m_lblCurrentTime
            // 
            this.m_lblCurrentTime.AutoSize = false;
            this.m_lblCurrentTime.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(237)))), ((int)(((byte)(242))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_lblCurrentTime.BlinkDynamicsValue = false;
            this.m_lblCurrentTime.EnabledDynamicsValue = true;
            this.m_lblCurrentTime.FontFamily = "Arial";
            this.m_lblCurrentTime.FontSizePixels = 18;
            this.m_lblCurrentTime.Height = 39;
            this.m_lblCurrentTime.Left = 205;
            this.m_lblCurrentTime.Name = "m_lblCurrentTime";
            this.m_lblCurrentTime.ScreenOwnerName = "RcrdTime";
            this.m_lblCurrentTime.TextHorizontalAlignment = "Center";
            this.m_lblCurrentTime.TextVerticalAlignment = "Center";
            this.m_lblCurrentTime.Top = 84;
            this.m_lblCurrentTime.VisibleDynamicsValue = true;
            this.m_lblCurrentTime.Width = 179;
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
            this.m_Text20.ScreenOwnerName = "RcrdTime";
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
            this.m_btnClear.ScreenOwnerName = "RcrdTime";
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
            this.m_btnBack.ScreenOwnerName = "RcrdTime";
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
            this.m_btnDash.EnabledDynamicsValue = true;
            this.m_btnDash.FontSizePixels = 18;
            this.m_btnDash.ForceTransparency = true;
            this.m_btnDash.Height = 45;
            this.m_btnDash.IndicatorMargin = null;
            this.m_btnDash.Left = 407;
            this.m_btnDash.Name = "m_btnDash";
            this.m_btnDash.RequiresTransparency = true;
            this.m_btnDash.ScreenOwnerName = "RcrdTime";
            this.m_btnDash.StyleName = "Glossy";
            this.m_btnDash.SymbolIntervalMapper = symbolintervalmapper3;
            this.m_btnDash.TextHeight = 22;
            this.m_btnDash.TextValue = 0D;
            this.m_btnDash.TextWidth = 54;
            this.m_btnDash.Top = 203;
            this.m_btnDash.Value = 0D;
            this.m_btnDash.VisibleDynamicsValue = true;
            this.m_btnDash.VisualPropertiesHashCode = 2023685050;
            this.m_btnDash.Width = 60;
            // 
            // m_btnMao
            // 
            this.m_btnMao.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnMao.BlinkDynamicsValue = false;
            this.m_btnMao.Bold = true;
            this.m_btnMao.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnMao.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_btnMao.EnabledDynamicsValue = true;
            this.m_btnMao.FontSizePixels = 18;
            this.m_btnMao.ForceTransparency = true;
            this.m_btnMao.Height = 45;
            this.m_btnMao.IndicatorMargin = null;
            this.m_btnMao.Left = 339;
            this.m_btnMao.Name = "m_btnMao";
            this.m_btnMao.RequiresTransparency = true;
            this.m_btnMao.ScreenOwnerName = "RcrdTime";
            this.m_btnMao.StyleName = "Glossy";
            this.m_btnMao.SymbolIntervalMapper = symbolintervalmapper4;
            this.m_btnMao.TextHeight = 22;
            this.m_btnMao.TextValue = 0D;
            this.m_btnMao.TextWidth = 54;
            this.m_btnMao.Top = 203;
            this.m_btnMao.Value = 0D;
            this.m_btnMao.VisibleDynamicsValue = true;
            this.m_btnMao.VisualPropertiesHashCode = 2023685050;
            this.m_btnMao.Width = 60;
            // 
            // m_btnS
            // 
            this.m_btnS.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnS.BlinkDynamicsValue = false;
            this.m_btnS.Bold = true;
            this.m_btnS.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnS.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_btnS.EnabledDynamicsValue = true;
            this.m_btnS.FontSizePixels = 18;
            this.m_btnS.ForceTransparency = true;
            this.m_btnS.Height = 45;
            this.m_btnS.IndicatorMargin = null;
            this.m_btnS.Left = 271;
            this.m_btnS.Name = "m_btnS";
            this.m_btnS.RequiresTransparency = true;
            this.m_btnS.ScreenOwnerName = "RcrdTime";
            this.m_btnS.StyleName = "Glossy";
            this.m_btnS.SymbolIntervalMapper = symbolintervalmapper5;
            this.m_btnS.TextHeight = 22;
            this.m_btnS.TextValue = 0D;
            this.m_btnS.TextWidth = 54;
            this.m_btnS.Top = 203;
            this.m_btnS.Value = 0D;
            this.m_btnS.VisibleDynamicsValue = true;
            this.m_btnS.VisualPropertiesHashCode = 2023685050;
            this.m_btnS.Width = 60;
            // 
            // m_btnM
            // 
            this.m_btnM.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnM.BlinkDynamicsValue = false;
            this.m_btnM.Bold = true;
            this.m_btnM.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnM.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_btnM.EnabledDynamicsValue = true;
            this.m_btnM.FontSizePixels = 18;
            this.m_btnM.ForceTransparency = true;
            this.m_btnM.Height = 45;
            this.m_btnM.IndicatorMargin = null;
            this.m_btnM.Left = 203;
            this.m_btnM.Name = "m_btnM";
            this.m_btnM.RequiresTransparency = true;
            this.m_btnM.ScreenOwnerName = "RcrdTime";
            this.m_btnM.StyleName = "Glossy";
            this.m_btnM.SymbolIntervalMapper = symbolintervalmapper6;
            this.m_btnM.TextHeight = 22;
            this.m_btnM.TextValue = 0D;
            this.m_btnM.TextWidth = 54;
            this.m_btnM.Top = 203;
            this.m_btnM.Value = 0D;
            this.m_btnM.VisibleDynamicsValue = true;
            this.m_btnM.VisualPropertiesHashCode = 2023685050;
            this.m_btnM.Width = 60;
            // 
            // m_btnH
            // 
            this.m_btnH.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(229))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnH.BlinkDynamicsValue = false;
            this.m_btnH.Bold = true;
            this.m_btnH.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnH.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_btnH.EnabledDynamicsValue = true;
            this.m_btnH.FontSizePixels = 18;
            this.m_btnH.ForceTransparency = true;
            this.m_btnH.Height = 45;
            this.m_btnH.IndicatorMargin = null;
            this.m_btnH.Left = 135;
            this.m_btnH.Name = "m_btnH";
            this.m_btnH.RequiresTransparency = true;
            this.m_btnH.ScreenOwnerName = "RcrdTime";
            this.m_btnH.StyleName = "Glossy";
            this.m_btnH.SymbolIntervalMapper = symbolintervalmapper7;
            this.m_btnH.TextHeight = 22;
            this.m_btnH.TextValue = 0D;
            this.m_btnH.TextWidth = 54;
            this.m_btnH.Top = 203;
            this.m_btnH.Value = 0D;
            this.m_btnH.VisibleDynamicsValue = true;
            this.m_btnH.VisualPropertiesHashCode = 2023685050;
            this.m_btnH.Width = 60;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(480, 272);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "RcrdTime";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_RcrdTime = true;
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
            if (!m_Initialized_RcrdTime) {
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
            this.DrawingPrimitives.Add(this.m_lblTimeFormat);
            this.DrawingPrimitives.Add(this.m_Text5);
            this.DrawingPrimitives.Add(this.m_Line);
            this.DrawingPrimitives.Add(this.m_lblCurrentTime);
            this.DrawingPrimitives.Add(this.m_Text20);
            this.DrawingPrimitives.Add(this.m_btnClear);
            this.DrawingPrimitives.Add(this.m_btnBack);
            this.DrawingPrimitives.Add(this.m_btnDash);
            this.DrawingPrimitives.Add(this.m_btnMao);
            this.DrawingPrimitives.Add(this.m_btnS);
            this.DrawingPrimitives.Add(this.m_btnM);
            this.DrawingPrimitives.Add(this.m_btnH);
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lblTimeFormat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_lblCurrentTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnDash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnMao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnH)).EndInit();
        }
        
        private void RcrdTime_Action_Opened(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("RcrdTime", "Opened", "Set Analog", "Tags.CurrentScreen", "");
            Neo.ApplicationFramework.Generated.Globals.Tags.CurrentScreen.SetAnalog(33);
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
        
        private void m_btnMao_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnMao", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_btnS_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnS", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_btnM_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnM", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_btnH_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnH", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(RcrdTime));
            this.m_Text2.Text = resources.GetText("RcrdTime.Text2.Text", "Time Format");
            this.m_lblTimeFormat.Text = resources.GetText("RcrdTime.lblTimeFormat.Text", "HH:MM:SS");
            this.m_Text5.Text = resources.GetText("RcrdTime.Text5.Text", "Format");
            this.m_lblCurrentTime.Text = resources.GetText("RcrdTime.lblCurrentTime.Text", "10:20:40");
            this.m_Text20.Text = resources.GetText("RcrdTime.Text20.Text", "Current\nTime");
            this.m_btnClear.Text = resources.GetText("RcrdTime.btnClear.Text", "Clear");
            this.m_btnBack.Text = resources.GetText("RcrdTime.btnBack.Text", "Back");
            this.m_btnDash.Text = resources.GetText("RcrdTime.btnDash.Text", "-");
            this.m_btnMao.Text = resources.GetText("RcrdTime.btnMao.Text", ":");
            this.m_btnS.Text = resources.GetText("RcrdTime.btnS.Text", "S");
            this.m_btnM.Text = resources.GetText("RcrdTime.btnM.Text", "M");
            this.m_btnH.Text = resources.GetText("RcrdTime.btnH.Text", "H");
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
            if (!m_Initialized_RcrdTime) {
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
