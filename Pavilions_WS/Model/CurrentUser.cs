using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavilions_WS.Model
{
    public static class CurrentUser
    {
        public static string LastName { get; set; }
        public static string FirstName { get; set; }
        public static string Patronymic { get; set; }
        public static string Role { get; set; }
        public static string Phone { get; set; }
        public static string Gender { get; set; }
        public static int ID { get; set; }
        public static byte[] Photo { get; set; }

        public static void Exit()
        {
            LastName = "";
            FirstName = "";
            Patronymic = "";
            Role = "";
            Phone = "";
            Gender = "";
            ID = default;
            Photo = default;
        }
    }
}
