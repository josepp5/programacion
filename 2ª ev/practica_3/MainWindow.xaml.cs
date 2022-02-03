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
using System.Text.RegularExpressions;

namespace practica_3
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

        private new void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public void Mostrar()
        {
            pbProgreso.Value = 0;

            if (txtNombre.Text != "")
            {
                pbProgreso.Value++;
            }                                   
            if (txtPrimerApellido.Text != "")
            {
                pbProgreso.Value++;
            }           

            if (rbCliente.IsChecked == true)
            {
                cbProvincia.IsEnabled = true;
                cbProvincia.Items.Add("Murcia");
                cbProvincia.Items.Add("Albacete");
                cbProvincia.Items.Add("Cuenca");
                cbProvincia.Items.Add("Teruel");
                pbProgreso.Value++;
            }
               
            if (rbDistribuidor.IsChecked == true)
            {
                cbProvincia.IsEnabled = true;
                cbProvincia.Items.Remove("Murcia");
                cbProvincia.Items.Remove("Albacete");
                cbProvincia.Items.Remove("Cuenca");
                cbProvincia.Items.Remove("Teruel");
                pbProgreso.Value++;
            }
               
            if (txtTelefono.Text != "")
                pbProgreso.Value++;

            if (txtEmail.Text != "")
                pbProgreso.Value++;

            if (txtDireccion.Text != "")
                pbProgreso.Value++;

            if (txtCodigoPostal.Text != "")
                pbProgreso.Value++;

            if (txtPoblacion.Text != "")
                pbProgreso.Value++;
                          
            lbProgreso.Content = pbProgreso.Value + " / 9";

            if (pbProgreso.Value == 9)         
                btnAceptar.IsEnabled = true;

            if (cbItemValencia.IsSelected || cbItemCastellon.IsSelected || cbItemAlicante.IsSelected)
            {
                pbProgreso.Value++;
                btnAceptar.IsEnabled = true;
            }     
        }

        private void rbCliente_IsChecked(object sender, RoutedEventArgs e)
        {
            Mostrar();     
        }

        private void rbDistribuidor_IsChecked(object sender, RoutedEventArgs e)
        {
            Mostrar();
        }

        private void txtNombreChanged(object sender, TextChangedEventArgs e)
        {
            Mostrar();
        }

        private void txtApellido1Changed(object sender, TextChangedEventArgs e)
        {
            Mostrar();
        }

        private void txtTelefonoChanged(object sender, TextChangedEventArgs e)
        {
            Mostrar();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtEmailChanged(object sender, TextChangedEventArgs e)
        {
            Mostrar();
        }

        private void txtDireccionChanged(object sender, TextChangedEventArgs e)
        {
            Mostrar();
        }

        private void txtCodigoPostalChanged(object sender, TextChangedEventArgs e)
        {
            Mostrar();
        }

        private void txtPoblacionChanged(object sender, TextChangedEventArgs e)
        {
            Mostrar();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Formulario completado correctamente!");
        }

    }
}
