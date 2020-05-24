using Pavilions_WS.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Pavilions_WS.Logic;
using System.ComponentModel.DataAnnotations;
using System.Windows;

namespace Pavilions_WS.ViewModels
{
    class AuthorizationViewModel : ValidateViewModel, IPageViewModel
    {
        /*private string login;

        public string Login
        {
            get => login;
            set => login = value;
        }

        private string password;
        public string Password
        {
            get => password;
            set => password = value;
        }*/


        string login;
        [Required]
        public string Login
        {
            get => login;
            set => Set(ref login, value);            
        }

        string password;
        [Required]
        public string Password
        {
            get => password;
            set => Set(ref password, value);
        }

        private ICommand testC;
        public ICommand TestC
        {
            get
            {
                return testC ?? (testC = new RelayCommand(x =>
                {
                    MessageBox.Show(login + "\n" + password);                    
                }));
            }
        }
    }
}
