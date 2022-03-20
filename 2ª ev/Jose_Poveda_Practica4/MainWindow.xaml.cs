using Jose_Poveda_Practica4.Models;
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

namespace Jose_Poveda_Practica4
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
        public static Persona[] personas = new Persona[80];
        public static int contadorPersonas;
        

        public static Sucursal[] sucursal = new Sucursal[80];
        public static int num;

        public static Cuenta[] cuentas = new Cuenta[80];
        public static int contadorCuenta;
   

        private void ClearTextBox()
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
        private void ClearCodigoSucursal()
        {
            lbCodigoSucursal.Content = "";
        }
        private void ClearlbCuenta()
        {
            lbCuenta.Content = "";
        }
        private new void PreviewTextInput(object sender, TextCompositionEventArgs e)  // Creada una funcion que solo dejara escribir numeros en el textbox
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public void btn_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;
            if (boton == btn_Aceptar_Sucursal)
            {
                sucursal[num] = new Sucursal(Convert.ToInt32(lbCodigoSucursal.Content), cbCiudad_sucursal.Text, txtCodigoPostal.Text, txtUbicacion.Text);
                ListSucursal.Items.Add(sucursal[num].MostrarSucursal());
                cbSucursal.Items.Add(sucursal[num].codigo_sucursal);
                num++;
                lbCodigoSucursal.Content = cbCiudad_sucursal.Text = txtCodigoPostal.Text = txtUbicacion.Text = "";

            }
            if (boton == btnAceptar_Cliente)
            {
                personas[contadorPersonas] = new Persona(txtNombre_Cliente.Text, Convert.ToInt32(txtDni_Cliente.Text), txtPrimerApellido_Cliente.Text, Convert.ToInt32(lbCuenta.Content), Convert.ToInt32(cbSucursal.SelectedItem));
                cuentas[contadorCuenta] = new Cuenta(1000, Convert.ToInt32(lbCuenta.Content) , sucursal[cbSucursal.SelectedIndex].codigo_sucursal);
                ListClientes.Items.Add(personas[contadorPersonas].MostrarCliente());
                ListCuentas.Items.Add(personas[contadorPersonas].MostrarCuenta());
                contadorPersonas++;
                contadorCuenta++;
                lbCuenta.Content = txtNombre_Cliente.Text = txtPrimerApellido_Cliente.Text = txtDni_Cliente.Text = cbSucursal.Text = "";
            }     
            
            if (boton == btnConfirmar)
            {
                if (((rbDepositar.IsChecked == true) || (rbRetirar.IsChecked == true)) && (txtOperacion.Text != ""))
                {
                    if (rbDepositar.IsChecked == true)
                    {
                        cuentas[ListClientes.SelectedIndex].Ingresar(Convert.ToInt32(txtOperacion.Text));
                        lbDineroCuenta.Content = cuentas[ListClientes.SelectedIndex].dinero;
                        cuentas[ListClientes.SelectedIndex].SetDinero(Convert.ToInt32(lbDineroCuenta.Content));
                        lbDineroCuenta.Content = cuentas[ListClientes.SelectedIndex].dinero;
                        txtOperacion.Text = "";
                    }

                    if (rbRetirar.IsChecked == true)
                    {
                        if (Convert.ToInt32(txtOperacion.Text) > cuentas[ListClientes.SelectedIndex].dinero)
                        {
                            MessageBox.Show("No Puedes retirar mas dinero del que dispone la cuenta");
                        }
                        else
                        {
                            cuentas[ListClientes.SelectedIndex].Retirar(Convert.ToInt32(txtOperacion.Text));
                            lbDineroCuenta.Content = cuentas[ListClientes.SelectedIndex].dinero;
                            cuentas[ListClientes.SelectedIndex].SetDinero(Convert.ToInt32(lbDineroCuenta.Content));
                            lbDineroCuenta.Content = cuentas[ListClientes.SelectedIndex].dinero;
                            txtOperacion.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Rellena los campos necesarios");
                }
            }

            if (boton == btncrearDefault)
            {
                sucursal[num] = new Sucursal(2040, "Alicante", "03600", "Jumilla");
                ListSucursal.Items.Add(sucursal[num].MostrarSucursal());
                cbSucursal.Items.Add(sucursal[num].codigo_sucursal);
                num++;
                sucursal[num] = new Sucursal(6020, "Castellon", "03560", "Monforte");
                ListSucursal.Items.Add(sucursal[num].MostrarSucursal());
                cbSucursal.Items.Add(sucursal[num].codigo_sucursal);
                num++;

                personas[contadorPersonas] = new Persona("Jose", 46983403, "Martinez", 2201, 2040);
                ListClientes.Items.Add(personas[contadorPersonas].MostrarCliente());
                ListCuentas.Items.Add(personas[contadorPersonas].MostrarCuenta());
                contadorPersonas++;

                personas[contadorPersonas] = new Persona("Maria", 423983589, "Sanchez", 4022, 6020);
                ListClientes.Items.Add(personas[contadorPersonas].MostrarCliente());
                ListCuentas.Items.Add(personas[contadorPersonas].MostrarCuenta());
                contadorPersonas++;

                cuentas[contadorCuenta] = new Cuenta(1250, 2201, 2040);
                contadorCuenta++;
                cuentas[contadorCuenta] = new Cuenta(8550, 4022, 6020);
                contadorCuenta++;
                btncrearDefault.IsEnabled = false;
            }

            if (boton == btnIban)
            {
                if (ListClientes.SelectedIndex != -1)
                {
                    int cuenta = personas[ListClientes.SelectedIndex].cuenta;
                    for (int i = 0; i < personas.Length; i++)
                    {
                        if (personas[i] != null && personas[i].cuenta == cuenta)
                        {
                            lbIban.Content = Convert.ToString(personas[i].codigo_sucursal) + " " + Convert.ToString(personas[i].cuenta) + " " + Convert.ToString(personas[i].dni) + " nº IBAN de " + personas[i].nombre;
                            lbDineroCuenta.Content = cuentas[i].GetDinero();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debes Seleccionar un Cliente para generar su IBAN");
                }
            }
        }    
        public void Generar_Sucursal()
        {
            Random numeroAzar = new Random();
            int codigo = numeroAzar.Next(1000, 9999);
          
            if (txtCodigoPostal.Text != "" && txtUbicacion.Text != "" && cbCiudad_sucursal.SelectedIndex != -1)
            {
                bool salir;
                do
                {
                    salir = true;
                    for (int a = 0; a < num; a++)
                    {
                        if (sucursal[a].GetCodigo_sucursal() == codigo)
                        {
                            codigo = numeroAzar.Next(1000, 9999);
                            salir = false;
                        }
                    }
                } while (salir == false);
                lbCodigoSucursal.Content = Convert.ToString(codigo);               
            }
            else
                ClearCodigoSucursal();
        }
        public void Generar_Cuenta()
        {
            Random numeroAzar = new Random();
            int random = numeroAzar.Next(1000, 9999);

            if (txtNombre_Cliente.Text != "" && txtPrimerApellido_Cliente.Text != "" && txtDni_Cliente.Text != "" && cbSucursal.SelectedIndex != -1)
            {
                bool salir;
                do
                {
                    salir = true;
                    for (int a = 0; a < contadorPersonas; a++)
                    {
                        if (personas[a].GetCuenta() == random)
                        {
                            random = numeroAzar.Next(1000, 9999);
                            salir = false;
                        }
                    }
                } while (salir == false);
                lbCuenta.Content = Convert.ToString(random);
            }
            else
                ClearlbCuenta();
        }
        private void OpcionesFCombo(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox == cbCiudad_sucursal)
                Generar_Sucursal();
            if (comboBox == cbSucursal)
                Generar_Cuenta();
        }     
        private void OpcionesFormularios(object sender, TextChangedEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox == txtNombre_Cliente || textbox == txtPrimerApellido_Cliente || textbox == txtDni_Cliente)
                Generar_Cuenta();
            if (textbox == txtCodigoPostal || textbox == txtUbicacion)
                Generar_Sucursal();    
        }
        private void MenuClick(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            if (menuItem == MenuItemBanco)
            {
                tbBanco.Visibility = Visibility.Visible;
                tbFormularios.Visibility = Visibility.Hidden;   
            }
            if (menuItem == MenuItemFormularios)
            {
                tbFormularios.Visibility = Visibility.Visible;
                tbBanco.Visibility = Visibility.Hidden; 
            }
        } 
        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            if (listBox == ListSucursal)
            {
                int codigo_sucursal = sucursal[ListSucursal.SelectedIndex].codigo_sucursal;
                ListCuentasSuc.Items.Clear();
                for (int i = 0; i < cuentas.Length; i++)
                {
                    if (cuentas[i] != null && cuentas[i].codigo_sucursal == codigo_sucursal)
                    {
                        ListCuentasSuc.Items.Add(cuentas[i].MostrarCuentasSuc());
                        lbCuentasSuc.Content = "Cuentas en la sucursal:  " + codigo_sucursal;
                    }
                }
            }  
            if (listBox == ListClientes)
            {
                if (ListClientes.SelectedIndex != -1)
                {
                    int dinero = cuentas[ListClientes.SelectedIndex].GetDinero();
                    for (int j = 0; j < cuentas.Length; j++)
                    {
                        if (cuentas[j] != null && cuentas[j].GetDinero() == dinero)
                        {
                            lbDineroCuenta.Content = cuentas[j].GetDinero();
                        }
                    }
                }
                else
                    MessageBox.Show("Debes Seleccionar un Cliente para hacer una operacion");
            }
        }
    }
}
