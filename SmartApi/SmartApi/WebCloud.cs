using System;

using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Text;
using System.Collections.Generic;
namespace SmartApi
{
    public class WebCloud
    {
        bool isOnline = false;
        String uid="";
        String name="";
        String url="";
        String value1="";
        String value2="";
        String firma = "";

        public WebCloud setUrl(String url_)
        {
            this.url = url_;
            return this;
        }
        public WebCloud setName(String name_)
        {
            this.name = name_;
            return this;
        }

        public WebCloud setUid(String uid_)
        {
            this.uid = uid_;
            return this;
        }

        public WebCloud setValue1(String value1_)
        {
            this.value1 = value1_;
            return this;
        }

        public WebCloud setValue2(String value2_)
        {
            this.value2 = value2_;
            return this;
        }
        public WebCloud setFirma(String firma_)
        {
            this.firma = firma_;
            return this;
        }
        public String publish()
        {
            String val = "";
            String request = "";
            request += url + "/webcloud/servis.php";
            request += "?uid=" + uid ;
            request += "&name=" + name.Replace(' ', '+') ;
            request += "&tank1=" + value1.Replace(',', '.') ;
            request += "&tank2=" + value2.Replace(',', '.') ;
            request += "&firm=" + firma.Replace(' ', '+');

            // String url = ip + getUrl + "?log=" + index  + "&n=" + istasyonAdi.replace(' ', '+') + "&t1=" + tank1.replace(',', '.') + "&t2=" + tank2.replace(',', '.') + "&f=" + firma.replace(' ', '+');
            val=httpRequest(request);
            return val;
        }

        public String httpRequest(String requestUrl)
        {
            String val = "";
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(requestUrl);
                req.Timeout = 1000;
                using (StreamReader reader = new StreamReader(req.GetResponse().GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    //MessageBox.Show(result);
                    val = result;
                }
                isOnline = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                val = ex.Message;
                isOnline = false;
            }
            return val;
        }
    }
}
