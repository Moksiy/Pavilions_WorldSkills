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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Pavilions_WS.Model;

namespace Pavilions_WS.ViewModels
{
    class AuthorizationViewModel : ValidateViewModel, IPageViewModel
    {
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

        string error;
        public string Error
        {
            get => error;
            set => Set(ref error, value);
        }

        private ICommand authorizate;
        public ICommand TryAuthorizate
        {
            get
            {
                return authorizate ?? (authorizate = new RelayCommand(x =>
                {
                    string error = AuthorizationCommands.Authorizate(Login, Password);
                    if (String.IsNullOrEmpty(error))
                    {
                        switch (CurrentUser.Role)
                        {
                            case "Менеджер С":
                                Mediator.Notify("LoadShoppingCentersList");
                                break;

                            case "  ":
                                Mediator.Notify("");
                                break;
                        }
                    }
                    else
                    {
                        if (error == "неверная комбинация логин-пароль")
                            Error = error;
                        else
                            MessageBox.Show(error);
                    }
                }));
            }
        }
    }
}
