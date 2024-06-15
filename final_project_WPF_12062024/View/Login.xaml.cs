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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public UserDataModel User { get; set; }
        private MediaPlayer mediaPlayer;

        public Login()
        {
            InitializeComponent();
            User = new UserDataModel();
            DataContext = User;

            // Initialize MediaPlayer
            mediaPlayer = new MediaPlayer();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateInputs())
            {
                var user = UserDataBase.UsersList.FirstOrDefault(u => u.Email == EmailTextBox.Text && u.Password == PasswordTextBox.Text);

                if (user != null)
                {
                    // Play the login success sound
                    PlayLoginSound();

                    if (user.Email == "admin@gmail.com")
                    {
                        MessageBox.Show("Admin succeeded login.");
                        ManagerView managerView = new ManagerView();
                        managerView.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Regular user succeeded login.");
                        // Navigate to GameView and pass the user's email
                        GameView gameView = new GameView(user.Email);
                        gameView.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password.");
                }
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MessageBox.Show("Email cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Password cannot be empty.");
                return false;
            }

            return true;
        }
        private void RegisterRedirectButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationView registrationView = new RegistrationView();
            registrationView.Show();
            this.Close();
        }

        private void PlayLoginSound()
        {
            string soundFilePath = @"C:\Users\User\source\repos\final_project_WPF_12062024\final_project_WPF_12062024\short-1-slow-196420.mp3";
            mediaPlayer.Open(new System.Uri(soundFilePath));
            mediaPlayer.Play();
        }
    }
}
