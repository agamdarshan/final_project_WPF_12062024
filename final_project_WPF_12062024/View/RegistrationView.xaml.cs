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
    /// Interaction logic for RegistrationView.xaml
    /// </summary>
    public partial class RegistrationView : Window
    {

        public UserDataModel User { get; set; }

        public RegistrationView()
        {
            InitializeComponent();
            User = new UserDataModel();
            DataContext = User;
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateInputs())
            {
                // Add user to UserDataBase
                UserDataBase.UsersList.Add(User);
                MessageBox.Show("User Registered Successfully!");

                Login login = new Login();
                login.Show();
                this.Close();


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

            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                MessageBox.Show("First name cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                MessageBox.Show("Last name cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(PhoneTextBox.Text))
            {
                MessageBox.Show("Phone cannot be empty.");
                return false;
            }

            if (!int.TryParse(AgeTextBox.Text, out int age) || age < 0)
            {
                MessageBox.Show("Please enter a valid age.");
                return false;
            }

            return true;
        }

        private void AgeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

    
}
