using System.Windows;
using System.Windows.Controls;

namespace Registro_Estudianes_36.Vistas.Alumnos.Paginas
{
    public partial class Pagina_Alumnos : Page
    {
        public Pagina_Alumnos()
        {
            InitializeComponent();
        }
        private void chkPrepa_Click(object sender, RoutedEventArgs e)
        {
            if (chkPrepa.IsChecked == true)
            {
                chkLicenciatura.IsChecked = false;
                chkMaestria.IsChecked = false;
            }
        }
        private void chkLicenciatura_Click(object sender, RoutedEventArgs e)
        {
            if (chkLicenciatura.IsChecked == true)
            {
                chkPrepa.IsChecked = false;
                chkMaestria.IsChecked = false;
            }
        }

        private void chkMaestria_Click(object sender, RoutedEventArgs e)
        {
            if (chkMaestria.IsChecked == true)
            {
                chkPrepa.IsChecked = false;
                chkLicenciatura.IsChecked = false;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int sueldoBase = 1500;
            int bono = 0;

            if (chkPrepa.IsChecked == true)
            {
                bono = 1500;
            }
            else if (chkLicenciatura.IsChecked == true)
            {
                bono = 2000;
            }
            else if (chkMaestria.IsChecked == true)
            {
                bono = 3000;
            }

            int pagoTotal = sueldoBase + bono;

            lblMostrarNombre.Content = "Nombre: " + txtNombre.Text;
            lblMostrarId.Content = "ID: " + txtId.Text;
            lblMostrarCorreo.Content = "Correo: " + txtCorreo.Text;
            lblMostrarCarrera.Content = "Carrera: " + txtCarrera.Text;
            lblMostrarPago.Content = "Pago: $" + pagoTotal.ToString();
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {

            try
            {

            }
            catch { 
            
            }
        }



        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {

            try
            {

            }
            catch
            {

            }
        }


        private void Actualizar_Click(object sender, RoutedEventArgs e)
        {

            try
            {

            }
            catch
            {

            }
        }

    }
}
