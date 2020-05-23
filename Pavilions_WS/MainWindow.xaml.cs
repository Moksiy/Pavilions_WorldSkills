using Pavilions_WS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pavilions_WS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Мать его MVVM
        public MainWindow()
        {
            InitializeComponent();

            using (var context = new PavilionsContext())
            {
                string sos = "";
                foreach(var item in context.Pavilions)
                {
                    sos += item.Name + " " + item.Status + "\n";
                }
                MessageBox.Show(sos);
            }
        }
    }
}
