using _24_04_03_Actividad_1.Models;
using _24_04_03_Actividad_1.Services;
namespace _24_04_03_Actividad_1
{
    public partial class MainForm : Form
    {
        private User? _User;
        private UserService _UserService = UserService.GetInstance();
        public MainForm(User currentUser)
        {
            InitializeComponent();
            this._User = currentUser;
            try
            {
                ProfilePic.Image = Image.FromFile($"./Uploads/{this._User.ProfilePic}"); ;
            }
            catch (FileNotFoundException)
            {
                ProfilePic.Image = Image.FromFile("./Uploads/default.jpg");
            }
        }

        private void UploadPicBtn_Click(object sender, EventArgs e)
        {
            if (ProfilePicLoader.ShowDialog() == DialogResult.OK)
            {
                Image picImage = Image.FromFile(ProfilePicLoader.FileName);

                // Guardar la imagen en una carpeta dentro de la aplicación
                string fileName = Path.GetFileName(ProfilePicLoader.FileName);
                string filePath = Path.Combine(Application.StartupPath, "Uploads", fileName);
                picImage.Save(filePath);

                ProfilePic.Image = Image.FromFile(ProfilePicLoader.FileName);
                _UserService.UpdateUserPic(this._User.Username, fileName);
            }
        }
    }
}
