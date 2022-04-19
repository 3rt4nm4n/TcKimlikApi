using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcKimlikApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public long kimlik_No;
        int yil;
        bool durum;
        private void button1_Click(object sender, EventArgs e)
        {
            kimlik_No = long.Parse(TextBox_TCNO.Text);
            yil = int.Parse(TextBox_Yil.Text);
            try
            {
                using (TcDogrula.KPSPublicSoapClient service = new TcDogrula.KPSPublicSoapClient { })
                {
                    durum = service.TCKimlikNoDogrula(kimlik_No, TextBox_Isim.Text, TextBox_Soyisim.Text, yil);
                }
            }
            catch (Exception)
            {
                throw;
            }
            if(!durum)
                MessageBox.Show("Hata! Bilgiler eksik yada yanlış.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else if(durum)
                MessageBox.Show("Girlen bilgiler "+TextBox_Isim.Text+" isimli kişiye aittir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
