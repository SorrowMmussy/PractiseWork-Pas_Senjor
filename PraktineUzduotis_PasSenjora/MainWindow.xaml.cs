using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Configuration;
using System.Data;

namespace PraktineUzduotis_PasSenjora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StaticCache.Init();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DG_Orders.ItemsSource = StaticCache.OrdersDataSet.Order;
        }

        private void B_Register_Click(object sender, RoutedEventArgs e)
        {
            Register_Window rw = new Register_Window();
            if(rw.ShowDialog() == true)
            {
                int tableID = rw.RegisterOrdersList.TableID;
                if (tableID == -1)
                {
                    return;
                }

                Dictionary<int, int> foodlist = rw.RegisterOrdersList.Where(a=>a.Count > 0).ToDictionary(x => x.FoodID, y => y.Count);
                
                OrdersDataSetTableAdapters.OrderTableAdapter oa = new OrdersDataSetTableAdapters.OrderTableAdapter();
                if(oa.Insert(tableID, 0) < 1)
                {
                    return;
                }
                oa.Fill(StaticCache.OrdersDataSet.Order);
                int orderID = (int)StaticCache.OrdersDataSet.Order.Last()["ID"];


                OrdersDataSetTableAdapters.TabTableAdapter ta = new OrdersDataSetTableAdapters.TabTableAdapter();
                foreach (KeyValuePair<int, int> kvp in foodlist)
                {
                    ta.Insert(kvp.Key, orderID, kvp.Value);
                }
                ta.Fill(StaticCache.OrdersDataSet.Tab);
            }

        }
        
        private void DG_Orders_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DataGrid grd = (DataGrid)sender;
            if (grd == null)
            {
                return;
            }

            DataRowView dr = grd.SelectedItem as DataRowView;
            int index = grd.SelectedIndex;
            if (dr == null)
            {
                return;
            }
            int state = (int)dr.Row["State"];

            if (e.LeftButton == MouseButtonState.Pressed &&
                e.ClickCount == 2)
            {

                OrdersDataSetTableAdapters.OrderTableAdapter oa = new OrdersDataSetTableAdapters.OrderTableAdapter();
                if (state > 1)
                {
                    //dr.Row["State"] = 0;
                }
                else
                {
                    dr.Row["State"] = state + 1;
                }
                oa.Update(dr.Row);
                oa.Fill(StaticCache.OrdersDataSet.Order);
                
                grd.SelectedItem = grd.Items[index];
            }

            if (e.RightButton == MouseButtonState.Pressed &&
                e.ClickCount == 2)
            {
                OrdersDataSetTableAdapters.OrderTableAdapter oa = new OrdersDataSetTableAdapters.OrderTableAdapter();
                if (state < 1)
                {
                    //dr.Row["State"] = 2;
                }
                else
                {
                    dr.Row["State"] = state - 1;
                }
                oa.Update(dr.Row);
                oa.Fill(StaticCache.OrdersDataSet.Order);
                
                grd.SelectedItem = grd.Items[index];

            }


        }
    }
}
