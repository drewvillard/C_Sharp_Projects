using Microsoft.EntityFrameworkCore;
using PROG2500_A3_Chinook_Linq.Data;
using PROG2500_A3_Chinook_Linq.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PROG2500_A2_Chinook.Pages
{
    /// <summary>
    /// Interaction logic for Artists.xaml
    /// </summary>
    public partial class Artists : Page
    {
        ChinookContext _context = new ChinookContext();
        CollectionViewSource artistViewSource = new CollectionViewSource();
        public Artists()
        {
            InitializeComponent();
            artistViewSource = (CollectionViewSource)FindResource(nameof(artistViewSource));

            _context.Artists.Load();  //Use the dbContext to tell EF to load the data we'll use on this page

            //Set the viewsource data source to use the artist data collection
            artistViewSource.Source = _context.Artists.Local.ToObservableCollection();
        }
        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = searchBox.Text;
           
            var artistQuery = from artist in _context.Artists.Local
                              where artist.Name.Contains(searchTerm)
                              select artist;

            var artists = artistQuery.ToList();
            var observableArtists = new ObservableCollection<Artist>(artists);

            // Update the view source with the new observable collection
            artistViewSource.Source = observableArtists;
        }
    }
}
