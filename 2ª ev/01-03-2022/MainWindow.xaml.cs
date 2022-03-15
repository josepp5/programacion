using _01_03_2022.Models;
using System;
using System.Collections.Generic;
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

namespace _01_03_2022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static Persona[] personas = new Persona[5];
        public static int num = 0;

        public void Clear()
        {
            txtEdad.Text = "";
            txtNombre.Text = "";
            cbCiudad.Text = "";
        }

        public void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
           
            if (txtNombre.Text == "" || txtEdad.Text == "" || cbCiudad.Text == "")
            {
                MessageBox.Show("Rellena los campos");
            }
            else
            {
                personas[num] = new Persona(txtNombre.Text, Convert.ToInt32(txtEdad.Text), cbCiudad.Text);
                lbNombre.Items.Add(personas[num].GetNombre());
                num++;
                Clear();
            }          
        }

        private void lbNombre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Persona persona = personas[lb.SelectedIndex];

            lbDatos.Items.Add(personas[num].GetNombre());
            


           
        }
      
    }
}