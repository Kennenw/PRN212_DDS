using DiamondShopSystem.Business;
using DiamondShopSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
    /// <summary>
    /// Interaction logic for WCustomer.xaml
    /// </summary>
    public partial class WCustomer : Window
    {
        private readonly CustomerBusiness _business;

        public WCustomer()
        {
            InitializeComponent();
            this._business ??= new CustomerBusiness();    
            this.LoadGrdCustomer();
        }
        private async void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int idd = -1;
                int .TryParse(CustomerId.Text, out idd);
                var item = await _business.GetById(idd);

                if (item.Data == null)
                {
                    var customer = new Customer()
                    {
                        //CustomerId = int.Parse(CustomerId.Text),
                        CustomerName = CustomerName.Text,
                        Phone = Phone.Text,
                        Address = Address.Text,
                        Email = Email.Text,
                        Password = Password.Text,
                    };

                    var result = await _business.Save(customer);
                    MessageBox.Show(result.Message, "Save");
                }
                else
                {
                    var customer = item.Data as Customer;
                    //customer.CustomerId = int.Parse(CustomerId.Text);
                    customer.CustomerName = CustomerName.Text;
                    customer.Phone = Phone.Text;
                    customer.Address = Address.Text;
                    customer.Email = Email.Text;
                    customer.Password = Password.Text;

                    var result = await _business.Update(customer);
                    MessageBox.Show(result.Message, "Update");
                }
                CustomerId.Text = string.Empty;
                CustomerName.Text = string.Empty;
                Phone.Text = string.Empty;
                Address.Text = string.Empty;
                Email.Text = string.Empty;
                Password.Text = string.Empty;
                this.LoadGrdCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }


        private async void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {

        }
        private async void grdCustomer_ButtonDelete_Click(object sender, RoutedEventArgs e)
        {

        }
        private async void grdCustomer_MouseDouble_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Double Click on Grid");
            DataGrid grd = sender as DataGrid;
            if (grd != null && grd.SelectedItems != null && grd.SelectedItems.Count == 1)
            {
                var row = grd.ItemContainerGenerator.ContainerFromItem(grd.SelectedItem) as DataGridRow;
                if (row != null)
                {
                    var item = row.Item as Customer;
                    if (item != null)
                    {
                        var customerResult = await _business.GetById(item.CustomerId);

                        if (customerResult.Status > 0 && customerResult.Data != null)
                        {
                            item = customerResult.Data as Customer;
                            CustomerId.Text = item.CustomerId.ToString();
                            CustomerName.Text = item.CustomerName;
                            Phone.Text = item.Phone;
                            Address.Text = item.Address;
                            Email.Text = item.Email;
                            Password.Text = item.Password;
                        }
                    }
                }
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
    }
}
