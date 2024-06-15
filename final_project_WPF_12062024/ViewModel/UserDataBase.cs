using final_project_WPF_12062024.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project_WPF_12062024.ViewModel
{
    public class UserDataBase
    {
        private static List<UserDataModel> _usersList = new List<UserDataModel>
        {
            new UserDataModel
            {
                Email = "admin@gmail.com",
                Password = "admin",
                FirstName = "Admin",
                LastName = "Admin",
                Phone = "123-456-7890",
                Age = 35
            },
            new UserDataModel
            {
                Email = "agam@gmail.com",
                Password = "agam",
                FirstName = "Agam",
                LastName = "Darshan",
                Phone = "098-765-4321",
                Age = 18
            },
            new UserDataModel
            {
                Email = "david@gmail.com",
                Password = "david123",
                FirstName = "David",
                LastName = "Levi",
                Phone = "111-222-3333",
                Age = 45
            },
            new UserDataModel
            {
                Email = "sara@gmail.com",
                Password = "sara456",
                FirstName = "Sara",
                LastName = "Cohen",
                Phone = "444-555-6666",
                Age = 30
            },
            new UserDataModel
            {
                Email = "michael@gmail.com",
                Password = "michael789",
                FirstName = "Michael",
                LastName = "Rosen",
                Phone = "777-888-9999",
                Age = 28
            },
            new UserDataModel
            {
                Email = "rachel@gmail.com",
                Password = "rachel321",
                FirstName = "Rachel",
                LastName = "Gavriel",
                Phone = "000-111-2222",
                Age = 23
            }
        };


        // Property to access the users list
        public static List<UserDataModel> UsersList
        {
            get { return _usersList; }
            set { _usersList = value; }
        }
    }
}
