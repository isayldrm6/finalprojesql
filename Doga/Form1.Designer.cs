
namespace Doga
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1_istasyon = new System.Windows.Forms.ComboBox();
            this.comboBox2_parametre = new System.Windows.Forms.ComboBox();
            this.button1_sorgula = new System.Windows.Forms.Button();
            this.button2_temizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.havaDataSet = new Doga.havaDataSet();
            this.havaDataSet1 = new Doga.havaDataSet1();
            this.ıstasyonlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.istasyonlarTableAdapter = new Doga.havaDataSet1TableAdapters.IstasyonlarTableAdapter();
            this.havaDataSet2 = new Doga.havaDataSet2();
            this.parametrelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parametrelerTableAdapter = new Doga.havaDataSet2TableAdapters.ParametrelerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.havaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıstasyonlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.havaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametrelerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1_istasyon
            // 
            this.comboBox1_istasyon.DataSource = this.ıstasyonlarBindingSource;
            this.comboBox1_istasyon.DisplayMember = "IstasyonAd";
            this.comboBox1_istasyon.FormattingEnabled = true;
            this.comboBox1_istasyon.Location = new System.Drawing.Point(164, 60);
            this.comboBox1_istasyon.Name = "comboBox1_istasyon";
            this.comboBox1_istasyon.Size = new System.Drawing.Size(162, 21);
            this.comboBox1_istasyon.TabIndex = 0;
            this.comboBox1_istasyon.ValueMember = "Id";
            // 
            // comboBox2_parametre
            // 
            this.comboBox2_parametre.DataSource = this.parametrelerBindingSource;
            this.comboBox2_parametre.DisplayMember = "ParametreAdi";
            this.comboBox2_parametre.FormattingEnabled = true;
            this.comboBox2_parametre.Location = new System.Drawing.Point(164, 128);
            this.comboBox2_parametre.Name = "comboBox2_parametre";
            this.comboBox2_parametre.Size = new System.Drawing.Size(162, 21);
            this.comboBox2_parametre.TabIndex = 1;
            this.comboBox2_parametre.ValueMember = "Id";
            // 
            // button1_sorgula
            // 
            this.button1_sorgula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1_sorgula.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1_sorgula.Location = new System.Drawing.Point(485, 63);
            this.button1_sorgula.Name = "button1_sorgula";
            this.button1_sorgula.Size = new System.Drawing.Size(116, 33);
            this.button1_sorgula.TabIndex = 2;
            this.button1_sorgula.Text = "SORGULA";
            this.button1_sorgula.UseVisualStyleBackColor = false;
            this.button1_sorgula.Click += new System.EventHandler(this.button1_sorgula_Click);
            // 
            // button2_temizle
            // 
            this.button2_temizle.BackColor = System.Drawing.Color.Red;
            this.button2_temizle.Location = new System.Drawing.Point(485, 128);
            this.button2_temizle.Name = "button2_temizle";
            this.button2_temizle.Size = new System.Drawing.Size(116, 34);
            this.button2_temizle.TabIndex = 3;
            this.button2_temizle.Text = "TEMİZLE";
            this.button2_temizle.UseVisualStyleBackColor = false;
            this.button2_temizle.Click += new System.EventHandler(this.button2_temizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "İSTASYON SEÇİNİZ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PARAMETRE SEÇİNİZ :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(909, 324);
            this.dataGridView1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Location = new System.Drawing.Point(35, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 42);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.Location = new System.Drawing.Point(2, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Günlük";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(147, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(206, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(36, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 36);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(0, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Saatliik";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 18, 0, 0, 0, 0);
            // 
            // havaDataSet
            // 
            this.havaDataSet.DataSetName = "havaDataSet";
            this.havaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // havaDataSet1
            // 
            this.havaDataSet1.DataSetName = "havaDataSet1";
            this.havaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ıstasyonlarBindingSource
            // 
            this.ıstasyonlarBindingSource.DataMember = "Istasyonlar";
            this.ıstasyonlarBindingSource.DataSource = this.havaDataSet1;
            // 
            // istasyonlarTableAdapter
            // 
            this.istasyonlarTableAdapter.ClearBeforeFill = true;
            // 
            // havaDataSet2
            // 
            this.havaDataSet2.DataSetName = "havaDataSet2";
            this.havaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parametrelerBindingSource
            // 
            this.parametrelerBindingSource.DataMember = "Parametreler";
            this.parametrelerBindingSource.DataSource = this.havaDataSet2;
            // 
            // parametrelerTableAdapter
            // 
            this.parametrelerTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 688);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2_temizle);
            this.Controls.Add(this.button1_sorgula);
            this.Controls.Add(this.comboBox2_parametre);
            this.Controls.Add(this.comboBox1_istasyon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hava Kalitesi - İstasyon Veri İndirme";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.havaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıstasyonlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.havaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametrelerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1_istasyon;
        private System.Windows.Forms.ComboBox comboBox2_parametre;
        private System.Windows.Forms.Button button1_sorgula;
        private System.Windows.Forms.Button button2_temizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private havaDataSet havaDataSet;
        private havaDataSet1 havaDataSet1;
        private System.Windows.Forms.BindingSource ıstasyonlarBindingSource;
        private havaDataSet1TableAdapters.IstasyonlarTableAdapter istasyonlarTableAdapter;
        private havaDataSet2 havaDataSet2;
        private System.Windows.Forms.BindingSource parametrelerBindingSource;
        private havaDataSet2TableAdapters.ParametrelerTableAdapter parametrelerTableAdapter;
    }
}

