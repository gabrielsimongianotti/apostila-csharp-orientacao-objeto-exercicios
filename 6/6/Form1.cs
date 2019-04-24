using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Conta
        {
            // numero, titular e saldo são atributos do objeto
            public int numero;
            public string titular;
            public double saldo;
            
            public void Deposita(double valor)
            {
                this.saldo += valor;
            }
            public void Saca(double valor)
            {
                if (valor < this.saldo)
                {
                    this.saldo -= valor;
                }
                else
                {
                    MessageBox.Show(valor +" é valor muito alto");
                }
                
            }
            public string Saldo()
            {
                return this.saldo.ToString();
            }
            public void Transfere(int valor, Conta pagar)
            {

                pagar.Saca(valor);
                this.Deposita(valor);
            }
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.numero = 1;
            c.titular = "victor";
            c.saldo = 100;
            Conta  a = new Conta();
            a.numero = 1;
            a.titular = "blablabla";
            a.saldo = 90;
            c.Deposita(20);
            MessageBox.Show( c.Saldo());
            a.Saca(100);
            MessageBox.Show(a.Saldo());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.numero = 1;
            c.titular = "victor";
            c.saldo = 100;
            Conta a = new Conta();
            a.numero = 1;
            a.titular = "blablabla";
            a.saldo = 90;
            c.Transfere(10, a);
            MessageBox.Show(c.Saldo());
            MessageBox.Show(a.Saldo());
        }
    }
}
