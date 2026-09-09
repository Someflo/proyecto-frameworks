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

        private void inicio_click(object sender, RoutedEventArgs e)
        {
            ContenedorPrincipal.Navigate((Uri)null);
        }

        private void materias_click(object sender, RoutedEventArgs e)
        {
            ContenedorPrincipal.Navigate(new Uri("Vistas/Materias/Paginas/Pagina_Materias.xaml", UriKind.RelativeOrAbsolute));
        }

        private void alumnos_click(object sender, RoutedEventArgs e)
        {
            ContenedorPrincipal.Navigate(new Uri("Vistas/Alumnos/Paginas/Pagina_Alumnos.xaml", UriKind.RelativeOrAbsolute));
        }

        private void incidencias_click(object sender, RoutedEventArgs e)
        {
            ContenedorPrincipal.Navigate(new Uri("Vistas/Incidencias/Paginas/Pagina_Incidencias.xaml", UriKind.RelativeOrAbsolute));
        }

        private void webcusva_click(object sender, RoutedEventArgs e)
        {
            ContenedorPrincipal.Navigate(new Uri("Vistas/WebCusva/Paginas/Pagina_WebCusva.xaml", UriKind.RelativeOrAbsolute));
        }

        private void semanas_click(object sender, RoutedEventArgs e)
        {
            ContenedorPrincipal.Navigate(new Uri("Vistas/Semanas/Paginas/Pagina_Semanas.xaml", UriKind.RelativeOrAbsolute));
        }

        private void killexcels_click(object sender, RoutedEventArgs e)
        {
            ContenedorPrincipal.Navigate(new Uri("Vistas/KillExcels/Paginas/Pagina_KillExcels.xaml", UriKind.RelativeOrAbsolute));
        }

        private void pociones_click(object sender, RoutedEventArgs e)
        {
            ContenedorPrincipal.Navigate(new Uri("Vistas/Pociones/Paginas/Pagina_Pociones.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ajustes_click(object sender, RoutedEventArgs e)
        {
            ContenedorPrincipal.Navigate(new Uri("Vistas/Ajustes/Paginas/Pagina_Ajustes.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
