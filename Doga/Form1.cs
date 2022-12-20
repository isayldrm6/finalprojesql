using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doga
{
    public partial class Form1 : Form
    {

        havaEntities db = new havaEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_sorgula_Click(object sender, EventArgs e)
        {

            int istasyonid = Convert.ToInt32(comboBox1_istasyon.SelectedValue);
            int parametreid = Convert.ToInt32(comboBox2_parametre.SelectedValue);

            var sonuc = db.Veriler.Where(v => v.IstasyonId == istasyonid && v.ParametreId == parametreid).ToList();
            dataGridView1.DataSource = sonuc;
            Console.WriteLine(sonuc);


        }

        private void button2_temizle_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {

            comboBox1_istasyon.Text = "İstasyon Seçiniz...";
            comboBox2_parametre.Text = "Parametre Seçiniz...";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'havaDataSet2.Parametreler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.parametrelerTableAdapter.Fill(this.havaDataSet2.Parametreler);
            // TODO: Bu kod satırı 'havaDataSet1.Istasyonlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.istasyonlarTableAdapter.Fill(this.havaDataSet1.Istasyonlar);

        }
    }
}
