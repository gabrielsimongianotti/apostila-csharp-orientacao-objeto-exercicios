using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _5
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int total = 2;
            for (int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é: " + total);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int n = 1;
            for (int i = 1; i < 1000; i += 1)
            {
                n = n + 1000;
                Console.WriteLine(n + i);
            }
            MessageBox.Show("O total é: " + n);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
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

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string t3=" ";
            string t4=" ";
            int n3 = 0;
            int n4 = 0;
            for (int i = 0; i < 30; i += 1)
            {
                if (i % 3 ==0)
                {
                    n3 += i;
                    t3 =t3 +" "+ i;
                }
                if (i%4 == 0)
                {
                    n4 += i;
                    t4 = t4 +" " + i; 
                }
               
            }
            MessageBox.Show(" divisiveis por 3: " + t3);
            MessageBox.Show(" divisiveis por 4: " + t4);
            MessageBox.Show("soma dos divisiveis por 3: "+n3.ToString());
            MessageBox.Show("soma dos divisiveis por 4: " + n4.ToString());

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                for(int f = 1; f <= n; f++)
                {
                    fatorial = f * fatorial;
                    Console.WriteLine(f);
                }
                MessageBox.Show(n+"! "+fatorial.ToString());
                fatorial = 1;
            }

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string fibonate = " ";
            int Fn = 0;
            int Fa = 1;
            int va = 0;
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
    }
}
