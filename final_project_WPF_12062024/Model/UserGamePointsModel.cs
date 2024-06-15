using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project_WPF_12062024.Model
{
    public class UserGamePointsModel : INotifyPropertyChanged
    {
        private string email;
        private string gamePoints;
        private string gameDate;

        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(nameof(Email)); }
        }

        public string GamePoints
        {
            get { return gamePoints; }
            set { gamePoints = value; OnPropertyChanged(nameof(GamePoints)); }
        }

        public string GameDate
        {
            get { return gameDate; }
            set { gameDate = value; OnPropertyChanged(nameof(GameDate)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
