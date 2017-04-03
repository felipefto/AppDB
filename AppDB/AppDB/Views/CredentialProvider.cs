using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppDB.Models;
namespace AppDB.Views
{
    public class CredentialProvider : ViewModels.Services.ICredentialProvider
    {
        public User Login(string userName, string password)
        {
            var user = new User(userName, password);
            return user;
        }

        public async Task Register(string email, string userName, string password)
        {
            
        }
    }
}
