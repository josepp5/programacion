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

namespace WPFlearn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public struct Persona
        {
            public string nombre;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnviar1_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Background = Brushes.IndianRed;
                txtNombre.Focus();
            }

            else if (txtEmail.Text == "")
            {
                txtEmail.Background = Brushes.IndianRed;
                txtEmail.Focus();
            }

            else
                MessageBox.Show(txtNombre.Text + "/n" + txtEmail.Text);
        }

        private void txtNombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNombre.Text != "")
            {
                txtNombre.Background = Brushes.White;
            }
            else
            {
                txtNombre.Background = Brushes.IndianRed;
            }
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtEmail.Text != "")
            {
                txtEmail.Background = Brushes.White;
            }
            else
            {
                txtEmail.Background = Brushes.IndianRed;
            }
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            txtNumero1.Text = btn.Content.ToString();
            txtNumero2.Text = btn.Content.ToString();              
        }

        private void Calcular(object sender, RoutedEventArgs e)
        {
            if (txtNumero1.Text == "")
            {
                txtNumero1.Background = Brushes.IndianRed;
                txtNumero1.Focus();
            }
            else if (txtNumero2.Text == "")
            {
                txtNumero2.Background = Brushes.IndianRed;
                txtNumero2.Focus();
            }
            else
            {
                int numero1 = Convert.ToInt32(txtNumero1.Text);
                int numero2 = Convert.ToInt32(txtNumero2.Text);

                Button btn = (Button)sender;
                char operacion = Convert.ToChar(btn.Content.ToString());

                switch (operacion)
                {
                    case '+': txtResultado.Text = (numero1 + numero2).ToString(); break;
                    case '-': txtResultado.Text = (numero1 - numero2).ToString(); break;
                    case '/': txtResultado.Text = (numero1 / numero2).ToString(); break;
                    case '*': txtResultado.Text = (numero1 * numero2).ToString(); break;
                }
            }
        }

        private void chkEstudiar_Click(object sender, RoutedEventArgs e)
        {
            if (chkEstudiar.IsChecked == true)
            {
                lbCiudades.IsEnabled = true;
            }
            else
            {
                lbCiudades.IsEnabled = false;
            }
                
        }

        private void chkTrabajas_Click(object sender, RoutedEventArgs e)
        {
            if (chkTrabajas.IsChecked == true)
            {
                cbPueblos.IsEnabled = true;
            }
            else
            {
                cbPueblos.IsEnabled = false;
            }
        }

      
    }
}
