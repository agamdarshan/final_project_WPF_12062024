using final_project_WPF_12062024.Model;
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
    /// Interaction logic for ManagerView.xaml
    /// </summary>
    public partial class ManagerView : Window
    {
        public ManagerView()
        {
            InitializeComponent();
        }

        private void DeleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            // Hide other elements
            AddQuestionPanel.Visibility = Visibility.Collapsed;
            DatabaseTablesComboBox.Visibility = Visibility.Collapsed;
            DatabaseDataGrid.Visibility = Visibility.Collapsed;

            // Show relevant elements
            UsersComboBox.ItemsSource = UserDataBase.UsersList.Where(u => u.Email != "admin@gmail.com").Select(u => u.Email).ToList();
            UsersComboBox.Visibility = Visibility.Visible;
            ConfirmDeleteUserButton.Visibility = Visibility.Visible;
        }

        private void ConfirmDeleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedEmail = UsersComboBox.SelectedItem as string;
            if (selectedEmail != null)
            {
                var userToDelete = UserDataBase.UsersList.FirstOrDefault(u => u.Email == selectedEmail);
                if (userToDelete != null)
                {
                    UserDataBase.UsersList.Remove(userToDelete);
                    MessageBox.Show("User deleted successfully.");
                    UsersComboBox.ItemsSource = UserDataBase.UsersList.Where(u => u.Email != "admin@gmail.com").Select(u => u.Email).ToList();
                }
            }
        }

        private void AddQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            // Hide other elements
            UsersComboBox.Visibility = Visibility.Collapsed;
            ConfirmDeleteUserButton.Visibility = Visibility.Collapsed;
            DatabaseTablesComboBox.Visibility = Visibility.Collapsed;
            DatabaseDataGrid.Visibility = Visibility.Collapsed;

            // Show relevant elements
            AddQuestionPanel.Visibility = Visibility.Visible;
        }

        private void ConfirmAddQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            string answer = AnswerTextBox.Text;
            string option1 = Option1TextBox.Text;
            string option2 = Option2TextBox.Text;
            string option3 = Option3TextBox.Text;
            string option4 = Option4TextBox.Text;

            if (answer != option1 && answer != option2 && answer != option3 && answer != option4)
            {
                MessageBox.Show("The answer must be one of the options.");
                return;
            }

            var newQuestion = new GameDataModel
            {
                Question = QuestionTextBox.Text,
                Option1 = Option1TextBox.Text,
                Option2 = Option2TextBox.Text,
                Option3 = Option3TextBox.Text,
                Option4 = Option4TextBox.Text,
                Answer = AnswerTextBox.Text,
                Level = (LevelComboBox.SelectedItem as ComboBoxItem)?.Content.ToString()
            };

            GameDataBase.QuestionsList.Add(newQuestion);
            MessageBox.Show("Question added successfully.");
            ClearAddQuestionForm();
        }

        private void ClearAddQuestionForm()
        {
            QuestionTextBox.Clear();
            Option1TextBox.Clear();
            Option2TextBox.Clear();
            Option3TextBox.Clear();
            Option4TextBox.Clear();
            AnswerTextBox.Clear();
            LevelComboBox.SelectedIndex = -1;
            AddQuestionPanel.Visibility = Visibility.Collapsed;
        }

        private void ShowDatabaseTablesButton_Click(object sender, RoutedEventArgs e)
        {
            // Hide other elements
            UsersComboBox.Visibility = Visibility.Collapsed;
            ConfirmDeleteUserButton.Visibility = Visibility.Collapsed;
            AddQuestionPanel.Visibility = Visibility.Collapsed;

            // Show relevant elements
            DatabaseTablesComboBox.Visibility = Visibility.Visible;
        }

        private void DatabaseTablesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DatabaseTablesComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                switch (selectedItem.Content.ToString())
                {
                    case "Users":
                        DatabaseDataGrid.ItemsSource = UserDataBase.UsersList;
                        break;
                    case "Questions":
                        DatabaseDataGrid.ItemsSource = GameDataBase.QuestionsList;
                        break;
                    case "Game Points":
                        DatabaseDataGrid.ItemsSource = UserGamePointsDataBase.GamePointsHistory;
                        break;
                }
                DatabaseDataGrid.Visibility = Visibility.Visible;
            }
        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            Login loginView = new Login();
            loginView.Show();
            this.Close();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
