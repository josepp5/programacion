using Examen_Jose_Poveda.Models;
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

namespace Examen_Jose_Poveda
{
    //-----------------------------
    // Jose Poveda Perez
    // Curso DAM
    // Modalidad Presencial
    // Examen Segunda Evaluación
    //-----------------------------

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static Cliente[] cliente = new Cliente[20];
        public static int contadorC;

        public static Distribuidor[] distribuidor = new Distribuidor[20];
        public static int contadorD;


        public void ClearFormulario()
        {
            txtNombre.Text = txtPrimerApellido.Text = txtTelefono1.Text = txtCorreoElectronico.Text = txtDireccion.Text = "";
            lbCodigo.Content = "";
            cbProvincia.SelectedIndex = -1;
            rbCliente.IsChecked = false;
            rbDistribuidor.IsChecked = false;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;

            if (menuItem == MenuVistas)
            {
                GVistas.Visibility = Visibility.Visible;
                GFormulario.Visibility = Visibility.Hidden;
            }

            if (menuItem == MenuFormularios)
            {
                GVistas.Visibility = Visibility.Hidden;
                GFormulario.Visibility = Visibility.Visible;
            }
        }

        private void PreviewText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void rb_IsChecked(object sender, RoutedEventArgs e)
        {
            RadioButton radiobutton = (RadioButton)sender;

            if (radiobutton == rbDistribuidor)
            {
                cbProvincia.Items.Add("Murcia");
                cbProvincia.Items.Add("Albacete");
                cbProvincia.Items.Add("Cuenca");
                cbProvincia.Items.Add("Teruel");
            }
            if (radiobutton == rbCliente)
            {
                cbProvincia.Items.Remove("Murcia");
                cbProvincia.Items.Remove("Albacete");
                cbProvincia.Items.Remove("Cuenca");
                cbProvincia.Items.Remove("Teruel");
            }
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;
            if (boton == btnAceptar)
            {
                if (txtNombre.Text != "" && txtPrimerApellido.Text != "" && txtTelefono1.Text != "" && txtCorreoElectronico.Text != "" && txtDireccion.Text != "" && cbProvincia.SelectedIndex != -1 && (rbCliente.IsChecked == true || rbDistribuidor.IsChecked == true))
                {
                    if (rbCliente.IsChecked == true)
                    {
  
                        cliente[contadorC] = new Cliente(txtNombre.Text, txtPrimerApellido.Text, Convert.ToInt32(txtTelefono1.Text), txtCorreoElectronico.Text, txtDireccion.Text, cbProvincia.Text, Convert.ToInt32(lbCodigo.Content));
                        ListClientes.Items.Add(cliente[contadorC].MostrarDatosC());
                        contadorC++;
                        ClearFormulario();

                    }

                    if (rbDistribuidor.IsChecked == true)
                    {
                        distribuidor[contadorD] = new Distribuidor(txtNombre.Text, txtPrimerApellido.Text, Convert.ToInt32(txtTelefono1.Text), txtCorreoElectronico.Text, txtDireccion.Text, cbProvincia.Text, Convert.ToInt32(lbCodigo.Content));
                        ListDistribuidor.Items.Add(distribuidor[contadorD].MostrarDatosD());
                        contadorD++;
                        ClearFormulario();
                    }
                }
                else
                {
                    MessageBox.Show("Tienes que rellenar todos los campos obligatorios");
                }
            }

            if (boton == btnCancelar)
            {
                Close();
            }         
        }

        public void Generar()
        {
            Random random = new Random();
            int codigo = random.Next(999, 10000);

            lbCodigo.Content = codigo;
        }

        public void Mostrar()
        {
            if (txtNombre.Text != "" && txtPrimerApellido.Text != "" && txtTelefono1.Text != "" && txtCorreoElectronico.Text != "" && txtDireccion.Text != "" && cbProvincia.SelectedIndex != -1 && (rbCliente.IsChecked == true || rbDistribuidor.IsChecked == true))
            {
                Generar();
            }
        }

        private void txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            Mostrar();
        }

        private void cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mostrar();
        }
    }
}
