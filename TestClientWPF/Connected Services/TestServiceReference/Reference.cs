﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestClientWPF.TestServiceReference {
    using System.Runtime.Serialization;
    using System;
    using System.Collections.ObjectModel;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/TestWCFService")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/TestWCFService")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TestClientWPF.TestServiceReference.Customer CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float PriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Count {
            get {
                return this.CountField;
            }
            set {
                if ((this.CountField.Equals(value) != true)) {
                    this.CountField = value;
                    this.RaisePropertyChanged("Count");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TestClientWPF.TestServiceReference.Customer Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerField, value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TestServiceReference.ITestService")]
    public interface ITestService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/GetCustomers", ReplyAction="http://tempuri.org/ITestService/GetCustomersResponse")]
        ObservableCollection<TestClientWPF.TestServiceReference.Customer> GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/GetCustomers", ReplyAction="http://tempuri.org/ITestService/GetCustomersResponse")]
        System.Threading.Tasks.Task<ObservableCollection<TestClientWPF.TestServiceReference.Customer>> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/UpdateCustomer", ReplyAction="http://tempuri.org/ITestService/UpdateCustomerResponse")]
        void UpdateCustomer(TestClientWPF.TestServiceReference.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/UpdateCustomer", ReplyAction="http://tempuri.org/ITestService/UpdateCustomerResponse")]
        System.Threading.Tasks.Task UpdateCustomerAsync(TestClientWPF.TestServiceReference.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/DeleteCustomer", ReplyAction="http://tempuri.org/ITestService/DeleteCustomerResponse")]
        void DeleteCustomer(TestClientWPF.TestServiceReference.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/DeleteCustomer", ReplyAction="http://tempuri.org/ITestService/DeleteCustomerResponse")]
        System.Threading.Tasks.Task DeleteCustomerAsync(TestClientWPF.TestServiceReference.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/AddCustomer", ReplyAction="http://tempuri.org/ITestService/AddCustomerResponse")]
        void AddCustomer(TestClientWPF.TestServiceReference.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/AddCustomer", ReplyAction="http://tempuri.org/ITestService/AddCustomerResponse")]
        System.Threading.Tasks.Task AddCustomerAsync(TestClientWPF.TestServiceReference.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/GetProducts", ReplyAction="http://tempuri.org/ITestService/GetProductsResponse")]
        ObservableCollection<TestClientWPF.TestServiceReference.Product> GetProducts(TestClientWPF.TestServiceReference.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/GetProducts", ReplyAction="http://tempuri.org/ITestService/GetProductsResponse")]
        System.Threading.Tasks.Task<ObservableCollection<TestClientWPF.TestServiceReference.Product>> GetProductsAsync(TestClientWPF.TestServiceReference.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/UpdateProduct", ReplyAction="http://tempuri.org/ITestService/UpdateProductResponse")]
        void UpdateProduct(TestClientWPF.TestServiceReference.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/UpdateProduct", ReplyAction="http://tempuri.org/ITestService/UpdateProductResponse")]
        System.Threading.Tasks.Task UpdateProductAsync(TestClientWPF.TestServiceReference.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/DeleteProduct", ReplyAction="http://tempuri.org/ITestService/DeleteProductResponse")]
        void DeleteProduct(TestClientWPF.TestServiceReference.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/DeleteProduct", ReplyAction="http://tempuri.org/ITestService/DeleteProductResponse")]
        System.Threading.Tasks.Task DeleteProductAsync(TestClientWPF.TestServiceReference.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/AddProduct", ReplyAction="http://tempuri.org/ITestService/AddProductResponse")]
        void AddProduct(TestClientWPF.TestServiceReference.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/AddProduct", ReplyAction="http://tempuri.org/ITestService/AddProductResponse")]
        System.Threading.Tasks.Task AddProductAsync(TestClientWPF.TestServiceReference.Product product);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITestServiceChannel : TestClientWPF.TestServiceReference.ITestService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TestServiceClient : System.ServiceModel.ClientBase<TestClientWPF.TestServiceReference.ITestService>, TestClientWPF.TestServiceReference.ITestService {
        
        public TestServiceClient() {
        }
        
        public TestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ObservableCollection<TestClientWPF.TestServiceReference.Customer> GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<ObservableCollection<TestClientWPF.TestServiceReference.Customer>> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public void UpdateCustomer(TestClientWPF.TestServiceReference.Customer customer) {
            base.Channel.UpdateCustomer(customer);
        }
        
        public System.Threading.Tasks.Task UpdateCustomerAsync(TestClientWPF.TestServiceReference.Customer customer) {
            return base.Channel.UpdateCustomerAsync(customer);
        }
        
        public void DeleteCustomer(TestClientWPF.TestServiceReference.Customer customer) {
            base.Channel.DeleteCustomer(customer);
        }
        
        public System.Threading.Tasks.Task DeleteCustomerAsync(TestClientWPF.TestServiceReference.Customer customer) {
            return base.Channel.DeleteCustomerAsync(customer);
        }
        
        public void AddCustomer(TestClientWPF.TestServiceReference.Customer customer) {
            base.Channel.AddCustomer(customer);
        }
        
        public System.Threading.Tasks.Task AddCustomerAsync(TestClientWPF.TestServiceReference.Customer customer) {
            return base.Channel.AddCustomerAsync(customer);
        }
        
        public ObservableCollection<TestClientWPF.TestServiceReference.Product> GetProducts(TestClientWPF.TestServiceReference.Customer customer) {
            return base.Channel.GetProducts(customer);
        }
        
        public System.Threading.Tasks.Task<ObservableCollection<TestClientWPF.TestServiceReference.Product>> GetProductsAsync(TestClientWPF.TestServiceReference.Customer customer) {
            return base.Channel.GetProductsAsync(customer);
        }
        
        public void UpdateProduct(TestClientWPF.TestServiceReference.Product product) {
            base.Channel.UpdateProduct(product);
        }
        
        public System.Threading.Tasks.Task UpdateProductAsync(TestClientWPF.TestServiceReference.Product product) {
            return base.Channel.UpdateProductAsync(product);
        }
        
        public void DeleteProduct(TestClientWPF.TestServiceReference.Product product) {
            base.Channel.DeleteProduct(product);
        }
        
        public System.Threading.Tasks.Task DeleteProductAsync(TestClientWPF.TestServiceReference.Product product) {
            return base.Channel.DeleteProductAsync(product);
        }
        
        public void AddProduct(TestClientWPF.TestServiceReference.Product product) {
            base.Channel.AddProduct(product);
        }
        
        public System.Threading.Tasks.Task AddProductAsync(TestClientWPF.TestServiceReference.Product product) {
            return base.Channel.AddProductAsync(product);
        }
    }
}