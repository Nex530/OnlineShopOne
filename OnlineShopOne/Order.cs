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

            totalPrice = 0;
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
        public bool CompletingOrder(Clients client)
        {
            if (client.Name.Count() > 1 && client.Balance - getTotalPrice() >= 0 && shippingAddress.Count() > 5 && cartClothes.Count > 0)
            {
                client.Balance -= getTotalPrice();
                paymentSuccessful = true;
                orderInfoFull = true;
                orderComplete = true;
                client.addCompletedOrder(this);
                return true;
            }
            if (client.Name.Count() <= 1)
            {
                Console.WriteLine("Client name is too short.");
            }
            if (client.Balance - getTotalPrice() < 0)
            {
                Console.WriteLine("Insufficient balance.");
            }
            if (shippingAddress.Count() <= 5)
            {
                Console.WriteLine("Shipping address is too short.");
            }
            if (cartClothes.Count == 0)
            {
                Console.WriteLine("Cart is empty.");
            }
            // za domashno:
            // da napravja output za VSEKI razlichen problem sus proverki za korektna informacija ot klienta, za dostatuchen balans, za adres > 5 index i za lichni produk ti v kolichkata (ako ima nishto)
            // d
            return false;
        }
    }
}
