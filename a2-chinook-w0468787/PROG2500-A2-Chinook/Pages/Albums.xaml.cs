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
    /// Interaction logic for Albums.xaml
    /// </summary>
    public partial class Albums : Page
    {
        //instatiate context and view source 
        ChinookContext _context = new ChinookContext();
        CollectionViewSource albumViewSource = new CollectionViewSource();
        public Albums()
        {
            InitializeComponent();
            //connect xaml and cs view sources
            albumViewSource = (CollectionViewSource)FindResource(nameof(albumViewSource));

            //Load from generated models
            _context.Albums.Load();

            //set viewsource data source to albums collection
            albumViewSource.Source = _context.Albums.Local.ToObservableCollection();


        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = searchBox.Text;
            var albumsQuery = from album in _context.Albums.Local
                              where album.Title.Contains(searchTerm)
                              select album;

            var albums = albumsQuery.ToList();
            var observableAlbums = new ObservableCollection<Album>(albums);

            // Update the view source with the new observable collection
            albumViewSource.Source = observableAlbums;
        }
    }
}
