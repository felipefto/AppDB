using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppDB.ViewModels.Services
{
    public interface ICredentialProvider
    {
        Models.User Login(string userName, string password);
        Task Register(string email, string userName, string password);

    }
}
