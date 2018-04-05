using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryCompanyCQG
{
    public partial class Form1 : Form
    {
        public static string[] A = { "" };
        public static string[] B = { "" };
        public static string[] C = { "" };
        public static string[] D = { "" };
        public static string[] order;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order Orders = new Order();
            string clientId = clientBox.SelectedItem.ToString();
            string supplierId = supplierBox.SelectedItem.ToString();
            string[] newOrder = new string[5];//new string[itemsList.CheckedItems.ToString().Length];
            itemsList.CheckedItems.CopyTo(newOrder, 0);
            
            switch (supplierBox.SelectedItem.ToString())
            {
                case "A":
                    order = Orders.FormedOrder(clientId, supplierId, newOrder, A);
                    A = order;
                    break;
                case "B":
                    order = Orders.FormedOrder(clientId, supplierId, newOrder, B);
                    B = order;
                    break;
                case "C":
                    order = Orders.FormedOrder(clientId, supplierId, newOrder, C);
                    C = order;
                    break;
                case "D":
                    order = Orders.FormedOrder(clientId, supplierId, newOrder, D);
                    D = order;
                    break;
            }
            Suppliers.Text = (supplierId + ": " + string.Join("", order) + "\n");
            Clients.AppendText(clientId + ": \n" + supplierId + "( " + string.Join("", newOrder) + " ) \n");
        }
    }
}
