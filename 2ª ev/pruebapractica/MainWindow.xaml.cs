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
    //--------------------------
    // Jose Poveda Perez
    // Curso DAM
    // Modalidad Presencial
    // Práctica nº 4
    //---------------------------
    public partial class MainWindow : Window
    {       
        public MainWindow()
        {
            InitializeComponent();                                
        }
        public static Persona[] personas = new Persona[80]; // Creo los array de objetos tipo Persona, Sucursal y Cuenta.
        public static int contadorPersonas;                 // Creo variables int que sera su contador para cada objeto.

        public static Sucursal[] sucursal = new Sucursal[80]; 
        public static int contadorSucursal;

        public static Cuenta[] cuentas = new Cuenta[80];
        public static int contadorCuenta;

        private void Clearlb(string label) // Funcion que me permitira vaciar el content de los label de codigos de sucursal y cuenta (cuando sea necesario).
        {
            if (label == "cuenta")
                lbCuenta.Content = "";
            if (label == "sucursal")
                lbCodigoSucursal.Content = "";
        }
        private new void PreviewTextInput(object sender, TextCompositionEventArgs e)  // Creada una funcion que solo dejara escribir numeros en el textbox
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public void btn_Click(object sender, RoutedEventArgs e) // En esta funcion encapsulado todos los eventos click menos el Menu.
        {
            Button boton = (Button)sender;
            if (boton == btn_Aceptar_Sucursal)  // al hacer click en este boton creo una nueva sucursal y añado sus datos en las listas necesarias  
            {
                sucursal[contadorSucursal] = new Sucursal(Convert.ToInt32(lbCodigoSucursal.Content), cbCiudad_sucursal.Text, txtCodigoPostal.Text, txtUbicacion.Text);
                ListSucursal.Items.Add(sucursal[contadorSucursal].MostrarSucursal());
                cbSucursal.Items.Add(sucursal[contadorSucursal].codigo_sucursal);
                contadorSucursal++;
                lbCodigoSucursal.Content = cbCiudad_sucursal.Text = txtCodigoPostal.Text = txtUbicacion.Text = "";
            }
            if (boton == btnAceptar_Cliente) // al hacer click en este boton creo un nuevo cliente y una nueva cuenta y añado sus datos en las listas necesarias
            {
                personas[contadorPersonas] = new Persona(txtNombre_Cliente.Text, Convert.ToInt32(txtDni_Cliente.Text), txtPrimerApellido_Cliente.Text, Convert.ToInt32(lbCuenta.Content), Convert.ToInt32(cbSucursal.SelectedItem));
                cuentas[contadorCuenta] = new Cuenta(1000, Convert.ToInt32(lbCuenta.Content) , sucursal[cbSucursal.SelectedIndex].codigo_sucursal);
                ListClientes.Items.Add(personas[contadorPersonas].MostrarCliente());
                ListCuentas.Items.Add(personas[contadorPersonas].MostrarCuenta());
                contadorPersonas++;
                contadorCuenta++;
                lbCuenta.Content = txtNombre_Cliente.Text = txtPrimerApellido_Cliente.Text = txtDni_Cliente.Text = cbSucursal.Text = "";
            }     
            if (boton == btnConfirmar)  // este boton ejecutara las funciones de ingresar o retirar dinero de una cuenta
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
                    MessageBox.Show("Rellena los campos necesarios");
            }
            if (boton == btncrearDefault) // con este boton se crearan 2 sucursales, 2 personas y 2 cuentas con valores predeterminados (ejemplo);
            {
                sucursal[contadorSucursal] = new Sucursal(2040, "Alicante", "03600", "Jumilla");
                ListSucursal.Items.Add(sucursal[contadorSucursal].MostrarSucursal());
                cbSucursal.Items.Add(sucursal[contadorSucursal].codigo_sucursal);
                contadorSucursal++;
                sucursal[contadorSucursal] = new Sucursal(6020, "Castellon", "03560", "Monforte");
                ListSucursal.Items.Add(sucursal[contadorSucursal].MostrarSucursal());
                cbSucursal.Items.Add(sucursal[contadorSucursal].codigo_sucursal);
                contadorSucursal++;

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
            if (boton == btnIban) // al hacer click en este boton generamos un string que contendra el iban generado a partir de algunos atributos de persona.
            {
                if (ListClientes.SelectedIndex != -1)
                {
                    int cuenta = personas[ListClientes.SelectedIndex].cuenta;
                    for (int i = 0; i < personas.Length; i++)
                    {
                        if (personas[i] != null && personas[i].cuenta == cuenta)
                        {
                            lbIban.Content = Convert.ToString(personas[i].codigo_sucursal) + " " + Convert.ToString(personas[i].cuenta) + " " + Convert.ToString(personas[i].dni) + " IBAN de " + personas[i].nombre;
                            lbDineroCuenta.Content = cuentas[i].GetDinero();
                        }
                    }
                }
                else
                    MessageBox.Show("Debes Seleccionar un Cliente para generar su IBAN");
            }
        }    
        public void Generar_Codigos(string opcion) // Esta funcion genera los codigos aleatorios no repetidos de sucursal y cuenta segun sea necesario.
        {
            if (opcion == "sucursal")  // Se genera el codigo aleatorio de sucursal si todos sus campos estan rellenados
            {
                Random numeroAzar = new Random();
                int codigo = numeroAzar.Next(1000, 9999);

                if (txtCodigoPostal.Text != "" && txtUbicacion.Text != "" && cbCiudad_sucursal.SelectedIndex != -1)
                {
                    for (int a = 0; a < contadorSucursal; a++)
                    {
                        if (sucursal[a].GetCodigo_sucursal() == codigo)
                        {
                            Generar_Codigos(opcion);
                            return;
                        }
                    }
                    lbCodigoSucursal.Content = Convert.ToString(codigo);
                
                else
                    Clearlb("sucursal");
            }
            if (opcion == "cuenta")  // Se genera el codigo aleatorio de cuenta si todos sus campos estan rellenados
            {
                Random numeroAzar = new Random();
                int random = numeroAzar.Next(1000, 9999);

                if (txtNombre_Cliente.Text != "" && txtPrimerApellido_Cliente.Text != "" && txtDni_Cliente.Text != "" && cbSucursal.SelectedIndex != -1)
                {
                    for (int a = 0; a < contadorPersonas; a++)
                    {
                        if (personas[a].GetCuenta() == random)
                        {
                            Generar_Codigos(opcion);
                            return;
                        }
                    }
                    lbCuenta.Content = Convert.ToString(random);
                }
                else
                    Clearlb("cuenta");
            }
        }       
        private void OpcionesFCombo(object sender, SelectionChangedEventArgs e)  // llamara a generar_codigos() aleatorios cuando se seleccione una opcion en sus combobox
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox == cbCiudad_sucursal)
                Generar_Codigos("sucursal");
            if (comboBox == cbSucursal)
                Generar_Codigos("cuenta");
        }     
        private void OpcionesFormularios(object sender, TextChangedEventArgs e)  // llamara a generar_codigos() aleatorios cuando se modifiquen datos en los textbox.
        {
            TextBox textbox = (TextBox)sender;
            if (textbox == txtNombre_Cliente || textbox == txtPrimerApellido_Cliente || textbox == txtDni_Cliente)
                Generar_Codigos("cuenta");
            if (textbox == txtCodigoPostal || textbox == txtUbicacion)
                Generar_Codigos("sucursal");    
        }
        private void MenuClick(object sender, RoutedEventArgs e) // Mostrara el tabcontrol necesario cuando el usuario haga click en un menuItem determinado
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
        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e) // Contiene codigo a ejecutar cuando un Item de las listas es seleccionado
        {
            ListBox listBox = (ListBox)sender;
            if (listBox == ListSucursal) // Al seleccionar un Item de la lista de sucursales muestra las cuentas que tiene dicha sucursal.
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
            if (listBox == ListClientes) // Al seleccionar un Item de la lista de clientes, la funcion recoge el dinero que tiene este cliente para ingresar o retirar despues.
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
