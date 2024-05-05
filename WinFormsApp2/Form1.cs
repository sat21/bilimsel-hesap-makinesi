using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;
namespace WinFormsApp2
{

    public partial class Form1 : Form
    {

        public Form1()

        {
            InitializeComponent();
        }
        //pencereyi taşımak için mouseyi nereye sürüklediğini gösteren xy ler
        bool Mov;
        int MovX, MovY;




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string sayi1 = null!, sayi2 = null!;
        //sayılarımız
        //işlemlerimiz
        int tplm = 0,
            ckrm = 0,
            crpm = 0,
             blm = 0,
             pow = 0,
             kok = 0,
            ebob = 0,
            ekok = 0,
             mod = 0,
            sayac = 0;

        //geçmiş için işlemlerin kaydını tutan dizi
        object[] Dizi1 = new string[4];









        //mouse tıklama
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            MovX = e.X;
            MovY = e.Y;
        }
        //mouse hareke ettirme
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov == true)
            {
                this.SetDesktopLocation(MousePosition.X - MovX, MousePosition.Y - MovY);
            }
        }
        //mouse bırakma
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        //uygulamadan çıkış butonu

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //rakam butonları
        private void button0_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0 && pow == 0 && kok == 0 && ebob == 0 && ekok == 0 && mod == 0)
            {

                sayi1 = sayi1 + "0";
                labelSayi1.Text = sayi1;

            }
            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1 || pow == 1 || ebob == 1 || ekok == 1 || mod == 1)
            {
                sayi2 = sayi2 + "0";
                labelSayi2.Text = sayi2;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0 && pow == 0 && kok == 0 && ebob == 0 && ekok == 0 && mod == 0)
            {

                sayi1 = sayi1 + "1";
                labelSayi1.Text = sayi1;

            }
            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1 || pow == 1 || ebob == 1 || ekok == 1 || mod == 1)
            {
                sayi2 = sayi2 + "1";
                labelSayi2.Text = sayi2;

            }
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0 && pow == 0 && kok == 0 && ebob == 0 && ekok == 0 && mod == 0)
            {

                sayi1 = sayi1 + "2";
                labelSayi1.Text = sayi1;

            }
            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1 || pow == 1 || ebob == 1 || ekok == 1 || mod == 1)
            {
                sayi2 = sayi2 + "2";
                labelSayi2.Text = sayi2;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0 && pow == 0 && kok == 0 && ebob == 0 && ekok == 0 && mod == 0)
            {

                sayi1 = sayi1 + "3";
                labelSayi1.Text = sayi1;

            }
            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1 || pow == 1 || ebob == 1 || ekok == 1 || mod == 1)
            {
                sayi2 = sayi2 + "3";
                labelSayi2.Text = sayi2;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0 && pow == 0 && kok == 0 && ebob == 0 && ekok == 0 && mod == 0)
            {

                sayi1 = sayi1 + "4";
                labelSayi1.Text = sayi1;

            }
            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1 || pow == 1 || ebob == 1 || ekok == 1 || mod == 1)
            {
                sayi2 = sayi2 + "4";
                labelSayi2.Text = sayi2;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0 && pow == 0 && kok == 0 && ebob == 0 && ekok == 0 && mod == 0)
            {

                sayi1 = sayi1 + "5";
                labelSayi1.Text = sayi1;

            }
            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1 || pow == 1 || ebob == 1 || ekok == 1 || mod == 1)
            {
                sayi2 = sayi2 + "5";
                labelSayi2.Text = sayi2;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0 && pow == 0 && kok == 0 && ebob == 0 && ekok == 0 && mod == 0)
            {

                sayi1 = sayi1 + "6";
                labelSayi1.Text = sayi1;

            }
            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1 || pow == 1 || ebob == 1 || ekok == 1 || mod == 1)
            {
                sayi2 = sayi2 + "6";
                labelSayi2.Text = sayi2;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0 && pow == 0 && kok == 0 && ebob == 0 && ekok == 0 && mod == 0)
            {

                sayi1 = sayi1 + "7";
                labelSayi1.Text = sayi1;

            }
            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1 || pow == 1 || ebob == 1 || ekok == 1 || mod == 1)
            {
                sayi2 = sayi2 + "7";
                labelSayi2.Text = sayi2;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0 && pow == 0 && kok == 0 && ebob == 0 && ekok == 0 && mod == 0)
            {

                sayi1 = sayi1 + "8";
                labelSayi1.Text = sayi1;

            }
            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1 || pow == 1 || ebob == 1 || ekok == 1 || mod == 1)
            {
                sayi2 = sayi2 + "8";
                labelSayi2.Text = sayi2;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0 && pow == 0 && kok == 0 && ebob == 0 && ekok == 0 && mod == 0)
            {

                sayi1 = sayi1 + "9";
                labelSayi1.Text = sayi1;

            }
            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1 || pow == 1 || ebob == 1 || ekok == 1 || mod == 1)
            {
                sayi2 = sayi2 + "9";
                labelSayi2.Text = sayi2;

            }
        }


        //işlem butonları
        private void buttonToplama_Click(object sender, EventArgs e)
        {
            if (labelSayi1.Text == "")
            {
                MessageBox.Show("ilk sayı girilmeden işlem yapılmaz");
            }
            else
            {
                labelİslem.Text = "+";
                tplm = 1;
                ckrm = 0;
                crpm = 0;
                blm = 0;
                pow = 0;
                kok = 0;
                ekok = 0;
                mod = 0;
            }
        }

        private void buttonCikarma_Click(object sender, EventArgs e)
        {
            if (labelSayi1.Text == "")
            {
                MessageBox.Show("ilk sayı girilmeden işlem yapılmaz");
            }
            else
            {
                labelİslem.Text = "-";
                tplm = 0;
                ckrm = 1;
                crpm = 0;
                blm = 0;
                pow = 0;
                kok = 0;
                ekok = 0;
                mod = 0;
            }
        }

        private void buttonCarpma_Click(object sender, EventArgs e)
        {
            if (labelSayi1.Text == "")
            {
                MessageBox.Show("ilk sayı girilmeden işlem yapılmaz");
            }
            else
            {
                labelİslem.Text = "X";
                tplm = 0;
                ckrm = 0;
                crpm = 1;
                blm = 0;
                pow = 0;
                kok = 0;
                ekok = 0;
                mod = 0;
            }
        }

        private void buttonBolme_Click(object sender, EventArgs e)
        {
            if (labelSayi1.Text == "")
            {
                MessageBox.Show("ilk sayı girilmeden işlem yapılmaz");
            }
            else
            {


                labelİslem.Text = "÷";
                tplm = 0;
                ckrm = 0;
                crpm = 0;
                blm = 1;
                pow = 0;
                kok = 0;
                ekok = 0;
                mod = 0;
            }
        }

        private void buttonKokAl_Click(object sender, EventArgs e)
        {
            if (labelSayi1.Text == "")
            {
                MessageBox.Show("ilk sayı girilmeden işlem yapılmaz");
            }
            else
            {
                labelİslem.Text = "√";
                tplm = 0;
                ckrm = 0;
                crpm = 0;
                blm = 0;
                pow = 0;
                kok = 1;
                ekok = 0;
                mod = 0;
            }
        }

        private void buttonUsAl_Click(object sender, EventArgs e)
        {
            if (labelSayi1.Text == "")
            {
                MessageBox.Show("ilk sayı girilmeden işlem yapılmaz");
            }
            else
            {
                labelİslem.Text = "^";
                tplm = 0;
                ckrm = 0;
                crpm = 0;
                blm = 0;
                pow = 1;
                kok = 0;
                ekok = 0;
                mod = 0;
            }
        }

        private void buttonEbob_Click(object sender, EventArgs e)
        {
            if (labelSayi1.Text == "")
            {
                MessageBox.Show("ilk sayı girilmeden işlem yapılmaz");
            }
            else
            {
                labelİslem.Text = "Ebob";
                tplm = 0;
                ckrm = 0;
                crpm = 0;
                blm = 0;
                pow = 0;
                kok = 0;
                ebob = 1;
                ekok = 0;
                mod = 0;
            }
        }

        private void buttonEkok_Click(object sender, EventArgs e)
        {
            if (labelSayi1.Text == "")
            {
                MessageBox.Show("ilk sayı girilmeden işlem yapılmaz");
            }
            else
            {
                labelİslem.Text = "Ekok";
                tplm = 0;
                ckrm = 0;
                crpm = 0;
                blm = 0;
                pow = 0;
                kok = 0;
                ebob = 0;
                ekok = 1;
                mod = 0;
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            if (labelSayi1.Text == "")
            {
                MessageBox.Show("ilk sayı girilmeden işlem yapılmaz");
            }
            else
            {
                labelİslem.Text = "Mod";
                tplm = 0;
                ckrm = 0;
                crpm = 0;
                blm = 0;
                pow = 0;
                kok = 0;
                ebob = 0;
                ekok = 0;
                mod = 1;
            }
        }

        //virgül butonu
        private void buttonVirgul_Click(object sender, EventArgs e)
        {
            if (labelİslem.Text == "" && labelSayi2.Text == "" && labelSonuc.Text == "")
            {
                if (labelSayi1.Text.IndexOf(",") < 1)
                {
                    labelSayi1.Text += ",";
                    sayi1 = labelSayi1.Text;
                }

            }
            else if (labelSayi1.Text != "0" && labelİslem.Text != "0")
            {
                if (labelSayi2.Text.IndexOf(",") < 1)
                {
                    labelSayi2.Text += ",";
                    sayi2 = labelSayi2.Text;
                }
            }



        }
        //işaret değiştirme butonu
        private void buttonİsaretDegistir_Click(object sender, EventArgs e)
        {


            if (labelİslem.Text == "" && labelSayi2.Text == "" && labelSonuc.Text == "")
            {
                if (labelSayi1.Text.StartsWith("-"))
                {
                    labelSayi1.Text = labelSayi1.Text.Replace("-", "");
                    sayi1 = labelSayi1.Text;
                }
                else if (labelSayi1.Text.StartsWith(""))
                {
                    labelSayi1.Text = "-" + labelSayi1.Text;
                    sayi1 = labelSayi1.Text;
                }

            }
            else if (labelSayi1.Text != "0" && labelİslem.Text != "0")
            {
                if (labelSayi2.Text.StartsWith("-"))
                {
                    labelSayi2.Text = labelSayi2.Text.Replace("-", "");
                    sayi2 = labelSayi2.Text;
                }
                else if (labelSayi2.Text.StartsWith(""))
                {
                    labelSayi2.Text = "-" + labelSayi2.Text;
                    sayi2 = labelSayi2.Text;
                }

            }


        }
        //silme butonları
        private void buttonTumunuSil_Click(object sender, EventArgs e)
        {
            labelSayi1.Text = "";
            labelSayi2.Text = "";
            labelİslem.Text = "";
            sayi1 = "";
            sayi2 = "";

            tplm = 0;
            ckrm = 0;
            crpm = 0;
            blm = 0;
            pow = 0;
            kok = 0;
            sayac = 0;
            ebob = 0;
            ekok = 0;
            mod = 0;
            labelSonuc.Text = "";
        }

        private void buttonSatirSil_Click(object sender, EventArgs e)
        {
            if (labelİslem.Text == "" && labelSayi2.Text == "" && labelSonuc.Text == "")
            {
                labelSayi1.Text = "";
                sayi1 = "";

            }

            if (labelSayi2.Text == "" && labelSonuc.Text == "")
            {
                labelİslem.Text = "";
                tplm = 0;
                ckrm = 0;
                crpm = 0;
                blm = 0;
                pow = 0;
                kok = 0;

            }



            if (labelSonuc.Text == "")
            {
                labelSayi2.Text = "";
                sayi2 = "";
            }
            else
            {
                labelSonuc.Text = "";
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {

            if (labelSayi1.Text != "" && labelİslem.Text == "" && labelSayi2.Text == "" && labelSonuc.Text == "")
            {

                labelSayi1.Text = labelSayi1.Text.Substring(0, labelSayi1.Text.Length - 1);

                sayi1 = labelSayi1.Text;

            }
            else if (labelSayi2.Text == "" && labelSonuc.Text == "")
            {
                labelİslem.Text = "";
                tplm = 0;
                ckrm = 0;
                crpm = 0;
                blm = 0;
                pow = 0;
                kok = 0;

            }
            if (labelSonuc.Text == "" && labelSayi1.Text != "" && labelSayi2.Text != "")
            {

                labelSayi2.Text = labelSayi2.Text.Substring(0, labelSayi2.Text.Length - 1);
                sayi2 = labelSayi2.Text;
            }


        }


        //geçmiş butonu

        private void buttonGecmis_Click(object sender, EventArgs e)
        {

            if (sayac == 0)
            {
                listBox1.Items.Add(labelSayi1.Text + labelİslem.Text + labelSayi2.Text + "=" + labelSonuc.Text + " " + "(" + txt_cevir.Text + ")");
                sayac = 1;
            }




        }


        //eşittir butonu ve işlemlerin yapıldığı kodlar

        private void buttonEsittir_Click(object sender, EventArgs e)
        {


            if (labelSayi1.Text == "")
            {
                MessageBox.Show("ilk sayı girilmedi");
            }
            if (labelSayi1.Text != "" && labelİslem.Text == "")
            {
                MessageBox.Show("işlem yapılmadı");
            }
            if (labelSayi1.Text != "" && labelİslem.Text != "" && labelSayi2.Text == "")
            {
                MessageBox.Show("ikinci sayı girilmedi");
            }




            //işlemlerin kaydını tutan diziye değerleri girer
            string[] Dizi1 = { labelSayi1.Text, labelİslem.Text, labelSayi2.Text, labelSonuc.Text };






            //toplama

            if (tplm == 1)
            {

                labelSonuc.Text = "" + (Convert.ToDouble(sayi1) + Convert.ToDouble(sayi2));
                Convert.ToString((Convert.ToDouble(sayi1) + Convert.ToDouble(sayi2)));

            }
            //çıkarma
            if (ckrm == 1)
            {


                labelSonuc.Text = "" + (Convert.ToDouble(sayi1) - Convert.ToDouble(sayi2));
                Convert.ToString((Convert.ToDouble(sayi1) - Convert.ToDouble(sayi2)));
            }

            //çarpma
            if (crpm == 1)
            {


                labelSonuc.Text = "" + (Convert.ToDouble(sayi1)) * (Convert.ToDouble(sayi2));
                Convert.ToString((Convert.ToDouble(sayi1) * Convert.ToDouble(sayi2)));
            }

            //bölme
            if (blm == 1)
            {


                labelSonuc.Text = "" + (Convert.ToDouble(sayi2) / Convert.ToDouble(sayi1));
                Convert.ToString((Convert.ToDouble(sayi2) / Convert.ToDouble(sayi1)));

            }

            //üs alma
            if (pow == 1)
            {
                labelSonuc.Text = "" + Math.Pow((Convert.ToDouble(sayi1)), Convert.ToDouble(sayi2));
                Convert.ToString(Math.Pow(Convert.ToDouble(sayi1), Convert.ToDouble(sayi2)));
            }

            //kök alma
            if (kok == 1)
            {

                labelSayi2.Text = "";
                labelSonuc.Text = "" + Math.Sqrt(Convert.ToDouble(sayi1));
                Convert.ToString(Math.Sqrt(Convert.ToDouble(sayi1)));
            }

            //ebob işlemi
            if (ebob == 1)
            {
                for (int i = 1; i < Convert.ToInt32(sayi1); i++)
                {
                    if (Convert.ToInt32(sayi1) % i == 0 && Convert.ToInt32(sayi2) % i == 0)
                    {
                        ebob = i;
                    }
                }
                labelSonuc.Text = "" + Convert.ToInt32(ebob);

            }


            //ekok işlemi
            if (ekok == 1)
            {
                int max = Convert.ToInt32(sayi1) * Convert.ToInt32(sayi2);
                for (int i = max; i > 0; i--)
                {
                    if (i % Convert.ToInt32(sayi1) == 0 && i % Convert.ToInt32(sayi2) == 0)
                    {
                        ekok = i;
                    }
                }
                labelSonuc.Text = "" + Convert.ToInt32(ekok);
            }
            //mod işlemi
            if (mod == 1)
            {



                int a, b;
                a = Convert.ToInt32(sayi1);
                b = Convert.ToInt32(sayi2);
                int Mod2 = a % b;

                if (a % b == 0)
                {
                    labelSonuc.Text = "0";
                }
                else
                {
                    labelSonuc.Text = "" + Mod2;
                }



            }

            //sayıyı sıfıra böldüğünde "∞"işaretini gösterme 
            if (sayi2 == "0" && blm == 1)
            {
                labelSonuc.Text = "" + (Convert.ToDouble(sayi2) / Convert.ToDouble(sayi1));
                labelSonuc.Text = "∞";
            }



            //roma rakalarını yazdırma


            if (labelSayi1.Text.IndexOf(",") < 1)
            {
                txt_cevir.ResetText();
                int number = Convert.ToInt32(labelSonuc.Text);

                if (number.ToString().Trim().Length == 0)
                    return;

                if (number >= 4000)
                {
                    txt_cevir.Text = "";

                    txt_cevir.Focus();
                    return;
                }

                String[] roman = new String[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
                int[] decimals = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

                string romanvalue = String.Empty;

                for (int i = 0; i < 13; i++)
                {
                    while (number >= decimals[i])
                    {
                        number -= decimals[i];
                        romanvalue += roman[i];
                    }
                }

                txt_cevir.Text = romanvalue;


            }

        }

        //geçmiş listesini temizleme
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

         private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
                {

                }


       
      


        private void label5_Click_1(object sender, EventArgs e)
        {

        }
        private void labelSayi1_Click(object sender, EventArgs e)
        {

        }

        private void labelİslem_Click(object sender, EventArgs e)
        {

        }

        private void labelSayi2_Click(object sender, EventArgs e)
        {

        }

        private void labelSonuc_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxHesaplama_Enter(object sender, EventArgs e)
        {

        }
        private void groupBoxGecmis_Enter(object sender, EventArgs e)
        {

        }

        private void labelGecmis_Click(object sender, EventArgs e)
        {

        }

       
    }
}
