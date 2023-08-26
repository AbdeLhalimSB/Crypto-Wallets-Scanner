using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Crypto_Wallets_Scanner
{
    public partial class Main : Form
    {
        private BackgroundWorker worker;

        public Main()
        {
            InitializeComponent();

            // Initialize the BackgroundWorker
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        List<string> wallets = new List<string>();
        string result = string.Empty;
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
            result_txt.Clear();
            if (!worker.IsBusy)
            {
                // Clear the result textbox before starting the background task
                result_txt.Text = string.Empty;

                // Start the background task
                worker.RunWorkerAsync();
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Perform the background task here
            List<string> blockchains = new List<string>
            {
                "https://bscscan.com/address/",
                "https://etherscan.io/address/",
                "https://polygonscan.com/address/",
                "https://ftmscan.com/address/",
                "https://snowtrace.io/address/",
                "https://moonriver.moonscan.io/address/",
                "https://moonscan.io/address/",
                "https://cronoscan.com/address/"
            };

            Wallets_Scanner ws = new Wallets_Scanner();

            Invoke((Action)(() =>
            {
                wallets.Clear();
                foreach (string item in wallets_txt.Lines)
                {
                    wallets.Add(item);
                }
                label4.Text = wallets.Count.ToString();
            }));

            int totalWallets = wallets.Count * blockchains.Count;
            int progress = 0;

            foreach (string wallet in wallets)
            {
                for (int b = 0; b < blockchains.Count; b++)
                {
                    string blockch;
                    if (b == 0)
                    {
                        blockch = "BNB";
                        result = ws.GetWalletBallance(wallet, blockchains[b], blockch, "dropdownMenuBalance");
                    }
                    else if (b == 1)
                    {
                        blockch = "Ether";
                        result = ws.GetWalletBallance(wallet, blockchains[b], blockch, "dropdownMenuBalance");
                    }
                    else if (b == 2)
                    {
                        blockch = "Polygon";
                        result = ws.GetWalletBallance(wallet, blockchains[b], blockch, "availableBalanceDropdown");
                    }
                    else if (b == 3)
                    {
                        blockch = "Fantom";
                        result = ws.GetWalletBallance(wallet, blockchains[b], blockch, "availableBalanceDropdown");
                    }
                    else if (b == 4)
                    {
                        blockch = "Avalanche";
                        result = ws.GetWalletBallance(wallet, blockchains[b], blockch, "availableBalanceDropdown");
                    }
                    else if (b == 5)
                    {
                        blockch = "MoonRiver";
                        result = ws.GetWalletBallance(wallet, blockchains[b], blockch, "availableBalanceDropdown");
                    }
                    else if (b == 6)
                    {
                        blockch = "MoonBeam";
                        result = ws.GetWalletBallance(wallet, blockchains[b], blockch, "availableBalanceDropdown");
                    }
                    else
                    {
                        blockch = "Cronos";
                        result = ws.GetWalletBallance(wallet, blockchains[b], blockch, "availableBalanceDropdown");
                    }

                    // Report progress and result to the UI thread
                    worker.ReportProgress((progress * 100) / totalWallets, result);

                    progress++;
                }
            }
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update the UI with the progress and result
            result_txt.AppendText(e.UserState.ToString());
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // The background task is completed
        }

        private void start_MouseEnter(object sender, EventArgs e)
        {
            start.ForeColor = Color.White;
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Handle key press event if needed
        }
    }
}
