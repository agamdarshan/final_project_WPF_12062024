using final_project_WPF_12062024.ViewModel;
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
using System.Windows.Shapes;

namespace final_project_WPF_12062024.View
{
    /// <summary>
    /// Interaction logic for EndGameView.xaml
    /// </summary>
    public partial class EndGameView : Window
    {
        private string userEmail;
        private int finalScore;
        private string userName;

        public EndGameView(string email, int score)
        {
            InitializeComponent();
            userEmail = email;
            finalScore = score;
            userName = UserDataBase.UsersList.FirstOrDefault(u => u.Email == email)?.FirstName; // Assuming UserDataBase contains user names

            DisplayUserData();
        }

        private void DisplayUserData()
        {
            FinalScoreTextBlock.Text = $"Final Score: {finalScore}";
            UserNameTextBlock.Text = $"User: {userName}";
        }

        private void EndGameButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ShowResultsButton_Click(object sender, RoutedEventArgs e)
        {
            var userResults = UserGamePointsDataBase.GamePointsHistory.Where(g => g.Email == userEmail).ToList();
            ResultsDataGrid.ItemsSource = userResults;
            ResultsDataGrid.Visibility = Visibility.Visible;
        }

        private void PlayAgainButton_Click(object sender, RoutedEventArgs e)
        {
            GameView gameView = new GameView(userEmail);
            gameView.Show();
            this.Close();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Login loginView = new Login();
            loginView.Show();
            this.Close();
        }
    }
}
