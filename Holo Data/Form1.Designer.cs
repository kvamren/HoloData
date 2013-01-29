namespace Holo_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLeggtil = new System.Windows.Forms.Button();
            this.btnFjern = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.åpneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lagreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lagreSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redigerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gjørOmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printFraktbrevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPakkseddelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lagDokumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fjernDokumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fraktbrevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pakkseddelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numKoli = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMottaker = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateFilter = new System.Windows.Forms.DateTimePicker();
            this.treeBestillinger = new System.Windows.Forms.TreeView();
            this.chkBedriftSkjekk = new System.Windows.Forms.CheckBox();
            this.numFraktNr = new System.Windows.Forms.NumericUpDown();
            this.cmbDispSelect = new System.Windows.Forms.ComboBox();
            this.listMottakere = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateSendtInput = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTransportor = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKoli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFraktNr)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeggtil
            // 
            this.btnLeggtil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeggtil.Location = new System.Drawing.Point(568, 431);
            this.btnLeggtil.Name = "btnLeggtil";
            this.btnLeggtil.Size = new System.Drawing.Size(75, 23);
            this.btnLeggtil.TabIndex = 0;
            this.btnLeggtil.Text = "Legg til";
            this.btnLeggtil.UseVisualStyleBackColor = true;
            this.btnLeggtil.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFjern
            // 
            this.btnFjern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFjern.Location = new System.Drawing.Point(568, 460);
            this.btnFjern.Name = "btnFjern";
            this.btnFjern.Size = new System.Drawing.Size(75, 23);
            this.btnFjern.TabIndex = 2;
            this.btnFjern.Text = "Fjern";
            this.btnFjern.UseVisualStyleBackColor = true;
            this.btnFjern.Click += new System.EventHandler(this.btnFjern_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filToolStripMenuItem,
            this.redigerToolStripMenuItem,
            this.printFraktbrevToolStripMenuItem,
            this.printPakkseddelToolStripMenuItem,
            this.hjelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filToolStripMenuItem
            // 
            this.filToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyToolStripMenuItem,
            this.åpneToolStripMenuItem,
            this.lagreToolStripMenuItem,
            this.lagreSomToolStripMenuItem});
            this.filToolStripMenuItem.Name = "filToolStripMenuItem";
            this.filToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.filToolStripMenuItem.Text = "Fil";
            // 
            // nyToolStripMenuItem
            // 
            this.nyToolStripMenuItem.Name = "nyToolStripMenuItem";
            this.nyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nyToolStripMenuItem.Text = "Ny";
            // 
            // åpneToolStripMenuItem
            // 
            this.åpneToolStripMenuItem.Name = "åpneToolStripMenuItem";
            this.åpneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.åpneToolStripMenuItem.Text = "Åpne";
            // 
            // lagreToolStripMenuItem
            // 
            this.lagreToolStripMenuItem.Name = "lagreToolStripMenuItem";
            this.lagreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lagreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lagreToolStripMenuItem.Text = "Lagre";
            this.lagreToolStripMenuItem.Click += new System.EventHandler(this.lagreToolStripMenuItem_Click);
            // 
            // lagreSomToolStripMenuItem
            // 
            this.lagreSomToolStripMenuItem.Name = "lagreSomToolStripMenuItem";
            this.lagreSomToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lagreSomToolStripMenuItem.Text = "Lagre som...";
            this.lagreSomToolStripMenuItem.Click += new System.EventHandler(this.lagreSomToolStripMenuItem_Click);
            // 
            // redigerToolStripMenuItem
            // 
            this.redigerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.angreToolStripMenuItem,
            this.gjørOmToolStripMenuItem});
            this.redigerToolStripMenuItem.Name = "redigerToolStripMenuItem";
            this.redigerToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.redigerToolStripMenuItem.Text = "Rediger";
            // 
            // angreToolStripMenuItem
            // 
            this.angreToolStripMenuItem.Name = "angreToolStripMenuItem";
            this.angreToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.angreToolStripMenuItem.Text = "Angre";
            // 
            // gjørOmToolStripMenuItem
            // 
            this.gjørOmToolStripMenuItem.Name = "gjørOmToolStripMenuItem";
            this.gjørOmToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.gjørOmToolStripMenuItem.Text = "Gjør om";
            // 
            // printFraktbrevToolStripMenuItem
            // 
            this.printFraktbrevToolStripMenuItem.Name = "printFraktbrevToolStripMenuItem";
            this.printFraktbrevToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.printFraktbrevToolStripMenuItem.Text = "Lag Fraktbrev";
            this.printFraktbrevToolStripMenuItem.Click += new System.EventHandler(this.printFraktbrevToolStripMenuItem_Click);
            // 
            // printPakkseddelToolStripMenuItem
            // 
            this.printPakkseddelToolStripMenuItem.Name = "printPakkseddelToolStripMenuItem";
            this.printPakkseddelToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.printPakkseddelToolStripMenuItem.Text = "Print Pakkseddel";
            // 
            // hjelpToolStripMenuItem
            // 
            this.hjelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lagDokumentToolStripMenuItem,
            this.fjernDokumentToolStripMenuItem,
            this.printingToolStripMenuItem});
            this.hjelpToolStripMenuItem.Name = "hjelpToolStripMenuItem";
            this.hjelpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hjelpToolStripMenuItem.Text = "Hjelp";
            // 
            // lagDokumentToolStripMenuItem
            // 
            this.lagDokumentToolStripMenuItem.Name = "lagDokumentToolStripMenuItem";
            this.lagDokumentToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.lagDokumentToolStripMenuItem.Text = "1. Lag dokument";
            // 
            // fjernDokumentToolStripMenuItem
            // 
            this.fjernDokumentToolStripMenuItem.Name = "fjernDokumentToolStripMenuItem";
            this.fjernDokumentToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fjernDokumentToolStripMenuItem.Text = "2. Fjern dokument";
            // 
            // printingToolStripMenuItem
            // 
            this.printingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fraktbrevToolStripMenuItem,
            this.pakkseddelToolStripMenuItem});
            this.printingToolStripMenuItem.Name = "printingToolStripMenuItem";
            this.printingToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.printingToolStripMenuItem.Text = "3. Printing";
            // 
            // fraktbrevToolStripMenuItem
            // 
            this.fraktbrevToolStripMenuItem.Name = "fraktbrevToolStripMenuItem";
            this.fraktbrevToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fraktbrevToolStripMenuItem.Text = "Fraktbrev";
            // 
            // pakkseddelToolStripMenuItem
            // 
            this.pakkseddelToolStripMenuItem.Name = "pakkseddelToolStripMenuItem";
            this.pakkseddelToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.pakkseddelToolStripMenuItem.Text = "Pakkseddel";
            // 
            // numKoli
            // 
            this.numKoli.Location = new System.Drawing.Point(36, 415);
            this.numKoli.Name = "numKoli";
            this.numKoli.Size = new System.Drawing.Size(100, 20);
            this.numKoli.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Koli:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Frakt Nr:";
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(192, 414);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(177, 20);
            this.txtSender.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sender:";
            // 
            // txtMottaker
            // 
            this.txtMottaker.Location = new System.Drawing.Point(192, 439);
            this.txtMottaker.Name = "txtMottaker";
            this.txtMottaker.Size = new System.Drawing.Size(177, 20);
            this.txtMottaker.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mottaker:";
            // 
            // dateFilter
            // 
            this.dateFilter.Location = new System.Drawing.Point(12, 33);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(177, 20);
            this.dateFilter.TabIndex = 19;
            this.dateFilter.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // treeBestillinger
            // 
            this.treeBestillinger.AllowDrop = true;
            this.treeBestillinger.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeBestillinger.Location = new System.Drawing.Point(214, 33);
            this.treeBestillinger.Name = "treeBestillinger";
            this.treeBestillinger.Size = new System.Drawing.Size(423, 375);
            this.treeBestillinger.TabIndex = 20;
            this.treeBestillinger.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeBestillinger.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            // 
            // chkBedriftSkjekk
            // 
            this.chkBedriftSkjekk.AutoSize = true;
            this.chkBedriftSkjekk.Location = new System.Drawing.Point(378, 441);
            this.chkBedriftSkjekk.Name = "chkBedriftSkjekk";
            this.chkBedriftSkjekk.Size = new System.Drawing.Size(62, 17);
            this.chkBedriftSkjekk.TabIndex = 21;
            this.chkBedriftSkjekk.Text = "Bedrift?";
            this.chkBedriftSkjekk.UseVisualStyleBackColor = true;
            // 
            // numFraktNr
            // 
            this.numFraktNr.Location = new System.Drawing.Point(429, 415);
            this.numFraktNr.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numFraktNr.Name = "numFraktNr";
            this.numFraktNr.Size = new System.Drawing.Size(117, 20);
            this.numFraktNr.TabIndex = 8;
            // 
            // cmbDispSelect
            // 
            this.cmbDispSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDispSelect.FormattingEnabled = true;
            this.cmbDispSelect.Items.AddRange(new object[] {
            "Dag",
            "Måned",
            "År"});
            this.cmbDispSelect.Location = new System.Drawing.Point(12, 59);
            this.cmbDispSelect.Name = "cmbDispSelect";
            this.cmbDispSelect.Size = new System.Drawing.Size(177, 21);
            this.cmbDispSelect.TabIndex = 22;
            this.cmbDispSelect.SelectedIndexChanged += new System.EventHandler(this.cmbDispSelect_SelectedIndexChanged);
            // 
            // listMottakere
            // 
            this.listMottakere.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMottakere.FormattingEnabled = true;
            this.listMottakere.ItemHeight = 15;
            this.listMottakere.Location = new System.Drawing.Point(12, 112);
            this.listMottakere.Name = "listMottakere";
            this.listMottakere.Size = new System.Drawing.Size(177, 259);
            this.listMottakere.TabIndex = 23;
            this.listMottakere.SelectedIndexChanged += new System.EventHandler(this.listMottakere_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mottakere";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mottaker:";
            // 
            // dateSendtInput
            // 
            this.dateSendtInput.Location = new System.Drawing.Point(70, 463);
            this.dateSendtInput.Name = "dateSendtInput";
            this.dateSendtInput.Size = new System.Drawing.Size(177, 20);
            this.dateSendtInput.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Fjern bedrift";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Transportør:";
            // 
            // txtTransportor
            // 
            this.txtTransportor.Location = new System.Drawing.Point(323, 462);
            this.txtTransportor.Name = "txtTransportor";
            this.txtTransportor.Size = new System.Drawing.Size(177, 20);
            this.txtTransportor.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listMottakere);
            this.Controls.Add(this.cmbDispSelect);
            this.Controls.Add(this.chkBedriftSkjekk);
            this.Controls.Add(this.treeBestillinger);
            this.Controls.Add(this.dateSendtInput);
            this.Controls.Add(this.dateFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTransportor);
            this.Controls.Add(this.txtMottaker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numFraktNr);
            this.Controls.Add(this.numKoli);
            this.Controls.Add(this.btnFjern);
            this.Controls.Add(this.btnLeggtil);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Holo Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKoli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFraktNr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeggtil;
        private System.Windows.Forms.Button btnFjern;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem åpneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lagreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lagreSomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redigerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gjørOmToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numKoli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMottaker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem printFraktbrevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPakkseddelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lagDokumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fjernDokumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fraktbrevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pakkseddelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyToolStripMenuItem;
        private System.Windows.Forms.BindingSource transportBindingSource;
        private System.Windows.Forms.DateTimePicker dateFilter;
        private System.Windows.Forms.TreeView treeBestillinger;
        private System.Windows.Forms.CheckBox chkBedriftSkjekk;
        private System.Windows.Forms.NumericUpDown numFraktNr;
        private System.Windows.Forms.ComboBox cmbDispSelect;
        private System.Windows.Forms.ListBox listMottakere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateSendtInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTransportor;
    }
}

