using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavilions_WS.Model
{
    public static class AuthorizationCommands
    {
        public static string Authorizate(string login, string pass)
        {
            string error = default;

            try
            {
                using (var context = new PavilionsEntities())
                {
                    var user = context.Staff.FirstOrDefault(empl => empl.Login == login);
                    if (user == null || user.Password != pass)
                        error = "неверная комбинация логин-пароль";
                    else
                    {
                        CurrentUser.FirstName = user.FirstName;
                        CurrentUser.LastName = user.LastName;
                        CurrentUser.Patronymic = user.Patronymic;
                        CurrentUser.Role = user.Role;
                        CurrentUser.ID = user.ID;
                    }
                }
            }
            catch(Exception ex)
            {
                error = ex.ToString();
            }

            return error;
        }
    }
}
