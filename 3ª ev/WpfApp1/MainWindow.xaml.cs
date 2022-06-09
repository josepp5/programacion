using practica5_Jose_Poveda_DAM1.Models;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
        public MainWindow()
        {
            InitializeComponent();
            File.Delete("Clientes.txt");
            File.Delete("text.txt");
            File.Delete("Castellon.txt");
            File.Delete("Valencia.txt");
            File.Delete("pedefe.pdf");
        }


        private void GenerarTxt(object sender, RoutedEventArgs e)
        {
            StreamWriter txt = File.AppendText("text.txt");

            txt.WriteLine(txtNombre.Text + " " + txtApellido.Text + " " + cbProvincia.Text);

            // txt.WriteLine(ToJSON());

            txt.Close();

            LeerFicheroTXT();
        }

        private void LeerFicheroTXT()
        {
            lbClientes.Items.Clear();

            StreamReader text = File.OpenText("text.txt");

            string linea = text.ReadLine();

            while (linea != null)
            {
                string[] palabras = linea.Split(" ");
                Cliente c = new Cliente(palabras[0], palabras[1] , palabras[2]);
                string cliente = c.ToString(false);
                lbClientes.Items.Add(cliente);
                linea = text.ReadLine();
            }
            text.Close();
            
        }

        private void GenerarPDF(object sender, RoutedEventArgs e)
        {
            Document doc = new Document();
            FileStream pdf = new FileStream("pedefe.pdf", FileMode.OpenOrCreate);
            PdfWriter.GetInstance(doc, pdf);

            doc.Open();

            Font f = FontFactory.GetFont("Helvetica", 20, BaseColor.DARK_GRAY);

            Paragraph p = new Paragraph(txtNombre.Text + " " + txtApellido.Text + " " + cbProvincia.Text , f);

            Chunk c = new Chunk(ToString());

            doc.Add(p);

            doc.Add(c);

            doc.Close();
        }



        private void btnDefault_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente(txtNombre.Text, txtApellido.Text, cbProvincia.Text);
            MessageBox.Show(c.ToJSON());
        }
    }
}

    