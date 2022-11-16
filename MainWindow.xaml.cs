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

namespace TrabalhoDeRedes
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
        //Camilly Souza Oliveira
        //Renata Lima Lopes Castellan

        private void btCriptografar_Click(object sender, RoutedEventArgs e)
        {

            int chave;
            chave = Convert.ToInt32(txtChave.Text);

            string textoEntrada = "";
            string textoSaida = "";
            int numeroCaracteres, numero;

            textoEntrada = txtCriptografia.Text;

            numeroCaracteres = textoEntrada.Length;
            for (int i = 0; i < numeroCaracteres; i++)
            {
                numero = Convert.ToInt16(textoEntrada[i]) + chave;
                textoSaida += Convert.ToChar(numero);

            }

            txtTextoCriptografado.Text = textoSaida;
            txtCriptografia.Clear();


        }

        private void btDescriptografar_Click(object sender, RoutedEventArgs e)
        {
            int chave;
            chave = Convert.ToInt32(txtChave.Text);

            string textoEntrada = "";
            string textoSaida = "";
            int numeroCaracteres, numero;

            textoEntrada = txtDescriptografia.Text;

            numeroCaracteres = textoEntrada.Length;
            for (int i = 0; i < numeroCaracteres; i++)
            {
                numero = Convert.ToInt16(textoEntrada[i]) - chave;
                textoSaida += Convert.ToChar(numero);

            }

            txtTextoDescriptografado.Text = textoSaida;
            txtDescriptografia.Clear();
        }

        private void btLimpar_Click(object sender, RoutedEventArgs e)
        {
            txtCriptografia.Clear();
            txtDescriptografia.Clear();
            txtTextoCriptografado.Clear();
            txtTextoDescriptografado.Clear();
            txtChave.Clear();
        }
    }
}
