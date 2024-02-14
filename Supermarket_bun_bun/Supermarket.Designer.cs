namespace Supermarket_bun_bun
{
    partial class Supermarket
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
            this.components = new System.ComponentModel.Container();
            this.adaugare_produse = new System.Windows.Forms.Button();
            this.afisare_produse = new System.Windows.Forms.Button();
            this.cautare_produse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // adaugare_produse
            // 
            this.adaugare_produse.Location = new System.Drawing.Point(13, 122);
            this.adaugare_produse.Margin = new System.Windows.Forms.Padding(4);
            this.adaugare_produse.Name = "adaugare_produse";
            this.adaugare_produse.Size = new System.Drawing.Size(149, 28);
            this.adaugare_produse.TabIndex = 0;
            this.adaugare_produse.Text = "Adaugare produse";
            this.adaugare_produse.UseVisualStyleBackColor = true;
            this.adaugare_produse.Click += new System.EventHandler(this.adaugare_produse_Click);
            // 
            // afisare_produse
            // 
            this.afisare_produse.Location = new System.Drawing.Point(13, 170);
            this.afisare_produse.Margin = new System.Windows.Forms.Padding(4);
            this.afisare_produse.Name = "afisare_produse";
            this.afisare_produse.Size = new System.Drawing.Size(149, 28);
            this.afisare_produse.TabIndex = 1;
            this.afisare_produse.Text = "Afisare produse";
            this.afisare_produse.UseVisualStyleBackColor = true;
            this.afisare_produse.Click += new System.EventHandler(this.afisare_produse_Click);
            // 
            // cautare_produse
            // 
            this.cautare_produse.Location = new System.Drawing.Point(116, 233);
            this.cautare_produse.Margin = new System.Windows.Forms.Padding(4);
            this.cautare_produse.Name = "cautare_produse";
            this.cautare_produse.Size = new System.Drawing.Size(123, 28);
            this.cautare_produse.TabIndex = 2;
            this.cautare_produse.Text = "Cautare produs";
            this.cautare_produse.UseVisualStyleBackColor = true;
            this.cautare_produse.Click += new System.EventHandler(this.cautare_produse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Supermarket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(291, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adaugare furnizor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 170);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Afisare furnizori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Supermarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(347, 370);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cautare_produse);
            this.Controls.Add(this.afisare_produse);
            this.Controls.Add(this.adaugare_produse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Supermarket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supermarket";
            this.Load += new System.EventHandler(this.Supermarket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adaugare_produse;
        private System.Windows.Forms.Button afisare_produse;
        private System.Windows.Forms.Button cautare_produse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
    }
}