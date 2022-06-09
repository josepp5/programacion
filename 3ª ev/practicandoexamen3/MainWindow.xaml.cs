using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Jose_Poveda_DAM_1.Models;

namespace Jose_Poveda_DAM_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Persona> clientesList = new List<Persona>();
        public List<Persona> distribuidoresList = new List<Persona>();
        public MainWindow()
        {
            InitializeComponent();
        }

        public int GenerarRandom(string tipo)
        {
            int random;
            if (tipo == "c")
            {
                Random rd = new Random();
                random = rd.Next(0000, 9999);
                for (int i = 0; i < clientesList.Count; i++)
                {
                    if (clientesList[i].codigo == random)
                    {
                        random = rd.Next(0000, 9999);
                    }
                }
                return random;
            } else
            {
                Random rd = new Random();
                random = rd.Next(000, 999);
                for (int i = 0; i < distribuidoresList.Count; i++)
                {
                    if (distribuidoresList[i].codigo == random)
                    {
                        random = rd.Next(0000, 9999);
                    }
                }
                return random;
            }
            
        }

        private void CrearPersona()
        {
            
            if (cbTipo.Text == "Cliente")
            {
                if (txtNombre.Text != "" && txtApellido.Text != "" && txtTelefono.Text != "" && txtDireccion.Text != "" && cbTipo.Text != "")
                {
                    Persona p = new Persona(GenerarRandom("c"), txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtDireccion.Text, cbTipo.Text);
                    clientesList.Add(p);
                }
                else
                    MessageBox.Show("Rellena los campos con * y tambien el apellido");
            }
            else
            {
                if (txtNombre.Text != "" && txtTelefono.Text != "" && txtDireccion.Text != "" && cbTipo.Text != "")
                {
                    Persona p = new Persona(GenerarRandom(" "), txtNombre.Text, txtTelefono.Text, txtDireccion.Text, cbTipo.Text);
                    distribuidoresList.Add(p);
                } else
                    MessageBox.Show("Rellena los campos con *");
            }

            ActualizarTxt();
            Rellenarlb();
        }

        private void ActualizarTxt()
        {
            if (clientesList.Count != 0)
            {
                StreamWriter sw = new StreamWriter("clientes.txt");

                for (int i = 0; i < clientesList.Count; i++)
                {
                    sw.WriteLine(clientesList[i].ToStringCliente("#"));
                }
                sw.Close();
            }

            if (distribuidoresList.Count != 0)
            {
                StreamWriter sw = new StreamWriter("distribuidores.txt");

                for (int i = 0; i < distribuidoresList.Count; i++)
                {
                    sw.WriteLine(distribuidoresList[i].ToStringDistribuidor("#"));
                }
                sw.Close();
            }
        }

        private void Rellenarlb()
        {
            lbCliente.Items.Clear();
            lbDistribuidor.Items.Clear();
            for (int i = 0; i < clientesList.Count; i++)
            {
                lbCliente.Items.Add(clientesList[i].ToStringCliente(" "));
            }

            for (int i = 0; i < distribuidoresList.Count; i++)
            {
                lbDistribuidor.Items.Add(distribuidoresList[i].ToStringCliente(" "));
            }

        }

        private void RellenarInfo()
        {
            if (lbCliente.SelectedIndex != -1)
            {
                txtNombre.Text = clientesList[lbCliente.SelectedIndex].nombre;
                txtApellido.Text = clientesList[lbCliente.SelectedIndex].apellido;
                txtTelefono.Text = clientesList[lbCliente.SelectedIndex].telefono;
                txtDireccion.Text = clientesList[lbCliente.SelectedIndex].direccion;
                cbTipo.Text = clientesList[lbCliente.SelectedIndex].tipo;
            } else if (lbDistribuidor.SelectedIndex != -1)
            {
                txtNombre.Text = distribuidoresList[lbDistribuidor.SelectedIndex].nombre;
                txtApellido.Text = distribuidoresList[lbDistribuidor.SelectedIndex].apellido;
                txtTelefono.Text = distribuidoresList[lbDistribuidor.SelectedIndex].telefono;
                txtDireccion.Text = distribuidoresList[lbDistribuidor.SelectedIndex].direccion;
                cbTipo.Text = distribuidoresList[lbDistribuidor.SelectedIndex].tipo;
            }
        }

        private void EliminarPersona()
        {
            if (lbCliente.SelectedIndex != -1)
            {
                clientesList.RemoveAt(lbCliente.SelectedIndex);
            } else if (lbDistribuidor.SelectedIndex != -1)
            {
                distribuidoresList.RemoveAt(lbDistribuidor.SelectedIndex);
            }
            ActualizarTxt();
            Rellenarlb();
        } 

        private void btnCrearPersona_Click(object sender, RoutedEventArgs e)
        {
            CrearPersona();
        }

        private void LbSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = (ListBox)sender;

            if (lb == lbCliente)
            {
                lbDistribuidor.SelectedIndex = -1;
                RellenarInfo();
            }
            else if (lb == lbDistribuidor)
            {
                lbCliente.SelectedIndex = -1;
                RellenarInfo();
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Si haces click en Confirmar la persona se eliminará");
        }

        private void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            EliminarPersona();
        }

        private void ModificarPersona()
        {
            if (lbCliente.SelectedIndex != -1)
            {
                if(clientesList[lbCliente.SelectedIndex].tipo != cbTipo.Text)
                {                   
                    clientesList.RemoveAt(lbCliente.SelectedIndex);
                    CrearPersona();
                }else
                {
                    clientesList[lbCliente.SelectedIndex].SetNombre(txtNombre.Text);
                    clientesList[lbCliente.SelectedIndex].SetApellido(txtApellido.Text);
                    clientesList[lbCliente.SelectedIndex].SetTelefono(txtTelefono.Text);
                    clientesList[lbCliente.SelectedIndex].SetDireccion(txtDireccion.Text);
                }
            }
            else if (lbDistribuidor.SelectedIndex != -1)
            {
                if (distribuidoresList[lbDistribuidor.SelectedIndex].tipo != cbTipo.Text)
                {
                    distribuidoresList.RemoveAt(lbDistribuidor.SelectedIndex);
                    CrearPersona();
                }
                else
                {
                    distribuidoresList[lbDistribuidor.SelectedIndex].SetNombre(txtNombre.Text);
                    distribuidoresList[lbDistribuidor.SelectedIndex].SetApellido(txtApellido.Text);
                    distribuidoresList[lbDistribuidor.SelectedIndex].SetTelefono(txtTelefono.Text);
                    distribuidoresList[lbDistribuidor.SelectedIndex].SetDireccion(txtDireccion.Text);
                }
            }
            ActualizarTxt();
            Rellenarlb();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            ModificarPersona();
        }

        private void btnGenerarJson_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btnGenerarJsonClientes)
            {
                txtJsonClientes.Text = GenerarJson(clientesList , "c");
            } else
                txtJsonDistribuidores.Text = GenerarJson(distribuidoresList, " ");
        }

        private string GenerarJson(List <Persona> tipo, string a)
        {
            string json = "";

            for (int i = 0; i < tipo.Count; i++)
            {
                json = json + tipo[i].PersonaToJSON(a);
            }
            return "{" + json + "}";
        }

        private void ActualizarPdf()
        {
            FileStream fl = new FileStream("Datos.pdf", FileMode.Create);
            Document d = new Document();
            PdfWriter.GetInstance(d, fl);
            d.Open();
            Paragraph parag = new Paragraph("Clientes");
            d.Add(parag);
            Phrase p = new Phrase("Clientes");
            PdfPTable tablaClientes = new PdfPTable(5);
            PdfPCell cellClientes = new PdfPCell(p);
            cellClientes.Colspan = 5;
            cellClientes.HorizontalAlignment = 1;
            tablaClientes.AddCell(cellClientes);

            tablaClientes.AddCell(new Phrase("Codigo"));
            tablaClientes.AddCell(new Phrase("Nombre"));
            tablaClientes.AddCell(new Phrase("Apellido"));
            tablaClientes.AddCell(new Phrase("Telefono"));
            tablaClientes.AddCell(new Phrase("Direccion"));

            StreamReader sr = new StreamReader("clientes.txt");
            string linea = sr.ReadLine();
            string[] posicion = linea.Split("#");

            while (linea != null)
            {
                tablaClientes.AddCell(new Phrase(posicion[0]));
                tablaClientes.AddCell(new Phrase(posicion[1]));
                tablaClientes.AddCell(new Phrase(posicion[2]));
                tablaClientes.AddCell(new Phrase(posicion[3]));
                tablaClientes.AddCell(new Phrase(posicion[4]));
                linea = sr.ReadLine();
            }
            d.Add(tablaClientes);

            PdfPTable tablad = new PdfPTable(5);
            PdfPCell celld = new PdfPCell(p);

            parag = new Paragraph("Distribuidores");
            d.Add(parag);
            p = new Phrase("Distribuidores");
            tablad = new PdfPTable(4);
            cellClientes = new PdfPCell(p);
            cellClientes.Colspan = 5;
            cellClientes.HorizontalAlignment = 1;
            tablad.AddCell(cellClientes);

            tablaClientes.AddCell(new Phrase("Codigo"));
            tablaClientes.AddCell(new Phrase("Nombre"));
            tablaClientes.AddCell(new Phrase("Telefono"));
            tablaClientes.AddCell(new Phrase("Direccion"));

            sr = new StreamReader("distribuidores.txt");
            linea = sr.ReadLine();
            posicion = linea.Split("#");

            while (linea != null)
            {
                tablad.AddCell(new Phrase(posicion[0]));
                tablad.AddCell(new Phrase(posicion[1]));
                tablad.AddCell(new Phrase(posicion[2]));
                tablad.AddCell(new Phrase(posicion[3]));               
                linea = sr.ReadLine();
            }

            d.Add(tablad);
            sr.Close();
            d.Close();
            fl.Close();

        }

        private void btnGenerarPDF_Click(object sender, RoutedEventArgs e)
        {
            ActualizarPdf();
        }
    }
}
