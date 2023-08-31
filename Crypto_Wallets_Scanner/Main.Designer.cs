
namespace Crypto_Wallets_Scanner
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.wallets_txt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.result_txt = new System.Windows.Forms.RichTextBox();
            this.start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.threads_tx = new System.Windows.Forms.NumericUpDown();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.threads_tx)).BeginInit();
            this.SuspendLayout();
            // 
            // wallets_txt
            // 
            this.wallets_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.wallets_txt.ForeColor = System.Drawing.Color.White;
            this.wallets_txt.Location = new System.Drawing.Point(56, 54);
            this.wallets_txt.Name = "wallets_txt";
            this.wallets_txt.Size = new System.Drawing.Size(294, 379);
            this.wallets_txt.TabIndex = 0;
            this.wallets_txt.Text = "";
            this.wallets_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(22)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(59, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Put Wallets Addresses here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(556, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(22)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(59, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wallet Loaded Count :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(299, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "0";
            // 
            // result_txt
            // 
            this.result_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.result_txt.ForeColor = System.Drawing.Color.White;
            this.result_txt.Location = new System.Drawing.Point(561, 54);
            this.result_txt.Name = "result_txt";
            this.result_txt.ReadOnly = true;
            this.result_txt.Size = new System.Drawing.Size(294, 421);
            this.result_txt.TabIndex = 1;
            this.result_txt.Text = "";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(22)))), ((int)(((byte)(70)))));
            this.start.FlatAppearance.BorderSize = 2;
            this.start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(22)))), ((int)(((byte)(70)))));
            this.start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(22)))), ((int)(((byte)(70)))));
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(22)))), ((int)(((byte)(70)))));
            this.start.Location = new System.Drawing.Point(630, 500);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(138, 53);
            this.start.TabIndex = 4;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.button1_Click);
            this.start.MouseEnter += new System.EventHandler(this.start_MouseEnter);
            this.start.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.start.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(22)))), ((int)(((byte)(70)))));
            this.panel1.Location = new System.Drawing.Point(444, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 517);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(22)))), ((int)(((byte)(70)))));
            this.label5.Location = new System.Drawing.Point(59, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Threads :";
            // 
            // threads_tx
            // 
            this.threads_tx.Location = new System.Drawing.Point(157, 521);
            this.threads_tx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threads_tx.Name = "threads_tx";
            this.threads_tx.Size = new System.Drawing.Size(64, 20);
            this.threads_tx.TabIndex = 9;
            this.threads_tx.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threads_tx.ValueChanged += new System.EventHandler(this.threads_ValueChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 585);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(896, 5);
            this.progressBar.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 590);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.threads_tx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result_txt);
            this.Controls.Add(this.wallets_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Crypto Wallets Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.threads_tx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox wallets_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox result_txt;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown threads_tx;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

