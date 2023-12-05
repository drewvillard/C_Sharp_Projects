using Microsoft.EntityFrameworkCore;
using PROG2500_A3_Chinook_Linq.Data;
using PROG2500_A3_Chinook_Linq.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
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
    /// Interaction logic for Customer.xaml
    /// </summary>
    public partial class Customer : Page
    {
        ChinookContext _context = new ChinookContext();
        CollectionViewSource customerViewSource = new CollectionViewSource();
        

        public Customer()
        {
            InitializeComponent();
            customerViewSource = (CollectionViewSource)FindResource(nameof(customerViewSource));

            _context.Customers.Load();
            _context.Invoices.Load();

           // customerViewSource.Source = _context.Customers.Local.ToObservableCollection();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {   //ignore case by normalizing to lower
            string searchTerm = searchBox.Text.ToLower();

            var customerQuery = from customer in _context.Customers.Local
                               where customer.LastName.ToLower().Contains(searchTerm)
                               select customer;
         
             var customers = customerQuery.ToList();

            customerListView.ItemsSource = customers;
           
        }
    }
}
