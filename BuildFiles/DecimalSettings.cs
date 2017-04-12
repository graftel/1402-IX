//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
	using Neo.ApplicationFramework.Tools.Actions;
	
	
	public partial class DecimalSettings : Neo.ApplicationFramework.Tools.Recipe.Recipe
	{
		
		private Neo.ApplicationFramework.Tools.Recipe.RecipeItem m_Low_sccm_decimal;
		
		private Neo.ApplicationFramework.Tools.Recipe.RecipeItem m_Low_slpm_decimal;
		
		private Neo.ApplicationFramework.Tools.Recipe.RecipeItem m_Low_scfm_decimal;
		
		private Neo.ApplicationFramework.Tools.Recipe.RecipeItem m_Low_scfh_decimal;
		
		private Neo.ApplicationFramework.Tools.Recipe.RecipeItem m_Mid_sccm_decimal;
		
		private Neo.ApplicationFramework.Tools.Recipe.RecipeItem m_Mid_slpm_decimal;
		
		private Neo.ApplicationFramework.Tools.Recipe.RecipeItem m_Mid_scfm_decimal;
		
		private Neo.ApplicationFramework.Tools.Recipe.RecipeItem m_Mid_scfh_decimal;
		
		private Neo.ApplicationFramework.Tools.Recipe.RecipeItem m_psig_decimal;
		
		private Neo.ApplicationFramework.Tools.Recipe.RecipeItem m_ksi_decimal;
		
		private Neo.ApplicationFramework.Tools.Recipe.RecipeItem m_bar_decimal;
		
		public DecimalSettings()
		{
			this.InitializeComponent();
			this.ApplyLanguageInternal();
		}
		
		public Neo.ApplicationFramework.Tools.Recipe.RecipeItem Low_sccm_decimal
		{
			get
			{
				return this.m_Low_sccm_decimal;
			}
			set
			{
				this.m_Low_sccm_decimal = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Recipe.RecipeItem Low_slpm_decimal
		{
			get
			{
				return this.m_Low_slpm_decimal;
			}
			set
			{
				this.m_Low_slpm_decimal = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Recipe.RecipeItem Low_scfm_decimal
		{
			get
			{
				return this.m_Low_scfm_decimal;
			}
			set
			{
				this.m_Low_scfm_decimal = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Recipe.RecipeItem Low_scfh_decimal
		{
			get
			{
				return this.m_Low_scfh_decimal;
			}
			set
			{
				this.m_Low_scfh_decimal = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Recipe.RecipeItem Mid_sccm_decimal
		{
			get
			{
				return this.m_Mid_sccm_decimal;
			}
			set
			{
				this.m_Mid_sccm_decimal = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Recipe.RecipeItem Mid_slpm_decimal
		{
			get
			{
				return this.m_Mid_slpm_decimal;
			}
			set
			{
				this.m_Mid_slpm_decimal = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Recipe.RecipeItem Mid_scfm_decimal
		{
			get
			{
				return this.m_Mid_scfm_decimal;
			}
			set
			{
				this.m_Mid_scfm_decimal = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Recipe.RecipeItem Mid_scfh_decimal
		{
			get
			{
				return this.m_Mid_scfh_decimal;
			}
			set
			{
				this.m_Mid_scfh_decimal = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Recipe.RecipeItem psig_decimal
		{
			get
			{
				return this.m_psig_decimal;
			}
			set
			{
				this.m_psig_decimal = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Recipe.RecipeItem ksi_decimal
		{
			get
			{
				return this.m_ksi_decimal;
			}
			set
			{
				this.m_ksi_decimal = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Recipe.RecipeItem bar_decimal
		{
			get
			{
				return this.m_bar_decimal;
			}
			set
			{
				this.m_bar_decimal = value;
			}
		}
		
		private void InitializeComponent()
		{
			this.InitializeObjectCreations();
			this.InitializeBeginInits();
			this.InitializeObjects();
			this.InitializeEndInits();
			this.ConnectDataBindings();
		}
		
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		public override void ConnectDataBindings()
		{
			base.ConnectDataBindings();
		}
		
		private void InitializeObjectCreations()
		{
			this.Low_sccm_decimal = new Neo.ApplicationFramework.Tools.Recipe.RecipeItem();
			this.Low_slpm_decimal = new Neo.ApplicationFramework.Tools.Recipe.RecipeItem();
			this.Low_scfm_decimal = new Neo.ApplicationFramework.Tools.Recipe.RecipeItem();
			this.Low_scfh_decimal = new Neo.ApplicationFramework.Tools.Recipe.RecipeItem();
			this.Mid_sccm_decimal = new Neo.ApplicationFramework.Tools.Recipe.RecipeItem();
			this.Mid_slpm_decimal = new Neo.ApplicationFramework.Tools.Recipe.RecipeItem();
			this.Mid_scfm_decimal = new Neo.ApplicationFramework.Tools.Recipe.RecipeItem();
			this.Mid_scfh_decimal = new Neo.ApplicationFramework.Tools.Recipe.RecipeItem();
			this.psig_decimal = new Neo.ApplicationFramework.Tools.Recipe.RecipeItem();
			this.ksi_decimal = new Neo.ApplicationFramework.Tools.Recipe.RecipeItem();
			this.bar_decimal = new Neo.ApplicationFramework.Tools.Recipe.RecipeItem();
		}
		
		private void InitializeBeginInits()
		{
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
		}
		
		private void InitializeEndInits()
		{
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		
		private void InitializeObjects()
		{
			this.DataVersion = ((long)(346));
			this.FieldNames.Add("Current");
			this.FieldNames.Add("Default");
			this.Guid = new System.Guid("4c34bd90-2c9d-4201-b716-86a9b7d658fb");
			this.Low_sccm_decimal.ColumnName = "Low_sccm_decimal";
			this.Low_sccm_decimal.DataConnection = "Tags.LowsccmDecimal";
			this.Low_sccm_decimal.Name = "Low_sccm_decimal";
			this.Low_sccm_decimal.VisualSortOrder = 99;
			this.Low_slpm_decimal.ColumnName = "Low_slpm_decimal";
			this.Low_slpm_decimal.DataConnection = "Tags.LowslpmDecimal";
			this.Low_slpm_decimal.Name = "Low_slpm_decimal";
			this.Low_slpm_decimal.VisualSortOrder = 100;
			this.Low_scfm_decimal.ColumnName = "Low_scfm_decimal";
			this.Low_scfm_decimal.DataConnection = "Tags.LowscfmDecimal";
			this.Low_scfm_decimal.Name = "Low_scfm_decimal";
			this.Low_scfm_decimal.VisualSortOrder = 101;
			this.Low_scfh_decimal.ColumnName = "Low_scfh_decimal";
			this.Low_scfh_decimal.DataConnection = "Tags.LowscfhDecimal";
			this.Low_scfh_decimal.Name = "Low_scfh_decimal";
			this.Low_scfh_decimal.VisualSortOrder = 102;
			this.Mid_sccm_decimal.ColumnName = "Mid_sccm_decimal";
			this.Mid_sccm_decimal.DataConnection = "Tags.MidsccmDecimal";
			this.Mid_sccm_decimal.Name = "Mid_sccm_decimal";
			this.Mid_sccm_decimal.VisualSortOrder = 103;
			this.Mid_slpm_decimal.ColumnName = "Mid_slpm_decimal";
			this.Mid_slpm_decimal.DataConnection = "Tags.MidslpmDecimal";
			this.Mid_slpm_decimal.Name = "Mid_slpm_decimal";
			this.Mid_slpm_decimal.VisualSortOrder = 104;
			this.Mid_scfm_decimal.ColumnName = "Mid_scfm_decimal";
			this.Mid_scfm_decimal.DataConnection = "Tags.MidscfmDecimal";
			this.Mid_scfm_decimal.Name = "Mid_scfm_decimal";
			this.Mid_scfm_decimal.VisualSortOrder = 105;
			this.Mid_scfh_decimal.ColumnName = "Mid_scfh_decimal";
			this.Mid_scfh_decimal.DataConnection = "Tags.MidscfhDecimal";
			this.Mid_scfh_decimal.Name = "Mid_scfh_decimal";
			this.Mid_scfh_decimal.VisualSortOrder = 106;
			this.psig_decimal.ColumnName = "psig_decimal";
			this.psig_decimal.DataConnection = "Tags.psigDecimal";
			this.psig_decimal.Name = "psig_decimal";
			this.psig_decimal.VisualSortOrder = 107;
			this.ksi_decimal.ColumnName = "ksi_decimal";
			this.ksi_decimal.DataConnection = "Tags.ksiDecimal";
			this.ksi_decimal.Name = "ksi_decimal";
			this.ksi_decimal.VisualSortOrder = 108;
			this.bar_decimal.ColumnName = "bar_decimal";
			this.bar_decimal.DataConnection = "Tags.barDecimal";
			this.bar_decimal.Name = "bar_decimal";
			this.bar_decimal.VisualSortOrder = 109;
			this.RecipeItems.Add(this.Low_sccm_decimal);
			this.RecipeItems.Add(this.Low_slpm_decimal);
			this.RecipeItems.Add(this.Low_scfm_decimal);
			this.RecipeItems.Add(this.Low_scfh_decimal);
			this.RecipeItems.Add(this.Mid_sccm_decimal);
			this.RecipeItems.Add(this.Mid_slpm_decimal);
			this.RecipeItems.Add(this.Mid_scfm_decimal);
			this.RecipeItems.Add(this.Mid_scfh_decimal);
			this.RecipeItems.Add(this.psig_decimal);
			this.RecipeItems.Add(this.ksi_decimal);
			this.RecipeItems.Add(this.bar_decimal);
			this.SchemaVersion = ((long)(591));
			this.TableName = "DecimalSettings";
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(DecimalSettings));
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected override void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
			base.ApplyLanguage();
		}
	}
}
