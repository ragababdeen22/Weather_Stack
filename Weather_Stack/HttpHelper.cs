using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Stack
{
    public class HttpHelper
    {
        //create  request and respond metho

        public string Json_Convert(string url)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(url);
            var response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            var jason = reader.ReadToEnd();
            return jason;
        }


    }
}
