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
    class ProductViewModel : INotifyPropertyChanged
    {
        private string name;
        private float price;
        private int count;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private TestServiceReference.Customer customer = new TestServiceReference.Customer();
        public TestServiceReference.Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        private TestServiceReference.Product currentProduct = new TestServiceReference.Product();

        public TestServiceReference.Product CurrentProduct
        {
            get { return currentProduct; }
            set
            {
                currentProduct = value;
                OnPropertyChanged(nameof(CurrentProduct));
            }
        }

        private ObservableCollection<TestServiceReference.Product> products;

        public ObservableCollection<TestServiceReference.Product> Products
        {
            get { return products; }
            set
            {
                products = value;
                OnPropertyChanged(nameof(Products));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private ProductModel model = new ProductModel();
        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void RefreshList()
        {
            Products = model.GetProducts(Customer);
        }

        public void Add()
        {
            TestServiceReference.Product newProduct = new TestServiceReference.Product();
            newProduct.Count = this.Count;
            newProduct.Name = this.Name;
            newProduct.Price = this.Price;
            newProduct.CustomerId = this.Customer.Id;
            model.AddProduct(newProduct);
            RefreshList();
        }

        public void Update()
        {
            if (currentProduct.Id != 0)
            {
                CurrentProduct.Count = this.Count;
                CurrentProduct.Name = this.Name;
                CurrentProduct.Price = this.Price;
                model.UpdateProduct(currentProduct);
                RefreshList();
            }
        }

        public void Delete()
        {
            if (currentProduct.Id != 0)
            {
                model.DeleteProduct(currentProduct);
                RefreshList();
            }
        }
    }
}
