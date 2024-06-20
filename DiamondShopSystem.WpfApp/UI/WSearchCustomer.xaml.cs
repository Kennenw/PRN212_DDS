using DiamondShopSystem.Business;
using DiamondShopSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DiamondShopSystem.WpfApp.UI
{
    /// <summary>
    /// Interaction logic for WSearchCustomer.xaml
    /// </summary>
    public partial class WSearchCustomer : Window
    {
        private readonly CustomerBusiness _business;

        public WSearchCustomer()
        {
            InitializeComponent();
            _business ??= new CustomerBusiness();
            DataContext = this;
        }

        private async void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            string name = CustomerName.Text.ToLower();
            string phone = Phone.Text;
            string address = Address.Text.ToLower();
            string gender = Gender.Text.ToLower();
            string email = Email.Text.ToLower();
            bool? isActive = IsActive.IsChecked;

            var searchResults = await _business.SearchCustomers(name, phone, gender, address, email, isActive);
            if (searchResults.Status > 0 && searchResults.Data != null)
            {
                grdCustomer.ItemsSource = searchResults.Data as List<Customer>;
            }
            else
            {
                MessageBox.Show(searchResults.Message, "Search");
                grdCustomer.ItemsSource = new List<Customer>();
            }
        }

        private async void ButtonViewDetail_Click(object sender, RoutedEventArgs e)
        {
            if (grdCustomer.SelectedItem is Customer selectedCustomer)
            {
                var customerDetail = new WViewCustomer(selectedCustomer.CustomerId);
                customerDetail.ShowDialog();
            }
            else
            {
                MessageBox.Show("No customer selected to view details.", "Error");
            }
        }

        private async void LoadGrdCustomer()
        {
            var result = await _business.GetAll();

            if (result.Status > 0 && result.Data != null)
            {
                grdCustomer.ItemsSource = result.Data as List<Customer>;
            }
            else
            {
                grdCustomer.ItemsSource = new List<Customer>();
            }


        }


        private async void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            var customerWindow = new WCustomer();
            customerWindow.ShowDialog();
            LoadGrdCustomer();
        }


        private async void grdCustomer_MouseDouble_Click(object sender, MouseButtonEventArgs e)
        {
           if(sender is DataGrid grid) 
           {
                var customer = grid.SelectedItem as Customer;
                if (customer != null)
                {
                    var customerView = new WCustomer(customer.CustomerId);
                    customerView.ShowDialog();

                }
            }
            
        }

    }
}
