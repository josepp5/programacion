using practica4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace practica4
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

        public static Persona[] personas = new Persona[10];
        public static int i = 0;

        public static Sucursal[] sucursal = new Sucursal[10];
        public static int num = 0;

        public void ClearTextBox()
        {
            txtUbicacion.Text = "";
            txtCodigoPostal.Text = "";
            cbCiudad_sucursal.SelectedIndex = -1;
            lbCodigoSucursal.Content = "";
            txtNombre_Cliente.Text = "";
            txtPrimerApellido_Cliente.Text = "";
            txtDni_Cliente.Text = "";
            lbCuenta.Content = "";
            cbSucursal.SelectedIndex = -1;
            
        }

        private new void PreviewTextInput(object sender, TextCompositionEventArgs e)  // Creada una funcion que solo dejara escribir numeros en el textbox
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public void btn_Aceptar_Sucursal_Click(object sender, RoutedEventArgs e)
        {
            sucursal[num] = new Sucursal(Convert.ToInt32(lbCodigoSucursal.Content), cbCiudad_sucursal.Text, txtCodigoPostal.Text, txtUbicacion.Text);
            ListSucursal.Items.Add(sucursal[num].MostrarSucursal());
            cbSucursal.Items.Add(sucursal[num].codigo_sucursal);
            ClearTextBox();
        }
        private void ClearCodigoSucursal()
        {
            lbCodigoSucursal.Content = "";
        }
        public void Generar_Sucursal()
        {
            Random numeroAzar = new Random();

            int contador = 0;
            if (cbCiudad_sucursal.SelectedIndex != -1)
                contador++;
            if (txtCodigoPostal.Text != "")
                contador++;
            if (txtUbicacion.Text != "")
                contador++;

            if (contador == 3)
            {
                lbCodigoSucursal.Content = Convert.ToInt32(numeroAzar.Next(0, 9999));                         
            }
            else
                ClearCodigoSucursal();
        }
        public void btnAceptar_Cliente_Click(object sender, RoutedEventArgs e)
        {
            personas[i] = new Persona(txtNombre_Cliente.Text, Convert.ToInt32(txtDni_Cliente.Text), txtPrimerApellido_Cliente.Text, Convert.ToInt32(lbCuenta.Content), Convert.ToInt32(cbSucursal.SelectedItem));
            ListClientes.Items.Add(personas[i].MostrarCliente());
            ClearTextBox();                                                     
        }        
        private void ClearlbCuenta() 
        {
            lbCuenta.Content = "";
        }

        public void Generar_Cuenta()
        {
            Random numeroAzar = new Random();          
            
            int contador = 0;
            if (txtNombre_Cliente.Text != "")
                contador++;
            if (txtPrimerApellido_Cliente.Text != "")
                contador++;
            if (txtDni_Cliente.Text != "")
                contador++;
            if (cbSucursal.SelectedIndex != -1)
                contador++;

            if (contador == 4)
                lbCuenta.Content = Convert.ToInt32(numeroAzar.Next(0, 9999));
            else
                ClearlbCuenta();
        }
        private void txtNombre_ClienteTextChanged(object sender, TextChangedEventArgs e)
        {
            Generar_Cuenta();
        }

        private void txtPrimerApellido_ClienteTextChanged(object sender, TextChangedEventArgs e)
        {
            Generar_Cuenta();
        }

        private void txtDni_ClienteTextChanged(object sender, TextChangedEventArgs e)
        {
            Generar_Cuenta();
        }

        private void cbCiudad_SlectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Generar_Sucursal();
        }

        private void txtCodigoPostal_TextChanged(object sender, TextChangedEventArgs e)
        {
            Generar_Sucursal();
        }

        private void txtUbicacion_TextChanged(object sender, TextChangedEventArgs e)
        {
            Generar_Sucursal();
        }

        private void cbSucursal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Generar_Cuenta();
        }

        private void MenuChecked(object sender, RoutedEventArgs e)
        {
            if (MenuBanco.IsChecked)
                GridInfo.Visibility = Visibility.Visible;
            else if (MenuFormulario.IsChecked)
                GridFormularios.Visibility = Visibility.Visible;
        }
    }
}
