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

namespace PROG2500_A2_Chinook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("/Pages/Home.xaml",UriKind.Relative));
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void ViewArtists_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("/Pages/Artists.xaml",UriKind.Relative));
        }

        private void ViewAlbums_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("/Pages/Albums.xaml", UriKind.Relative));
        }

        private void ViewTracks_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("/Pages/Tracks.xaml", UriKind.Relative));
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("/Pages/Home.xaml", UriKind.Relative));
        }

        private void CataloguesButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("/Pages/Catalogue.xaml",UriKind.Relative));
        }

        private void CustomerButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Uri("/Pages/Customer.xaml", UriKind.Relative));
        }
    }
}
