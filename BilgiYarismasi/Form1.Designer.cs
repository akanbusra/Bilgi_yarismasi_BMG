namespace BilgiYarismasi
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblSoruCevapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbYarismaDataSet = new BilgiYarismasi.DbYarismaDataSet();
            this.BtnSeçimTemizle = new System.Windows.Forms.Button();
            this.BtnSoruGüncelle = new System.Windows.Forms.Button();
            this.BtnSoruSil = new System.Windows.Forms.Button();
            this.btnSoruEkle = new System.Windows.Forms.Button();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblSoruCevapTableAdapter = new BilgiYarismasi.DbYarismaDataSetTableAdapters.TblSoruCevapTableAdapter();
            this.TxtHarf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSoruCevapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbYarismaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(689, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "Soruları Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 174);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 398);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tblSoruCevapBindingSource
            // 
            this.tblSoruCevapBindingSource.DataMember = "TblSoruCevap";
            this.tblSoruCevapBindingSource.DataSource = this.dbYarismaDataSet;
            // 
            // dbYarismaDataSet
            // 
            this.dbYarismaDataSet.DataSetName = "DbYarismaDataSet";
            this.dbYarismaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnSeçimTemizle
            // 
            this.BtnSeçimTemizle.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSeçimTemizle.Location = new System.Drawing.Point(600, 123);
            this.BtnSeçimTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSeçimTemizle.Name = "BtnSeçimTemizle";
            this.BtnSeçimTemizle.Size = new System.Drawing.Size(206, 36);
            this.BtnSeçimTemizle.TabIndex = 22;
            this.BtnSeçimTemizle.Text = "Seçimleri Temizle";
            this.BtnSeçimTemizle.UseVisualStyleBackColor = true;
            this.BtnSeçimTemizle.Click += new System.EventHandler(this.BtnSeçimTemizle_Click);
            // 
            // BtnSoruGüncelle
            // 
            this.BtnSoruGüncelle.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSoruGüncelle.Location = new System.Drawing.Point(539, 66);
            this.BtnSoruGüncelle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSoruGüncelle.Name = "BtnSoruGüncelle";
            this.BtnSoruGüncelle.Size = new System.Drawing.Size(146, 33);
            this.BtnSoruGüncelle.TabIndex = 20;
            this.BtnSoruGüncelle.Text = "Soru Güncelle";
            this.BtnSoruGüncelle.UseVisualStyleBackColor = true;
            this.BtnSoruGüncelle.Click += new System.EventHandler(this.BtnSoruGüncelle_Click);
            // 
            // BtnSoruSil
            // 
            this.BtnSoruSil.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSoruSil.Location = new System.Drawing.Point(689, 14);
            this.BtnSoruSil.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSoruSil.Name = "BtnSoruSil";
            this.BtnSoruSil.Size = new System.Drawing.Size(149, 32);
            this.BtnSoruSil.TabIndex = 19;
            this.BtnSoruSil.Text = "Soru Sil";
            this.BtnSoruSil.UseVisualStyleBackColor = true;
            this.BtnSoruSil.Click += new System.EventHandler(this.BtnSoruSil_Click);
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoruEkle.Location = new System.Drawing.Point(539, 14);
            this.btnSoruEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(146, 32);
            this.btnSoruEkle.TabIndex = 18;
            this.btnSoruEkle.Text = "Soru Ekle";
            this.btnSoruEkle.UseVisualStyleBackColor = true;
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // txtSoru
            // 
            this.txtSoru.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoru.Location = new System.Drawing.Point(106, 53);
            this.txtSoru.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(415, 27);
            this.txtSoru.TabIndex = 16;
            // 
            // txtCevap
            // 
            this.txtCevap.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCevap.Location = new System.Drawing.Point(106, 92);
            this.txtCevap.Margin = new System.Windows.Forms.Padding(2);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(415, 27);
            this.txtCevap.TabIndex = 17;
            // 
            // txtıd
            // 
            this.txtıd.Enabled = false;
            this.txtıd.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtıd.Location = new System.Drawing.Point(106, 14);
            this.txtıd.Margin = new System.Windows.Forms.Padding(2);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(415, 27);
            this.txtıd.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "CEVAP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "SORU :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID :";
            // 
            // tblSoruCevapTableAdapter
            // 
            this.tblSoruCevapTableAdapter.ClearBeforeFill = true;
            // 
            // TxtHarf
            // 
            this.TxtHarf.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtHarf.Location = new System.Drawing.Point(106, 132);
            this.TxtHarf.Margin = new System.Windows.Forms.Padding(2);
            this.TxtHarf.Name = "TxtHarf";
            this.TxtHarf.Size = new System.Drawing.Size(415, 27);
            this.TxtHarf.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "HARF :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(225)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(906, 583);
            this.Controls.Add(this.TxtHarf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSeçimTemizle);
            this.Controls.Add(this.BtnSoruGüncelle);
            this.Controls.Add(this.BtnSoruSil);
            this.Controls.Add(this.btnSoruEkle);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.txtıd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Bilgi Yarışması";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSoruCevapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbYarismaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSeçimTemizle;
        private System.Windows.Forms.Button BtnSoruGüncelle;
        private System.Windows.Forms.Button BtnSoruSil;
        private System.Windows.Forms.Button btnSoruEkle;
        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DbYarismaDataSet dbYarismaDataSet;
        private System.Windows.Forms.BindingSource tblSoruCevapBindingSource;
        private DbYarismaDataSetTableAdapters.TblSoruCevapTableAdapter tblSoruCevapTableAdapter;
        private System.Windows.Forms.TextBox TxtHarf;
        private System.Windows.Forms.Label label4;
    }
}

