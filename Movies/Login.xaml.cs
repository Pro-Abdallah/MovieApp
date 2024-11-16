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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        MovieAppEntities1 movie = new MovieAppEntities1();  
        public Login()
        {
            InitializeComponent();
        }

        private void NavToRegister(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            NavigationService.Navigate(register);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            User user = new User();
            AllMovies movies = new AllMovies();

            user = movie.Users.FirstOrDefault(x => x.Name == UserTT.Text && x.Password == PassTT.Text);
            if (user != null)
            {
                NavigationService.Navigate(movies);
            }
            else if (UserTT.Text == "Abdallah" && PassTT.Text == "O@1234")
            {
                NavigationService.Navigate(admin);
            }
            else
            {
                MessageBox.Show("Wrong username of password");
            }
        }

        private void NavToForgPass(object sender, RoutedEventArgs e)
        {
            ForgetPass forget = new ForgetPass();
            NavigationService.Navigate(forget);
        }
    }
}
