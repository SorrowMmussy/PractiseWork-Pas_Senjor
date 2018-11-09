using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktineUzduotis_PasSenjora
{
    class StaticCache
    {
        const int TableCount = 15;

        public static List<int> TableList
        {
            get
            {
                List<int> BusyTables = OrdersDataSet.Order.Where(y=>y.State != 2).Select((x) => x.TableID).ToList();
                List<int> FreeTables = new List<int>();
                for (int i = 1; i <= TableCount; i++)
                {
                    FreeTables.Add(i);
                }
                //return FreeTables.Except(BusyTables).ToList();
                return FreeTables;
            }
        }
        public static OrdersDataSet OrdersDataSet = new OrdersDataSet();

        public static void Init()
        {
            OrdersDataSetTableAdapters.FoodTableAdapter fta = new OrdersDataSetTableAdapters.FoodTableAdapter();
            OrdersDataSetTableAdapters.TabTableAdapter tta = new OrdersDataSetTableAdapters.TabTableAdapter();
            OrdersDataSetTableAdapters.OrderTableAdapter ota = new OrdersDataSetTableAdapters.OrderTableAdapter();

            fta.Fill(OrdersDataSet.Food);
            tta.Fill(OrdersDataSet.Tab);
            ota.Fill(OrdersDataSet.Order);
            
        }
    }
}
