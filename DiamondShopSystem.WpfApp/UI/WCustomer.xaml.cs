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

        public WCustomer(int id)
        {
            InitializeComponent();
            this._business ??= new CustomerBusiness();
            this.LoadGrdCustomer(id);
        }

        private async void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int idd = -1;
                int.TryParse(CustomerId.Text, out idd);
                var item = await _business.GetById(idd);

                if (item.Data == null)
                {
                    var customer = new Customer()
                    {
                        CustomerName = CustomerName.Text,
                        Phone = Phone.Text,
                        Address = Address.Text,
                        Email = Email.Text,
                        Password = Password.Text,
                        ImgUrl = ImgUrl.Text,
                        CreateDate = CreateDate.SelectedDate,
                        Gender = Gender.Text,
                        IsActive = IsActive.IsChecked,
                        UpdateTime = UpdateTime.SelectedDate
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
                    customer.ImgUrl = ImgUrl.Text;
                    customer.CreateDate = CreateDate.SelectedDate;
                    customer.Gender = Gender.Text;
                    customer.IsActive = IsActive.IsChecked;
                    customer.UpdateTime = UpdateTime.SelectedDate;

                    var result = await _business.Update(customer);
                    MessageBox.Show(result.Message, "Update");
                }

                ClearForm();
                this.LoadGrdCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        private void ClearForm()
        {
            CustomerId.Text = string.Empty;
            CustomerName.Text = string.Empty;
            Phone.Text = string.Empty;
            Address.Text = string.Empty;
            Email.Text = string.Empty;
            Password.Text = string.Empty;
            ImgUrl.Text = string.Empty;
            CreateDate.SelectedDate = null;
            Gender.Text = string.Empty;
            IsActive.IsChecked = false;
            UpdateTime.SelectedDate = null;
        }

        private async void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.ClearForm();
        }

        private async void grdCustomer_ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            string customerId = btn.CommandParameter.ToString();

            //MessageBox.Show(currencyCode);

            if (!string.IsNullOrEmpty(customerId))
            {
                if (MessageBox.Show("Do you want to delete this item?", "Delete", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    var result = await _business.DeleteById(int.Parse(customerId));
                    MessageBox.Show($"{result.Message}", "Delete");
                    this.LoadGrdCustomer();
                }
            }
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
                            ImgUrl.Text = item.ImgUrl;
                            CreateDate.SelectedDate = item.CreateDate;
                            Gender.Text = item.Gender;
                            IsActive.IsChecked = item.IsActive;
                            UpdateTime.SelectedDate = item.UpdateTime;
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

        private async void LoadGrdCustomer(int customerId)
        {
            var customerResult = await _business.GetById(customerId);
            if (customerResult.Status > 0 && customerResult.Data != null)
            {
                this.LoadGrdCustomer();
                var customer = customerResult.Data as Customer;
                CustomerId.Text = customer.CustomerId.ToString();
                CustomerName.Text = customer.CustomerName;
                Phone.Text = customer.Phone;
                Address.Text = customer.Address;
                Email.Text = customer.Email;
                Password.Text = customer.Password;
                ImgUrl.Text = customer.ImgUrl;
                CreateDate.SelectedDate = customer.CreateDate;
                Gender.Text = customer.Gender;
                IsActive.IsChecked = customer.IsActive;
                UpdateTime.SelectedDate = customer.UpdateTime;
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

    }
}
