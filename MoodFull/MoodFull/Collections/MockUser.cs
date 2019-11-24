using System;
using System.Collections.Generic;
using System.Text;

namespace MoodFull.Mocks
{
    public class MockUser
    {
        string username;
        string password;
        string confirmPassword;
        string name;
        string lastName;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string ConfirmPassword { get => confirmPassword; set => confirmPassword = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public MockUser(string username, string password, string name, string lastname)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.lastName = lastname;

        }
    }
}
