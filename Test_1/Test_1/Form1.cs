using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Hide();
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            textBox3.Clear();
            textBox2.Clear();
            try {
                int N = Int32.Parse(textBox1.Text);
                if (N == 0)
                {
                    MessageBox.Show("nezadal jsi zadne cislo");
                }
                else
                {
                    Random rng = new Random();
                    while (N != 0)
                    {
                        int Cislo = rng.Next(31, 128);
                        listBox1.Items.Add((char)Cislo);
                        N--;
                    }
                    foreach (char X in listBox1.Items)
                    {
                        if ((int)X == 32)
                        {
                        }
                        else
                        {
                            textBox3.Text += X;
                        }
                    }
                    foreach (char Y in listBox1.Items)
                    {
                        textBox2.Text += Y;
                    }
                    string text = textBox2.Text;
                    string[] Pole = text.Split((char)32);
                    bool slovo = false;
                    int pocitadlo = 0;
                    foreach (string K in Pole)
                    {
                        foreach (char l in K)
                        {
                            if (((l > 64) && (l < 91))||((l > 96) && (l < 123)))
                            {
                                
                            }
                            else
                            {
                                slovo = true;
                            }

                            if ((l > 47) && (l < 58))
                            {
                                listBox3.Items.Add(l);
                            }
                            else
                            {
                                if(((l >32)&&(l < 48))|| ((l > 90) && (l < 96)) ||(l == 126))
                                {
                                    listBox4.Items.Add(l);
                                }
                            }
                            pocitadlo++;
                        }
                        if ((slovo == false) && (pocitadlo > 1))
                        {
                            listBox2.Items.Add(K);
                        }
                        slovo = false;
                        pocitadlo = 0;
                    }

                    string veta = textBox2.Text;
                    funkce(veta);
                }
            }
            catch
            {
                MessageBox.Show("nejaka chybka nastala");
            }
        }

        private void funkce(string veta)
        {
            bool mezera = false;
            int acka = 0;
            int ecka = 0;
            foreach (char O in veta)
            {
                if(O == 32)
                {
                    mezera = true;
                }
                else if(O == 97)
                {
                    acka++;
                }
                else if (O == 101)
                {
                    ecka++;
                } 
            }
            if (mezera == true)
            {
                MessageBox.Show("v textu se nachazi mezera, pocet a je:" + acka + "pocet e je:" + ecka);
            }
            if(mezera == false)
            {
                MessageBox.Show("v textu se nenachazi mezera, pocet a je:" + acka + "pocet e je:" + ecka);
            }
        }

    }
}
