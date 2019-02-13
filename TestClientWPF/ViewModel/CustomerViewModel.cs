using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClientWPF.Model;

namespace TestClientWPF.ViewModel
{
    class CustomerViewModel : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private string phone;
        private string address;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private TestServiceReference.Customer currentCustomer = new TestServiceReference.Customer();

        public TestServiceReference.Customer CurrentCustomer
        {
            get { return currentCustomer; }
            set
            {
                currentCustomer = value;
                OnPropertyChanged(nameof(CurrentCustomer));
            }
        }

        private ObservableCollection<TestServiceReference.Customer> customers;

        public ObservableCollection<TestServiceReference.Customer> Customers
        {
            get { return customers; }
            set
            {
                customers = value;
                OnPropertyChanged(nameof(Customers));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private CustomerModel model = new CustomerModel();
        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void RefreshList()
        {
            Customers = model.GetCustomers();
        }

        public void Add()
        {
            TestServiceReference.Customer newCustomer = new TestServiceReference.Customer();
            newCustomer.Address = this.Address;
            newCustomer.Phone = this.Phone;
            newCustomer.LastName = this.LastName;
            newCustomer.FirstName = this.FirstName;
            model.AddCustomer(newCustomer);
            RefreshList();
        }

        public void Update()
        {
            if (currentCustomer.Id != 0)
            {
                currentCustomer.Address = this.Address;
                currentCustomer.Phone = this.Phone;
                currentCustomer.LastName = this.LastName;
                currentCustomer.FirstName = this.FirstName;
                model.UpdateCustomer(currentCustomer);
                RefreshList();
            }
        }

        public void Delete()
        {
            if (currentCustomer.Id != 0)
            {
                model.DeleteCustomer(currentCustomer);
                RefreshList();
            }
        }
    }
}