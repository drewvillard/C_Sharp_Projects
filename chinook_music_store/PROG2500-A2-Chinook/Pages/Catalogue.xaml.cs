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
    /// Interaction logic for catalogue.xaml
    /// </summary>
    public partial class catalogue : Page
    {
        ChinookContext _context = new ChinookContext();
        CollectionViewSource catalogueViewSource = new CollectionViewSource();
        public catalogue()
        {
            InitializeComponent();
            catalogueViewSource = (CollectionViewSource)FindResource(nameof(catalogueViewSource));

            _context.Artists.Load();
            _context.Albums.Load();
            _context.Tracks.Load();

            //Set the viewsource data source to use the artist data collection
            catalogueViewSource.Source = _context.Artists.Local.ToObservableCollection();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            //ignore case by normalising to lower
         string searchTerm = searchBox.Text.ToLower();
         var catalogueQuery = from artist in _context.Artists.Local
                            group artist by artist.Name.ToUpper().Substring(0,1) into artistGroup
                            select new
                             {
                                Index = artistGroup.Key,
                                artistCount = artistGroup.Count().ToString(),
                                artist = artistGroup.ToList<Artist>()
                             };
             

        catalogueListView.ItemsSource= catalogueQuery.ToList();
            
        }
    }
}
