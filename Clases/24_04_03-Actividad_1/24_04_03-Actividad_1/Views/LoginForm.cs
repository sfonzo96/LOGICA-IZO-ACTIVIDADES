using _24_04_03_Actividad_1.Models;
using _24_04_03_Actividad_1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_04_03_Actividad_1.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UserTxt.Text.Trim();
            string password = PassTxt.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Todos los campos son requeridos");
                return;
            }

            UserService userService = UserService.GetInstance();
            User user = userService.GetUser(username);

            if (user == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }

            if (username != user.Username || password != user.Password)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }

            this.Hide();
            MainForm mainForm = new MainForm(user);
            mainForm.Show();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.ShowDialog();
        }
    }
}
