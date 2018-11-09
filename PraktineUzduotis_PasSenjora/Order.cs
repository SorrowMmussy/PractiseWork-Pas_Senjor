using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PraktineUzduotis_PasSenjora
{
    public class RegisterOrder
    {
        public int FoodID { get; set; }
        public string Name { get; set; }
        //public bool IsSelected { get; set; }
        public int Count { get; set; }

        public RegisterOrder(string foodName, int foodid)
        {
            Name = foodName;
            FoodID = foodid;
            //IsSelected = false;
            Count = 0;
        }
        //com
    }

    public class RegisterOrders : List<RegisterOrder>
    {
        public int TableID { get; set; }
        public List<int> FreeTables { get; set; }

        public RegisterOrders(Dictionary<string, int> foods, List<int> freeTables)
        {
            FreeTables = freeTables;
            TableID = -1;
            foreach (KeyValuePair<string, int> kvp in foods)
            {
                this.Add(new RegisterOrder(kvp.Key, kvp.Value));
            }
        }
        
    }
    

    enum OrderState
    {
        Priimtas,
        Daromas,
        Užbaigtas
    }
}
