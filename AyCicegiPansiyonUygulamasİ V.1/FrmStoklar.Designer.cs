namespace AyCicegiPansiyonUygulamasİ_V._1
{
    partial class FrmStoklar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStoklar));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblelektrik = new System.Windows.Forms.Label();
            this.lblsu = new System.Windows.Forms.Label();
            this.lblinternet = new System.Windows.Forms.Label();
            this.txtelektrik = new System.Windows.Forms.TextBox();
            this.txtsu = new System.Windows.Forms.TextBox();
            this.txtinternet = new System.Windows.Forms.TextBox();
            this.Kaydet2 = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtcerez = new System.Windows.Forms.TextBox();
            this.txticecekler = new System.Windows.Forms.TextBox();
            this.txtgidalar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnKaydet2 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Aqua;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1, 276);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(458, 250);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gıda ";
            this.columnHeader1.Width = 121;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İçecek";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Çerez";
            // 
            // lblelektrik
            // 
            this.lblelektrik.AutoSize = true;
            this.lblelektrik.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblelektrik.Location = new System.Drawing.Point(38, 24);
            this.lblelektrik.Name = "lblelektrik";
            this.lblelektrik.Size = new System.Drawing.Size(85, 28);
            this.lblelektrik.TabIndex = 8;
            this.lblelektrik.Text = "Elektrik:";
            // 
            // lblsu
            // 
            this.lblsu.AutoSize = true;
            this.lblsu.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsu.Location = new System.Drawing.Point(38, 76);
            this.lblsu.Name = "lblsu";
            this.lblsu.Size = new System.Drawing.Size(40, 28);
            this.lblsu.TabIndex = 9;
            this.lblsu.Text = "Su:";
            // 
            // lblinternet
            // 
            this.lblinternet.AutoSize = true;
            this.lblinternet.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblinternet.Location = new System.Drawing.Point(38, 135);
            this.lblinternet.Name = "lblinternet";
            this.lblinternet.Size = new System.Drawing.Size(90, 28);
            this.lblinternet.TabIndex = 10;
            this.lblinternet.Text = "İnternet:";
            // 
            // txtelektrik
            // 
            this.txtelektrik.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtelektrik.Location = new System.Drawing.Point(172, 24);
            this.txtelektrik.Name = "txtelektrik";
            this.txtelektrik.Size = new System.Drawing.Size(272, 34);
            this.txtelektrik.TabIndex = 11;
            // 
            // txtsu
            // 
            this.txtsu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsu.Location = new System.Drawing.Point(172, 76);
            this.txtsu.Name = "txtsu";
            this.txtsu.Size = new System.Drawing.Size(272, 34);
            this.txtsu.TabIndex = 12;
            // 
            // txtinternet
            // 
            this.txtinternet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtinternet.Location = new System.Drawing.Point(172, 129);
            this.txtinternet.Name = "txtinternet";
            this.txtinternet.Size = new System.Drawing.Size(272, 34);
            this.txtinternet.TabIndex = 13;
            this.txtinternet.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Kaydet2
            // 
            this.Kaydet2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kaydet2.Location = new System.Drawing.Point(788, 545);
            this.Kaydet2.Name = "Kaydet2";
            this.Kaydet2.Size = new System.Drawing.Size(212, 45);
            this.Kaydet2.TabIndex = 14;
            this.Kaydet2.Text = "Kaydet";
            this.Kaydet2.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(160, 186);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(212, 45);
            this.btnKaydet.TabIndex = 21;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // txtcerez
            // 
            this.txtcerez.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcerez.Location = new System.Drawing.Point(138, 135);
            this.txtcerez.Name = "txtcerez";
            this.txtcerez.Size = new System.Drawing.Size(272, 34);
            this.txtcerez.TabIndex = 20;
            // 
            // txticecekler
            // 
            this.txticecekler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txticecekler.Location = new System.Drawing.Point(138, 76);
            this.txticecekler.Name = "txticecekler";
            this.txticecekler.Size = new System.Drawing.Size(272, 34);
            this.txticecekler.TabIndex = 19;
            // 
            // txtgidalar
            // 
            this.txtgidalar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgidalar.Location = new System.Drawing.Point(138, 24);
            this.txtgidalar.Name = "txtgidalar";
            this.txtgidalar.Size = new System.Drawing.Size(272, 34);
            this.txtgidalar.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Çerez Tutarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "İçecek Tutarı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Gıda Tutarı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txticecekler);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcerez);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtgidalar);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 251);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MUTFAK";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnKaydet2);
            this.groupBox2.Controls.Add(this.txtsu);
            this.groupBox2.Controls.Add(this.lblelektrik);
            this.groupBox2.Controls.Add(this.lblsu);
            this.groupBox2.Controls.Add(this.txtinternet);
            this.groupBox2.Controls.Add(this.lblinternet);
            this.groupBox2.Controls.Add(this.txtelektrik);
            this.groupBox2.Location = new System.Drawing.Point(519, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 251);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FATURALAR";
            // 
            // BtnKaydet2
            // 
            this.BtnKaydet2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnKaydet2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet2.Location = new System.Drawing.Point(189, 186);
            this.BtnKaydet2.Name = "BtnKaydet2";
            this.BtnKaydet2.Size = new System.Drawing.Size(212, 45);
            this.BtnKaydet2.TabIndex = 24;
            this.BtnKaydet2.Text = "Kaydet";
            this.BtnKaydet2.UseVisualStyleBackColor = false;
            this.BtnKaydet2.Click += new System.EventHandler(this.BtnKaydet2_Click);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.Aqua;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(607, 276);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(447, 250);
            this.listView2.TabIndex = 24;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Elektrik";
            this.columnHeader4.Width = 121;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Su";
            this.columnHeader5.Width = 111;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "İnternet";
            this.columnHeader6.Width = 105;
            // 
            // FrmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1050, 517);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Kaydet2);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStoklar";
            this.Text = "Stoklar";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblelektrik;
        private System.Windows.Forms.Label lblsu;
        private System.Windows.Forms.Label lblinternet;
        private System.Windows.Forms.TextBox txtelektrik;
        private System.Windows.Forms.TextBox txtsu;
        private System.Windows.Forms.TextBox txtinternet;
        private System.Windows.Forms.Button Kaydet2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtcerez;
        private System.Windows.Forms.TextBox txticecekler;
        private System.Windows.Forms.TextBox txtgidalar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnKaydet2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}