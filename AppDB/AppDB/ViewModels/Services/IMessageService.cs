using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppDB.ViewModels.Services
{
    public interface IMessageService
    {
        Task ShowAsync(string message);
    }
}
