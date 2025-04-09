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

namespace Week12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MovieData db = new MovieData();
        public MainWindow()
        {
            InitializeComponent();

            foreach(Movie movie in db.Movies)
            {
                lbxDisplayMovies.Items.Add(movie);
            }
        }

        private void lbxDisplayMovies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lbxDisplayMovies.SelectedItem != null)
            {
                //string movieTitle = lbxDisplayMovies.SelectedItem.ToString();

                //var movie = db.Movies.FirstOrDefault(x => x.Title == movieTitle);

                //tblSynopsis.Text = movie.Description;
                Movie movie = lbxDisplayMovies.SelectedItem as Movie;

                tblSynopsis.Text = movie.Description;
            }
        }
    }
}
