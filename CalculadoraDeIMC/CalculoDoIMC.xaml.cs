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

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            Resultado res = new Resultado();
            res.ShowDialog();
        }

        public double CalculoIMC()
        {
            return peso / (altura * altura);
        }

        public string InterpretarIMC()
        {
            double imc = CalcularIMC();
            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc < 25)
            {
                return "Peso normal";
            }
            else if (imc < 30)
            {
                return "Sobrepeso";
            }
            else
            {
                return "Obesidade";
            }
        }
    }
}
