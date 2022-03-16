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
        public void btn_Aceptar_Click(object sender, RoutedEventArgs e)
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
        }
        private void ClearCodigoSucursal()
        {
            lbCodigoSucursal.Content = "";
        }         
        private void ClearlbCuenta()
        {
            lbCuenta.Content = "";
        }
        public void Generar_Sucursal()
        {
            Random numeroAzar = new Random();
            int codigo = numeroAzar.Next(0000, 9999);
          
            if (txtCodigoPostal.Text != "" && txtUbicacion.Text != "" && cbCiudad_sucursal.SelectedIndex != -1)
            {
                bool salir = true;
                do
                {
                    salir = true;
                    for (int a = 0; a < num; a++)
                    {
                        if (sucursal[a].GetCodigo_sucursal() == codigo)
                        {
                            codigo = numeroAzar.Next(0000, 9999);
                            salir = false;
                        }
                    }
                } while (salir == false);
                lbCodigoSucursal.Content = Convert.ToString(codigo);               
            }
            else
                ClearCodigoSucursal();
        }
        private void OpcionesFS(object sender, TextChangedEventArgs e)
        {
            Generar_Sucursal();
        }
        private void OpcionesFSCombo(object sender, SelectionChangedEventArgs e)
        {
            Generar_Sucursal();
        }
        public void Generar_Cuenta()
        {
            Random numeroAzar = new Random();
            int random = numeroAzar.Next(0000, 9999);
    
            if (txtNombre_Cliente.Text != "" && txtPrimerApellido_Cliente.Text != "" && txtDni_Cliente.Text != "" && cbSucursal.SelectedIndex != -1)
            {
                bool salir = true;
                do
                {
                    salir = true;
                    for (int a = 0; a < contadorPersonas; a++)
                    {
                        if (personas[a].GetCuenta() == random)
                        {
                            random = numeroAzar.Next(0000, 9999);
                            salir = false;
                        }
                    }
                } while (salir == false);
                lbCuenta.Content = Convert.ToString(random);               
            }
            else
                ClearlbCuenta();
        }
        private void OpcionesFC(object sender, TextChangedEventArgs e)
        {
            Generar_Cuenta();
        }
        private void OpcionesFCCombo(object sender, SelectionChangedEventArgs e)
        {
            Generar_Cuenta();
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
        private void GenerarIbanClicK(object sender, RoutedEventArgs e)
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
        private void ListSucursal_SelectionChanged(object sender, SelectionChangedEventArgs e)
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

        private void CrearDefault_Click(object sender, RoutedEventArgs e)
        {  
            sucursal[num] = new Sucursal(2040, "Alicante", "03600", "Jumilla");
            ListSucursal.Items.Add(sucursal[num].MostrarSucursal());
            cbSucursal.Items.Add(sucursal[num].codigo_sucursal);
            num++;
            sucursal[num] = new Sucursal(6020, "Castellon", "03560", "Monforte");
            ListSucursal.Items.Add(sucursal[num].MostrarSucursal());
            cbSucursal.Items.Add(sucursal[num].codigo_sucursal);
            num++;

            personas[contadorPersonas] = new Persona("Jose", 46983403, "Martinez", 0001, 2040);
            ListClientes.Items.Add(personas[contadorPersonas].MostrarCliente());
            ListCuentas.Items.Add(personas[contadorPersonas].MostrarCuenta());
            contadorPersonas++;

            personas[contadorPersonas] = new Persona("Maria", 423983589, "Sanchez", 0022, 6020);
            ListClientes.Items.Add(personas[contadorPersonas].MostrarCliente());
            ListCuentas.Items.Add(personas[contadorPersonas].MostrarCuenta());
            contadorPersonas++;

            cuentas[contadorCuenta] = new Cuenta(1250, 0001, 2040);
            contadorCuenta++;
            cuentas[contadorCuenta] = new Cuenta(8550, 0022, 6020);
            contadorCuenta++;

        }

        private void rbOperacion_Checked(object sender, RoutedEventArgs e)
        {
          /*  if ((rbDepositar.IsChecked == true) || (rbRetirar.IsChecked == true) && (txtOperacion.Text != ""))
               
            else
            {
                lbSaldo.Content = lbDineroCuenta.Content = "";
                
            }    */         
        }

        private void ListClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
            {
                MessageBox.Show("Debes Seleccionar un Cliente para hacer una operacion");
            }
        }

        private void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            if (((rbDepositar.IsChecked == true) || (rbRetirar.IsChecked == true)) && (txtOperacion.Text != ""))
            {
                if (rbDepositar.IsChecked == true)
                {
                    cuentas[ListClientes.SelectedIndex].Ingresar(Convert.ToInt32(txtOperacion.Text));
                    lbSaldo.Content = cuentas[ListClientes.SelectedIndex].dinero;
                    cuentas[ListClientes.SelectedIndex].SetDinero(Convert.ToInt32(lbSaldo.Content));
                    lbDineroCuenta.Content = cuentas[ListClientes.SelectedIndex].dinero;
                    txtOperacion.Text = "";
                }

                if (rbRetirar.IsChecked == true)
                {
                    int dineroaRetirar = Convert.ToInt32(txtOperacion.Text);
                    if (dineroaRetirar > cuentas[ListClientes.SelectedIndex].dinero)
                    {
                        MessageBox.Show("No Puedes retirar mas dinero del que dispone la cuenta");
                    }
                    else
                    {
                        cuentas[ListClientes.SelectedIndex].Retirar(Convert.ToInt32(txtOperacion.Text));
                        lbSaldo.Content = cuentas[ListClientes.SelectedIndex].dinero;
                        cuentas[ListClientes.SelectedIndex].SetDinero(Convert.ToInt32(lbSaldo.Content));
                        lbDineroCuenta.Content = cuentas[ListClientes.SelectedIndex].dinero;
                        txtOperacion.Text = "";
                    }                                      
                }
            } else
            {
                MessageBox.Show("Rellena los campos necesarios");
            }
                       
        }
    }
}
