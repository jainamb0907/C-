using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SRP
{
    internal class UserWithSRP : IUser
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public bool Login(string username, string password)
        {
            // fetched from database
            string fetchedUsername = "jainam";
            string fetchedPasswoed = "jainam@123";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Logger.LogError("Empty username or password");
                return false;
            }
            if (username.Equals(fetchedUsername) && password.Equals(fetchedPasswoed))
            {
                Logger.LogSuccess("Login success");
                return true;
            }
            else
            {
                Logger.LogError("Invalid username or password");
                return false;
            }
        }

        public bool Register(string username, string password, string name)
        {
            if (
                string.IsNullOrEmpty(username)
                || string.IsNullOrEmpty(password)
                || string.IsNullOrEmpty(name)
            )
            {
                Logger.LogError("Empty username, password or name");
                return false;
            }

            // save data to database
            Logger.LogSuccess("Registration success");
            Email.SendEmail($"Hey, {username} Thank you for joining with us");
            return true;
        }
    }
}
