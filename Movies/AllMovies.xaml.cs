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
    /// Interaction logic for AllMovies.xaml
    /// </summary>
    public partial class AllMovies : Page
    {
        MovieAppEntities1 db = new MovieAppEntities1();
        public AllMovies()
        {
            InitializeComponent();
            DGT.ItemsSource = db.Movies.ToList();
        }

        private void Show(object sender, RoutedEventArgs e)
        {
            Movy movy = new Movy();
            int id = int.Parse(IDT.Text);
            var MO = db.Movies.FirstOrDefault(x => x.ID == id);
            MovieDetails detailsmovie = new MovieDetails(MO);
            NavigationService.Navigate(detailsmovie);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void Filter(object sender, RoutedEventArgs e)
        {
            var selectedITtem = combofilter.Text.ToString();
            var movies = db.Movies.Where(m => m.Category == selectedITtem).Select(mv => new { mv.ID, mv.Name, mv.Category, mv.Year });

            if (combofilter.Text == "All")
            {
              DGT.ItemsSource = db.Movies.ToList();
            }
            else
            {
            DGT.ItemsSource = movies.ToList();
            }
        }
    }
}
