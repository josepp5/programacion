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
                pbProgreso.Value++;
                                           
            if (txtPrimerApellido.Text != "")
                pbProgreso.Value++;       
               
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

            if (rbCliente.IsChecked == true || rbDistribuidor.IsChecked == true)
            {
                pbProgreso.Value++;               
            }
            if (cbItemValencia.IsSelected ||
                    cbItemCastellon.IsSelected ||
                    cbItemAlicante.IsSelected ||
                    cbItemAlbacete.IsSelected ||
                    cbItemCuenca.IsSelected ||
                    cbItemMurcia.IsSelected ||
                    cbItemTeruel.IsSelected ||
                    cbItemValenciaD.IsSelected ||
                    cbItemAlicanteD.IsSelected ||
                    cbItemCastellonD.IsSelected)
                pbProgreso.Value++;

            if (pbProgreso.Value == 9)
                btnAceptar.IsEnabled = true;

            lbProgreso.Content = pbProgreso.Value + " / 9";
        }

        private void ClearComboBox()
        {
            cbProvinciaCliente.SelectedIndex = -1;
            cbProvinciaDistribuidor.SelectedIndex = -1;
        }

        private void rbCliente_IsChecked(object sender, RoutedEventArgs e)
        {
            ClearComboBox();
            Mostrar();
            cbProvinciaCliente.Visibility = Visibility.Visible;
            cbProvinciaDistribuidor.Visibility = Visibility.Hidden;
            cbProvinciaCliente.IsEnabled = true;
        }

        private void rbDistribuidor_IsChecked(object sender, RoutedEventArgs e)
        {
            ClearComboBox();
            Mostrar();
            cbProvinciaDistribuidor.Visibility = Visibility.Visible;
            cbProvinciaCliente.Visibility = Visibility.Hidden;
            cbProvinciaDistribuidor.IsEnabled = true;
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

        private void cbProvinciaC_IsSelected(object sender, SelectionChangedEventArgs e)
        {
            Mostrar();
        }
        private void cbProvinciaD_IsSelected(object sender, SelectionChangedEventArgs e)
        {
            Mostrar();
        }
    }
}
