using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PraktineUzduotis_PasSenjora
{

    public class OrderStateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var obj = value as DataRowView;
            if(obj == null)
            {
                return null;
            }
            return (OrderState)obj["State"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class OrderTabConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var obj = value as DataRowView;
            if (obj == null)
            {
                return null;
            }
            DataRow[] drs = StaticCache.OrdersDataSet.Tab.Select($"OrderID = '{(int)obj["ID"]}'");

            return drs;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class OrderPriceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var obj = value as DataRowView;
            if (obj == null)
            {
                return null;
            }
            
            DataRow[] drs = StaticCache.OrdersDataSet.Tab.Select($"OrderID = '{(int)obj["ID"]}'");
            decimal price = 0;
            foreach(DataRow dr in drs)
            {
                int foodID = (int)dr["FoodID"];
                int foodCount = (int)dr["FoodCount"];
                decimal foodPrice = (decimal)StaticCache.OrdersDataSet.Food.Rows.Find(foodID)["Price"];
                price += foodCount * foodPrice;
            }
            return price.ToString("N2");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class TabFullPriceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var obj = value as OrdersDataSet.TabRow;
            if (obj == null)
            {
                return null;
            }

            return (obj.FoodRow.Price * obj.FoodCount).ToString("N2");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class TabPriceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var obj = value as OrdersDataSet.TabRow;
            if (obj == null)
            {
                return null;
            }
            
            return obj.FoodRow.Price.ToString("N2");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
    public class TabNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var obj = value as OrdersDataSet.TabRow;
            if (obj == null)
            {
                return null;
            }
            return obj.FoodRow.Name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
