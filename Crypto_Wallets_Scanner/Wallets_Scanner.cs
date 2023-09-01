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

        static bool ContainsOnlyZeroesAndSpecialChars(string input)
        {
            foreach (char c in input)
            {
                // Check if the character is not '0' and not a special character
                if (c != '0' && !IsSpecialCharacter(c))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsSpecialCharacter(char c)
        {
            // Define the set of special characters you want to consider
            string specialChars = "!@#$%^&*()_+[]{}|;':\",./<>?`~\\-";

            // Check if the character is in the set of special characters
            return specialChars.Contains(c);
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
                    balance = balance.Replace(" ", "").Replace("\n", "").Replace("{{Math.abs(change)}}%", "");

                    if (balance == "0BTC0USD")
                    {
                        result = string.Empty;
                    }
                    else
                    {
                        result = blockch + " Network, Wallet: " + wallet + " | Balance: " + balance + " \n_____________________________________________\n";
                    }

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
