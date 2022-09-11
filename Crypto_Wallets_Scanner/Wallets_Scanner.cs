using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.IO;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;

namespace Crypto_Wallets_Scanner
{
    class Wallets_Scanner
    {
        string wallet_address;

        public Wallets_Scanner()
        {
        }

        public Wallets_Scanner(string wallet_address)
        {
            this.wallet_address = wallet_address;
        }
        public string GetWalletBallance(string wallet,string blockchaine,string blockch)
        {
            string result = "";
            HtmlAgilityPack.HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(blockchaine + wallet);
            System.Threading.Thread.Sleep(2000);
            var bnb = doc.GetElementbyId("availableBalanceDropdown");
            //string tokens = bnb.InnerText.Substring('\n');
            if (bnb != null)
            {
                string balance = bnb.InnerText.TrimEnd('\n') + " Tokens";
                result = blockch + " Network , Wallet : " + wallet + " | Balance : " + balance + "\n_____________________________________________\n";
                return result;
            }
            else
            {
                return result;
            }
        }
    }
}
