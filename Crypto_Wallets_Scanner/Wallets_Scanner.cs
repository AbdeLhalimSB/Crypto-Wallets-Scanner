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
using System.Windows;

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
        public string GetWalletBallance(string wallet,string blockchaine,string blockch,string id)
        {
            string result = "";
            HtmlAgilityPack.HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(blockchaine + wallet);
            System.Threading.Thread.Sleep(2000);
            if (blockchaine.Contains("bitcoin"))
            {
                var bnb = doc.DocumentNode.SelectSingleNode("//span[contains(@class, '" + id + "')]");

                if (bnb != null)
                {
                    string balance = bnb.InnerText.Trim();
                    result = blockch + " Network, Wallet: " + wallet + " | Balance: " + balance.Replace(" ","").Replace("\n","").Replace("{{Math.abs(change)}}%","") + " \n_____________________________________________\n";
                }
                else
                {
                    result = "Element with class '" + id + "' not found.\n";
                }
                return result;
            }

            else
            {
                var bnb = doc.GetElementbyId(id);
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
}
