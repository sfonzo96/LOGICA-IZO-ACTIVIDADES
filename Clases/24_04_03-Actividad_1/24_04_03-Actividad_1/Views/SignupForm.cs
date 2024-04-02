using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _24_04_03_Actividad_1.Services;

namespace _24_04_03_Actividad_1.Views
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
                
            string adminPass = AdminPassTxt.Text.Trim();
            if (adminPass != "admin")
            {
                MessageBox.Show("Contraseña de administrador incorrecta");
                return;
            }

            string username = UserTxt.Text.Trim();
            string firstName = FNameTxt.Text.Trim();
            string lastName = LNameTxt.Text.Trim();
            string password = PassTxt.Text.Trim();
            string email = EmailTxt.Text.Trim();

            if (username == "" || firstName == "" || lastName == "" || password == "" || email == "" )
            {
                MessageBox.Show("Todos los campos son requeridos");
                return;
            }

            UserService userService = UserService.GetInstance();
            bool success = userService.AddUser(username, firstName, lastName, password, email);

            if (success == true)
            {
                MessageBox.Show("Usuario registrado correctamente");
                this.Close();
            }
        }
    }
}
