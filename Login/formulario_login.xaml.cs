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
using Registro_Estudianes_36.Principal;

namespace Registro_Estudianes_36.Login
{
    /// <summary>
    /// Lógica de interacción para formulario_login.xaml
    /// </summary>
    public partial class formulario_login : Window
    {
        public formulario_login()
        {
            InitializeComponent();
        }

        private void Boton_Iniciar_Click(object sender, RoutedEventArgs e)
        {
          

            try
            {
                if (usuariocampo.Text == "admin" && contraseñacampo.Text == "admin")
                {
                    Form_principal Form_P = new Form_principal();
                    Form_P.Show();
                    Hide();

                }
                else
                {
                    MessageBox.Show("usuario y contrase;a incorrectos, intente de nuevo", "Error 404", MessageBoxButton.OK, MessageBoxImage.Error);
                    
                    contraseñacampo.Clear();
                    usuariocampo.Clear();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al navegar al iniciar sesion  " + ex.Message, "Error 404", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
