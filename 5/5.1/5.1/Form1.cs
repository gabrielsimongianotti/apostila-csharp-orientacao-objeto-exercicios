using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int total = 2;
            for (int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é: " + total);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int n = 1;
            for (int i = 1; i < 1000; i += 1)
            {
                n = n + 1000;
                Console.WriteLine(n + i);
            }
            MessageBox.Show("O total é: " + n);
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            String numero = "";
            for (int i = 1; i < 100; i += 1)
            {
                if (i % 3 == 0)
                {
                    numero = numero + " " + i;

                }
            }
            MessageBox.Show(numero);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int numero = 0;

            for (int i = 1; i < 100; i += 1)
            {
                if (i % 3 != 0)
                {

                    numero = numero + i;

                }

            }
            MessageBox.Show(numero.ToString());
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string t3 = " ";
            string t4 = " ";
            int n3 = 0;
            int n4 = 0;
            for (int i = 0; i < 30; i += 1)
            {
                if (i % 3 == 0)
                {
                    n3 += i;
                    t3 = t3 + " " + i;
                }
                if (i % 4 == 0)
                {
                    n4 += i;
                    t4 = t4 + " " + i;
                }

            }
            MessageBox.Show(" divisiveis por 3: " + t3);
            MessageBox.Show(" divisiveis por 4: " + t4);
            MessageBox.Show("soma dos divisiveis por 3: " + n3.ToString());
            MessageBox.Show("soma dos divisiveis por 4: " + n4.ToString());
        }

        private void Button6_Click(object sender, EventArgs e)
        {

            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                for (int f = 1; f <= n; f++)
                {
                    fatorial = f * fatorial;
                    Console.WriteLine(f);
                }
                MessageBox.Show(n + "! " + fatorial.ToString());
                fatorial = 1;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string fibonate = " ";
            int Fn = 0;
            int Fa = 1;
        
            fibonate = Fn + " " + Fa + " ";

            do
            {
                var aux = Fn;
                Fn += Fa;
                fibonate += " " + Fn;
                Fa = aux;
            }
            while (Fn < 100);
            MessageBox.Show(fibonate);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("digite algo na caixa de texto");
            }
            else
            {
                string texto = "";
                int n=1;
                for(int i=1;i<= Convert.ToInt32(textBox1.Text); i++)
                {
                    texto += i;
                    n = i;
                    for (int o = 1; o < i; o++)
                    {
                        n += i;
                        texto +=" "+ n;
                    }
                    texto += Environment.NewLine;
                    
                }
                MessageBox.Show(texto);


            }
        }

       
    }
}
