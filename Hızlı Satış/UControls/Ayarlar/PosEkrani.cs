using Hızlı_Satış.Classes.DataClasses;
using Hızlı_Satış.Database;
using Hızlı_Satış.Forms.Base.Edit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Hızlı_Satış.UControls.Ayarlar
{
    public partial class PosEkrani : UserControl
    {
        public PosEkrani()
        {
            InitializeComponent();
        }

        private void PosEkrani_Load(object sender, EventArgs e)
        {
            PosKategoriGetir();
        }

        public string kategoriadi = "";
        public DataTable table;

        private void PosKategoriGetir()
        {
            poskategoriliste.Items.Clear();
            List<string> liste = PosDAL.GetPosCategorys();

            foreach (var item in liste)
            {
                poskategoriliste.Items.Add(item);
            }
        }

        private void yenikategorikaydet_Click_1(object sender, EventArgs e)
        {
            if (kategoritext.Text != "")
            {
                PosKategori posKategori = new PosKategori();
                posKategori.KategoriAdi = kategoritext.Text;
                if (PosDAL.PosKategoriEkle(posKategori))
                {
                    //MessageEngine..Show("Kayıt edildi");

                    PosKategoriGetir();
                    kategoritext.Clear();
                }
                else
                {
                    MessageBox.Show("Hata Oluştu");
                }
            }
            else
            {
                MessageBox.Show("Kategori adı boş olamaz");
            }
        }

        private void poskategoriduzenle_Click(object sender, EventArgs e)
        {
            int index = poskategoriliste.SelectedIndex;
            if (index > 0 || index == 0)
            {
                PosKategoriDuzenle posKategoriDuzenle = new PosKategoriDuzenle();
                posKategoriDuzenle.TopMost = true;
                posKategoriDuzenle.kategoriadi = poskategoriliste.SelectedItem.ToString();
                posKategoriDuzenle.ShowDialog();
                PosKategoriGetir();
            }
        }

        private void usttasibtn_Click(object sender, EventArgs e)
        {
            int index = poskategoriliste.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Lütfen Kategori Seçiniz.");
            }
            else
            {
                string listBoxItemText = poskategoriliste.SelectedItem.ToString();
                if (index > 0)
                {
                    poskategoriliste.Items.RemoveAt(index);
                    poskategoriliste.Items.Insert(index - 1, listBoxItemText);
                    poskategoriliste.SetSelected(index - 1, true);
                }
            }
        }

        private void alttasibtn_Click(object sender, EventArgs e)
        {
            int index = poskategoriliste.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("Lütfen Kategori Seçiniz.");
            }
            else
            {
                string listBoxItemText = poskategoriliste.SelectedItem.ToString();
                if (index < poskategoriliste.Items.Count - 1)
                {
                    poskategoriliste.Items.RemoveAt(index);
                    poskategoriliste.Items.Insert(index + 1, listBoxItemText);
                    poskategoriliste.SetSelected(index + 1, true);
                }
            }
        }

        private void siralamakaydet_Click(object sender, EventArgs e)
        {
            int say = 1;

            foreach (var item in poskategoriliste.Items)
            {
                //MessageBox.Show(item.ToString()+" sıralama"+ say.ToString());
                PosDAL.PosKategoriSiralamaKaydet(item.ToString(), say.ToString());
                say++;
            }

            PosKategoriGetir();
            MessageBox.Show("Sıralama Kayıt Edildi");
        }
    }
}