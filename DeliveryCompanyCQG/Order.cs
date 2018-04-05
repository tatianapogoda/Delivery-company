using System.Linq;

namespace DeliveryCompanyCQG
{
    public class Order
    {
        public static string[] A;
        public static string[] B;
        public static string[] C;
        public static string[] D;

        public Order()
        { }

        public Order(string clientId, OrderSide side, int quantity, OrderState state, float price)
        {
            this.ClientId = clientId;
            this.Quantity = quantity;
            this.Price = price;
        }

        public string ClientId { get; set; }

        public int Quantity { get; set; }

        public float Price { get; set; }

        public string[] FormedOrder(string clientId, string supplierId, string[] newOrder, string[] supplier)
        {
            return supplier.Concat(newOrder).Distinct().ToArray();
        }
    }

    public enum OrderSide
    {
        Buy,
        Sell
    };
    public enum OrderState
    {
        InTransit,
        Reject,
        Done
    };
}
