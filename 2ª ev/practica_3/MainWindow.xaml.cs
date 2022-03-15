using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Text.RegularExpressions;
using practica_3.Models;

namespace practica_3
{
    // --------------------------------------------
    // Jose Poveda Perez
    // Curso DAM
    // Modalidad Presencial
    // Práctica nº 3
    // --------------------------------------------
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private new void PreviewTextInput(object sender, TextCompositionEventArgs e)  // Creada una funcion que solo dejara escribir numeros en el textbox
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public void Mostrar() // Esta funcion comprueba que campos obligatorios estan rellenados
        {
            int contador = 0; // variable que contabiliza los campos obligatorios, la he usado para el boton aceptar
            pbProgreso.Value = 0; // variable que he usado para mostrar el progreso en la progressbar

            if (txtNombre.Text != "")
            {
                pbProgreso.Value++;
                contador++;
            }         
            
            if (txtPrimerApellido.Text != "")
            {
                pbProgreso.Value++;
                contador++;
            }

            if (txtTelefono.Text != "")
            {
                pbProgreso.Value++;
                contador++;
            }

            if (txtEmail.Text != "")
            {
                pbProgreso.Value++;
                contador++;
            }

            if (txtDireccion.Text != "")
            {
                pbProgreso.Value++;
                contador++;
            }

            if (txtCodigoPostal.Text != "")
            {
                pbProgreso.Value++;
                contador++;
            }

            if (txtPoblacion.Text != "")
            {
                pbProgreso.Value++;
                contador++;
            }

            if (rbCliente.IsChecked == true || rbDistribuidor.IsChecked == true)
            {
                pbProgreso.Value++;
                contador++;
            }

            if (cbProvincia.SelectedIndex != -1) // comprueba que se ha escogido una provincia en el combobox
            {
                pbProgreso.Value++;
                contador++;
            }

            if (contador == 9) // condicion que activa y muestra el boton aceptar solo si estan rellenos los campos obligatorios
                btnAceptar.IsEnabled = true;
            else
                btnAceptar.IsEnabled = false;

            lbProgreso.Content = pbProgreso.Value + " / 9"; // label que muestra el progreso del formulario
        }
        private void ClearComboBox() // funcion creada que borra el item escojido en el combobox y lo deja vacio si cambias de cliente a distribuidor en cualquier momento
        {
            cbProvincia.SelectedIndex = -1;
        }
        private void rbCliente_IsChecked(object sender, RoutedEventArgs e) // activa y añade items necesarios al combobox si rb cliente es seleccionado
        {
            ClearComboBox();
            cbProvincia.Items.Add("Albacete");
            cbProvincia.Items.Add("Murcia");
            cbProvincia.Items.Add("Cuenca");
            cbProvincia.Items.Add("Teruel");
            Mostrar();
            cbProvincia.IsEnabled = true;
        }
        private void rbDistribuidor_IsChecked(object sender, RoutedEventArgs e) // activa y elimina items (si es necesario) del combobox si rb distribuidor es selecccionado
        {
            ClearComboBox();
            cbProvincia.Items.Remove("Albacete");
            cbProvincia.Items.Remove("Murcia");
            cbProvincia.Items.Remove("Cuenca");
            cbProvincia.Items.Remove("Teruel");
            Mostrar();
            cbProvincia.IsEnabled = true;
        }
        private void txtNombreChanged(object sender, TextChangedEventArgs e) // comprueba
        {
            Mostrar();
        }
        private void txtApellido1Changed(object sender, TextChangedEventArgs e)  // comprueba
        {
            Mostrar();
        }
        private void txtTelefonoChanged(object sender, TextChangedEventArgs e)  // comprueba
        {
            Mostrar();
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)  // comprueba
        {
            Close();
        }
        private void txtEmailChanged(object sender, TextChangedEventArgs e)  // comprueba
        {
            Mostrar();
        }
        private void txtDireccionChanged(object sender, TextChangedEventArgs e)  // comprueba
        {
            Mostrar();
        }
        private void txtCodigoPostalChanged(object sender, TextChangedEventArgs e)  // comprueba
        {
            Mostrar();
        }
        private void txtPoblacionChanged(object sender, TextChangedEventArgs e)  // comprueba
        {
            Mostrar();
        }
        private void cbProvincia_IsSelected(object sender, SelectionChangedEventArgs e) // comprueba
        {
            Mostrar();
        }
        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            // Creamos la instancia de la clase Persona sobrecargando los parametros
            Persona persona = new Persona(txtNombre.Text, txtPrimerApellido.Text, int.Parse(txtTelefono.Text), txtEmail.Text, txtCodigoPostal.Text, txtDireccion.Text, cbProvincia.Text, txtPoblacion.Text);

            if (rbCliente.IsChecked == true)
            {
                MessageBox.Show(persona.ToSQL("cliente")); // si es de tipo cliente, mostramos la cadena SQL para la tabla cliente
            }
            else if (rbDistribuidor.IsChecked == true)
            {
                MessageBox.Show(persona.ToSQL("distribuidor")); // si es de tipo distribuidor, mostramos la cadena SQL para la tabla distribuidor
            }
        }

    }
}
