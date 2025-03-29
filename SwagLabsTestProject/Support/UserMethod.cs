using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace SwagLabsTestProject.Support
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class LoginData
    {
        public string Url { get; set; }
        public List<User> Users { get; set; }
    }

    public class LoginDataProvider
    {
        private readonly LoginData _loginData;

        public LoginDataProvider(string jsonFilePath = @"Support\LoginData.json")
        {
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName;
            var fullPath = Path.Combine(projectPath, jsonFilePath);
            var jsonData = File.ReadAllText(fullPath); 
            _loginData = JsonConvert.DeserializeObject<LoginData>(jsonData);
        }

        public (string Login, string Password) GetCredentials(string login)
        {
            var user = _loginData.Users.FirstOrDefault(u => u.Login == login);
            if (user == null)
            {
                throw new KeyNotFoundException($"User with login '{login}' not found.");
            }
            return (user.Login, user.Password);
        }

        public string GetUrl()
        {
            return _loginData.Url;
        }
    }
}
