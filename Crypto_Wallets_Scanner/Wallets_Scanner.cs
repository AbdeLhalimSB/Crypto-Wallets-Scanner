using System;
using System.IO;
using System.Net;

namespace Crypto_Wallets_Scanner
{
    class Wallets_Scanner
    {

        public Wallets_Scanner()
        {
            
        }
        public string GetWalletBallance(string wallet,string api,string blockch,string networklink)
        {
            string request = "https://"+networklink+"/api?module=account&action=balance&address="+wallet+"&apikey="+api;
            var req = (HttpWebRequest)WebRequest.Create(request);
            StreamReader responseReader = new StreamReader(req.GetResponse().GetResponseStream());
            var responseData = responseReader.ReadToEnd();
            try
            {
                string result = responseData.Substring(responseData.IndexOf("result") + 9);
                result = result.Trim('}');
                result = result.Trim('"');
                double wei = Convert.ToDouble(result) / Math.Pow(10, 18);
                if (wei.ToString().Contains("E"))
                {
                    return "";
                }
                else
                {
                    result = "\nwallet : " + wallet + " | " + wei + " " + blockch + "\n__________________________________________\n";
                    return result;
                }
            }
            catch
            {
                return "";
            }
        }
    }
}
