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
    /// Interaction logic for Tracks.xaml
    /// </summary>
    public partial class Tracks : Page
    {
        ChinookContext _context = new ChinookContext();
        CollectionViewSource tracksViewSource = new CollectionViewSource();
        public Tracks()
        {
            InitializeComponent();
            tracksViewSource = (CollectionViewSource)FindResource(nameof(tracksViewSource));

            _context.Tracks.Load();

            //Set the viewsource data source to use the artist data collection
            tracksViewSource.Source = _context.Tracks.Local.ToObservableCollection();
        }
        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            //ignore case by normalising to lower
            string searchTerm = searchBox.Text.ToLower();

            var trackQuery = from track in _context.Tracks.Local
                              where track.Name.ToLower().Contains(searchTerm)
                              select track;

            var tracks = trackQuery.ToList();
            var observableTracks = new ObservableCollection<Track>(tracks);

            // Update the view source with the new observable collection
            tracksViewSource.Source = observableTracks;
        }
    }
}
