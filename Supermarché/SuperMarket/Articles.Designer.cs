namespace SuperMarket
{
    partial class Articles
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NomTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrixTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StockTb = new System.Windows.Forms.TextBox();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.DateExpiration = new System.Windows.Forms.Label();
            this.ExpTb = new System.Windows.Forms.DateTimePicker();
            this.EnregistrerBtn = new System.Windows.Forms.Button();
            this.SuprimerBtn = new System.Windows.Forms.Button();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.FiltrerCb = new System.Windows.Forms.ComboBox();
            this.ActualiserBtn = new System.Windows.Forms.Button();
            this.ArticlesListe = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesListe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 763);
            this.panel1.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(19, 500);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 22);
            this.label13.TabIndex = 13;
            this.label13.Text = "Deconnexion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(45, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "Facturation";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(45, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Catégories";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(45, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Vendeurs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(45, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Articles";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1325, 60);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(622, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion des Articles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(231, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nom de l\'Article";
            // 
            // NomTb
            // 
            this.NomTb.Location = new System.Drawing.Point(236, 140);
            this.NomTb.Name = "NomTb";
            this.NomTb.Size = new System.Drawing.Size(171, 23);
            this.NomTb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(463, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prix de l\'Article en $";
            // 
            // PrixTb
            // 
            this.PrixTb.Location = new System.Drawing.Point(468, 140);
            this.PrixTb.Name = "PrixTb";
            this.PrixTb.Size = new System.Drawing.Size(204, 23);
            this.PrixTb.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(741, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Catégories";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(934, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stock";
            // 
            // StockTb
            // 
            this.StockTb.Location = new System.Drawing.Point(939, 140);
            this.StockTb.Name = "StockTb";
            this.StockTb.Size = new System.Drawing.Size(204, 23);
            this.StockTb.TabIndex = 14;
            // 
            // CatCb
            // 
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Location = new System.Drawing.Point(746, 139);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(121, 25);
            this.CatCb.TabIndex = 15;
            // 
            // DateExpiration
            // 
            this.DateExpiration.AutoSize = true;
            this.DateExpiration.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateExpiration.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DateExpiration.Location = new System.Drawing.Point(1196, 99);
            this.DateExpiration.Name = "DateExpiration";
            this.DateExpiration.Size = new System.Drawing.Size(136, 22);
            this.DateExpiration.TabIndex = 16;
            this.DateExpiration.Text = "Date Expiration";
            // 
            // ExpTb
            // 
            this.ExpTb.Location = new System.Drawing.Point(1200, 140);
            this.ExpTb.Name = "ExpTb";
            this.ExpTb.Size = new System.Drawing.Size(200, 23);
            this.ExpTb.TabIndex = 17;
            // 
            // EnregistrerBtn
            // 
            this.EnregistrerBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.EnregistrerBtn.FlatAppearance.BorderSize = 0;
            this.EnregistrerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnregistrerBtn.Location = new System.Drawing.Point(804, 220);
            this.EnregistrerBtn.Name = "EnregistrerBtn";
            this.EnregistrerBtn.Size = new System.Drawing.Size(167, 35);
            this.EnregistrerBtn.TabIndex = 18;
            this.EnregistrerBtn.Text = "Enregistrer";
            this.EnregistrerBtn.UseVisualStyleBackColor = false;
            this.EnregistrerBtn.Click += new System.EventHandler(this.EnregistrerBtn_Click);
            // 
            // SuprimerBtn
            // 
            this.SuprimerBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.SuprimerBtn.FlatAppearance.BorderSize = 0;
            this.SuprimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuprimerBtn.Location = new System.Drawing.Point(1034, 220);
            this.SuprimerBtn.Name = "SuprimerBtn";
            this.SuprimerBtn.Size = new System.Drawing.Size(167, 35);
            this.SuprimerBtn.TabIndex = 19;
            this.SuprimerBtn.Text = "Supprimer";
            this.SuprimerBtn.UseVisualStyleBackColor = false;
            this.SuprimerBtn.Click += new System.EventHandler(this.SuprimerBtn_Click);
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.ModifierBtn.FlatAppearance.BorderSize = 0;
            this.ModifierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifierBtn.Location = new System.Drawing.Point(543, 220);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(167, 35);
            this.ModifierBtn.TabIndex = 20;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = false;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(758, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Liste des Articles";
            // 
            // FiltrerCb
            // 
            this.FiltrerCb.FormattingEnabled = true;
            this.FiltrerCb.Location = new System.Drawing.Point(776, 351);
            this.FiltrerCb.Name = "FiltrerCb";
            this.FiltrerCb.Size = new System.Drawing.Size(121, 25);
            this.FiltrerCb.TabIndex = 23;
            this.FiltrerCb.SelectedIndexChanged += new System.EventHandler(this.FiltrerCb_SelectedIndexChanged);
            // 
            // ActualiserBtn
            // 
            this.ActualiserBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.ActualiserBtn.FlatAppearance.BorderSize = 0;
            this.ActualiserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualiserBtn.Location = new System.Drawing.Point(986, 351);
            this.ActualiserBtn.Name = "ActualiserBtn";
            this.ActualiserBtn.Size = new System.Drawing.Size(167, 28);
            this.ActualiserBtn.TabIndex = 24;
            this.ActualiserBtn.Text = "Actualiser";
            this.ActualiserBtn.UseVisualStyleBackColor = false;
            this.ActualiserBtn.Click += new System.EventHandler(this.ActualiserBtn_Click);
            // 
            // ArticlesListe
            // 
            this.ArticlesListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArticlesListe.Location = new System.Drawing.Point(285, 417);
            this.ArticlesListe.Name = "ArticlesListe";
            this.ArticlesListe.RowHeadersWidth = 51;
            this.ArticlesListe.RowTemplate.Height = 24;
            this.ArticlesListe.Size = new System.Drawing.Size(1178, 291);
            this.ArticlesListe.TabIndex = 41;
            this.ArticlesListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArticlesListe_CellContentClick);
            // 
            // Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 763);
            this.Controls.Add(this.ArticlesListe);
            this.Controls.Add(this.ActualiserBtn);
            this.Controls.Add(this.FiltrerCb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.SuprimerBtn);
            this.Controls.Add(this.EnregistrerBtn);
            this.Controls.Add(this.ExpTb);
            this.Controls.Add(this.DateExpiration);
            this.Controls.Add(this.CatCb);
            this.Controls.Add(this.StockTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrixTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Articles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articles";
            this.Load += new System.EventHandler(this.Articles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArticlesListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NomTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrixTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StockTb;
        private System.Windows.Forms.ComboBox CatCb;
        private System.Windows.Forms.Label DateExpiration;
        private System.Windows.Forms.DateTimePicker ExpTb;
        private System.Windows.Forms.Button EnregistrerBtn;
        private System.Windows.Forms.Button SuprimerBtn;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox FiltrerCb;
        private System.Windows.Forms.Button ActualiserBtn;
        private System.Windows.Forms.DataGridView ArticlesListe;
    }
}