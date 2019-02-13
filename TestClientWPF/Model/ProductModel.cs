using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClientWPF.Model
{
    class ProductModel
    {
        private TestServiceReference.TestServiceClient testReference = new TestServiceReference.TestServiceClient();

        public ObservableCollection<TestServiceReference.Product> GetProducts(TestServiceReference.Customer customer)
        {
            return testReference.GetProducts(customer);
        }

        public void AddProduct(TestServiceReference.Product product)
        {
            testReference.AddProduct(product);
        }

        public void DeleteProduct(TestServiceReference.Product product)
        {
            testReference.DeleteProduct(product);
        }

        public void UpdateProduct(TestServiceReference.Product product)
        {
            testReference.UpdateProduct(product);
        }
    }
}
