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
	
	
	public partial class Tags : Neo.ApplicationFramework.Tools.OpcClient.GlobalController, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage
	{
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem TANK_SEVIYE_1;
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem TANK_SEVIYE_2;
		
		public Neo.ApplicationFramework.Tools.OpcClient.LightweightTag TANK_DOLUM_DEGERI;
		
		public Neo.ApplicationFramework.Tools.OpcClient.LightweightTag HAVA_YAPMAMA_ZAMANI;
		
		public Neo.ApplicationFramework.Tools.OpcClient.LightweightTag ACIL_STOP_ALARM;
		
		public Neo.ApplicationFramework.Tools.OpcClient.LightweightTag DISPENSER_GAZ_KACAGI_ALARM;
		
		public Neo.ApplicationFramework.Tools.OpcClient.LightweightTag TANK_SAHASI_GAZ_KACAGI_ALARM;
		
		public Neo.ApplicationFramework.Tools.OpcClient.LightweightTag TANKER_DOLUM_ALARM;
		
		public Neo.ApplicationFramework.Tools.OpcClient.LightweightTag KACAK_DOLUM_ALARM;
		
		public Neo.ApplicationFramework.Tools.OpcClient.SystemDataItem SystemTagSecond;
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem WEB_IOT_UID;
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem WEB_PUBLISH_URL;
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem WEB_DEVICE_NAME;
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem WEB_FIRM_NAME;
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem WEB_CONNECTOIN_STATUS;
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem WEB_RESPONCE;
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup1;
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup2;
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup3;
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup4;
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup5;
		
		public Tags()
		{
			this.InitializeComponent();
			this.ApplyLanguageInternal();
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
		}
		
		private void InitializeObjectCreations()
		{
			this.TANK_SEVIYE_1 = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("TANK_SEVIYE_1", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_REAL4)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", Core.Api.DataSource.AccessRights.Read, "PollGroup1", true, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_REAL4)), "", ((short)(1)), "", "");
			this.TANK_SEVIYE_2 = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("TANK_SEVIYE_2", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_REAL4)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", Core.Api.DataSource.AccessRights.Read, "PollGroup1", true, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_REAL4)), "", ((short)(1)), "", "");
			this.TANK_DOLUM_DEGERI = new Neo.ApplicationFramework.Tools.OpcClient.LightweightTag("TANK_DOLUM_DEGERI", "Controller1.DataItem3", 500, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_REAL4)), false, "", null);
			this.HAVA_YAPMAMA_ZAMANI = new Neo.ApplicationFramework.Tools.OpcClient.LightweightTag("HAVA_YAPMAMA_ZAMANI", "Controller1.DataItem4", 500, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_INTEGER4)), false, "", null);
			this.ACIL_STOP_ALARM = new Neo.ApplicationFramework.Tools.OpcClient.LightweightTag("ACIL_STOP_ALARM", "Controller1.DataItem5", 500, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_INTEGER2)), false, "", null);
			this.DISPENSER_GAZ_KACAGI_ALARM = new Neo.ApplicationFramework.Tools.OpcClient.LightweightTag("DISPENSER_GAZ_KACAGI_ALARM", "Controller1.DataItem6", 500, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_INTEGER2)), false, "", null);
			this.TANK_SAHASI_GAZ_KACAGI_ALARM = new Neo.ApplicationFramework.Tools.OpcClient.LightweightTag("TANK_SAHASI_GAZ_KACAGI_ALARM", "Controller1.DataItem7", 500, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_INTEGER2)), false, "", null);
			this.TANKER_DOLUM_ALARM = new Neo.ApplicationFramework.Tools.OpcClient.LightweightTag("TANKER_DOLUM_ALARM", "Controller1.DataItem8", 500, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_INTEGER2)), false, "", null);
			this.KACAK_DOLUM_ALARM = new Neo.ApplicationFramework.Tools.OpcClient.LightweightTag("KACAK_DOLUM_ALARM", "Controller1.DataItem9", 500, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_INTEGER2)), false, "", null);
			this.SystemTagSecond = new Neo.ApplicationFramework.Tools.OpcClient.SystemDataItem("Second", "SystemTagSecond", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_INTEGER2)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", Core.Api.DataSource.AccessRights.Read, "PollGroup1", true, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), "Second component of current time", ((short)(1)), "", "");
			this.WEB_IOT_UID = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("WEB_IOT_UID", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Core.Api.DataSource.AccessRights)((Core.Api.DataSource.AccessRights.Read | Core.Api.DataSource.AccessRights.Write))), "PollGroup1", true, true, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_STRING)), "", ((short)(1)), "", "");
			this.WEB_PUBLISH_URL = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("WEB_PUBLISH_URL", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Core.Api.DataSource.AccessRights)((Core.Api.DataSource.AccessRights.Read | Core.Api.DataSource.AccessRights.Write))), "PollGroup1", true, true, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_STRING)), "", ((short)(1)), "", "");
			this.WEB_DEVICE_NAME = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("WEB_DEVICE_NAME", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Core.Api.DataSource.AccessRights)((Core.Api.DataSource.AccessRights.Read | Core.Api.DataSource.AccessRights.Write))), "PollGroup1", true, true, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_STRING)), "", ((short)(1)), "", "");
			this.WEB_FIRM_NAME = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("WEB_FIRM_NAME", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Core.Api.DataSource.AccessRights)((Core.Api.DataSource.AccessRights.Read | Core.Api.DataSource.AccessRights.Write))), "PollGroup1", true, true, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_STRING)), "", ((short)(1)), "", "");
			this.WEB_CONNECTOIN_STATUS = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("WEB_CONNECTOIN_STATUS", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Core.Api.DataSource.AccessRights)((Core.Api.DataSource.AccessRights.Read | Core.Api.DataSource.AccessRights.Write))), "PollGroup1", true, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), "", ((short)(1)), "", "");
			this.WEB_RESPONCE = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("WEB_RESPONCE", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Core.Api.DataSource.AccessRights)((Core.Api.DataSource.AccessRights.Read | Core.Api.DataSource.AccessRights.Write))), "PollGroup1", true, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_STRING)), "", ((short)(1)), "", "");
			this.PollGroup1 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
			this.PollGroup2 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
			this.PollGroup3 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
			this.PollGroup4 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
			this.PollGroup5 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
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
			this.TANK_SEVIYE_1.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[] {
							"Controller1"}, new string[] {
							"DataItem1"}, true));
			this.TANK_SEVIYE_2.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[] {
							"Controller1"}, new string[] {
							"DataItem2"}, true));
			this.SystemTagSecond.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(new Neo.ApplicationFramework.Interfaces.VariantValue("0"), 0, new string[0], new string[0], true));
			this.WEB_IOT_UID.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[0], new string[0], true));
			this.WEB_PUBLISH_URL.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(new Neo.ApplicationFramework.Interfaces.VariantValue("http://www.rezonansmuhendislik.com/"), 0, new string[0], new string[0], true));
			this.WEB_DEVICE_NAME.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[0], new string[0], true));
			this.WEB_FIRM_NAME.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(new Neo.ApplicationFramework.Interfaces.VariantValue("MILANGAZ"), 0, new string[0], new string[0], true));
			this.WEB_CONNECTOIN_STATUS.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[0], new string[0], true));
			this.WEB_RESPONCE.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[0], new string[0], true));
			this.GlobalDataItems.Add(this.TANK_SEVIYE_1);
			this.GlobalDataItems.Add(this.TANK_SEVIYE_2);
			this.LightweightTags.Add(this.TANK_DOLUM_DEGERI);
			this.LightweightTags.Add(this.HAVA_YAPMAMA_ZAMANI);
			this.LightweightTags.Add(this.ACIL_STOP_ALARM);
			this.LightweightTags.Add(this.DISPENSER_GAZ_KACAGI_ALARM);
			this.LightweightTags.Add(this.TANK_SAHASI_GAZ_KACAGI_ALARM);
			this.LightweightTags.Add(this.TANKER_DOLUM_ALARM);
			this.LightweightTags.Add(this.KACAK_DOLUM_ALARM);
			this.GlobalDataItems.Add(this.SystemTagSecond);
			this.GlobalDataItems.Add(this.WEB_IOT_UID);
			this.GlobalDataItems.Add(this.WEB_PUBLISH_URL);
			this.GlobalDataItems.Add(this.WEB_DEVICE_NAME);
			this.GlobalDataItems.Add(this.WEB_FIRM_NAME);
			this.GlobalDataItems.Add(this.WEB_CONNECTOIN_STATUS);
			this.GlobalDataItems.Add(this.WEB_RESPONCE);
			this.PollGroup1.Interval = 500;
			this.PollGroup1.Name = "PollGroup1";
			this.PollGroup2.Interval = 500;
			this.PollGroup2.Name = "PollGroup2";
			this.PollGroup3.Interval = 500;
			this.PollGroup3.Name = "PollGroup3";
			this.PollGroup4.Interval = 500;
			this.PollGroup4.Name = "PollGroup4";
			this.PollGroup5.Interval = 500;
			this.PollGroup5.Name = "PollGroup5";
			this.PollGroups.Add(this.PollGroup1);
			this.PollGroups.Add(this.PollGroup2);
			this.PollGroups.Add(this.PollGroup3);
			this.PollGroups.Add(this.PollGroup4);
			this.PollGroups.Add(this.PollGroup5);
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(Tags));
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		void Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage.ApplyLanguage()
		{
			this.ApplyLanguage();
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected virtual void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
		}
	}
}
