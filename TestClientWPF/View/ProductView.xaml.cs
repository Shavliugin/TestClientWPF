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
using TestClientWPF.TestServiceReference;
using TestClientWPF.ViewModel;

namespace TestClientWPF.View
{
    /// <summary>
    /// Логика взаимодействия для ProductView.xaml
    /// </summary>
    public partial class ProductView : Window
    {
        private ProductViewModel vm = new ProductViewModel();

        public ProductView(TestClientWPF.TestServiceReference.Customer customer)
        {
            InitializeComponent();
            vm.Customer = customer;
            this.DataContext = vm;            
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            vm.Add();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            vm.Update();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            vm.Delete();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                vm.CurrentProduct = (TestServiceReference.Product)e.AddedItems[0];
            }
            else
            {
                vm.CurrentProduct = null;
            }
        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            vm.RefreshList();
        }
    }
}
