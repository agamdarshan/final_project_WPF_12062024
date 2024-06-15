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
    /// Interaction logic for GameView.xaml
    /// </summary>
    public partial class GameView : Window
    {
        private List<GameDataModel> questions;
        private int currentQuestionIndex;
        private int totalPoints;
        private GameDataModel currentQuestion;
        private Random random;
        private List<GameDataModel> selectedQuestions;
        private string userEmail;
        private string userName;

        public GameView(string email)
        {
            InitializeComponent();
            random = new Random();
            userEmail = email;
            userName = UserDataBase.UsersList.FirstOrDefault(u => u.Email == email)?.FirstName; // Assuming UserDataBase contains user names
            LoadQuestions();
            StartGame();
            DisplayUserName();
        }

        private void LoadQuestions()
        {
            questions = GameDataBase.QuestionsList;
        }

        private void StartGame()
        {
            currentQuestionIndex = 0;
            totalPoints = 0;
            selectedQuestions = new List<GameDataModel>();

            for (int i = 1; i <= 5; i++)
            {
                var level = $"רמה {i}";
                var levelQuestions = questions.Where(q => q.Level == level).ToList();
                selectedQuestions.Add(levelQuestions[random.Next(levelQuestions.Count)]);
            }

            ShowNextQuestion();
        }

        private void DisplayUserName()
        {
            UserNameTextBlock.Text = $"User: {userName}";
        }

        private void ShowNextQuestion()
        {
            if (currentQuestionIndex < selectedQuestions.Count)
            {
                currentQuestion = selectedQuestions[currentQuestionIndex];

                QuestionTextBlock.Text = currentQuestion.Question;
                LevelTextBlock.Text = $"Level: {currentQuestion.Level}";
                Option1RadioButton.Content = currentQuestion.Option1;
                Option2RadioButton.Content = currentQuestion.Option2;
                Option3RadioButton.Content = currentQuestion.Option3;
                Option4RadioButton.Content = currentQuestion.Option4;

                ClearSelectionAndBorders();

                currentQuestionIndex++;
                QuestionIndicatorTextBlock.Text = $"Question {currentQuestionIndex}/5";
                NextQuestionButton.Visibility = Visibility.Collapsed;
                SubmitButton.Visibility = Visibility.Visible;
            }
            else
            {
                // Save the user's game results
                var newGameResult = new UserGamePointsModel
                {
                    Email = userEmail,
                    GamePoints = totalPoints.ToString(),
                    GameDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                };

                UserGamePointsDataBase.GamePointsHistory.Add(newGameResult);

                MessageBox.Show($"Game over! Your total points: {totalPoints}");
                EndGameView endGameView = new EndGameView(userEmail, totalPoints);
                endGameView.Show();
                this.Close();
            }
        }

        private void ClearSelectionAndBorders()
        {
            Option1RadioButton.IsChecked = false;
            Option2RadioButton.IsChecked = false;
            Option3RadioButton.IsChecked = false;
            Option4RadioButton.IsChecked = false;

            Option1RadioButton.BorderBrush = null;
            Option2RadioButton.BorderBrush = null;
            Option3RadioButton.BorderBrush = null;
            Option4RadioButton.BorderBrush = null;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedOption = null;

            if (Option1RadioButton.IsChecked == true) selectedOption = Option1RadioButton.Content.ToString();
            else if (Option2RadioButton.IsChecked == true) selectedOption = Option2RadioButton.Content.ToString();
            else if (Option3RadioButton.IsChecked == true) selectedOption = Option3RadioButton.Content.ToString();
            else if (Option4RadioButton.IsChecked == true) selectedOption = Option4RadioButton.Content.ToString();

            if (selectedOption == currentQuestion.Answer)
            {
                totalPoints += currentQuestionIndex;
                PointsTextBlock.Text = $"Points: {totalPoints}";
                MessageBox.Show("Correct Answer!");
                HighlightCorrectAnswer(Brushes.Green);
            }
            else
            {
                MessageBox.Show("Wrong Answer!");
                HighlightCorrectAnswer(Brushes.Green);
                HighlightSelectedAnswer(selectedOption, Brushes.Red);
            }

            NextQuestionButton.Visibility = Visibility.Visible;
            SubmitButton.Visibility = Visibility.Collapsed;
        }

        private void HighlightCorrectAnswer(Brush color)
        {
            if (Option1RadioButton.Content.ToString() == currentQuestion.Answer) Option1RadioButton.BorderBrush = color;
            else if (Option2RadioButton.Content.ToString() == currentQuestion.Answer) Option2RadioButton.BorderBrush = color;
            else if (Option3RadioButton.Content.ToString() == currentQuestion.Answer) Option3RadioButton.BorderBrush = color;
            else if (Option4RadioButton.Content.ToString() == currentQuestion.Answer) Option4RadioButton.BorderBrush = color;
        }

        private void HighlightSelectedAnswer(string selectedOption, Brush color)
        {
            if (Option1RadioButton.Content.ToString() == selectedOption) Option1RadioButton.BorderBrush = color;
            else if (Option2RadioButton.Content.ToString() == selectedOption) Option2RadioButton.BorderBrush = color;
            else if (Option3RadioButton.Content.ToString() == selectedOption) Option3RadioButton.BorderBrush = color;
            else if (Option4RadioButton.Content.ToString() == selectedOption) Option4RadioButton.BorderBrush = color;
        }

        private void NextQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            ShowNextQuestion();
        }
    }
}
