namespace ders7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Sil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fontName = new System.Windows.Forms.ComboBox();
            this.fontSize = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Ekle = new System.Windows.Forms.Button();
            this.Guncelle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sil
            // 
            this.Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sil.Location = new System.Drawing.Point(130, 12);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(112, 74);
            this.Sil.TabIndex = 1;
            this.Sil.Text = "sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.fontName);
            this.panel1.Controls.Add(this.fontSize);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Ekle);
            this.panel1.Controls.Add(this.Guncelle);
            this.panel1.Controls.Add(this.Sil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 93);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1019, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 34);
            this.button4.TabIndex = 7;
            this.button4.Text = "resim göster";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(946, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "renk";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(873, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "font dialog";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fontName
            // 
            this.fontName.FormattingEnabled = true;
            this.fontName.Location = new System.Drawing.Point(672, 14);
            this.fontName.Name = "fontName";
            this.fontName.Size = new System.Drawing.Size(182, 33);
            this.fontName.TabIndex = 4;
            // 
            // fontSize
            // 
            this.fontSize.FormattingEnabled = true;
            this.fontSize.Location = new System.Drawing.Point(484, 14);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(182, 33);
            this.fontSize.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "font ayarla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Ekle
            // 
            this.Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ekle.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ekle.Location = new System.Drawing.Point(12, 12);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(112, 74);
            this.Ekle.TabIndex = 0;
            this.Ekle.Text = "ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Guncelle
            // 
            this.Guncelle.Location = new System.Drawing.Point(248, 12);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(112, 74);
            this.Guncelle.TabIndex = 2;
            this.Guncelle.Text = "gülcelle";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(0, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1102, 357);
            this.listBox1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 100);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(149, 32);
            this.ekleToolStripMenuItem.Text = "ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(149, 32);
            this.silToolStripMenuItem.Text = "sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(149, 32);
            this.güncelleToolStripMenuItem.Text = "güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Sil;
        private Panel panel1;
        private Button Ekle;
        private Button Guncelle;
        private ListBox listBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ekleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private ComboBox fontName;
        private ComboBox fontSize;
        private Button button1;
        private Button button2;
        private FontDialog fontDialog1;
        private Button button3;
        private ColorDialog colorDialog1;
        private Button button4;
        private OpenFileDialog openFileDialog1;
    }
}