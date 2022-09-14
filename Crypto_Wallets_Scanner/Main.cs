using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


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
            List<string> api = new List<string>();
            api.Add("REFSSP45CHYSZTHZJQTPUEPSIKFHK8BKBF");
            api.Add("G5D41QG8P7TPMH7RZ3MRXU8UZ9TIHTD46E");
            api.Add("QM6QBUT2TJV9UDVC2ZJJ1SKAHC4224UW3X");
            api.Add("2DMMWYK1UJDYNG6PVGKEYFEWM4BGT5PFGS");
            api.Add("9IGDBNVNDWRWPD1DEA62SYABA5ZSIJQFJP");
            api.Add("PI61AG4F4GEFCAMU5NNT58R8U4SCCBG28A");
            api.Add("4GF58CNDHFGRNSZJJ1XS225RNCWC71BJAS");
            api.Add("IR522N8MSR5ZYZ4AYY473K9P6FQCY5TYN3");
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
                    string blockch="";
                    string networklink = "";
                    if (b == 0)
                    {
                        blockch = "BNB";
                        networklink = "api.bscscan.com";
                    }
                    else if (b == 1)
                    {
                        blockch = "Ether";
                        networklink = "api.etherscan.io";
                    }
                    else if (b == 2)
                    {
                        blockch = "Polygon";
                        networklink = "api.polygonscan.com";
                    }
                    else if (b == 3)
                    {
                        blockch = "Fantom";
                        networklink = "api.ftmscan.com";
                    }
                    else if (b == 4)
                    {
                        blockch = "Avalanche";
                        networklink = "api.snowtrace.io";
                    }
                    else if (b == 5)
                    {
                        blockch = "MoonRiver";
                        networklink = "api-moonriver.moonscan.io";
                    }
                    else if (b == 6)
                    {
                        blockch = "MoonBeam";
                        networklink = "api-moonbeam.moonscan.io";
                    }
                    else
                    {
                        blockch = "Cronos";
                        networklink = "api.cronoscan.com/";
                    }
                    result_txt.Text += ws.GetWalletBallance(wallets[i], api[b], blockch,networklink);
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
