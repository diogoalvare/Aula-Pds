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
using System.Windows.Shapes;

namespace CalculadoraDeIMC
{
    /// <summary>
    /// Lógica interna para CalculoDoIMC.xaml
    /// </summary>
    public partial class CalculoDoIMC : Window
    {
        public CalculoDoIMC()
        {
            InitializeComponent();
        }

        public static double imc = 0;

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            imc = Convert.ToDouble(txtPeso.Text) / (Convert.ToDouble(txtAltura.Text) * Convert.ToDouble(txtAltura.Text));
            Resultado res = new Resultado();
            res.ShowDialog();
        }

        public string MostrarResultado()
        {
            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                return "Peso normal";
            }
            else if (imc >= 24.9 && imc <= 29.9)
            {
                return "Sobrepeso";
            }
            else if (imc >= 29.9 && imc <= 34.9)
            {
                return "Obesidade Grau 1";
            }
            else if (imc >= 34.9 && imc <= 40)
            {
                return "Obesidade Grau 2";
            }
            else
            {
                return "Obesidade Grau 3";
            }
        }
    }
}
