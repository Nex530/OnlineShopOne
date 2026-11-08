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
            foreach (Clothes clothing in cartClothes)
            {
                if (clothing.Discount == 0)
                {
                    totalPrice += clothing.Price - (clothing.Price * additionalDiscount / 100);
                }
                else
                {
                    totalPrice += clothing.priceAfterDiscount();
                }
            }
            totalPrice += deliveryPrice;
            return totalPrice;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Order ID: " + id + ", ClientID: = " + clientId + ", Shipping Address: " + this.shippingAddress + ", Total Price: " + getTotalPrice());
            foreach (Clothes clothing in cartClothes)
            {
                clothing.PrintInfo();
            }
        }
    }
}
