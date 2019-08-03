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
	using Neo.ApplicationFramework.Tools.Alarm;
	
	
	public partial class AlarmServer : Neo.ApplicationFramework.Tools.Alarm.AlarmServer, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage
	{
		
		private Neo.ApplicationFramework.Tools.Alarm.AlarmGroup m_Default;
		
		private Neo.ApplicationFramework.Tools.Alarm.AlarmItem m_Default_AlarmItem0;
		
		private Neo.ApplicationFramework.Tools.Alarm.AlarmItem m_Default_AlarmItem1;
		
		private Neo.ApplicationFramework.Tools.Alarm.AlarmItem m_Default_AlarmItem2;
		
		private Neo.ApplicationFramework.Tools.Alarm.AlarmItem m_Default_AlarmItem3;
		
		private Neo.ApplicationFramework.Tools.Alarm.AlarmItem m_Default_AlarmItem4;
		
		public AlarmServer()
		{
			this.InitializeComponent();
			this.ApplyLanguageInternal();
		}
		
		public Neo.ApplicationFramework.Tools.Alarm.AlarmGroup Default
		{
			get
			{
				return this.m_Default;
			}
			set
			{
				this.m_Default = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Alarm.AlarmItem Default_AlarmItem0
		{
			get
			{
				return this.m_Default_AlarmItem0;
			}
			set
			{
				this.m_Default_AlarmItem0 = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Alarm.AlarmItem Default_AlarmItem1
		{
			get
			{
				return this.m_Default_AlarmItem1;
			}
			set
			{
				this.m_Default_AlarmItem1 = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Alarm.AlarmItem Default_AlarmItem2
		{
			get
			{
				return this.m_Default_AlarmItem2;
			}
			set
			{
				this.m_Default_AlarmItem2 = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Alarm.AlarmItem Default_AlarmItem3
		{
			get
			{
				return this.m_Default_AlarmItem3;
			}
			set
			{
				this.m_Default_AlarmItem3 = value;
			}
		}
		
		public Neo.ApplicationFramework.Tools.Alarm.AlarmItem Default_AlarmItem4
		{
			get
			{
				return this.m_Default_AlarmItem4;
			}
			set
			{
				this.m_Default_AlarmItem4 = value;
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
		public virtual void ConnectDataBindings()
		{
			this.Default_AlarmItem0.DataBindings.Add(new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", ((Neo.ApplicationFramework.Common.Data.RealtimeDataItemProxy)(Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateRealtimeProxy("Tags.ACIL_STOP_ALARM"))), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, null));
			this.Default_AlarmItem1.DataBindings.Add(new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", ((Neo.ApplicationFramework.Common.Data.RealtimeDataItemProxy)(Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateRealtimeProxy("Tags.DISPENSER_GAZ_KACAGI_ALARM"))), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, null));
			this.Default_AlarmItem2.DataBindings.Add(new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", ((Neo.ApplicationFramework.Common.Data.RealtimeDataItemProxy)(Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateRealtimeProxy("Tags.TANK_SAHASI_GAZ_KACAGI_ALARM"))), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, null));
			this.Default_AlarmItem3.DataBindings.Add(new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", ((Neo.ApplicationFramework.Common.Data.RealtimeDataItemProxy)(Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateRealtimeProxy("Tags.TANKER_DOLUM_ALARM"))), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, null));
			this.Default_AlarmItem4.DataBindings.Add(new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", ((Neo.ApplicationFramework.Common.Data.RealtimeDataItemProxy)(Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateRealtimeProxy("Tags.KACAK_DOLUM_ALARM"))), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, null));
		}
		
		private void InitializeObjectCreations()
		{
			this.Default = new Neo.ApplicationFramework.Tools.Alarm.AlarmGroup();
			this.Default_AlarmItem0 = new Neo.ApplicationFramework.Tools.Alarm.AlarmItem();
			this.Default_AlarmItem1 = new Neo.ApplicationFramework.Tools.Alarm.AlarmItem();
			this.Default_AlarmItem2 = new Neo.ApplicationFramework.Tools.Alarm.AlarmItem();
			this.Default_AlarmItem3 = new Neo.ApplicationFramework.Tools.Alarm.AlarmItem();
			this.Default_AlarmItem4 = new Neo.ApplicationFramework.Tools.Alarm.AlarmItem();
		}
		
		private void InitializeBeginInits()
		{
			((System.ComponentModel.ISupportInitialize)(this.Default_AlarmItem0)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_AlarmItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_AlarmItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_AlarmItem3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_AlarmItem4)).BeginInit();
		}
		
		private void InitializeEndInits()
		{
			((System.ComponentModel.ISupportInitialize)(this.Default_AlarmItem0)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_AlarmItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_AlarmItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_AlarmItem3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Default_AlarmItem4)).EndInit();
		}
		
		private void InitializeObjects()
		{
			this.Default.AcknowledgeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(127)))), ((int)(((byte)(70)))));
			this.Default.AcknowledgeForeColor = System.Drawing.Color.Black;
			this.Default.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(19)))), ((int)(((byte)(41)))));
			this.Default.ActiveForeColor = System.Drawing.Color.Black;
			this.Default_AlarmItem0.AcknowledgeRequired = true;
			this.Default_AlarmItem0.ComparerType = Neo.ApplicationFramework.Interfaces.ComparerTypes.EqualTo;
			this.Default_AlarmItem0.Contacts = null;
			this.Default_AlarmItem0.DefaultText = "ACİL STOP BUTONU BASILI";
			this.Default_AlarmItem0.DisplayName = "AlarmItem0";
			Neo.ApplicationFramework.Common.Dynamics.DynamicString DynamicString1 = new Neo.ApplicationFramework.Common.Dynamics.DynamicString();
			DynamicString1.Text = "ACİL STOP BUTONU BASILI";
			this.Default_AlarmItem0.DynamicString = DynamicString1;
			this.Default_AlarmItem0.EnableDistribution = false;
			this.Default_AlarmItem0.GroupId = new System.Guid("2f29adee-3bc0-41ab-bbcc-1bb0cb3d562a");
			this.Default_AlarmItem0.GroupName = "Default";
			this.Default_AlarmItem0.History = true;
			this.Default_AlarmItem0.IsDigitalValue = false;
			this.Default_AlarmItem0.Name = "Default_AlarmItem0";
			this.Default_AlarmItem0.OutputDevices = null;
			this.Default_AlarmItem0.RepeatCount = false;
			this.Default_AlarmItem0.TriggerValue = 1;
			this.Default_AlarmItem1.AcknowledgeRequired = true;
			this.Default_AlarmItem1.ComparerType = Neo.ApplicationFramework.Interfaces.ComparerTypes.EqualTo;
			this.Default_AlarmItem1.Contacts = null;
			this.Default_AlarmItem1.DefaultText = "DİSPENSER GAZ KAÇAĞI ";
			this.Default_AlarmItem1.DisplayName = "AlarmItem1";
			Neo.ApplicationFramework.Common.Dynamics.DynamicString DynamicString2 = new Neo.ApplicationFramework.Common.Dynamics.DynamicString();
			DynamicString2.Text = "DİSPENSER GAZ KAÇAĞI ";
			this.Default_AlarmItem1.DynamicString = DynamicString2;
			this.Default_AlarmItem1.EnableDistribution = false;
			this.Default_AlarmItem1.GroupId = new System.Guid("2f29adee-3bc0-41ab-bbcc-1bb0cb3d562a");
			this.Default_AlarmItem1.GroupName = "Default";
			this.Default_AlarmItem1.History = true;
			this.Default_AlarmItem1.IsDigitalValue = false;
			this.Default_AlarmItem1.Name = "Default_AlarmItem1";
			this.Default_AlarmItem1.OutputDevices = null;
			this.Default_AlarmItem1.RepeatCount = false;
			this.Default_AlarmItem1.TriggerValue = 2;
			this.Default_AlarmItem2.AcknowledgeRequired = true;
			this.Default_AlarmItem2.ComparerType = Neo.ApplicationFramework.Interfaces.ComparerTypes.EqualTo;
			this.Default_AlarmItem2.Contacts = null;
			this.Default_AlarmItem2.DefaultText = "TANK SAHASI GAZ KAÇAĞI";
			this.Default_AlarmItem2.DisplayName = "AlarmItem2";
			Neo.ApplicationFramework.Common.Dynamics.DynamicString DynamicString3 = new Neo.ApplicationFramework.Common.Dynamics.DynamicString();
			DynamicString3.Text = "TANK SAHASI GAZ KAÇAĞI";
			this.Default_AlarmItem2.DynamicString = DynamicString3;
			this.Default_AlarmItem2.EnableDistribution = false;
			this.Default_AlarmItem2.GroupId = new System.Guid("2f29adee-3bc0-41ab-bbcc-1bb0cb3d562a");
			this.Default_AlarmItem2.GroupName = "Default";
			this.Default_AlarmItem2.History = true;
			this.Default_AlarmItem2.IsDigitalValue = false;
			this.Default_AlarmItem2.Name = "Default_AlarmItem2";
			this.Default_AlarmItem2.OutputDevices = null;
			this.Default_AlarmItem2.RepeatCount = false;
			this.Default_AlarmItem2.TriggerValue = 4;
			this.Default_AlarmItem3.AcknowledgeRequired = true;
			this.Default_AlarmItem3.ComparerType = Neo.ApplicationFramework.Interfaces.ComparerTypes.EqualTo;
			this.Default_AlarmItem3.Contacts = null;
			this.Default_AlarmItem3.DefaultText = "TANKER DOLUM YAPILIYOR";
			this.Default_AlarmItem3.DisplayName = "AlarmItem3";
			Neo.ApplicationFramework.Common.Dynamics.DynamicString DynamicString4 = new Neo.ApplicationFramework.Common.Dynamics.DynamicString();
			DynamicString4.Text = "TANKER DOLUM YAPILIYOR";
			this.Default_AlarmItem3.DynamicString = DynamicString4;
			this.Default_AlarmItem3.EnableDistribution = false;
			this.Default_AlarmItem3.GroupId = new System.Guid("2f29adee-3bc0-41ab-bbcc-1bb0cb3d562a");
			this.Default_AlarmItem3.GroupName = "Default";
			this.Default_AlarmItem3.History = true;
			this.Default_AlarmItem3.IsDigitalValue = false;
			this.Default_AlarmItem3.Name = "Default_AlarmItem3";
			this.Default_AlarmItem3.OutputDevices = null;
			this.Default_AlarmItem3.RepeatCount = false;
			this.Default_AlarmItem3.TriggerValue = 8;
			this.Default_AlarmItem4.AcknowledgeRequired = true;
			this.Default_AlarmItem4.ComparerType = Neo.ApplicationFramework.Interfaces.ComparerTypes.EqualTo;
			this.Default_AlarmItem4.Contacts = null;
			this.Default_AlarmItem4.DefaultText = "KAÇAK DOLUM YAPILDI";
			this.Default_AlarmItem4.DisplayName = "AlarmItem4";
			Neo.ApplicationFramework.Common.Dynamics.DynamicString DynamicString5 = new Neo.ApplicationFramework.Common.Dynamics.DynamicString();
			DynamicString5.Text = "KAÇAK DOLUM YAPILDI";
			this.Default_AlarmItem4.DynamicString = DynamicString5;
			this.Default_AlarmItem4.EnableDistribution = false;
			this.Default_AlarmItem4.GroupId = new System.Guid("2f29adee-3bc0-41ab-bbcc-1bb0cb3d562a");
			this.Default_AlarmItem4.GroupName = "Default";
			this.Default_AlarmItem4.History = true;
			this.Default_AlarmItem4.IsDigitalValue = false;
			this.Default_AlarmItem4.Name = "Default_AlarmItem4";
			this.Default_AlarmItem4.OutputDevices = null;
			this.Default_AlarmItem4.RepeatCount = false;
			this.Default_AlarmItem4.TriggerValue = 16;
			this.Default.AlarmItems.Add(this.Default_AlarmItem0);
			this.Default.AlarmItems.Add(this.Default_AlarmItem1);
			this.Default.AlarmItems.Add(this.Default_AlarmItem2);
			this.Default.AlarmItems.Add(this.Default_AlarmItem3);
			this.Default.AlarmItems.Add(this.Default_AlarmItem4);
			this.Default.EnableDistribution = false;
			this.Default.InactiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(204)))), ((int)(((byte)(71)))));
			this.Default.InactiveForeColor = System.Drawing.Color.Black;
			this.Default.Name = "Default";
			this.Default.NormalBackColor = System.Drawing.SystemColors.Window;
			this.Default.NormalForeColor = System.Drawing.Color.Black;
			this.AlarmGroups.Add(this.Default);
			this.StorageEvent.AcknowledgeTime = null;
			this.StorageEvent.ActiveTime = null;
			this.StorageEvent.AlarmGroupName = "";
			this.StorageEvent.AlarmGroupText = "";
			this.StorageEvent.AlarmItemId = new System.Guid("00000000-0000-0000-0000-000000000000");
			this.StorageEvent.Count = 0;
			this.StorageEvent.DisplayText = "";
			this.StorageEvent.EnableDistribution = false;
			this.StorageEvent.ForceToList = false;
			this.StorageEvent.History = false;
			this.StorageEvent.InActiveTime = null;
			this.StorageEvent.NormalTime = null;
			this.StorageEvent.RepeatCount = false;
			this.StorageEvent.State = Neo.ApplicationFramework.Interfaces.AlarmState.Normal;
			this.StorageEvent.TableName = "AlarmServer";
			this.StorageEvent.Text = "";
			this.SummaryAlarmComponentMode = Neo.ApplicationFramework.Interfaces.AlarmServerAlarmEventsState.Active;
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(AlarmServer));
			this.m_Default.Text = resources.GetText("AlarmServer.Default.Text", "Default");
			this.m_Default_AlarmItem0.StaticText = resources.GetText("AlarmServer.Default_AlarmItem0.StaticText", "ACİL STOP BUTONU BASILI");
			this.m_Default_AlarmItem1.StaticText = resources.GetText("AlarmServer.Default_AlarmItem1.StaticText", "DİSPENSER GAZ KAÇAĞI ");
			this.m_Default_AlarmItem2.StaticText = resources.GetText("AlarmServer.Default_AlarmItem2.StaticText", "TANK SAHASI GAZ KAÇAĞI");
			this.m_Default_AlarmItem3.StaticText = resources.GetText("AlarmServer.Default_AlarmItem3.StaticText", "TANKER DOLUM YAPILIYOR");
			this.m_Default_AlarmItem4.StaticText = resources.GetText("AlarmServer.Default_AlarmItem4.StaticText", "KAÇAK DOLUM YAPILDI");
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		void Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage.ApplyLanguage()
		{
			this.ApplyLanguage();
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected override void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
			base.ApplyLanguage();
		}
	}
}
