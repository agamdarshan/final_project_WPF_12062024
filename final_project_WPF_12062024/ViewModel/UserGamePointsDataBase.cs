using final_project_WPF_12062024.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project_WPF_12062024.ViewModel
{
    public class UserGamePointsDataBase
    {
        private static List<UserGamePointsModel> _gamePointsHistory = new List<UserGamePointsModel>
        {
            new UserGamePointsModel
            {
                Email = "admin@gmail.com",
                GamePoints = "10",
                GameDate = new DateTime(2024, 1, 15, 14, 30, 0).ToString("yyyy-MM-dd HH:mm:ss")
            },
            new UserGamePointsModel
            {
                Email = "agam@gmail.com",
                GamePoints = "15",
                GameDate = new DateTime(2024, 2, 10, 9, 45, 0).ToString("yyyy-MM-dd HH:mm:ss")
            },
            new UserGamePointsModel
            {
                Email = "david@gmail.com",
                GamePoints = "12",
                GameDate = new DateTime(2024, 3, 20, 18, 0, 0).ToString("yyyy-MM-dd HH:mm:ss")
            },
            new UserGamePointsModel
            {
                Email = "sara@gmail.com",
                GamePoints = "8",
                GameDate = new DateTime(2024, 4, 5, 11, 15, 0).ToString("yyyy-MM-dd HH:mm:ss")
            },
            new UserGamePointsModel
            {
                Email = "michael@gmail.com",
                GamePoints = "6",
                GameDate = new DateTime(2024, 5, 22, 16, 50, 0).ToString("yyyy-MM-dd HH:mm:ss")
            },
            new UserGamePointsModel
            {
                Email = "rachel@gmail.com",
                GamePoints = "7",
                GameDate = new DateTime(2024, 6, 18, 10, 5, 0).ToString("yyyy-MM-dd HH:mm:ss")
            }
        };

        // Property to access the game points history list
        public static List<UserGamePointsModel> GamePointsHistory
        {
            get { return _gamePointsHistory; }
            set { _gamePointsHistory = value; }
        }
    }
}
