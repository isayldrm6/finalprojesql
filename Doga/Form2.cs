using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doga
{
    public partial class Form2 : Form
    {
        havaEntities hb = new havaEntities();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_kayitol_Click(object sender, EventArgs e)
        {
            string sifreyeni = SHA1Hash(textBox4_sifre.Text);
            KullaniciTbl yenikullanici = new KullaniciTbl();
            yenikullanici.Adi = textBox2_adi.Text;
            yenikullanici.KullaniciAdi = textBox1_kullaniciadi.Text;
            yenikullanici.Sifre = sifreyeni;
            yenikullanici.Soyadi = textBox3_soyadi.Text;
            hb.KullaniciTbl.Add(yenikullanici);
            hb.SaveChanges();
        }
        string SHA1Hash(string text)
        {
            string source = text;
            using (SHA1 sha1hash = SHA1.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hashBytes = sha1hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                return hash;
            }
        }

        private void button2_girisyap_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox6_kullaniciadi.Text;
            string sifre = SHA1Hash(textBox7_sifre.Text);
            KullaniciTbl giren = hb.KullaniciTbl.Where(k => k.KullaniciAdi == kullaniciadi && k.Sifre == sifre).FirstOrDefault();
            if (giren == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
            else
            {
                GirisYapan.Adi = giren.Adi;
                GirisYapan.Soyadi = giren.Soyadi;
                GirisYapan.KullaniciAdi = giren.KullaniciAdi;
                Form1 nesne = new Form1();
                this.Hide();
                nesne.Show();
            }
        }
    }
}
