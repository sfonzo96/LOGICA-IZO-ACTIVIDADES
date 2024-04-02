using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _24_04_03_Actividad_1.Models;
using System.Text.Json;

namespace _24_04_03_Actividad_1.Services
{
    internal class UserService
    {
        static UserService? Instance;
        string DataPath;
        private UserService(string dataPath)
        {
            this.DataPath = dataPath;
        }

        public bool AddUser(string username, string firstName, string lastName,string password, string email)
        {
            if (this.UserExists(username))
            {
                MessageBox.Show("Ya existe un registro con ese usuario");
                return false;
            }

            User user = new User(username, firstName, lastName, email, password);
            List<User> users = this.GetUsers();
            users.Add(user);
            this.UpdateUsersJson(users);

            return true;
        }

        public User GetUser(string username)
        {
            List<User> users = this.GetUsers();
            User user = users.SingleOrDefault(user => user.Username == username);
            return user;
        }

        public bool UpdateUserPic(string username, string path)
        {
            List<User> users = this.GetUsers();
            foreach (User user in users)
            {
                if (user.Username == username)
                {
                    user.ProfilePic = path;
                    this.UpdateUsersJson(users);
                    return true;
                }
            }
            return false;
        }

        private void UpdateUsersJson(List<User> users)
        {
            string jsonData = JsonSerializer.Serialize(users);
            File.WriteAllText(this.DataPath, jsonData);
        }

        public bool UserExists(string username)
        {
            List<User> users = this.GetUsers();
            foreach (User user in users)
            {
                if (user.Username == username)
                {
                    return true;
                }
            }

            return false;
        }

        private List<User> GetUsers()
        {
            string jsonData = System.IO.File.ReadAllText(this.DataPath);
            List<User> users = JsonSerializer.Deserialize<List<User>>(jsonData);
            return users;
        }

        public static UserService GetInstance()
        {
            if (UserService.Instance == null)
            {
                UserService.Instance = new UserService("../../../Data/users.json");
            }
            return UserService.Instance;
        }
    }
}
