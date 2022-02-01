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

namespace trabajoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int resultado = 0;
        public bool Primera = true;
        public char operador = ' ';
        public string operacion = "";
        public int guardarnumero;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        public void Mostrar()
        {
            pbProgreso.Value = 0;

            if (txtNombre.Text != "")
                pbProgreso.Value++;

            if (txtApellidos.Text != "")
                pbProgreso.Value++;

            if (txtEmail.Text != "")
                pbProgreso.Value++;

            if (rbAspe.IsChecked == true)
                pbProgreso.Value++;

            if (rbCullera.IsChecked == true)
                pbProgreso.Value++;

            if (rbMonforte.IsChecked == true)
                pbProgreso.Value++;

            if (chkSi.IsChecked == true || chkNo.IsChecked == true)
                pbProgreso.Value++;

            lbProgress.Content = pbProgreso.Value + " / 5";

        }

        private void rbAspe_Checked(object sender, RoutedEventArgs e)
        {
            Mostrar();
        }

        private void rbCullera_Checked(object sender, RoutedEventArgs e)
        {
            Mostrar();
        }

        private void rbMonforte_Checked(object sender, RoutedEventArgs e)
        {
            Mostrar();
        }

        private void txtApellidos_TextChanged(object sender, TextChangedEventArgs e)
        {
            Mostrar();
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            Mostrar();
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            Mostrar();
        }

        private void chkSi_Checked(object sender, RoutedEventArgs e)
        {
            Mostrar();
        }

        private void chkNo_Checked(object sender, RoutedEventArgs e)
        {
            Mostrar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            operacion = operacion + btn.Content.ToString();
            txtNumero.Text = operacion;
        }

        private void Calcular(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            if (Primera)
            {
                resultado = Convert.ToInt32(operacion);
                Primera = false;

                operador = Convert.ToChar(btn.Content);

                operacion = "";
            }

            else
            {
                guardarnumero = Convert.ToInt32(operacion);
                operacion = "";

                switch (operador)
                {
                    case '+': resultado = resultado + guardarnumero; break;
                    case '-': resultado = resultado - guardarnumero; break;
                    case '*': resultado = resultado * guardarnumero; break;
                    case '/': resultado = resultado / guardarnumero; break;
                }
                operador = Convert.ToChar(btn.Content);
            }

            if (operador == '=')
            {
                operacion = Convert.ToString(resultado);
                txtNumero.Text = operacion;
                Primera = true;
                operacion = "";
            }
           
        }
    }   
}
