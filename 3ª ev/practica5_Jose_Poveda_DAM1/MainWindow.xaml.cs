using practica5_Jose_Poveda_DAM1.Models;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace practica5_Jose_Poveda_DAM1
{
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

        private void ActualizarListBox()
        {
            lbClientes.Items.Clear();
            lbCastellon.Items.Clear();
            lbValencia.Items.Clear();
            lbAlicante.Items.Clear();

            for (int i = 0; i < clientes.Count; i++)
            {
                lbClientes.Items.Add(clientes[i].ToString(true));
            }

            for (int i = 0; i < alicante.Count; i++)
            {
                lbAlicante.Items.Add(alicante[i].ToString(false));
            }

            for (int i = 0; i < castellon.Count; i++)
            {
                lbCastellon.Items.Add(castellon[i].ToString(false));
            }

            for (int i = 0; i < valencia.Count; i++)
            {
                lbValencia.Items.Add(valencia[i].ToString(false));
            }
        }

        private void ClearFormulario(string tipo)
        {
            if (tipo == "cliente")
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                cbProvincia.Text = "";
            } else
            {
                txtNombrePro.Text = "";
                txtApellidoPro.Text = "";
                cbProvinciaPro.Text = "";
            }
            
        }

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
                    ActualizarListBoxProvincia(c);

                    // Actualizar listado de clientes por provincia
                    ActualizarClientesProvincia(c);
                }
                linea = clientestxt.ReadLine();
            }
            clientestxt.Close();
        }

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

            switch (nuevaProvincia)
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

            return c;
        }

        private void btn_AceptarCambios_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            if (btn == btnAceptarModificacion)
            {
                if (txtNombre.Text != null && txtApellido.Text != null && cbProvincia.Text != null)
                {
                    if (lbClientes.SelectedItem != null)
                    {
                        Cliente c = clientes[lbClientes.SelectedIndex];
                        c.SetNombre(txtNombre.Text);
                        c.SetApellido(txtApellido.Text);
                        c = ModificarProvincia(c, cbProvincia.Text);
                        //c.SetProvincia(cbProvincia.Text);
                        clientes[lbClientes.SelectedIndex] = c;

                        ActualizarListBox();
                        ActualizarFicheroClientes();
                    }

                    ClearFormulario("cliente");
                    btnAceptarModificacion.IsEnabled = false;
                    btnCrear.IsEnabled = true;
                } else MessageBox.Show("Rellena los campos");
            }

            if (btn == btnConfirmar_Pro)
            {
                if (txtNombrePro.Text != null && txtApellidoPro.Text != null && cbProvinciaPro.Text != null)
                {
                    Cliente clienteP = new Cliente(txtNombrePro.Text, txtApellidoPro.Text, cbProvinciaPro.Text);

                    if (lbCastellon.SelectedItem != null)
                    {
                        castellon[lbCastellon.SelectedIndex] = clienteP;
                        if (cbProvinciaPro.Text != "Castellon")
                        {
                            if (cbProvinciaPro.Text == "Alicante")
                            {
                                alicante.Add(clienteP);
                                lbAlicante.Items.Add(clienteP.ToString(false));
                                castellon.RemoveAt(lbCastellon.SelectedIndex);
                                ActualizarListBoxyTxt("A", " ");
                                ActualizarListBoxyTxt("C", " ");
                            }
                            if (cbProvinciaPro.Text == "Valencia")
                            {
                                valencia.Add(clienteP);
                                lbValencia.Items.Add(clienteP.ToString(false));
                                castellon.RemoveAt(lbCastellon.SelectedIndex);
                                ActualizarListBoxyTxt("V", " ");
                                ActualizarListBoxyTxt("C", " ");
                            }
                        }
                        else
                            ActualizarListBoxyTxt("C", " ");
                    }
                    if (lbValencia.SelectedItem != null)
                    {
                        valencia[lbValencia.SelectedIndex] = clienteP;
                        if (cbProvinciaPro.Text != "Valencia")
                        {
                            if (cbProvinciaPro.Text == "Alicante")
                            {
                                alicante.Add(clienteP);
                                lbAlicante.Items.Add(clienteP.ToString(false));
                                valencia.RemoveAt(lbValencia.SelectedIndex);
                                ActualizarListBoxyTxt("A", " ");
                                ActualizarListBoxyTxt("V", " ");
                            }
                            if (cbProvinciaPro.Text == "Castellon")
                            {
                                castellon.Add(clienteP);
                                lbCastellon.Items.Add(clienteP.ToString(false));
                                valencia.RemoveAt(lbValencia.SelectedIndex);
                                ActualizarListBoxyTxt("C", " ");
                                ActualizarListBoxyTxt("V", " ");
                            }
                        }
                        else
                            ActualizarListBoxyTxt("V", " ");
                    }
                    if (lbAlicante.SelectedItem != null)
                    {
                        alicante[lbAlicante.SelectedIndex] = clienteP;
                        if (cbProvinciaPro.Text != "Alicante")
                        {
                            if (cbProvinciaPro.Text == "Castellon")
                            {
                                castellon.Add(clienteP);
                                lbCastellon.Items.Add(clienteP.ToString(false));
                                alicante.RemoveAt(lbAlicante.SelectedIndex);
                                ActualizarListBoxyTxt("C", " ");
                                ActualizarListBoxyTxt("A", " ");
                            }
                            if (cbProvinciaPro.Text == "Valencia")
                            {
                                valencia.Add(clienteP);
                                lbValencia.Items.Add(clienteP.ToString(false));
                                alicante.RemoveAt(lbAlicante.SelectedIndex);
                                ActualizarListBoxyTxt("V", " ");
                                ActualizarListBoxyTxt("A", " ");
                            }
                        }
                        else
                            ActualizarListBoxyTxt("A", " ");
                    }
                    btnConfirmar_Pro.IsEnabled = false;
                    btnCrear1.IsEnabled = true;
                    ClearFormulario(" ");
                }
                else MessageBox.Show("Rellena los campos");      
            }                             
        }
        
        private void AnyadirClienteAFicheroProvincia(Cliente c)
        {
            string nombreArchivo = c.GetProvincia() + ".txt";
            StreamWriter provinciaSW = File.AppendText(nombreArchivo);
            provinciaSW.WriteLine(c.ToString(false));
            provinciaSW.Close();
        }

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

        private void EliminarClienteDeProvincia(int index, ListBox lb)
        {
            lb.Items.RemoveAt(index);
        }

        private void ActualizarListBoxProvincia(Cliente c)
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

        private void ActualizarClientesProvincia(Cliente c)
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

        private void EliminarCliente(int identificador)
        {
            Cliente c = clientes.Find(cliente => cliente.GetIdentificador() == identificador);
            clientes.Remove(c);
            switch (c.GetProvincia())
            {
                case "Alicante":
                    alicante.Remove(c);
                    break;
                case "Castellon":
                    castellon.Remove(c);
                    break;
                case "Valencia":
                    valencia.Remove(c);
                    break;
            }
        }

        private void ActualizarListBoxConClientes(ListBox lb, List<Cliente> clientes)
        {
            lb.Items.Clear();
            for (int i = 0; i < clientes.Count; i++)
            {
                lb.Items.Add(clientes[i].ToString(false));
            }
        }

        private void ActualizarListBoxyTxt(string Lb, string tipo)
        {
            if (tipo == "x")
            {
                if (Lb == "C")
                {
                    ActualizarListBoxConClientes(lbCastellon, castellon);
                }
                if (Lb == "V")
                {
                    ActualizarListBoxConClientes(lbValencia, valencia);
                }
                if (Lb == "A")
                {
                    ActualizarListBoxConClientes(lbAlicante, alicante);
                }
                if (Lb == "Clientes")
                {
                    File.Delete("Clientes.txt");
                    if (clientes.Count != 0)
                    {
                        for (int i = 0; i < clientes.Count; i++)
                        {
                            lbClientes.Items.Add(clientes[i].ToString(true));
                            StreamWriter txt = File.AppendText("Clientes.txt");
                            txt.WriteLine(clientes[i].ToString(true));
                            txt.Close();
                        }
                    }
                }
            } else
            {
                if (Lb == "C")
                {
                    File.Delete("Castellon.txt");
                    lbCastellon.Items.Clear();
                    if (castellon.Count != 0)
                    {
                        for (int i = 0; i < castellon.Count; i++)
                        {
                            lbCastellon.Items.Add(castellon[i].ToString(false));
                            StreamWriter txt = File.AppendText("Castellon.txt");
                            txt.WriteLine(castellon[i].ToString(false));
                            txt.Close();
                        }
                    }
                }
                if (Lb == "V")
                {
                    File.Delete("Valencia.txt");
                    lbValencia.Items.Clear();
                    if (valencia.Count != 0)
                    {
                        for (int i = 0; i < valencia.Count; i++)
                        {
                            lbValencia.Items.Add(valencia[i].ToString(false));
                            StreamWriter txt = File.AppendText("Valencia.txt");
                            txt.WriteLine(valencia[i].ToString(false));
                            txt.Close();
                        }
                    }
                }
                if (Lb == "A")
                {
                    File.Delete("Alicante.txt");
                    lbAlicante.Items.Clear();
                    if (alicante.Count != 0)
                    {
                        for (int i = 0; i < alicante.Count; i++)
                        {
                            lbAlicante.Items.Add(alicante[i].ToString(false));
                            StreamWriter txt = File.AppendText("Alicante.txt");
                            txt.WriteLine(alicante[i].ToString(false));
                            txt.Close();
                        }
                    }
                }
                if (Lb == "Clientes")
                {
                    File.Delete("Clientes.txt");
                    lbClientes.Items.Clear();
                    if (clientes.Count != 0)
                    {
                        for (int i = 0; i < clientes.Count; i++)
                        {
                            lbClientes.Items.Add(clientes[i].ToString(true));
                            StreamWriter txt = File.AppendText("Clientes.txt");
                            txt.WriteLine(clientes[i].ToString(true));
                            txt.Close();
                        }
                        lbValencia.Items.Clear();
                        lbAlicante.Items.Clear();
                        lbCastellon.Items.Clear();
                        if (castellon.Count != 0)
                        {
                            for (int i = 0; i < castellon.Count; i++)
                            {
                                lbCastellon.Items.Add(castellon[i].ToString(false));
                            }
                        }
                        if (valencia.Count != 0)
                        {
                            for (int i = 0; i < valencia.Count; i++)
                            {
                                lbValencia.Items.Add(valencia[i].ToString(false));
                            }
                        }
                        if (alicante.Count != 0)
                        {
                            for (int i = 0; i < alicante.Count; i++)
                            {
                                lbAlicante.Items.Add(alicante[i].ToString(false));
                            }
                        }
                    }
                }
            }
            
        }
        
        private void btn_CrearCliente_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btnCrear)
            {
                if (txtNombre.Text != "" && txtApellido.Text != "" && cbProvincia.Text != "")
                {
                    Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text, cbProvincia.Text);
                    Cliente clienteP = new Cliente(txtNombre.Text, txtApellido.Text, cbProvincia.Text);
                    clientes.Add(cliente);
                    lbClientes.Items.Add(cliente.ToString(true));

                    if (cbProvincia.Text == "Castellon")
                    {
                        lbCastellon.Items.Add(clienteP.ToString(false));
                        castellon.Add(clienteP);
                    }
                    else if (cbProvincia.Text == "Valencia")
                    {
                        lbValencia.Items.Add(clienteP.ToString(false));
                        valencia.Add(clienteP);
                    }
                    else if (cbProvincia.Text == "Alicante")
                    {
                        lbAlicante.Items.Add(clienteP.ToString(false));
                        alicante.Add(clienteP);
                    }

                    if (lbClientes.Items.Count != 0)
                    {
                        StreamWriter clientestxt;
                        clientestxt = File.CreateText("Clientes.txt");

                        for (int i = 0; i < clientes.Count; i++)
                        {
                            clientestxt.WriteLine(lbClientes.Items[i].ToString());
                        }
                        clientestxt.Close();
                    }
                    ClearFormulario("cliente");
                }
                else
                    MessageBox.Show("Rellena los campos");
            }

            if (btn == btnCrear1)
            {
                if (txtNombrePro.Text != "" && txtApellidoPro.Text != "" && cbProvinciaPro.Text != "")
                {
                    Cliente clienteP = new Cliente(txtNombrePro.Text, txtApellidoPro.Text, cbProvinciaPro.Text);                   

                    if (cbProvinciaPro.Text == "Castellon")
                    {
                        lbCastellon.Items.Add(clienteP.ToString(false));
                        castellon.Add(clienteP);
                    }
                    else if (cbProvinciaPro.Text == "Valencia")
                    {
                        lbValencia.Items.Add(clienteP.ToString(false));
                        valencia.Add(clienteP);
                    }
                    else if (cbProvinciaPro.Text == "Alicante")
                    {
                        lbAlicante.Items.Add(clienteP.ToString(false));
                        alicante.Add(clienteP);
                    }
                    //ActualizarListBoxyTxt("C", " ");
                    //ActualizarListBoxyTxt("A", " ");
                    //ActualizarListBoxyTxt("V", " ");
                    ActualizarListBox();
                    ClearFormulario(" ");
                }
                else
                    MessageBox.Show("Rellena los campos");
            }
        }
    }
}
