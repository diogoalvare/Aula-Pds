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
    /// Lógica interna para Resultado.xaml
    /// </summary>
    public partial class Resultado : Window
    {
        public Resultado()
        {
            InitializeComponent();

            CalculoDoIMC cal = new CalculoDoIMC();

            txtResultado.Text = cal.MostrarResultado();
            
        }
    }
}
