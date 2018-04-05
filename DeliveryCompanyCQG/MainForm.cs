using System;
using System.Windows.Forms;

namespace DeliveryCompanyCQG
{
    public partial class MainForm : Form
    {
        public static string[] A = { "" };
        public static string[] B = { "" };
        public static string[] C = { "" };
        public static string[] D = { "" };
        public static string[] orderString;
        public MainForm()
        {
            InitializeComponent();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            var order = new Order();
            var clientId = clientBox.SelectedItem.ToString();
            var supplierId = supplierBox.SelectedItem.ToString();
            var newOrder = new string[5];//new string[itemsList.CheckedItems.ToString().Length];
            itemsList.CheckedItems.CopyTo(newOrder, 0);
            
            switch (supplierBox.SelectedItem.ToString())
            {
                case "A":
                    MainForm.orderString = order.FormedOrder(clientId, supplierId, newOrder, A);
                    A = MainForm.orderString;
                    break;
                case "B":
                    MainForm.orderString = order.FormedOrder(clientId, supplierId, newOrder, B);
                    B = MainForm.orderString;
                    break;
                case "C":
                    MainForm.orderString = order.FormedOrder(clientId, supplierId, newOrder, C);
                    C = MainForm.orderString;
                    break;
                case "D":
                    MainForm.orderString = order.FormedOrder(clientId, supplierId, newOrder, D);
                    D = MainForm.orderString;
                    break;
            }
            suppliers.Text = (supplierId + ": " + string.Join("", MainForm.orderString) + "\n");
            clients.AppendText(clientId + ": \n" + supplierId + "( " + string.Join("", newOrder) + " ) \n");
        }
    }
}
