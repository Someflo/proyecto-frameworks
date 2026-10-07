using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Registro_Estudianes_36.Principal
{
    public partial class Form_principal : Window
    {
        public Form_principal()
        {
            InitializeComponent();
        }

        private void label_menu_MouseEnter(object sender, MouseEventArgs e)
        {
            label_menu.Foreground = new SolidColorBrush(Colors.Red);
            label_menu.FontSize = 20;
        }

        private void NavegarA(string ruta)
        {
            Panel_Menu_Cuadricula.Visibility = Visibility.Collapsed;
            ContenedorPrincipal.Visibility = Visibility.Visible;
            ContenedorPrincipal.Navigate(new Uri(ruta, UriKind.RelativeOrAbsolute));
        }

        private void inicio_click(object sender, RoutedEventArgs e)
        {
            ContenedorPrincipal.Navigate((Uri)null);
            ContenedorPrincipal.Visibility = Visibility.Collapsed;
            Panel_Menu_Cuadricula.Visibility = Visibility.Visible;
        }

        private void materias_click(object sender, RoutedEventArgs e)
        {
            NavegarA("Vistas/Materias/Paginas/Pagina_Materias.xaml");
        }

        private void alumnos_click(object sender, RoutedEventArgs e)
        {
            NavegarA("Vistas/Alumnos/Paginas/Pagina_Alumnos.xaml");
        }

        private void incidencias_click(object sender, RoutedEventArgs e)
        {
            NavegarA("Vistas/Incidencias/Paginas/Pagina_Incidencias.xaml");
        }

        private void webcusva_click(object sender, RoutedEventArgs e)
        {
            NavegarA("Vistas/WebCusva/Paginas/Pagina_WebCusva.xaml");
        }

        private void semanas_click(object sender, RoutedEventArgs e)
        {
            NavegarA("Vistas/Semanas/Paginas/Pagina_Semanas.xaml");
        }

        private void killexcels_click(object sender, RoutedEventArgs e)
        {
            NavegarA("Vistas/KillExcels/Paginas/Pagina_KillExcels.xaml");
        }

        private void pociones_click(object sender, RoutedEventArgs e)
        {
            NavegarA("Vistas/Pociones/Paginas/Pagina_Pociones.xaml");
        }

        private void ajustes_click(object sender, RoutedEventArgs e)
        {
            NavegarA("Vistas/Ajustes/Paginas/Pagina_Ajustes.xaml");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
