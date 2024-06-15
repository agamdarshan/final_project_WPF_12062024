using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project_WPF_12062024.Model
{
    public class GameDataModel : INotifyPropertyChanged
    {
        private string question;
        private string option1;
        private string option2;
        private string option3;
        private string option4;
        private string answer;
        private string level;

        public string Question
        {
            get { return question; }
            set { question = value; OnPropertyChanged(nameof(Question)); }
        }

        public string Option1
        {
            get { return option1; }
            set { option1 = value; OnPropertyChanged(nameof(Option1)); }
        }

        public string Option2
        {
            get { return option2; }
            set { option2 = value; OnPropertyChanged(nameof(Option2)); }
        }

        public string Option3
        {
            get { return option3; }
            set { option3 = value; OnPropertyChanged(nameof(Option3)); }
        }

        public string Option4
        {
            get { return option4; }
            set { option4 = value; OnPropertyChanged(nameof(Option4)); }
        }

        public string Answer
        {
            get { return answer; }
            set { answer = value; OnPropertyChanged(nameof(Answer)); }
        }

        public string Level
        {
            get { return level; }
            set { level = value; OnPropertyChanged(nameof(Level)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
