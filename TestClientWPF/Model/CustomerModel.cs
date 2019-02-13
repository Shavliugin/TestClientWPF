using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClientWPF.Model
{
    class CustomerModel
    {
        private TestServiceReference.TestServiceClient testReference = new TestServiceReference.TestServiceClient();

        public ObservableCollection<TestServiceReference.Customer> GetCustomers()
        {
            return testReference.GetCustomers();
        }

        public void AddCustomer(TestServiceReference.Customer customer)
        {
            testReference.AddCustomer(customer);
        }

        public void DeleteCustomer(TestServiceReference.Customer customer)
        {
            testReference.DeleteCustomer(customer);
        }

        public void UpdateCustomer(TestServiceReference.Customer customer)
        {
            testReference.UpdateCustomer(customer);
        }
    }
}
