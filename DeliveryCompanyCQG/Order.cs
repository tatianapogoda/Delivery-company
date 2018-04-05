using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCompanyCQG
{
    class Order
    {

        public static string[] A;
        public static string[] B;
        public static string[] C;
        public static string[] D;
        public enum OrderSide { Buy, Sell };
        public enum OrderState { Intransit, Reject, Done};
        public Order() { }
        public Order(string clientId, OrderSide side, int quantity, OrderState state, float price)
        {
            this.ClientId = clientId;
            this.Quantity = quantity;
            this.Price = price;
        }
        public string ClientId { get; set; }
        public int Quantity { get; set; }

        //internal string[] FormedOrder(Func<object, string> getItemText1, Func<object, string> getItemText2, string v)
        //{
        //    throw new NotImplementedException();
        //}

        public float Price { get; set; }
        
        public string[] FormedOrder(string clientId, string supplierId, string[] newOrder, string[] supplier)
        {
            var tmp = supplier.Concat(newOrder).Distinct().ToArray();
            string[] A = tmp;
            return A;
        }
    }
}
