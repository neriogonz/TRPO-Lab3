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
using TrpoLabs.Core;

namespace TrpoLabs.WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcularAreaButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double radio = Convert.ToDouble(RadioTextBox.Text);
                double altura = Convert.ToDouble(AlturaTextBox.Text);

                Calculator calculator = new Calculator();
                double area = calculator.CalcularAreaCono(radio, altura);

                ResultadoTextBlock.Text = $"Площадь конуса: {area}";
            }
            catch (FormatException)
            {
                ResultadoTextBlock.Text = "Пожалуйста, введите корректные числовые значения.";
            }
        }
    }
}
