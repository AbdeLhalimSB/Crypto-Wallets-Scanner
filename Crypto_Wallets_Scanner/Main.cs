using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using HtmlAgilityPack;


namespace Crypto_Wallets_Scanner
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        List<string> wallets = new List<string>();
        private void button1_MouseHover(object sender, EventArgs e)
        {
            start.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            start.ForeColor = Color.FromArgb(234, 22, 70);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wallets.Clear();
            List<string> blockchains = new List<string>();
            blockchains.Add("https://bscscan.com/address/");
            blockchains.Add("https://etherscan.io/address/");
            blockchains.Add("https://polygonscan.com/address/");
            blockchains.Add("https://ftmscan.com/address/");
            blockchains.Add("https://snowtrace.io/address/");
            blockchains.Add("https://moonriver.moonscan.io/");
            blockchains.Add("https://moonscan.io/address/");
            blockchains.Add("https://cronoscan.com/address/");
            Wallets_Scanner ws = new Wallets_Scanner();
            foreach (string item in wallets_txt.Lines)
            {
                wallets.Add(item);
            }
            label4.Text = wallets.Count.ToString();
            for(int i = 0; i < wallets.Count; i++)
            {
                for(int b=0;b < 7; b++)
                {
                    string blockch;
                    if (b == 0)
                    {
                        blockch = "BNB";
                    }
                    else if (b == 1)
                    {
                        blockch = "Ether";
                    }
                    else if (b == 2)
                    {
                        blockch = "Polygon";
                    }
                    else if (b == 3)
                    {
                        blockch = "Fantom";
                    }
                    else if (b == 4)
                    {
                        blockch = "Avalanche";
                    }
                    else if (b == 5)
                    {
                        blockch = "MoonRiver";
                    }
                    else if (b == 6)
                    {
                        blockch = "MoonBeam";
                    }
                    else
                    {
                        blockch = "Cronos";
                    }
                    result_txt.Text += ws.GetWalletBallance(wallets[i], blockchains[b], blockch);
                }
                
            }
        }

        private void start_MouseEnter(object sender, EventArgs e)
        {
            start.ForeColor = Color.White;
        }

       
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }


    }
}
