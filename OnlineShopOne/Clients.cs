using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopOne
{
    internal class Clients
    {
        int id;
        string name;
        string shippingAddress;
        string phoneNumber;
        string email;
        string password;
        double balance;
        List<Order> CompletedOrders = new List<Order>();
        List<int> likedProductsId = new List<int>();

        public Clients(int id, string name, string shippingAddress, string phoneNumber, string email, string password, double balance)
        {
            this.id = id;
            this.name = name;
            this.shippingAddress = shippingAddress;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.password = password;
            this.balance = balance;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string ShippingAddress { get => shippingAddress; set => shippingAddress = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public double Balance { get => balance; set => balance = value; }

        public void PrintInfo()
        {
            Console.WriteLine("ID: " + id + ", Name = " + name + ", Shipping Address: " +  this.shippingAddress + this.balance);
        }
    }
}
