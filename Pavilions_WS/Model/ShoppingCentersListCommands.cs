using Pavilions_WS.Logic;
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
        public static void AddNew()
        {
            Mediator.Notify("");
        }

        public static string Remove(ShoppingCenterElement elem)
        {
            string error = default;
            try
            {
                using(var context = new PavilionsEntities())
                {
                    ShoppingCenters pavilion = context.ShoppingCenters.Where(o => o.ID == elem.Number).FirstOrDefault();

                    context.ShoppingCenters.Remove(pavilion);

                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                error = ex.ToString();
            }
            return error;
        }

        public static ObservableCollection<ShoppingCenterElement> GetSC()
        {
            ObservableCollection<ShoppingCenterElement> result = new ObservableCollection<ShoppingCenterElement>();

            try
            {
                using (var context = new PavilionsEntities())
                {
                    var centers = (from scenters in context.ShoppingCenters
                                  join cities in context.Cities on scenters.City equals cities.Code
                                  join statuses in context.Statuses on scenters.Status equals statuses.ID
                                  select new
                                  {
                                      scenters.Name,
                                      statuses.Status,
                                      scenters.Quantity,
                                      cities.City,
                                      scenters.Cost,
                                      scenters.Floors,
                                      scenters.Coefficient,
                                      scenters.ID
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
                            Coefficient = (double?)item.Coefficient,
                            Number = item.ID
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
