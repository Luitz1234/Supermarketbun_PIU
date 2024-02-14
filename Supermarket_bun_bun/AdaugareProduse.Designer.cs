namespace Supermarket_bun_bun
{
    partial class AdaugareProduse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumeProdus = new System.Windows.Forms.TextBox();
            this.tipProdus = new System.Windows.Forms.ComboBox();
            this.Expirare = new System.Windows.Forms.TextBox();
            this.Inapoi = new System.Windows.Forms.Button();
            this.Adauga = new System.Windows.Forms.Button();
            this.Sterge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(121, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adăugare produse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dată de expirare";
            // 
            // NumeProdus
            // 
            this.NumeProdus.Location = new System.Drawing.Point(190, 160);
            this.NumeProdus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumeProdus.Name = "NumeProdus";
            this.NumeProdus.Size = new System.Drawing.Size(160, 22);
            this.NumeProdus.TabIndex = 6;
            this.NumeProdus.TextChanged += new System.EventHandler(this.NumeProdus_TextChanged);
            // 
            // tipProdus
            // 
            this.tipProdus.FormattingEnabled = true;
            this.tipProdus.Items.AddRange(new object[] {
            "Panificatie",
            "Patiserie",
            "Mezeluri",
            "Lactate",
            "Peste",
            "Fructe",
            "Legume",
            "Dulciuri",
            "Congelate",
            "Detergenti"});
            this.tipProdus.Location = new System.Drawing.Point(190, 203);
            this.tipProdus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tipProdus.Name = "tipProdus";
            this.tipProdus.Size = new System.Drawing.Size(160, 24);
            this.tipProdus.TabIndex = 7;
            // 
            // Expirare
            // 
            this.Expirare.Location = new System.Drawing.Point(190, 237);
            this.Expirare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Expirare.Name = "Expirare";
            this.Expirare.Size = new System.Drawing.Size(160, 22);
            this.Expirare.TabIndex = 8;
            // 
            // Inapoi
            // 
            this.Inapoi.Location = new System.Drawing.Point(403, 310);
            this.Inapoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inapoi.Name = "Inapoi";
            this.Inapoi.Size = new System.Drawing.Size(100, 28);
            this.Inapoi.TabIndex = 9;
            this.Inapoi.Text = "Înapoi";
            this.Inapoi.UseVisualStyleBackColor = true;
            this.Inapoi.Click += new System.EventHandler(this.Inapoi_Click);
            // 
            // Adauga
            // 
            this.Adauga.Location = new System.Drawing.Point(403, 160);
            this.Adauga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Adauga.Name = "Adauga";
            this.Adauga.Size = new System.Drawing.Size(100, 31);
            this.Adauga.TabIndex = 10;
            this.Adauga.Text = "Adaugă";
            this.Adauga.UseVisualStyleBackColor = true;
            this.Adauga.Click += new System.EventHandler(this.Adauga_Click);
            // 
            // Sterge
            // 
            this.Sterge.Location = new System.Drawing.Point(403, 199);
            this.Sterge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sterge.Name = "Sterge";
            this.Sterge.Size = new System.Drawing.Size(100, 31);
            this.Sterge.TabIndex = 11;
            this.Sterge.Text = "Sterge";
            this.Sterge.UseVisualStyleBackColor = true;
            this.Sterge.Click += new System.EventHandler(this.Sterge_Click);
            // 
            // AdaugareProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(527, 360);
            this.Controls.Add(this.Sterge);
            this.Controls.Add(this.Adauga);
            this.Controls.Add(this.Inapoi);
            this.Controls.Add(this.Expirare);
            this.Controls.Add(this.tipProdus);
            this.Controls.Add(this.NumeProdus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdaugareProduse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdaugareProduse";
            this.Load += new System.EventHandler(this.AdaugareProduse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumeProdus;
        private System.Windows.Forms.ComboBox tipProdus;
        private System.Windows.Forms.TextBox Expirare;
        private System.Windows.Forms.Button Inapoi;
        private System.Windows.Forms.Button Adauga;
        private System.Windows.Forms.Button Sterge;
    }
}