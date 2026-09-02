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
using System.Windows.Shapes;
using Registro_Estudianes_36.menu.Inicio;
using Registro_Estudianes_36.menu.Materias;
namespace Registro_Estudianes_36.principal.formularios
{
    /// <summary>
    /// Lógica de interacción para Form_principal.xaml
    /// </summary>
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
            form_inicio ventana = new form_inicio();
            ventana.ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void materias_click(object sender, RoutedEventArgs e)
        {
            form_materias ventana = new form_materias();
            ventana.ShowDialog();
        }   
    }
}
