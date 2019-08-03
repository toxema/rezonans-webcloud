//--------------------------------------------------------------
// Press F1 to get help about using script.
// To access an object that is not located in the current class, start the call with Globals.
// When using events and timers be cautious not to generate memoryleaks,
// please see the help for more information.
//---------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
    using System.Windows.Forms;
    using System;
    using System.Drawing;
    using Neo.ApplicationFramework.Tools;
    using Neo.ApplicationFramework.Common.Graphics.Logic;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
    
    
    public partial class Updater
    {
		SmartApi.WebCloud webCloud=new SmartApi.WebCloud();
		
		public void init(){
			String	iot_uid=Globals.Tags.WEB_IOT_UID.Value;
			if(iot_uid==""){
				iot_uid=generateUID();
				Globals.Tags.WEB_IOT_UID.SetString(iot_uid);
			}
			startTimer();
		}
		
		private Timer timer = null; 

		public void startTimer(){
		
			if(timer==null){
				timer = new Timer();
				timer.Tick += new EventHandler(loop);
				timer.Interval = 2000;
				timer.Enabled = true;
			}
		}
		
		void loop(Object myObject, EventArgs myEventArgs) 
		{   
			
			float tank1=Globals.Tags.TANK_SEVIYE_1.Value;
			float tank2=Globals.Tags.TANK_SEVIYE_2.Value;
			
			if(webCloud!=null){
				webCloud.setFirma(Globals.Tags.WEB_FIRM_NAME.Value)
					.setName(Globals.Tags.WEB_DEVICE_NAME.Value)
					.setUid(Globals.Tags.WEB_IOT_UID.Value)
					.setUrl(Globals.Tags.WEB_PUBLISH_URL.Value)
					.setValue1(tank1.ToString("0.000"))
					.setValue2(tank2.ToString("0.000"));
				
				String responce=webCloud.publish();	
				Globals.Tags.WEB_RESPONCE.Value=responce;
				if(webCloud.online()){
					Globals.Tags.WEB_CONNECTOIN_STATUS.SetTag();
				}else{
					Globals.Tags.WEB_CONNECTOIN_STATUS.ResetTag();
				}	
			}
			
		}
		
 
		public String generateUID(){
		
			Guid g;
			g = Guid.NewGuid();
			return g.ToString();
		}
		
		
		void Updater_Created(System.Object sender, System.EventArgs e)
		{
			init();
		}

    }
}
