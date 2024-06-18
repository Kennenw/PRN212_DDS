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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DiamondShopSystem.WpfApp.UI
{

    public partial class WViewCustomer : Window
    {
        private readonly CustomerBusiness _business;
        private readonly int _id;
        public WViewCustomer(int id)
        {
            InitializeComponent();
            _business = new CustomerBusiness();
            _id = id;
            LoadCustomerDetails();
        }
        private async void LoadCustomerDetails()
        {
            var result = await _business.GetById(_id);

            if (result.Status > 0 && result.Data != null)
            {
                var customer = result.Data as Customer;
                CustomerId.Text = customer.CustomerId.ToString();
                CustomerName.Text = customer.CustomerName;
                CustomerPhone.Text = customer.Phone;
                CustomerAddress.Text = customer.Address;
                CustomerGender.Text = customer.Gender;
                CustomerEmail.Text = customer.Email;
                ImageUrl.Text = customer.ImgUrl;
                CreateAt.Text = customer.CreateDate.ToString();
                UpdateAt.Text = customer.UpdateTime.ToString();
                IsActive.IsChecked = customer.IsActive;
            }
            else
            {
                MessageBox.Show(result.Message, "Error");
            }
        }
        private async void ButtonClose_Click(object sender, RoutedEventArgs e) 
        {
            this.Close();
        }

    }
}
