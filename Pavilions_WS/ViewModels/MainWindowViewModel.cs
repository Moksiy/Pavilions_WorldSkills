using Pavilions_WS.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavilions_WS.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;

        public string UserLogin { get; set; }
        public string UserPassword { get; set; }

        /// <summary>
        /// Список страниц
        /// </summary>
        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IPageViewModel>();
                return _pageViewModels;
            }
        }

        /// <summary>
        /// Текущая страница
        /// </summary>
        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                _currentPageViewModel = value;
                OnPropertyChanged("CurrentPageViewModel");
            }
        }

        /// <summary>
        /// Смена текущей страницы
        /// </summary>
        /// <param name="viewModel"></param>
        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }

        /// <summary>
        /// Заргузка страницы авторизации
        /// </summary>
        /// <param name="obj"></param>
        private void LoadAuthorisationPage(object obj)
        {
            ChangeViewModel(PageViewModels[0]);
        }


        public MainWindowViewModel()
        {
            // Добавлем все странички
            PageViewModels.Add(new AuthorizationViewModel());
            //PageViewModels.Add(new UserControl2ViewModel());

            CurrentPageViewModel = PageViewModels[0];

            Mediator.Subscribe("LoadAuthorisationPage", LoadAuthorisationPage);
            //Mediator.Subscribe("GoTo2Screen", OnGo2Screen);
        }
    }
}

