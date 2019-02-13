using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestClientWPF.ViewModel;
using TestClientWPF.View;

namespace TestClientWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CustomerViewModel vm = new CustomerViewModel();

        private class ololo
        {
            public ObservableCollection<string> gaben { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        private void LbCustomer_Loaded(object sender, RoutedEventArgs e)
        {
            vm.RefreshList();
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

        private void BtnOpenProducts_Click(object sender, RoutedEventArgs e)
        {
            ProductView view = new ProductView(vm.CurrentCustomer);
            view.Show();
        }

        private void LbCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                vm.CurrentCustomer = (TestServiceReference.Customer)e.AddedItems[0];
            }
            else
            {
                vm.CurrentCustomer = null;
            }
        }
    }
}
