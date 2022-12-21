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

namespace Bin2Dec
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ConverToDecimal(string binaryNumber)
        {
            try
            {
                if (binaryNumber.Length > 8)
                {
                    valorDecimal.Text = "Quantidade máxima de números excedida. O limite é 8!";
                }
                else
                {
                    List<int> numbers = new();
                    int result = 0;
                    for (int i = 0; i < binaryNumber.Length; i++)
                    {
                        int value = int.Parse(binaryNumber.Substring(i, 1));
                        numbers.Add(value);

                    }
                    numbers.Reverse();

                    for (int i = 0; i < binaryNumber.Length; i++)
                    {
                        result += numbers[i] * (int)Math.Pow(2, i);
                    }



                    valorDecimal.Text = $"O equivalente decimal para {binaryNumber} é {result}";


                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro na conversão!");
            }

        }

        private void ConvertToDecimal(object sender, MouseButtonEventArgs e)
        {
            ConverToDecimal(valorBinario.Text);
        }
    }
}
