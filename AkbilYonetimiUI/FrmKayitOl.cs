using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI
{
    public partial class FrmKayitOl : Form
    {
        AkbildbContext context = new AkbildbContext();
        public FrmKayitOl()
        {
            InitializeComponent(); // İnşa etmek
        }

        private void FrmKayitOl_Load(object sender, EventArgs e)
        {
            #region Ayarlar
            txtSifre.PasswordChar = '*';
            dtpDogumTarihi.MaxDate = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Value = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;

            #endregion
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                btnKayitOl.Enabled = false;
                btnGirisYap.Enabled = false;
                foreach (var item in Controls)
                {
                    if (item is TextBox && string.IsNullOrEmpty(((TextBox)item).Text))
                    {
                        MessageBox.Show("Zorunlu alanları doldurunuz!");
                        btnKayitOl.Enabled = true;
                        btnGirisYap.Enabled = true;
                        return;
                    }

                }
                //bu emailden sistemde var mı ?
                if (context.Kullanicilars.FirstOrDefault(x => x.Email == txtEmail.Text.Trim())!=null)
                {
                    btnKayitOl.Enabled = true;
                    btnGirisYap.Enabled = true;
                    MessageBox.Show("Bu emaille sistemde kayıt mevcuttur");
                    return;
                }

                Kullanicilar yeniKullanici = new Kullanicilar()
                {
                    EklenmeTarihi = DateTime.Now,
                    Ad = txtIsim.Text.Trim(),
                    Soyad = txtSoyisim.Text.Trim(),
                    DogumTarihi = dtpDogumTarihi.Value,
                    Email = txtEmail.Text.Trim(),
                    Parola = GenelIslemler.MD5Encryption(txtIsim.Text.Trim())
                };
                context.Kullanicilars.Add(yeniKullanici);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Kullanici Eklendi");
                    //Temizlik
                    foreach (var item in Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Clear();

                        }
                        if (item is DateTimePicker)
                        {
                            ((DateTimePicker)item).Value = ((DateTimePicker)item).MaxDate;

                        }
                    }
                  DialogResult cevap = MessageBox.Show("Giris Sayfasina gitmek ister misiniz?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes)
                    {
                        FrmGiris frmg = new FrmGiris();
                        frmg.Email = txtEmail.Text.Trim();
                        this.Hide();
                        frmg.Show();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Kullanici Eklenemedi !!!!");
                }
                btnKayitOl.Enabled = true;
                btnGirisYap.Enabled = true;


            }
            catch (Exception ex)
            {
                // ex log.txt'ye yazılanacak (loglama)
                MessageBox.Show("Beklenmedik bir hata oluştu! Lütfen tekrar deneyiniz !", ex.Message);
            }
        }

        private void GirisFormunaGit()
        {
            FrmGiris frmG = new FrmGiris();
            frmG.Email = txtEmail.Text.Trim();
            this.Hide();
            frmG.Show();
        }

        private void FrmKayitOl_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisFormunaGit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisFormunaGit();
        }
    }
}
