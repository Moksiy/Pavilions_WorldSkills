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
        public ShoppingCentersListViewModel()
        {
            centers = ShoppingCentersListCommands.GetSC();
        }

        ObservableCollection<ShoppingCenterElement> centers;

        public ObservableCollection<ShoppingCenterElement> Centers
        {
            get
            {
                return centers;
            }
            set
            {
                centers = value;
                OnPropertyChanged("Centers");
            }
        }

        private ICommand addnew;
        public ICommand AddNew
        {
            get
            {
                return addnew ?? (addnew = new RelayCommand(x =>
                {
                    ShoppingCentersListCommands.AddNew();
                }));
            }
        }


        private ICommand remove;
        public ICommand RemoveCommand
        {
            get
            {
                if (remove == null)
                {
                    remove = new DelegateCommand(CanExecute, Execute);
                }
                return remove;
            }
        }

        private void Execute(object parameter)
        {
            int index = Centers.IndexOf(parameter as ShoppingCenterElement);
            if (index > -1 && index < Centers.Count)
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Вы уверены, что хотите удалить торговый центр из списка?", "Удаление", System.Windows.MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    string message = ShoppingCentersListCommands.Remove(Centers[index]);
                    if (String.IsNullOrEmpty(message))
                        Centers.RemoveAt(index);
                    else
                        MessageBox.Show(message);
                }
            }
        }

        private bool CanExecute(object parameter)
        {
            return true;
        }

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
