using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace Pavilions_WS.Model
{
    public static class ShoppingCentersListCommands
    {
        public static ObservableCollection<ShoppingCenterElement> GetSC()
        {
            ObservableCollection<ShoppingCenterElement> result = new ObservableCollection<ShoppingCenterElement>();

            try
            {
                using (var context = new PavilionsContext())
                {
                    var centers = (from scenters in context.ShoppingCenters
                                  join cities in context.Cities on scenters.City equals cities.Code
                                  join statuses in context.Statuses on scenters.Status equals statuses.ID
                                  select new
                                  {
                                      Name = scenters.Name,
                                      Status = statuses.Status,
                                      Quantity = scenters.Quantity,
                                      City = cities.City,
                                      Cost = scenters.Cost,
                                      Floors = scenters.Floors,
                                      Coefficient = scenters.Coefficient
                                  }).ToList();
                    foreach (var item in centers)
                    {
                        result.Add(new ShoppingCenterElement
                        {
                            Name = item.Name,
                            Status = item.Status,
                            Quantity = item.Quantity,
                            City = item.City,
                            Cost = (double?)item.Cost,
                            Floors = (Int32?)item.Floors,
                            Coefficient = (double?)item.Coefficient
                        });
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return result;
        }
    }
}
