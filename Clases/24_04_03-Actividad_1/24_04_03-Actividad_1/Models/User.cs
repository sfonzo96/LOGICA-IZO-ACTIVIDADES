using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_04_03_Actividad_1.Models
{
    public class User
    {   
        public string Username { get; set; } = String.Empty;
        public string Name { get; set; } = String.Empty;
        public string LastName { get; set; }  = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;

        public string ProfilePic { get; set; } = String.Empty;

        public User()
        {
        }
        public User(string username, string name, string lastName, string email, string password)
        {
            this.Username = username;
            this.Name = name;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
        }

        public User(string username, string name, string lastName, string email, string password, string profilePic)
        {
            this.Username = username;
            this.Name = name;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.ProfilePic = profilePic;
        }
    }
}
