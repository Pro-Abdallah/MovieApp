using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for ForgetPass.xaml
    /// </summary>
    public partial class ForgetPass : Page
    {
        MovieAppEntities1 mv = new MovieAppEntities1();
        public ForgetPass()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User use = new User();

            var Email = em.Text;
            use = mv.Users.FirstOrDefault(m => m.Email == Email);

            if (use != null)
            {
                use.Password = pass.Text;
                mv.Users.AddOrUpdate(use);
                mv.SaveChanges();
                MessageBox.Show("Password has changed successfully!");
            }
        }
    }
}
