using practica5_Jose_Poveda_DAM1.Models;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace practica5_Jose_Poveda_DAM1
{
    //
    // Jose Poveda Perez
    // Curso DAM 1º
    // Modalidad Presencial
    // Práctica nº 5
    //

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Cliente> clientes = new List<Cliente>();
        public List<Cliente> alicante = new List<Cliente>();
        public List<Cliente> valencia = new List<Cliente>();
        public List<Cliente> castellon = new List<Cliente>();
        public MainWindow()
        {
            InitializeComponent();
            File.Delete("Clientes.txt");
            File.Delete("Alicante.txt");
            File.Delete("Castellon.txt");
            File.Delete("Valencia.txt");
        }

        /// <summary>
        /// Crea clientes default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_default_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente("Manuel", "Fernandez", "Castellon");
            clientes.Add(cliente);
            castellon.Add(cliente);
            cliente = new Cliente("Miguel", "Ruiz", "Castellon");
            clientes.Add(cliente);
            castellon.Add(cliente);

            cliente = new Cliente("Rodolfo", "Garcia", "Valencia");
            clientes.Add(cliente);
            valencia.Add(cliente);
            cliente = new Cliente("Matias", "Sanchez", "Valencia");
            clientes.Add(cliente);
            valencia.Add(cliente);

            cliente = new Cliente("Anakin", "Skywalker", "Alicante");
            clientes.Add(cliente);
            alicante.Add(cliente);
            cliente = new Cliente("Gines", "Lopez", "Alicante");
            clientes.Add(cliente);
            alicante.Add(cliente);

            ActualizarListBox();
            ActualizarFicheroClientes();
        }

        /// <summary>
        /// Actualiza los Listbox
        /// </summary>
        private void ActualizarListBox()
        {
            ActualizarListBoxConClientes(lbClientes, clientes, true);
            ActualizarListBoxConClientes(lbAlicante, alicante, false);
            ActualizarListBoxConClientes(lbCastellon, castellon, false);
            ActualizarListBoxConClientes(lbValencia, valencia, false);
        }

        /// <summary>
        /// Vacia los TextBox de la pestaña Provincias
        /// </summary>
        private void ClearFormularioProvincias()
        {
            txtNombrePro.Text = "";
            txtApellidoPro.Text = "";
            cbProvinciaPro.Text = "";
        }

        /// <summary>
        /// Vacia los TextBox de la pestaña Clientes(Formulario)
        /// </summary>
        private void ClearFormularioClientes()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cbProvincia.Text = "";
        }

        /// <summary>
        /// Evento que se ejecuta cuando pulsamos en los botones de Eliminar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (lbClientes.SelectedItem != null)
            {
                EliminarCliente(clientes[lbClientes.SelectedIndex].GetIdentificador());
                ActualizarFicheroClientes();
            } else if (lbCastellon.SelectedItem != null)
            {
                castellon.RemoveAt(lbCastellon.SelectedIndex);
            } else if (lbAlicante.SelectedItem != null)
            {
                alicante.RemoveAt(lbAlicante.SelectedIndex);
            } else if (lbValencia.SelectedItem != null)
            {
                valencia.RemoveAt(lbValencia.SelectedIndex);
            }
            ActualizarListBox();
        }

        /// <summary>
        /// Genera los ficheros de las provincias recogiendo los datos de Clientes.txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerarProvinciastxt_Click(object sender, RoutedEventArgs e)
        {
            File.Delete("Alicante.txt");
            lbAlicante.Items.Clear();
            alicante = new List<Cliente>();

            File.Delete("Castellon.txt");
            lbCastellon.Items.Clear();
            castellon = new List<Cliente>();

            File.Delete("Valencia.txt");
            lbValencia.Items.Clear();
            valencia = new List<Cliente>();

            StreamReader clientestxt;

            clientestxt = File.OpenText("Clientes.txt");

            string linea = clientestxt.ReadLine();
            while (linea != null) {
                string[] lineaCliente = linea.Split("#");
                if (lineaCliente.Length == 3)
                {
                    Cliente c = new Cliente(lineaCliente[0], lineaCliente[1], lineaCliente[2]);
                    
                    // Actualizar fichero de provincia
                    AnyadirClienteAFicheroProvincia(c);

                    // Actualizar ListBox de provincia
                    AnyadirClienteAListBoxProvincia(c);

                    // Actualizar listado de clientes por provincia
                    AnyadirClienteAProvincia(c);
                }
                linea = clientestxt.ReadLine();
            }
            clientestxt.Close();
        }
        
        /// <summary>
        /// Añade el cliente que le pasamos por parametro al fichero correspondiente
        /// </summary>
        /// <param name="c"> Objeto de Cliente </param>
        private void AnyadirClienteAFicheroProvincia(Cliente c)
        {
            string nombreArchivo = c.GetProvincia() + ".txt";
            StreamWriter provinciaSW = File.AppendText(nombreArchivo);
            provinciaSW.WriteLine(c.ToString(false));
            provinciaSW.Close();
        }

        /// <summary>
        /// Añade el string corto que representa una instancia del struct Cliente al ListBox de la provincia a la que pertenece.
        /// </summary>
        /// <param name="c">Objeto cliente</param>
        private void AnyadirClienteAListBoxProvincia(Cliente c)
        {
            string cliente = c.ToString(false);
            switch (c.GetProvincia())
            {
                case "Alicante":
                    lbAlicante.Items.Add(cliente);
                    break;
                case "Castellon":
                    lbCastellon.Items.Add(cliente);
                    break;
                case "Valencia":
                    lbValencia.Items.Add(cliente);
                    break;
            }
        }

        /// <summary>
        /// Añade el cliente que le pasamos por parametro a su lista de provincia correspondiente
        /// </summary>
        /// <param name="c"> Objeto de Cliente </param>
        private void AnyadirClienteAProvincia(Cliente c)
        {
            switch (c.GetProvincia())
            {
                case "Alicante":
                    alicante.Add(c);
                    break;
                case "Castellon":
                    castellon.Add(c);
                    break;
                case "Valencia":
                    valencia.Add(c);
                    break;
            }
        }

        /// <summary>
        /// Funcion que no permite que este mas de un ListBoxItem seleccionado y activa y desactiva los Button 
        /// correspondientes segun sea necesario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = (ListBox)sender;

            if (lb == lbCastellon)
            {
                lbAlicante.SelectedIndex = -1;
                lbValencia.SelectedIndex = -1;
                lbClientes.SelectedIndex = -1;
                btnModificarP.IsEnabled = true;
                btnEliminar_Provincia.IsEnabled = true;
            }
            else if (lb == lbAlicante)
            {
                lbCastellon.SelectedIndex = -1;
                lbValencia.SelectedIndex = -1;
                lbClientes.SelectedIndex = -1;
                btnModificarP.IsEnabled = true;
                btnEliminar_Provincia.IsEnabled = true;
            }
            else if (lb == lbValencia)
            {
                lbCastellon.SelectedIndex = -1;
                lbAlicante.SelectedIndex = -1;
                lbClientes.SelectedIndex = -1;
                btnModificarP.IsEnabled = true;
                btnEliminar_Provincia.IsEnabled = true;
            }
            else if (lb == lbClientes)
            {
                lbCastellon.SelectedIndex = -1;
                lbAlicante.SelectedIndex = -1;
                lbValencia.SelectedIndex = -1;
                btnModificarP.IsEnabled = false;
                btnEliminar_Provincia.IsEnabled = false;
                btnEliminar.IsEnabled = true;
                btnModificar_Cliente.IsEnabled = true;
            }
        }

        /// <summary>
        /// Evento Click que rellena los TextBox con los datos del cliente que deseamos modificar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, RoutedEventArgs e)
        { 
            if (lbClientes.SelectedItem != null)
            {
                btnAceptarModificacion.IsEnabled = true;
                btnCrear.IsEnabled = false;

                txtNombre.Text = clientes[lbClientes.SelectedIndex].GetNombre();
                txtApellido.Text = clientes[lbClientes.SelectedIndex].GetApellido();
                cbProvincia.Text = clientes[lbClientes.SelectedIndex].GetProvincia();
            }
            else
            {
                btnConfirmar_Pro.IsEnabled = true;
                btnCrear1.IsEnabled = false;

                if (lbCastellon.SelectedItem != null)
                {
                    txtNombrePro.Text = castellon[lbCastellon.SelectedIndex].GetNombre();
                    txtApellidoPro.Text = castellon[lbCastellon.SelectedIndex].GetApellido();
                    cbProvinciaPro.Text = castellon[lbCastellon.SelectedIndex].GetProvincia();
                }

                if (lbValencia.SelectedItem != null)
                {
                    txtNombrePro.Text = valencia[lbValencia.SelectedIndex].GetNombre();
                    txtApellidoPro.Text = valencia[lbValencia.SelectedIndex].GetApellido();
                    cbProvinciaPro.Text = valencia[lbValencia.SelectedIndex].GetProvincia();
                }

                if (lbAlicante.SelectedItem != null)
                {
                    txtNombrePro.Text = alicante[lbAlicante.SelectedIndex].GetNombre();
                    txtApellidoPro.Text = alicante[lbAlicante.SelectedIndex].GetApellido();
                    cbProvinciaPro.Text = alicante[lbAlicante.SelectedIndex].GetProvincia();
                }
            }
        }

        /// <summary>
        /// Al modificar la provincia no solo se tiene que cambiar en la clase,
        /// tambien hay que asegurarse de que el listado de provincias tambien se actualice.
        /// </summary>
        /// <param name="c"> Objeto de Cliente </param>
        /// <param name="nuevaProvincia"> string con el valor de la nueva provincia </param>
        /// <returns> Devuelve el Cliente ya modificado </returns>
        private Cliente ModificarProvincia(Cliente c, string nuevaProvincia)
        {
            Cliente clienteDeProvincia;
            switch (c.GetProvincia())
            {
                case "Alicante":
                    clienteDeProvincia = alicante.Find(cliente => cliente.GetIdentificador() == c.GetIdentificador());
                    alicante.Remove(clienteDeProvincia);
                    break;

                case "Castellon":
                    clienteDeProvincia = castellon.Find(cliente => cliente.GetIdentificador() == c.GetIdentificador());
                    castellon.Remove(clienteDeProvincia);
                    break;

                case "Valencia":
                    clienteDeProvincia = valencia.Find(cliente => cliente.GetIdentificador() == c.GetIdentificador());
                    valencia.Remove(clienteDeProvincia);
                    break;
            }
            c.SetProvincia(nuevaProvincia);

            AnyadirClienteAProvincia(c);

            return c;
        }

        /// <summary>
        /// Comprueba que el contenido del TextBox no este vacio.
        /// </summary>
        /// <param name="s"> string que posee el valor del TextBox </param>
        /// <returns></returns>
        public bool isStringValid(string s)
        {
            return s != null && s != "";
        }

        /// <summary>
        /// Evento que recoge las modificaciones de los TextBox y las guarda en el cliente correspondiente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AceptarCambios_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            if (btn == btnAceptarModificacion)
            {
                if (isStringValid(txtNombre.Text) && isStringValid(txtApellido.Text) && isStringValid(cbProvincia.Text))
                {
                    if (lbClientes.SelectedItem != null)
                    {
                        Cliente c = clientes[lbClientes.SelectedIndex];
                        c.SetNombre(txtNombre.Text);
                        c.SetApellido(txtApellido.Text);
                        c = ModificarProvincia(c, cbProvincia.Text);
                        clientes[lbClientes.SelectedIndex] = c;

                        ActualizarListBox();
                        ActualizarFicheroClientes();
                    }

                    ClearFormularioClientes();
                    btnAceptarModificacion.IsEnabled = false;
                    btnCrear.IsEnabled = true;
                } else MessageBox.Show("Rellena los campos");
            }

            if (btn == btnConfirmar_Pro)
            {
                if (isStringValid(txtNombrePro.Text) && isStringValid(txtApellidoPro.Text) && isStringValid(cbProvinciaPro.Text))
                {
                    if (lbCastellon.SelectedItem != null)
                    {
                        Cliente clienteP = castellon[lbCastellon.SelectedIndex];
                        clienteP.SetNombre(txtNombrePro.Text);
                        clienteP.SetApellido(txtApellidoPro.Text);
                        ModificarProvincia(clienteP, cbProvinciaPro.Text);
                    }
                    if (lbValencia.SelectedItem != null)
                    {
                        Cliente clienteP = valencia[lbValencia.SelectedIndex];
                        clienteP.SetNombre(txtNombrePro.Text);
                        clienteP.SetApellido(txtApellidoPro.Text);
                        ModificarProvincia(clienteP, cbProvinciaPro.Text);
                    }
                    if (lbAlicante.SelectedItem != null)
                    {
                        Cliente clienteP = alicante[lbAlicante.SelectedIndex];
                        clienteP.SetNombre(txtNombrePro.Text);
                        clienteP.SetApellido(txtApellidoPro.Text);
                        ModificarProvincia(clienteP, cbProvinciaPro.Text);
                    }
                    ActualizarListBox();
                    btnConfirmar_Pro.IsEnabled = false;
                    btnCrear1.IsEnabled = true;
                    ClearFormularioProvincias();
                }
                else MessageBox.Show("Rellena los campos");
            }
        }

        /// <summary>
        /// Actualiza el fichero de Clientes.txt con los clientes añadidos, eliminados o modificados.
        /// </summary>
        private void ActualizarFicheroClientes()
        {
            File.Delete("Clientes.txt");
            for (int i = 0; i < clientes.Count; i++)
            {
                StreamWriter txt = File.AppendText("Clientes.txt");
                txt.WriteLine(clientes[i].ToString(true));
                txt.Close();
            }
        }

        /// <summary>
        /// Busca el cliente dado un identificador y lo elimina de los listados tanto de cliente como de provincia.
        /// </summary>
        /// <param name="identificador"> Atributo que distingue un cliente de otro</param>
        private void EliminarCliente(int identificador)
        {
            Cliente c = clientes.Find(cliente => cliente.GetIdentificador() == identificador);
            clientes.Remove(c);

            List<Cliente> clientesDeProvincias = new List<Cliente>();
            clientesDeProvincias.AddRange(alicante);
            clientesDeProvincias.AddRange(castellon);
            clientesDeProvincias.AddRange(valencia);

            Cliente clienteDeProvincia = clientesDeProvincias.Find(cliente => cliente.GetIdentificador() == identificador);

            switch (clienteDeProvincia.GetProvincia())
            {
                case "Alicante":
                    alicante.Remove(clienteDeProvincia);
                    break;
                case "Castellon":
                    castellon.Remove(clienteDeProvincia);
                    break;
                case "Valencia":
                    valencia.Remove(clienteDeProvincia);
                    break;
            }
        }

        /// <summary>
        /// Actualiza el ListBox correspondiente indicado por parametro.
        /// </summary>
        /// <param name="lb"> Listbox </param>
        /// <param name="clientes"> Lista de clientes totales o por provincia </param>
        /// <param name="fullString">A la hora de representar el cliente como string hay dos opciones, una larga y otra más corta</param>
        private void ActualizarListBoxConClientes(ListBox lb, List<Cliente> clientes, bool fullString)
        {
            lb.Items.Clear();
            for (int i = 0; i < clientes.Count; i++)
            {
                lb.Items.Add(clientes[i].ToString(fullString));
            }
        }

        /// <summary>
        /// Crea un cliente nuevo y lo añade en la provincia correspondiente,
        /// si se crea desde la pestaña provincias no modificara nuestro fichero o lista de clientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CrearCliente_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btnCrear)
            {
                if (isStringValid(txtNombre.Text) && isStringValid(txtApellido.Text) && isStringValid(cbProvincia.Text))
                {
                    Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text, cbProvincia.Text);
                    clientes.Add(cliente);

                    AnyadirClienteAProvincia(cliente);
                    ActualizarListBox();
                    ActualizarFicheroClientes();
                    ClearFormularioClientes();
                }
                else MessageBox.Show("Rellena los campos");
            }

            if (btn == btnCrear1)
            {
                if (isStringValid(txtNombrePro.Text) && isStringValid(txtApellidoPro.Text) && isStringValid(cbProvinciaPro.Text))
                {
                    Cliente clienteP = new Cliente(txtNombrePro.Text, txtApellidoPro.Text, cbProvinciaPro.Text);

                    AnyadirClienteAProvincia(clienteP);
                    AnyadirClienteAListBoxProvincia(clienteP);

                    ClearFormularioProvincias();
                }
                else MessageBox.Show("Rellena los campos");
            }
        }

        private void btnGenerarJson_Click(object sender, RoutedEventArgs e)
        {           
            string json = clientes[lbClientes.SelectedIndex].ToJson();

            txtJson.Text = json;
        }
    }
}
