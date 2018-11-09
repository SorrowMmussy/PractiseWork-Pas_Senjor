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

namespace PraktineUzduotis_PasSenjora
{
    /// <summary>
    /// Interaction logic for Register_Window.xaml
    /// </summary>
    public partial class Register_Window : Window
    {
        public RegisterOrders RegisterOrdersList { get; set; }

        public Register_Window()
        {
            InitializeComponent();
            RegisterOrdersList = new RegisterOrders(StaticCache.OrdersDataSet.Food.ToDictionary(x => x.Name, y=>y.ID), StaticCache.TableList);
            DataContext = RegisterOrdersList;
            DG_Register.ItemsSource = RegisterOrdersList;
        }


        private void B_RegisterOK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void DataGrid_GotFocus(object sender, RoutedEventArgs e)
        {
            DataGrid grd = (DataGrid)sender;
            if (grd == null)
            {
                return;
            }
            grd.BeginEdit(e);
        }
    }
}
