using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TO_lab002
{
    class Connection
    {
        private string URL;

        public Connection(string url)
        {
            this.URL = url;
        }

        public string GetURL() => URL;
         
        public string GetResource()
        {
            if (IsReachableUri(URL))
            {
                using (WebClient client = new WebClient())
                {
                    string s = client.DownloadString(URL);
                    return s;
                }
            }
            else
            {
                return null;
            }
        }

        public static bool IsReachableUri(string uriInput)
        {
            bool testStatus;

            WebRequest request = WebRequest.Create(uriInput);
            request.Timeout = 5000; // 5 Sec

            WebResponse response;
            try
            {
                response = request.GetResponse();
                testStatus = true; // Uri does exist                 
                response.Close();
            }
            catch (Exception)
            {
                testStatus = false; // Uri does not exist
            }
            // Result
            return testStatus;
        }
    }
}
