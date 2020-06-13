using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayi
{



    class formPermut
    {
        public int[,] permutated = new int[721, 5];
        public int index = 0;
        public void swapTwoNumber(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void prnPermut(int[] list, int k, int m)
        {
            int i;
            if (k == m)
            {
                for (i = 0; i <= m; i++)
                    Console.Write("{0}", list[i]);
                Console.Write(" ");
            }
            else
                for (i = k; i <= m; i++)
                {
                    swapTwoNumber(ref list[k], ref list[i]);
                    prnPermut(list, k + 1, m);
                    swapTwoNumber(ref list[k], ref list[i]);
                }
            
            permutated[index, 0] = Convert.ToInt32(list[0]);
            permutated[index, 1] = Convert.ToInt32(list[1]);
            permutated[index, 2] = Convert.ToInt32(list[2]);
            permutated[index, 3] = Convert.ToInt32(list[3]);
            permutated[index, 4] = Convert.ToInt32(list[4]);

            index++;

        }
    }

    public partial class Form1 : Form
    {
        formPermut permutasyon = new formPermut();
        public Form1()
        {
            InitializeComponent();
        }

        int olusturulmus = 0;

        private void rasgeleOlustur_Click(object sender, EventArgs e)
        {

            olusturulmus = 1;
            Random rastgele = new Random();

            int rastgeleTamSayiOlustur(int min, int maks, int ondalikCarpim){

                return rastgele.Next(min, maks) * ondalikCarpim;
            }

            sayi1.Text = rastgeleTamSayiOlustur(1, 10, 1).ToString();
            sayi2.Text = rastgeleTamSayiOlustur(1, 10, 1).ToString();
            sayi3.Text = rastgeleTamSayiOlustur(1, 10, 1).ToString();
            sayi4.Text = rastgeleTamSayiOlustur(1, 10, 1).ToString();
            sayi5.Text = rastgeleTamSayiOlustur(1, 10, 10).ToString();
            hedefSayi.Text = rastgeleTamSayiOlustur(100, 999, 1).ToString();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {

            if (olusturulmus == 1)
            {
                int karsilastir(string dizi)
                {
                    string[] haystack = { "5", "6", "7", "8", "9", "0" };

                    int check = 0;
                    for (int u = 0; u < 4; u++)
                    {
                        for (int y = 0; y < 6; y++)
                        {
                            if (dizi[u].ToString() == haystack[y])
                            {
                                check = 1;
                            }
                        }
                    }

                    if (check == 1)
                    {
                        return 1;
                    } else {
                        return 0;
                    }
                }

                int[] sayilar = new int[5];
                sayilar[0] =Convert.ToInt32(sayi1.Text);
                sayilar[1] =Convert.ToInt32(sayi2.Text);
                sayilar[2] = Convert.ToInt32(sayi3.Text);
                sayilar[3] = Convert.ToInt32(sayi4.Text);
                sayilar[4] = Convert.ToInt32(sayi5.Text);
                //MessageBox.Show(sayilar[0].ToString() + sayilar[1].ToString() + sayilar[2].ToString() + sayilar[3].ToString() + sayilar[4].ToString());


                int enAzFark = 9999999;
                string enAzFarkFoo = "3333";
                int temp1 = 0;
                int temp2 = 0;
                int temp3 = 0;
                int temp4 = 0;
                int temp5 = 0;
                permutasyon.prnPermut(sayilar, 0, 4);
                permutasyon.index = 0;
                for (int p = 0; p < 120; p++)
                {
                    sayilar[0] = permutasyon.permutated[p, 0];
                    sayilar[1] = permutasyon.permutated[p, 1];
                    sayilar[2] = permutasyon.permutated[p, 2];
                    sayilar[3] = permutasyon.permutated[p, 3];
                    sayilar[4] = permutasyon.permutated[p, 4];
                    //MessageBox.Show(permutasyon.permutated[p, 0].ToString() + permutasyon.permutated[p, 1].ToString() + permutasyon.permutated[p, 2].ToString() + permutasyon.permutated[p, 3].ToString() + permutasyon.permutated[p, 4].ToString());
                    //MessageBox.Show(sayilar[0].ToString() + sayilar[1].ToString() + sayilar[2].ToString() + sayilar[3].ToString() + sayilar[4].ToString());
             

                    for (int i = 1111; i <= 4444; i++)
                {
                    string foo = i.ToString();

                    if (karsilastir(foo) == 0)
                    {
                        int bar = 0;

                    

                        for (int key = 0; key < (sayilar.Length); ++key)
                        {
                            int val = sayilar[key];
                            if (key == 0)
                            {
                                bar = val;

                            } else {

                                if (foo[key - 1] == '1')
                                {
                                    bar += val;
                                } else if (foo[key - 1] == '2')
                                {
                                    bar -= val;
                                }
                                else if (foo[key - 1] == '3')
                                {
                                    bar *= val;
                                }
                                else if (foo[key - 1] == '4')
                                {
                                    bar /= val;
                                }
                            }
                        }

                        if (Math.Abs(Convert.ToInt32(hedefSayi.Text) - bar) < enAzFark)
                        {
                            enAzFark = Math.Abs(Convert.ToInt32(hedefSayi.Text) - bar);
                            enAzFarkFoo = foo;
                                temp1 = sayilar[0];
                                temp2 = sayilar[1];
                                temp3 = sayilar[2];
                                 temp4 = sayilar[3];
                                 temp5 = sayilar[4];
                            }
                    }
                }
            }
                
                string isaretiYazdir(char sayisi)
                {
                    switch (sayisi)
                    {
                        case '1':
                            return "+";
                        case '2':
                            return "-";
                        case '3':
                            return "*";
                        case '4':
                            return "/";
                        default: return sayisi.ToString();
                    }
                }

                int sonuc = Convert.ToInt32(hedefSayi.Text) + enAzFark;

                string text = "+- " + enAzFark + " değeri kadar yaklaşıldı.\n";
                text += temp1.ToString() + " " + isaretiYazdir(Convert.ToChar(enAzFarkFoo[0])) + " ";
                text += temp2.ToString() + " " + isaretiYazdir(Convert.ToChar(enAzFarkFoo[1])) + " ";
                text += temp3.ToString() + " " + isaretiYazdir(Convert.ToChar(enAzFarkFoo[2])) + " ";
                text += temp4.ToString() + " " + isaretiYazdir(Convert.ToChar(enAzFarkFoo[3])) + " ";
                text += temp5.ToString();
                text += " = " + sonuc;

                MessageBox.Show(text);
               

            }
            else{

                MessageBox.Show("Önce sayı oluşturmalısınız!");
            }
        }
    }
}
