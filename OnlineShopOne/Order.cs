using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OnlineShopOne
{
    internal class Order
    {
        int id;
        int clientId;
        List<Clothes> cartClothes = new List<Clothes>();
        bool paymentSuccessful = false;
        bool orderInfoFull = false;
        bool orderComplete = false;
        double totalPrice = 0;
        double deliveryPrice = 0;
        double additionalDiscount = 0; // (for clothes without a discount)
        string shippingAddress;
        public Order(int id, int clientId, List<Clothes> cartClothes, double deliveryPrice, double additionalDiscount, string shippingAddress)
        {
            this.id = id;
            this.clientId = clientId;
            this.cartClothes = cartClothes;
            this.deliveryPrice = deliveryPrice;
            this.additionalDiscount = additionalDiscount;
            this.shippingAddress = shippingAddress;
        }
        private double getTotalPrice()
        {
            //za domashno: da go smetna total price
            return 0;
        }
        public void PrintInfo()
        {
            Console.WriteLine("ID: " + id + ", ClientID: = " + clientId + ", Shipping Address: " + this.shippingAddress + ", Total Price: " + getTotalPrice());
            foreach (Clothes clothing in cartClothes)
            {
                clothing.PrintInfo();
            }
        }
    }
}
