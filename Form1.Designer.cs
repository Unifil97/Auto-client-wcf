namespace Autoclient
{
    partial class Form1
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
            this.Dtp = new System.Windows.Forms.DateTimePicker();
            this.lbVari = new System.Windows.Forms.Label();
            this.lbPolttoaine = new System.Windows.Forms.Label();
            this.cbvari = new System.Windows.Forms.ComboBox();
            this.cbpolttoaine = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btseuraava = new System.Windows.Forms.Button();
            this.btedellinen = new System.Windows.Forms.Button();
            this.btpoista = new System.Windows.Forms.Button();
            this.bttallenna = new System.Windows.Forms.Button();
            this.btuusitietue = new System.Windows.Forms.Button();
            this.cbmalli = new System.Windows.Forms.ComboBox();
            this.cbmerkki = new System.Windows.Forms.ComboBox();
            this.tbhinta = new System.Windows.Forms.TextBox();
            this.tbtilavuus = new System.Windows.Forms.TextBox();
            this.tbmittarilukema = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaYhteysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dtp
            // 
            this.Dtp.CustomFormat = "yyyy-MM-dd";
            this.Dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp.Location = new System.Drawing.Point(668, 210);
            this.Dtp.Name = "Dtp";
            this.Dtp.Size = new System.Drawing.Size(235, 26);
            this.Dtp.TabIndex = 41;
            this.Dtp.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // lbVari
            // 
            this.lbVari.AutoSize = true;
            this.lbVari.Location = new System.Drawing.Point(756, 95);
            this.lbVari.Name = "lbVari";
            this.lbVari.Size = new System.Drawing.Size(37, 20);
            this.lbVari.TabIndex = 40;
            this.lbVari.Text = "Vari";
            this.lbVari.Click += new System.EventHandler(this.lbVari_Click);
            // 
            // lbPolttoaine
            // 
            this.lbPolttoaine.AutoSize = true;
            this.lbPolttoaine.Location = new System.Drawing.Point(526, 95);
            this.lbPolttoaine.Name = "lbPolttoaine";
            this.lbPolttoaine.Size = new System.Drawing.Size(80, 20);
            this.lbPolttoaine.TabIndex = 39;
            this.lbPolttoaine.Text = "Polttoaine";
            this.lbPolttoaine.Click += new System.EventHandler(this.lbPolttoaine_Click);
            // 
            // cbvari
            // 
            this.cbvari.FormattingEnabled = true;
            this.cbvari.Location = new System.Drawing.Point(760, 148);
            this.cbvari.Name = "cbvari";
            this.cbvari.Size = new System.Drawing.Size(217, 28);
            this.cbvari.TabIndex = 38;
            this.cbvari.SelectedIndexChanged += new System.EventHandler(this.cbvari_SelectedIndexChanged);
            // 
            // cbpolttoaine
            // 
            this.cbpolttoaine.FormattingEnabled = true;
            this.cbpolttoaine.Location = new System.Drawing.Point(530, 148);
            this.cbpolttoaine.Name = "cbpolttoaine";
            this.cbpolttoaine.Size = new System.Drawing.Size(217, 28);
            this.cbpolttoaine.TabIndex = 37;
            this.cbpolttoaine.SelectedIndexChanged += new System.EventHandler(this.cbpolttoaine_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Malli";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Merkki";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Hinta";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Moottorintilavuus";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mittarinlukema";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btseuraava
            // 
            this.btseuraava.Location = new System.Drawing.Point(784, 360);
            this.btseuraava.Name = "btseuraava";
            this.btseuraava.Size = new System.Drawing.Size(193, 36);
            this.btseuraava.TabIndex = 31;
            this.btseuraava.Text = "Seuraava";
            this.btseuraava.UseVisualStyleBackColor = true;
            this.btseuraava.Click += new System.EventHandler(this.btseuraava_Click);
            // 
            // btedellinen
            // 
            this.btedellinen.Location = new System.Drawing.Point(600, 360);
            this.btedellinen.Name = "btedellinen";
            this.btedellinen.Size = new System.Drawing.Size(166, 36);
            this.btedellinen.TabIndex = 30;
            this.btedellinen.Text = "Edellenin";
            this.btedellinen.UseVisualStyleBackColor = true;
            this.btedellinen.Click += new System.EventHandler(this.btedellinen_Click);
            // 
            // btpoista
            // 
            this.btpoista.Location = new System.Drawing.Point(391, 360);
            this.btpoista.Name = "btpoista";
            this.btpoista.Size = new System.Drawing.Size(182, 36);
            this.btpoista.TabIndex = 29;
            this.btpoista.Text = "Poista";
            this.btpoista.UseVisualStyleBackColor = true;
            this.btpoista.Click += new System.EventHandler(this.btpoista_Click);
            // 
            // bttallenna
            // 
            this.bttallenna.Location = new System.Drawing.Point(192, 360);
            this.bttallenna.Name = "bttallenna";
            this.bttallenna.Size = new System.Drawing.Size(169, 36);
            this.bttallenna.TabIndex = 28;
            this.bttallenna.Text = "Tallenna";
            this.bttallenna.UseVisualStyleBackColor = true;
            this.bttallenna.Click += new System.EventHandler(this.bttallenna_Click);
            // 
            // btuusitietue
            // 
            this.btuusitietue.Location = new System.Drawing.Point(12, 360);
            this.btuusitietue.Name = "btuusitietue";
            this.btuusitietue.Size = new System.Drawing.Size(163, 36);
            this.btuusitietue.TabIndex = 27;
            this.btuusitietue.Text = "Uusitietue";
            this.btuusitietue.UseVisualStyleBackColor = true;
            this.btuusitietue.Click += new System.EventHandler(this.btuusitietue_Click);
            // 
            // cbmalli
            // 
            this.cbmalli.FormattingEnabled = true;
            this.cbmalli.Location = new System.Drawing.Point(307, 148);
            this.cbmalli.Name = "cbmalli";
            this.cbmalli.Size = new System.Drawing.Size(217, 28);
            this.cbmalli.TabIndex = 26;
            this.cbmalli.SelectedIndexChanged += new System.EventHandler(this.cbmalli_SelectedIndexChanged);
            // 
            // cbmerkki
            // 
            this.cbmerkki.FormattingEnabled = true;
            this.cbmerkki.Location = new System.Drawing.Point(84, 148);
            this.cbmerkki.Name = "cbmerkki";
            this.cbmerkki.Size = new System.Drawing.Size(217, 28);
            this.cbmerkki.TabIndex = 25;
            this.cbmerkki.SelectedIndexChanged += new System.EventHandler(this.LisaaMallit);
            // 
            // tbhinta
            // 
            this.tbhinta.Location = new System.Drawing.Point(516, 264);
            this.tbhinta.Name = "tbhinta";
            this.tbhinta.Size = new System.Drawing.Size(196, 26);
            this.tbhinta.TabIndex = 24;
            this.tbhinta.TextChanged += new System.EventHandler(this.tbhinta_TextChanged);
            // 
            // tbtilavuus
            // 
            this.tbtilavuus.Location = new System.Drawing.Point(314, 264);
            this.tbtilavuus.Name = "tbtilavuus";
            this.tbtilavuus.Size = new System.Drawing.Size(196, 26);
            this.tbtilavuus.TabIndex = 23;
            this.tbtilavuus.TextChanged += new System.EventHandler(this.tbtilavuus_TextChanged);
            // 
            // tbmittarilukema
            // 
            this.tbmittarilukema.Location = new System.Drawing.Point(96, 264);
            this.tbmittarilukema.Name = "tbmittarilukema";
            this.tbmittarilukema.Size = new System.Drawing.Size(196, 26);
            this.tbmittarilukema.TabIndex = 22;
            this.tbmittarilukema.TextChanged += new System.EventHandler(this.tbmittarilukema_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 33);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.fileToolStripMenuItem.Text = "Valikko";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem2});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.exitToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(141, 34);
            this.exitToolStripMenuItem2.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaYhteysToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // testaaYhteysToolStripMenuItem
            // 
            this.testaaYhteysToolStripMenuItem.Name = "testaaYhteysToolStripMenuItem";
            this.testaaYhteysToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.testaaYhteysToolStripMenuItem.Text = "Testaa Yhteys";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.Dtp);
            this.Controls.Add(this.lbVari);
            this.Controls.Add(this.lbPolttoaine);
            this.Controls.Add(this.cbvari);
            this.Controls.Add(this.cbpolttoaine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btseuraava);
            this.Controls.Add(this.btedellinen);
            this.Controls.Add(this.btpoista);
            this.Controls.Add(this.bttallenna);
            this.Controls.Add(this.btuusitietue);
            this.Controls.Add(this.cbmalli);
            this.Controls.Add(this.cbmerkki);
            this.Controls.Add(this.tbhinta);
            this.Controls.Add(this.tbtilavuus);
            this.Controls.Add(this.tbmittarilukema);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Dtp;
        private System.Windows.Forms.Label lbVari;
        private System.Windows.Forms.Label lbPolttoaine;
        private System.Windows.Forms.ComboBox cbvari;
        private System.Windows.Forms.ComboBox cbpolttoaine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btseuraava;
        private System.Windows.Forms.Button btedellinen;
        private System.Windows.Forms.Button btpoista;
        private System.Windows.Forms.Button bttallenna;
        private System.Windows.Forms.Button btuusitietue;
        private System.Windows.Forms.ComboBox cbmalli;
        private System.Windows.Forms.ComboBox cbmerkki;
        private System.Windows.Forms.TextBox tbhinta;
        private System.Windows.Forms.TextBox tbtilavuus;
        private System.Windows.Forms.TextBox tbmittarilukema;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaYhteysToolStripMenuItem;
    }
}

