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
	
	
	public partial class FilterSettingMid : Neo.ApplicationFramework.Tools.Recipe.Recipe
	{
		
		private Neo.ApplicationFramework.Tools.Recipe.RecipeItem m_Filter_Mid_UpperLimit;
		
		private Neo.ApplicationFramework.Tools.Recipe.RecipeItem m_Filter_Mid_Response;
		
		public FilterSettingMid()
		{
			this.InitializeComponent();
			this.ApplyLanguageInternal();
		}
		
		public Neo.ApplicationFramework.Tools.Recipe.RecipeItem Filter_Mid_UpperLimit
		{
			get
			{
				return this.m_Filter_Mid_UpperLimit;
			}
			set
			{
				this.m_Filter_Mid_UpperLimit = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Recipe.RecipeItem Filter_Mid_Response
		{
			get
			{
				return this.m_Filter_Mid_Response;
			}
			set
			{
				this.m_Filter_Mid_Response = value;
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
			this.Filter_Mid_UpperLimit = new Neo.ApplicationFramework.Tools.Recipe.RecipeItem();
			this.Filter_Mid_Response = new Neo.ApplicationFramework.Tools.Recipe.RecipeItem();
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
			this.Guid = new System.Guid("3725da6b-7d39-4f79-b8cc-b74a3e146b13");
			this.Filter_Mid_UpperLimit.ColumnName = "Filter_Mid_UpperLimit";
			this.Filter_Mid_UpperLimit.DataConnection = "Tags.FilterUpperLimitMid";
			this.Filter_Mid_UpperLimit.Name = "Filter_Mid_UpperLimit";
			this.Filter_Mid_UpperLimit.VisualSortOrder = 99;
			this.Filter_Mid_Response.ColumnName = "Filter_Mid_Response";
			this.Filter_Mid_Response.DataConnection = "Tags.FilterResponseMid";
			this.Filter_Mid_Response.Name = "Filter_Mid_Response";
			this.Filter_Mid_Response.VisualSortOrder = 100;
			this.RecipeItems.Add(this.Filter_Mid_UpperLimit);
			this.RecipeItems.Add(this.Filter_Mid_Response);
			this.SchemaVersion = ((long)(591));
			this.TableName = "FilterSettingMid";
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(FilterSettingMid));
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected override void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
			base.ApplyLanguage();
		}
	}
}
