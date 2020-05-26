using Pavilions_WS.Command;
using Pavilions_WS.Logic;
using Pavilions_WS.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Pavilions_WS.ViewModels
{
    public class ShoppingCentersListViewModel: BaseViewModel, IPageViewModel
    {
        ObservableCollection<ShoppingCenterElement> centers;

        private ICommand exit;
        public ICommand Exit
        {
            get
            {
                return exit ?? (exit = new RelayCommand(x =>
                {
                    MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Вы уверены, что хотите выйти из учетной записи?", "Выход из учетной записи", System.Windows.MessageBoxButton.YesNo);
                    if (messageBoxResult == MessageBoxResult.Yes)
                    {
                        CurrentUser.Exit();
                        Mediator.Notify("LoadAuthorisationPage");
                    }
                }));
            }
        }
    }
}
