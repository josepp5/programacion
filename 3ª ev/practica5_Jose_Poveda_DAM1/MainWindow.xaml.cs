using practica5_Jose_Poveda_DAM1.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace practica5_Jose_Poveda_DAM1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Cliente> alicante = new List<Cliente>();
        public static List<Cliente> valencia = new List<Cliente>();
        public static List<Cliente> castellon = new List<Cliente>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_default_Click(object sender, RoutedEventArgs e)
        {          
            Cliente cliente = new Cliente("Manuel", "Fernandez", "Castellon");
            clientes.Add(cliente);
            castellon.Add(cliente);
            lbClientes.Items.Add(cliente.ToString("Cliente"));
            lbCastellon.Items.Add(cliente.ToString(" "));
            cliente = new Cliente("Miguel", "Ruiz", "Castellon");
            clientes.Add(cliente);
            castellon.Add(cliente);
            lbClientes.Items.Add(cliente.ToString("Cliente"));
            lbCastellon.Items.Add(cliente.ToString(" "));

            cliente = new Cliente("Rodolfo", "Garcia", "Valencia");
            clientes.Add(cliente);
            valencia.Add(cliente);
            lbClientes.Items.Add(cliente.ToString("Cliente"));
            lbValencia.Items.Add(cliente.ToString(" "));
            cliente = new Cliente("Matias", "Sanchez", "Valencia");
            clientes.Add(cliente);
            valencia.Add(cliente);
            lbClientes.Items.Add(cliente.ToString("Cliente"));
            lbValencia.Items.Add(cliente.ToString(" "));

            cliente = new Cliente("Anakin", "Skywalker", "Alicante");
            clientes.Add(cliente);
            alicante.Add(cliente);
            lbClientes.Items.Add(cliente.ToString("Cliente"));
            lbAlicante.Items.Add(cliente.ToString(" "));
            cliente = new Cliente("Gines", "Lopez", "Alicante");
            clientes.Add(cliente);
            alicante.Add(cliente);
            lbClientes.Items.Add(cliente.ToString("Cliente"));
            lbAlicante.Items.Add(cliente.ToString(" "));

            StreamWriter clientestxt;
            clientestxt = File.CreateText("Clientes.txt");

            for (int i = 0; i < clientes.Count; i++)
            {
                clientestxt.WriteLine(lbClientes.Items[i].ToString());
            }
            clientestxt.Close();
        }

        private void ClearFormulario()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cbProvincia.Text = "";
        }

        private void btn_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (lbClientes.SelectedItem != null)
            {
                clientes.RemoveAt(lbClientes.SelectedIndex);
                lbClientes.Items.RemoveAt(lbClientes.SelectedIndex);
                ActualizarListBoxyTxt("Clientes");
            } else if (lbCastellon.SelectedItem != null)
            {
                castellon.RemoveAt(lbCastellon.SelectedIndex);
                lbCastellon.Items.RemoveAt(lbCastellon.SelectedIndex);
                ActualizarListBoxyTxt("C");
                
            } else if (lbAlicante.SelectedItem != null)
            {
                alicante.RemoveAt(lbAlicante.SelectedIndex);
                lbAlicante.Items.RemoveAt(lbAlicante.SelectedIndex);
                ActualizarListBoxyTxt("A");
            } else if (lbValencia.SelectedItem != null)
            {
                valencia.RemoveAt(lbValencia.SelectedIndex);
                lbValencia.Items.RemoveAt(lbValencia.SelectedIndex);
                ActualizarListBoxyTxt("V");
            }
        }                  

        private void btnGenerarProvinciastxt_Click(object sender, RoutedEventArgs e)
        {
            File.Delete("Castellon.txt");
            File.Delete("Alicante.txt");
            File.Delete("Valencia.txt");

            StreamReader clientestxt;

            clientestxt = File.OpenText("Clientes.txt");

            string linea = clientestxt.ReadLine();
            while (linea != null){
                string[] lineaCliente = linea.Split("#");
                if (lineaCliente.Length == 3)
                {
                    string provincia = lineaCliente[2];
                    string nombreArchivo = provincia + ".txt";
                    StreamWriter provinciaSW = File.AppendText(nombreArchivo);
                    provinciaSW.WriteLine(lineaCliente[0] + " " + lineaCliente[1] + " " + lineaCliente[2]);
                    provinciaSW.Close();
                }
                linea = clientestxt.ReadLine();
            }
            clientestxt.Close();
            btnModificar.IsEnabled = true;
            btnEliminar_Provincia.IsEnabled = true;
        }

        private void lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = (ListBox)sender;

            if (lb == lbCastellon)
            {
                lbAlicante.SelectedIndex = -1;
                lbValencia.SelectedIndex = -1;
                lbClientes.SelectedIndex = -1;
            }else if (lb == lbAlicante)
            {
                lbCastellon.SelectedIndex = -1;
                lbValencia.SelectedIndex = -1;
                lbClientes.SelectedIndex = -1;
            }
            else if (lb == lbValencia)
            {
                lbCastellon.SelectedIndex = -1;
                lbAlicante.SelectedIndex = -1;
                lbClientes.SelectedIndex = -1;
            }
            else if (lb == lbClientes)
            {
                lbCastellon.SelectedIndex = -1;
                lbAlicante.SelectedIndex = -1;
                lbValencia.SelectedIndex = -1;
            }
                
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            tbcFormulario.Focus();
            btnAceptarModificacion.IsEnabled = true;
            btnCrear.IsEnabled = false;

            if (lbClientes.SelectedItem != null)
            {
                txtNombre.Text = clientes[lbClientes.SelectedIndex].GetNombre();
                txtApellido.Text = clientes[lbClientes.SelectedIndex].GetApellido();
                cbProvincia.Text = clientes[lbClientes.SelectedIndex].GetProvincia();
            }

            if (lbCastellon.SelectedItem != null)
            {
                txtNombre.Text = castellon[lbCastellon.SelectedIndex].GetNombre();
                txtApellido.Text = castellon[lbCastellon.SelectedIndex].GetApellido();
                cbProvincia.Text = castellon[lbCastellon.SelectedIndex].GetProvincia();
            }

            if (lbValencia.SelectedItem != null)
            {
                txtNombre.Text = valencia[lbValencia.SelectedIndex].GetNombre();
                txtApellido.Text = valencia[lbValencia.SelectedIndex].GetApellido();
                cbProvincia.Text = valencia[lbValencia.SelectedIndex].GetProvincia();
            }

            if (lbAlicante.SelectedItem != null)
            {
                txtNombre.Text = alicante[lbAlicante.SelectedIndex].GetNombre();
                txtApellido.Text = alicante[lbAlicante.SelectedIndex].GetApellido();
                cbProvincia.Text = alicante[lbAlicante.SelectedIndex].GetProvincia();
            }
        }

        private void btn_AceptarCambios_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text, cbProvincia.Text);
            if (lbCastellon.SelectedItem != null)
            {  
                castellon[lbCastellon.SelectedIndex].SetNombre(txtNombre.Text);
                castellon[lbCastellon.SelectedIndex].SetApellido(txtApellido.Text);
                castellon[lbCastellon.SelectedIndex].SetProvincia(cbProvincia.Text);
                if (cbProvincia.Text != "Castellon")
                {
                    if (cbProvincia.Text == "Alicante")
                    {
                        alicante.Add(cliente);
                        lbAlicante.Items.Add(cliente.ToString(" "));
                        castellon.RemoveAt(lbCastellon.SelectedIndex);
                        ActualizarListBoxyTxt("A");
                        ActualizarListBoxyTxt("C");
                    }
                    if (cbProvincia.Text == "Valencia")
                    {
                        valencia.Add(cliente);
                        lbValencia.Items.Add(cliente.ToString(" "));
                        castellon.RemoveAt(lbCastellon.SelectedIndex);
                        ActualizarListBoxyTxt("V");
                        ActualizarListBoxyTxt("C");
                    }
                } else
                    ActualizarListBoxyTxt("C");

                tcProvincias.Focus();
            }
            if (lbValencia.SelectedItem != null)
            {
                valencia[lbValencia.SelectedIndex].SetNombre(txtNombre.Text);
                valencia[lbValencia.SelectedIndex].SetApellido(txtApellido.Text);
                valencia[lbValencia.SelectedIndex].SetProvincia(cbProvincia.Text);
                if (cbProvincia.Text != "Valencia")
                {
                    if (cbProvincia.Text == "Alicante")
                    {
                        alicante.Add(cliente);
                        lbAlicante.Items.Add(cliente.ToString(" "));
                        valencia.RemoveAt(lbValencia.SelectedIndex);
                        ActualizarListBoxyTxt("A");
                        ActualizarListBoxyTxt("V");
                    } 
                    if (cbProvincia.Text == "Castellon")
                    {
                        castellon.Add(cliente);
                        lbCastellon.Items.Add(cliente.ToString(" "));
                        valencia.RemoveAt(lbValencia.SelectedIndex);
                        ActualizarListBoxyTxt("C");
                        ActualizarListBoxyTxt("V");
                    }
                }
                else
                    ActualizarListBoxyTxt("V");

                tcProvincias.Focus();
            }
            if (lbAlicante.SelectedItem != null)
            {
                alicante[lbAlicante.SelectedIndex].SetNombre(txtNombre.Text);
                alicante[lbAlicante.SelectedIndex].SetApellido(txtApellido.Text);
                alicante[lbAlicante.SelectedIndex].SetProvincia(cbProvincia.Text);
                if (cbProvincia.Text != "Alicante")
                {
                    if (cbProvincia.Text == "Castellon")
                    {
                        castellon.Add(cliente);
                        lbCastellon.Items.Add(cliente.ToString(" "));
                        alicante.RemoveAt(lbAlicante.SelectedIndex);
                        ActualizarListBoxyTxt("C");
                        ActualizarListBoxyTxt("A");
                    }
                    if (cbProvincia.Text == "Valencia")
                    {
                        valencia.Add(cliente);
                        lbValencia.Items.Add(cliente.ToString(" "));
                        alicante.RemoveAt(lbAlicante.SelectedIndex);
                        ActualizarListBoxyTxt("V");
                        ActualizarListBoxyTxt("A");
                    }
                }
                else
                    ActualizarListBoxyTxt("A");

                tcProvincias.Focus();
            }
            if (lbClientes.SelectedItem != null)
            {
                clientes[lbClientes.SelectedIndex].SetNombre(txtNombre.Text);
                clientes[lbClientes.SelectedIndex].SetApellido(txtApellido.Text);
                clientes[lbClientes.SelectedIndex].SetProvincia(cbProvincia.Text);
                ActualizarListBoxyTxt("Clientes");
            }

            ClearFormulario();
            btnAceptarModificacion.IsEnabled = false;
            btnCrear.IsEnabled = true;
        }

        private void ActualizarListBoxyTxt(string Lb)
        {
            if (Lb == "C")
            {
                File.Delete("Castellon.txt");
                lbCastellon.Items.Clear();
                if (castellon.Count != 0)
                {
                    for (int i = 0; i < castellon.Count; i++)
                    {
                        lbCastellon.Items.Add(castellon[i].ToString(" "));
                        StreamWriter txt = File.AppendText("Castellon.txt");
                        txt.WriteLine(castellon[i].ToString(" "));
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
                        lbValencia.Items.Add(valencia[i].ToString(" "));
                        StreamWriter txt = File.AppendText("Valencia.txt");
                        txt.WriteLine(valencia[i].ToString(" "));
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
                        lbAlicante.Items.Add(alicante[i].ToString(" "));
                        StreamWriter txt = File.AppendText("Alicante.txt");
                        txt.WriteLine(alicante[i].ToString(" "));
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
                        lbClientes.Items.Add(clientes[i].ToString("Cliente"));
                        StreamWriter txt = File.AppendText("Clientes.txt");
                        txt.WriteLine(clientes[i].ToString("Cliente"));
                        txt.Close();
                    }
                    lbValencia.Items.Clear();
                    lbAlicante.Items.Clear();
                    lbCastellon.Items.Clear();
                    if (castellon.Count != 0)
                    {
                        for (int i = 0; i < castellon.Count; i++)
                        {
                            lbCastellon.Items.Add(castellon[i].ToString(" "));                         
                        }
                    }
                    if (valencia.Count != 0)
                    {
                        for (int i = 0; i < valencia.Count; i++)
                        {
                            lbValencia.Items.Add(valencia[i].ToString(" "));
                        }
                    }
                    if (alicante.Count != 0)
                    {
                        for (int i = 0; i < alicante.Count; i++)
                        {
                            lbAlicante.Items.Add(alicante[i].ToString(" "));
                        }
                    }
                }
            }
        }
        private void btn_CrearCliente_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && cbProvincia.Text != "")
            {
                Cliente cliente = new Cliente(txtNombre.Text, txtApellido.Text, cbProvincia.Text);
                clientes.Add(cliente);
                lbClientes.Items.Add(cliente.ToString("Cliente"));

                if (cbProvincia.Text == "Castellon")
                {
                    lbCastellon.Items.Add(cliente.ToString(" "));
                    castellon.Add(cliente);
                }
                else if (cbProvincia.Text == "Valencia")
                {
                    lbValencia.Items.Add(cliente.ToString(" "));
                    valencia.Add(cliente);
                }
                else if (cbProvincia.Text == "Alicante")
                {
                    lbAlicante.Items.Add(cliente.ToString(" "));
                    alicante.Add(cliente);
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
                ClearFormulario();
            }
            else
                MessageBox.Show("Rellena los campos");
           
        }
    }
}
