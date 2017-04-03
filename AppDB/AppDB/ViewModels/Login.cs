using AppDB.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppDB.ViewModels
{
    public class Login : Base
    {
        string _userName;
        public string UserName{
            get {
                return _userName;
            }
            set {
                _userName = value;
                this.Notify("UserName");
            }
        }

        string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                this.Notify("Password");
            }
        }

        public ICommand _LoginCommand
        {
            get;
            set;

        }
        private readonly Services.IMessageService _messageService;
        private readonly Services.ICredentialProvider _credentialProvider;
        public Login()
        {
            this._LoginCommand = new Command(this.LoginCommand);
            this._messageService = DependencyService.Get<Services.IMessageService>();
            this._credentialProvider = DependencyService.Get<Services.ICredentialProvider>();
        }

        private void LoginCommand()
        {
            var user = this._credentialProvider.Login(this.UserName, this.Password);
            if (user.CheckInformation())
            {
                this._messageService.ShowAsync("Sucesso");
            }
            else
            {
                this._messageService.ShowAsync("Login not Corret, empty username or password");
            }
        }
        

    }
}
