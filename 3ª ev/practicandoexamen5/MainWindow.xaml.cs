using iTextSharp.text;
using iTextSharp.text.pdf;
using practicandoexamen4.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace practicandoexamen4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Persona> person = new List<Persona>();
        public List<Persona> alien = new List<Persona>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CrearPersona()
        {
            Persona p = new Persona(txtNombre.Text, txtApellido.Text, cbCliente.Text);
            
            if (p.GetTipo() == "Persona")
            {
                person.Add(p);
                ActualizarTxt();
                RellenarLb();
                ActualizarPdf();

            } else
            {
                alien.Add(p);
                ActualizarTxt();
                RellenarLb();
                ActualizarPdf();
            }
        }

        private void RellenarLb()
        {
            lbPersonas.Items.Clear();

            for (int i = 0; i < person.Count; i++)
            {
                lbPersonas.Items.Add(person[i].ToString());
            }

            lbAlien.Items.Clear();

            for (int i = 0; i < alien.Count; i++)
            {
                lbAlien.Items.Add(alien[i].ToString());
            }

        }
        
        private void CrearPersona_Click(object sender, RoutedEventArgs e)
        {
            CrearPersona();
        }

        private void ActualizarTxt()
        {
            File.Delete("Persona.txt");
            File.Delete("Alien.txt");
            File.Delete("Todos.txt");
                    

            if (person.Count != 0)
            {
                StreamWriter sw = new StreamWriter("Persona.txt");
                for (int i = 0; i < person.Count; i++)
                {
                    sw.WriteLine(person[i].ToString());
                }
                sw.Close();
            }
            
            if (alien.Count != 0)
            {
                StreamWriter sw = new StreamWriter("Alien.txt");

                for (int i = 0; i < alien.Count; i++)
                {
                    sw.WriteLine(alien[i].ToString());
                }
                sw.Close();
            }

            if (person.Count + alien.Count != 0)
            {
                StreamWriter sw = new StreamWriter("Todos.txt");

                for (int i = 0; i < alien.Count; i++)
                {
                    sw.WriteLine(alien[i].ToString());
                }
                for (int i = 0; i < person.Count; i++)
                {
                    sw.WriteLine(person[i].ToString());
                }
                sw.Close();
            }
                                                                   
        }

        private void ActualizarPdf()
        {
           
            if (person.Count != 0)
            {
                FileStream fl = new FileStream("Personas.pdf", FileMode.Create);
                Document d = new Document();
                PdfWriter.GetInstance(d, fl);
                d.Open();

                for (int i = 0; i < person.Count; i++)
                {
                    Paragraph p = new Paragraph(person[i].ToString());
                    d.Add(p);
                }

                d.Close();
                fl.Close();
            }
            

            if (alien.Count != 0)
            {
                FileStream fl = new FileStream("Aliens.pdf", FileMode.Create);
                Document d = new Document();
                PdfWriter.GetInstance(d, fl);
                d.Open();

                for (int i = 0; i < alien.Count; i++)
                {
                    Paragraph p = new Paragraph(alien[i].ToString());
                    d.Add(p);
                }

                d.Close();
                fl.Close();
            }           
        }

        private void lbSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = (ListBox)sender;

            if (lb == lbAlien)
            {
                lbDistribuidor.SelectedItem = null;
                lbPersonas.SelectedItem = null;
                RellenarTextBox();
               
            }
            else if (lb == lbDistribuidor)
            {
                lbAlien.SelectedItem = null;
                lbPersonas.SelectedItem = null;

            }
            else if (lb == lbPersonas)
            {
                lbAlien.SelectedItem = null;
                lbDistribuidor.SelectedItem = null;
                RellenarTextBox();


            }
        }

        private void GenerarTabla()
        {
            FileStream fl = new FileStream("Tabla.pdf", FileMode.Create);
            Document d = new Document();
            PdfWriter.GetInstance(d, fl);
            d.Open();

            PdfPTable tabla = new PdfPTable(3);
            PdfPCell cell = new PdfPCell(new Phrase("Tabla de seres"));
            cell.HorizontalAlignment = 1;
            cell.Colspan = 3;
            tabla.AddCell(cell);
            cell = new PdfPCell(new Phrase("Nombre"));
            cell.HorizontalAlignment = 1;
            cell = new PdfPCell(new Phrase("Apellido"));
            cell.HorizontalAlignment = 1;
            cell = new PdfPCell(new Phrase("Tipo"));
            cell.HorizontalAlignment = 1;

            StreamReader sr = File.OpenText("Todos.txt");

            string linea = sr.ReadLine();

            while (linea != null)
            {
                string[] posicion = linea.Split(" ");
                cell = new PdfPCell(new Phrase(posicion[0]));
                tabla.AddCell(cell);
                cell = new PdfPCell(new Phrase(posicion[1]));
                tabla.AddCell(cell);
                cell = new PdfPCell(new Phrase(posicion[2]));
                tabla.AddCell(cell);
                linea = sr.ReadLine();
            }
            sr.Close();
            d.Add(tabla);
            d.Close();
            fl.Close();
        }

        private void btnGenerarPDF_Click(object sender, RoutedEventArgs e)
        {
            GenerarTabla();
        }

        private void RellenarTextBox()
        {
            if (lbPersonas.SelectedIndex != -1)
            {
                txtNombre.Text = person[lbPersonas.SelectedIndex].GetNombre();
                txtApellido.Text = person[lbPersonas.SelectedIndex].GetApellido();
                cbCliente.Text = person[lbPersonas.SelectedIndex].GetTipo();
            } else if (lbAlien.SelectedIndex != -1)
            {
                txtNombre.Text = alien[lbAlien.SelectedIndex].GetNombre();
                txtApellido.Text = alien[lbAlien.SelectedIndex].GetApellido();
                cbCliente.Text = alien[lbAlien.SelectedIndex].GetTipo();
            }
            

        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (lbPersonas.SelectedIndex != -1)
            {
                if (cbCliente.Text != person[lbPersonas.SelectedIndex].GetTipo())
                {
                    person.RemoveAt(lbPersonas.SelectedIndex);
                    CrearPersona();
                }
                else
                {
                    person[lbPersonas.SelectedIndex].SetNombre(txtNombre.Text);
                    person[lbPersonas.SelectedIndex].SetApellido(txtApellido.Text);
                }
            } else if (lbAlien.SelectedIndex != -1)
            {
                if (cbCliente.Text != alien[lbAlien.SelectedIndex].GetTipo())
                {
                    alien.RemoveAt(lbAlien.SelectedIndex);
                    CrearPersona();
                }
                else
                {
                    alien[lbAlien.SelectedIndex].SetNombre(txtNombre.Text);
                    alien[lbAlien.SelectedIndex].SetApellido(txtApellido.Text);
                }
            }
            GenerarTabla();

        }
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (lbPersonas.SelectedIndex != -1)
            {
                person.RemoveAt(lbPersonas.SelectedIndex);
                ActualizarTxt();
                ActualizarPdf();
                RellenarLb();
            } else if (lbAlien.SelectedIndex != -1)
            {
                alien.RemoveAt(lbAlien.SelectedIndex);
                ActualizarTxt();
                ActualizarPdf();
                RellenarLb();
            }
            GenerarTabla();
        }
    }
}
