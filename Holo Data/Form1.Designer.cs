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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button2 = new System.Windows.Forms.Button();
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transport = new Holo_Data.Transport();
            this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Legg til";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 33);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Fjern";
            this.button2.UseVisualStyleBackColor = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
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
            this.nyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.nyToolStripMenuItem.Text = "Ny";
            // 
            // åpneToolStripMenuItem
            // 
            this.åpneToolStripMenuItem.Name = "åpneToolStripMenuItem";
            this.åpneToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.åpneToolStripMenuItem.Text = "Åpne";
            // 
            // lagreToolStripMenuItem
            // 
            this.lagreToolStripMenuItem.Name = "lagreToolStripMenuItem";
            this.lagreToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.lagreToolStripMenuItem.Text = "Lagre";
            // 
            // lagreSomToolStripMenuItem
            // 
            this.lagreSomToolStripMenuItem.Name = "lagreSomToolStripMenuItem";
            this.lagreSomToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.lagreSomToolStripMenuItem.Text = "Lagre som...";
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
            this.printFraktbrevToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.printFraktbrevToolStripMenuItem.Text = "Print Fraktbrev";
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 444);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(373, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 415);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(36, 415);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(34, 20);
            this.numericUpDown1.TabIndex = 8;
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
            this.label2.Location = new System.Drawing.Point(229, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Frakt Nr.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 414);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sender";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(443, 414);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mottaker";
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(9, 207);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(171, 199);
            this.printPreviewControl1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.transportBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(192, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(321, 354);
            this.dataGridView1.TabIndex = 17;
            // 
            // transport
            // 
            this.transport.DataSetName = "Transport";
            this.transport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportBindingSource
            // 
            this.transportBindingSource.DataSource = this.transport;
            this.transportBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 480);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Holo Data";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem åpneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lagreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lagreSomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redigerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gjørOmToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem printFraktbrevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPakkseddelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lagDokumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fjernDokumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fraktbrevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pakkseddelToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.ToolStripMenuItem nyToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource transportBindingSource;
        private Transport transport;
    }
}

