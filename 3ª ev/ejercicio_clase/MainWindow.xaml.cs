using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Examen2Solucion
{
    /// Jose Poveda Perez
    /// Ejercicio DAM1
    
    public partial class MainWindow : Window
    {
        //Variable global que almacena mis Clientes
        public static List<Cliente> clientes = new List<Cliente>();
        
        //Variable global que almacena mis Distribuidores
        public static List<Distribuidor> distribuidores = new List<Distribuidor>();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Validation(object sender, TextCompositionEventArgs e)
        {
            //Convertimos el caracter introducido a char
            char c = Convert.ToChar(e.Text);

            //Comprobamos si está dentro del rango de 0 - 9 para saber si
            //hay que bloquear su escritura.
            e.Handled = c < '0' || c > '9';
        }

        // Función asociada al check de Cliente que muestra el Desplegable
        private void rbCliente_Checked(object sender, RoutedEventArgs e)
        {
            cbProvincia.Visibility = Visibility.Visible;
            lbProvincia.Visibility = Visibility.Hidden;
        }

        // Función asociada al check de Distribuidor que muestra la Lista
        private void rbDistribuidor_Checked(object sender, RoutedEventArgs e)
        {
            lbProvincia.Visibility = Visibility.Visible;
            cbProvincia.Visibility = Visibility.Hidden;
        }

        // Función asociada al evento Click del botón Cancelar
        // que cierra el programa
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // Función asociada al evento Click del botón Enviar
        // que comprueba los datos, crea los objetos y añade la información
        // para que pueda ser vista en al interfaz.
        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombre.Text == "")
                MessageBox.Show("Rellena el campo Nombre", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (txtApellido.Text == "")
                MessageBox.Show("Rellena el campo Apellido", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (rbCliente.IsChecked != true && rbDistribuidor.IsChecked != true)
                MessageBox.Show("Selecciona el Tipo", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (txtTelefono1.Text == "")
                MessageBox.Show("Rellena el campo Teléfono 1", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (txtTelefono1.Text.Length < 9)
                MessageBox.Show("El Teléfono 1 debe tener 9 dígitos", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (txtTelefono2.Text != "" && txtTelefono2.Text.Length < 9)
                MessageBox.Show("Si se rellena, el Teléfono 2 debe tener 9 dígitos", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (txtEmail.Text == "")
                MessageBox.Show("Rellena el campo Email", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (txtDireccion.Text == "")
                MessageBox.Show("Rellena el campo Dirección", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (txtPoblacion.Text == "")
                MessageBox.Show("Rellena el campo Población", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else if (cbProvincia.SelectedItem == null && lbProvincia.SelectedItem == null)
                MessageBox.Show("Selecciona la Provincia", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                if (rbCliente.IsChecked == true)
                {
                    Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text, txtTelefono1.Text, txtTelefono2.Text, txtDireccion.Text, txtEmail.Text, txtPoblacion.Text, cbProvincia.Text);
                    clientes.Add(cliente);
                    AñadirElemento("Cliente", cliente);                   
                }
                else
                {
                    Distribuidor distribuidor = new Distribuidor(txtNombre.Text, txtApellido.Text, txtTelefono1.Text, txtTelefono2.Text, txtDireccion.Text, txtEmail.Text, txtPoblacion.Text, lbProvincia.SelectedItem.ToString());
                    distribuidores.Add(distribuidor);
                    AñadirElemento("Distribuidor", distribuidor);
                }
            }
        }

        //Función que confirma el elemento creado y reinicia el formulario
        private void ReiniciarFormulario(string tipo)
        {
            if (tipo == "Cliente")
                MessageBox.Show("Se ha dado de alta un nuevo Cliente");
            else
                MessageBox.Show("Se ha dado de alta un nuevo Distribuidor");
            
            txtNombre.Text = txtApellido.Text = "";
            rbCliente.IsChecked = rbDistribuidor.IsChecked = false;
            txtTelefono1.Text = txtTelefono2.Text = "";
            txtEmail.Text = txtDireccion.Text = txtPoblacion.Text = "";
            cbProvincia.SelectedItem = lbProvincia.SelectedItem = null;
            cbProvincia.Visibility = lbProvincia.Visibility = Visibility.Hidden;
        }

        //Función que añade el elemento creado a la lista correspondiente
        private void AñadirElemento(string tipo, Persona p)
        {
            
                ReiniciarFormulario(tipo);


            if (p.GetType().Name == "Cliente")
            {
                lbClientes.Items.Add(((Cliente)p).ToString());             
            }               
            else
                lbDistribuidor.Items.Add(((Distribuidor)p).ToString());                          
                        
        }

        // Funcion que muestra los detalles de la persona al pinchar sobre ella en la lista
        private void lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = (ListBox)sender;
                      
                if (lb == lbClientes)
                {
                    if (lbClientes.SelectedItem != null)
                    {
                        lbDistribuidor.SelectedItem = null;
                        MessageBox.Show(clientes[lbClientes.SelectedIndex].GetDetalles());
                    }                     
                }
                if (lb == lbDistribuidor)
                {
                    if (lbDistribuidor.SelectedItem != null)
                    {
                        lbClientes.SelectedItem = null;
                        MessageBox.Show(distribuidores[lbDistribuidor.SelectedIndex].GetDetalles());
                    }                                 
                }               
        }

        // Funcion que crea cliente y distribuidor de ejemplo
        private void btn_default_Click(object sender, RoutedEventArgs e)
        {
            Distribuidor distribuidor = new Distribuidor("Jose", "Garcia", "663489461", "965344984", "calle principal", "maildejose@hotmail.com", "Aspe", "Alicante");
            distribuidores.Add(distribuidor);
            AñadirElemento("Distribuidor", distribuidor);
            Cliente cliente = new Cliente("Manuel", "Fernandez", "662587465", "965342434", "calle nueva", "maildemanu@hotmail.com", "Cullera", "Castellon");
            clientes.Add(cliente);
            AñadirElemento("Cliente", cliente);
        }

        // Funcion que elimina el cliente o distribuidor del listbox y de su lista correspondiente
        private void btn_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (lbClientes.SelectedItem != null)
            {
                clientes.RemoveAt(lbClientes.SelectedIndex);
                lbClientes.Items.RemoveAt(lbClientes.SelectedIndex);
            }

            if (lbDistribuidor.SelectedItem != null)
            {
                distribuidores.RemoveAt(lbDistribuidor.SelectedIndex);
                lbDistribuidor.Items.RemoveAt(lbDistribuidor.SelectedIndex);
            }
        }

        // Funcion que nos lleva al fomulario y rellena los campos
        // con los datos antiguos listos para ser modificados
        private void btn_Modificar_Click(object sender, RoutedEventArgs e)
        {
            tcFormulario.Focus();

            btnAceptarModificacion.IsEnabled = true;
            btnEnviar.IsEnabled = false;
            

            if (lbClientes.SelectedItem != null)
            {
                rbDistribuidor.Visibility = Visibility.Hidden;
                rbCliente.Visibility = Visibility.Hidden;
                txtNombre.Text = clientes[lbClientes.SelectedIndex].GetNombre();
                txtApellido.Text = clientes[lbClientes.SelectedIndex].GetApellido();
                txtDireccion.Text = clientes[lbClientes.SelectedIndex].GetDireccion();
                txtEmail.Text = clientes[lbClientes.SelectedIndex].GetEmail();
                txtPoblacion.Text = clientes[lbClientes.SelectedIndex].GetPoblacion();
                txtTelefono1.Text = clientes[lbClientes.SelectedIndex].GetTelefono1();
            }

            if (lbDistribuidor.SelectedItem != null)
            {
                rbCliente.Visibility = Visibility.Hidden;
                rbDistribuidor.Visibility = Visibility.Hidden;
                txtTelefono1.Text = distribuidores[lbDistribuidor.SelectedIndex].GetTelefono1();
                txtDireccion.Text = distribuidores[lbDistribuidor.SelectedIndex].GetDireccion();
                txtEmail.Text = distribuidores[lbDistribuidor.SelectedIndex].GetEmail();
                txtNombre.Text = distribuidores[lbDistribuidor.SelectedIndex].GetNombre();
                txtApellido.Text = distribuidores[lbDistribuidor.SelectedIndex].GetApellido();
                txtPoblacion.Text = distribuidores[lbDistribuidor.SelectedIndex].GetPoblacion();               
            }
        }

        // Funcion que confirma y modifica los datos de la persona correspondiente
        private void btn_Aceptar_Click(object sender, RoutedEventArgs e)
        {
            if (lbClientes.SelectedItem != null)
            {
                clientes[lbClientes.SelectedIndex].SetTelefono1(txtTelefono1.Text);
                clientes[lbClientes.SelectedIndex].SetDireccion(txtDireccion.Text);
                clientes[lbClientes.SelectedIndex].SetEmail(txtEmail.Text);
                clientes[lbClientes.SelectedIndex].SetNombre(txtNombre.Text);
                clientes[lbClientes.SelectedIndex].SetApellidos(txtApellido.Text);
                clientes[lbClientes.SelectedIndex].SetPoblacion(txtPoblacion.Text);
                lbClientes.Items[lbClientes.SelectedIndex].ToString();
                tcDatos.Focus();
            }

            if (lbDistribuidor.SelectedItem != null)
            {
                distribuidores[lbDistribuidor.SelectedIndex].SetTelefono1(txtTelefono1.Text);
                distribuidores[lbDistribuidor.SelectedIndex].SetDireccion(txtDireccion.Text);
                distribuidores[lbDistribuidor.SelectedIndex].SetEmail(txtEmail.Text);
                distribuidores[lbDistribuidor.SelectedIndex].SetNombre(txtNombre.Text);
                distribuidores[lbDistribuidor.SelectedIndex].SetApellidos(txtApellido.Text);
                distribuidores[lbDistribuidor.SelectedIndex].SetPoblacion(txtPoblacion.Text);
                lbDistribuidor.Items[lbDistribuidor.SelectedIndex].ToString();
                tcDatos.Focus();
            }           
                       
            ClearFormulario();
        }


        // Funcion que deja e formulario listo para introducir nueva persona
        private void ClearFormulario()
        {
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtNombre.Text = "";
            txtPoblacion.Text = "";
            txtTelefono1.Text = "";
            lbProvincia.Visibility = Visibility.Hidden;
            cbProvincia.Visibility = Visibility.Hidden;
            rbCliente.IsChecked = false;
            rbDistribuidor.IsChecked = false;
            btnAceptarModificacion.IsEnabled = false;
            btnEnviar.IsEnabled = true;
            rbCliente.Visibility = Visibility.Visible;
            rbDistribuidor.Visibility = Visibility.Visible;
        }


        // Funcion para bajar una posicion en el listbox de cliente
        private void DisminuirPosicionClientes(object sender, RoutedEventArgs e)
        {
            int posicionSeleccionada = lbClientes.SelectedIndex;
            if (posicionSeleccionada < clientes.Count - 1)
            {
                Cliente aux = clientes[posicionSeleccionada];
                clientes.RemoveAt(posicionSeleccionada);
                lbClientes.Items.RemoveAt(posicionSeleccionada);
                clientes.Insert(posicionSeleccionada + 1, aux);
                lbClientes.Items.Insert(posicionSeleccionada + 1, aux.ToString());
                lbClientes.SelectedIndex = posicionSeleccionada+1;
            }
        }


        // Funcion para subir una posicion en el listbox de cliente
        private void AumentarPosicionClientes(object sender, RoutedEventArgs e)
        {
            int posicionSeleccionada = lbClientes.SelectedIndex;
            if (posicionSeleccionada > 0)
            {
                Cliente aux = clientes[posicionSeleccionada];
                clientes.RemoveAt(posicionSeleccionada);
                lbClientes.Items.RemoveAt(posicionSeleccionada);
                clientes.Insert(posicionSeleccionada - 1, aux);
                lbClientes.Items.Insert(posicionSeleccionada - 1, aux.ToString());
                lbClientes.SelectedIndex = posicionSeleccionada-1;
            }
        }
        // Funcion para subir una posicion en el listbox de distribuidor

        private void AumentarPosicionDistribuidor(object sender, RoutedEventArgs e)
        {
            int posicionSeleccionada = lbDistribuidor.SelectedIndex;
            if (posicionSeleccionada > 0)
            {
                Distribuidor aux = distribuidores[posicionSeleccionada];
                distribuidores.RemoveAt(posicionSeleccionada);
                lbDistribuidor.Items.RemoveAt(posicionSeleccionada);
                distribuidores.Insert(posicionSeleccionada - 1, aux);
                lbDistribuidor.Items.Insert(posicionSeleccionada - 1, aux.ToString());
                lbDistribuidor.SelectedIndex = posicionSeleccionada - 1;
            }
        }
        // Funcion para bajar una posicion en el listbox de distribuidor

        private void DisminuirPosicionDistribuidor(object sender, RoutedEventArgs e)
        {
            int posicionSeleccionada = lbDistribuidor.SelectedIndex;
            if (posicionSeleccionada < distribuidores.Count - 1)
            {
                Distribuidor aux = distribuidores[posicionSeleccionada];
                distribuidores.RemoveAt(posicionSeleccionada);
                lbDistribuidor.Items.RemoveAt(posicionSeleccionada);
                distribuidores.Insert(posicionSeleccionada + 1, aux);
                lbDistribuidor.Items.Insert(posicionSeleccionada + 1, aux.ToString());
                lbDistribuidor.SelectedIndex = posicionSeleccionada + 1;
            }
        }
        // Funcion que genera el .txt de distribuidores
        private void GenerarDistribuidorestxt_Click(object sender, RoutedEventArgs e)
        {
            if (lbDistribuidor.Items.Count != 0)
            {            
                StreamWriter distribuidorestxt; 
                distribuidorestxt = File.CreateText("distribuidores.txt");

                for (int i = 0; i < clientes.Count; i++)
                {
                    distribuidorestxt.WriteLine(lbDistribuidor.Items[i].ToString());
                }
                distribuidorestxt.Close();
                MessageBox.Show("El fichero distribuidores.txt ha sido creado o modificado");
            }
            else
                MessageBox.Show("Tiene que haber algun distribuidor en la lista");
                
        }
        // Funcion que genera el .txt de clientes
        private void GenerarClientestxt_Click(object sender, RoutedEventArgs e)
        {
            if (lbClientes.Items.Count != 0)
            {            
                StreamWriter clientestxt; 
                clientestxt = File.CreateText("clientes.txt");

                for (int i = 0; i < clientes.Count; i++)
                {
                    clientestxt.WriteLine(lbClientes.Items[i].ToString());
                }
                clientestxt.Close();
                MessageBox.Show("El fichero clientes.txt ha sido creado o modificado");
            }
            else
                MessageBox.Show("Tiene que haber algun cliente en la lista");
        }
    }
}
