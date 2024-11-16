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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Movies
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        MovieAppEntities1 movie = new MovieAppEntities1();

        public Register()
        {
            InitializeComponent();
        }

        private void NavToLogin(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            NavigationService.Navigate(login);
        }

        private void NavToLogin1(object sender, RoutedEventArgs e)
        {
            User user = new User();

            user.Name = UserT.Text;
            user.Email = EmailT.Text;
            user.Password = ConfPassT.Text;
            movie.Users.Add(user);
            movie.SaveChanges();
            MessageBox.Show("User has been added successfully");

            Login login = new Login();
            NavigationService.Navigate(login);
        }
    }
}
