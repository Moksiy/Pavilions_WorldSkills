using Pavilions_WS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Pavilions_WS.Model
{
    public class ShoppingCenterElement : BaseViewModel
    {
        private string name;
        private string status;
        private Int32 quantity;
        private string city;
        private double? cost;
        private Int32? floors;
        private double? coefficient;

        public ShoppingCenterElement()
        {

        }

        /// <summary>
        /// Название ТЦ
        /// </summary>
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Статус ТЦ
        /// </summary>
        public string Status
        {
            get => status;
            set
            {
                status = value;
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Количество павильонов
        /// </summary>
        public Int32 Quantity
        {
            get => quantity;
            set
            {
                quantity = value;
                OnPropertyChanged("Quantity");
            }
        }

        /// <summary>
        /// Город
        /// </summary>
        public string City
        {
            get => city;
            set
            {
                city = value;
                OnPropertyChanged("City");
            }
        }

        /// <summary>
        /// Стоимость
        /// </summary>
        public double? Cost
        {
            get => cost;
            set
            {
                if (value != null)
                    cost = (double)value;
                else
                    cost = 0;
                OnPropertyChanged("Cost");
            }
        }

        /// <summary>
        /// Этажность
        /// </summary>
        public Int32? Floors
        {
            get => floors;
            set
            {
                if (Floors != null)
                    floors = (Int32)value;
                else
                    floors = 0;
                OnPropertyChanged("Floors");
            }
        }

        /// <summary>
        /// Добавочный коэффициент
        /// </summary>
        public double? Coefficient
        {
            get => coefficient;
            set
            {
                if (Coefficient != null)
                    coefficient = (double)value;
                else
                    coefficient = 0;
                OnPropertyChanged("Coefficient");
            }
        }
    }
}
