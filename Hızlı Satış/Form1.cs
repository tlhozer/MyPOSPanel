using Hızlı_Satış.Engines;
using Hızlı_Satış.Tools.Components;
using System;

namespace Hızlı_Satış
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageEngine.SuccesMessage("Deneme Başlık", "Deneme Yazı", this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageEngine.ErrorMessage("Uyarı", "Bir hata oluştu!", this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageEngine.WarningMessage("Uyarı", "Devam Etmek İstiyor Musunuz?", this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageEngine.InfoMessage("Bilgi", "Test bilgi", this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Test");
        }
    }
}