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
    public partial class popConfirm : Neo.ApplicationFramework.Controls.Controls.Form {
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnYes;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_btnNo;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text;
        
        private bool m_Initialized_popConfirm;
        
        public popConfirm() {
            this.InitializeComponent();
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            this.Adapter.Closed += new System.EventHandler(this.popConfirm_Closed);
            this.Adapter.Opened += new System.EventHandler(this.popConfirm_Opened);
            this.m_btnYes.Click += new System.EventHandler(this.m_btnYes_Action_Click);
            this.m_btnNo.Click += new System.EventHandler(this.m_btnNo_Action_Click);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter btnYes {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_btnYes);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter btnNo {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_btnNo);
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
            this.m_btnYes = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_btnNo = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Text = new Neo.ApplicationFramework.Controls.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).BeginInit();
            this.SuspendLayout();
            // 
            // popConfirm
            // 
            this.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.SingleBorder;
            this.ControlBox = false;
            // 
            // m_btnYes
            // 
            this.m_btnYes.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(146)))), ((int)(((byte)(214))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnYes.BlinkDynamicsValue = false;
            this.m_btnYes.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnYes.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_btnYes.EnabledDynamicsValue = true;
            this.m_btnYes.FontSizePixels = 22;
            this.m_btnYes.ForceTransparency = true;
            this.m_btnYes.Height = 60;
            this.m_btnYes.IndicatorMargin = null;
            this.m_btnYes.Left = 44;
            this.m_btnYes.Name = "m_btnYes";
            this.m_btnYes.RequiresTransparency = true;
            this.m_btnYes.ScreenOwnerName = "popConfirm";
            this.m_btnYes.StyleName = "Glossy";
            this.m_btnYes.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_btnYes.TextHeight = 27;
            this.m_btnYes.TextValue = 0D;
            this.m_btnYes.TextWidth = 106;
            this.m_btnYes.Top = 122;
            this.m_btnYes.Value = 0D;
            this.m_btnYes.VisibleDynamicsValue = true;
            this.m_btnYes.VisualPropertiesHashCode = 1349808925;
            this.m_btnYes.Width = 112;
            // 
            // m_btnNo
            // 
            this.m_btnNo.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(146)))), ((int)(((byte)(214))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnNo.BlinkDynamicsValue = false;
            this.m_btnNo.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_btnNo.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_btnNo.EnabledDynamicsValue = true;
            this.m_btnNo.FontSizePixels = 22;
            this.m_btnNo.ForceTransparency = true;
            this.m_btnNo.Height = 60;
            this.m_btnNo.IndicatorMargin = null;
            this.m_btnNo.Left = 183;
            this.m_btnNo.Name = "m_btnNo";
            this.m_btnNo.RequiresTransparency = true;
            this.m_btnNo.ScreenOwnerName = "popConfirm";
            this.m_btnNo.StyleName = "Glossy";
            this.m_btnNo.SymbolIntervalMapper = symbolintervalmapper2;
            this.m_btnNo.TextHeight = 27;
            this.m_btnNo.TextValue = 0D;
            this.m_btnNo.TextWidth = 119;
            this.m_btnNo.Top = 122;
            this.m_btnNo.Value = 0D;
            this.m_btnNo.VisibleDynamicsValue = true;
            this.m_btnNo.VisualPropertiesHashCode = 1745019713;
            this.m_btnNo.Width = 125;
            // 
            // m_Text
            // 
            this.m_Text.AutoSize = false;
            this.m_Text.BlinkDynamicsValue = false;
            this.m_Text.EnabledDynamicsValue = true;
            this.m_Text.FontSizePixels = 22;
            this.m_Text.Height = 115;
            this.m_Text.Left = 7;
            this.m_Text.MultiLine = true;
            this.m_Text.Name = "m_Text";
            this.m_Text.ScreenOwnerName = "popConfirm";
            this.m_Text.Top = 6;
            this.m_Text.VisibleDynamicsValue = true;
            this.m_Text.Width = 329;
            this.m_Text.WordWrap = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ClientSize = new System.Drawing.Size(348, 190);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(63, 20);
            this.ModalScreen = true;
            this.Name = "popConfirm";
            this.PopupScreen = true;
            this.ScreenID = null;
            this.ScreenTitle = "  Confirm";
            this.StyleName = "Default";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_popConfirm = true;
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
            if (!m_Initialized_popConfirm) {
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
            this.DrawingPrimitives.Add(this.m_btnYes);
            this.DrawingPrimitives.Add(this.m_btnNo);
            this.DrawingPrimitives.Add(this.m_Text);
            ((System.ComponentModel.ISupportInitialize)(this.m_btnYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_btnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).EndInit();
        }
        
        private void m_btnYes_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnYes", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        private void m_btnNo_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_btnNo", "Click", "Execute Script", "Buzzer", "");
            Neo.ApplicationFramework.Generated.Globals.Buzzer.Buzz();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(popConfirm));
            this.m_btnYes.Text = resources.GetText("popConfirm.btnYes.Text", "Yes");
            this.m_btnNo.Text = resources.GetText("popConfirm.btnNo.Text", "No");
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
            if (!m_Initialized_popConfirm) {
                return;
            }
            base.ApplyLanguageInitialize();
            this.ApplyLanguageInternal();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ConnectDataBindings() {
            base.ConnectDataBindings();
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding1 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.GeneralConfirmMsg"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_Text.DataBindings.Add(dynamicBinding1);
            this.m_DynamicBindings.Add(dynamicBinding1);
        }
    }
}
