using DiamondShopSystem.Business;
using DiamondShopSystem.Data.Models;
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
using System.Windows.Shapes;

namespace DiamondShopSystem.WpfApp.UI
{

    public partial class WViewCustomer : Window
    {
        private readonly CustomerBusiness _business;
        public WViewCustomer(int id)
        {
            InitializeComponent();
            LoadCustomerDetails(id);
        }
        private async void LoadCustomerDetails(int customerId)
        {
            var result = await _business.GetById(customerId);
            if (result.Status > 0 && result.Data != null)
            {
                var customer = result.Data as Customer;
                if (customer != null)
                {
                    CustomerId.Text = customer.CustomerId.ToString();
                    CustomerName.Text = customer.CustomerName;
                    Phone.Text = customer.Phone;
                    Address.Text = customer.Address;
                    Email.Text = customer.Email;
                    Password.Text = customer.Password;
                    ImgUrl.Text = customer.ImgUrl;
                    CreateDate.Text = customer.CreateDate?.ToString("g");
                    Gender.Text = customer.Gender;
                    IsActive.IsChecked = customer.IsActive;
                    UpdateTime.Text = customer.UpdateTime?.ToString("g");
                }
            }
            else
            {
                MessageBox.Show(result.Message, "Error");
                this.Close();
            }
        }

        private async void ButtonClose_Click(object sender, RoutedEventArgs e) 
        {
            this.Close();
        }

    }
}
