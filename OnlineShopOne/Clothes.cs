using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OnlineShopOne
{
    internal class Clothes
    {
        private int id;
        private double price;
        private double discount;
        private int amount;
        private string title;
        private string description;
        private string brand;
        private enum size;
        private string color;
        private string typeClothing;
        private string genderForClothing;

        public int Id { get => id; set => id = value; }
        public double Price { get => price; set => price = value; }
        public double Discount { get => discount; set => discount = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Color { get => color; set => color = value; }
        public string TypeClothing { get => typeClothing; set => typeClothing = value; }
        public string GenderForClothing { get => genderForClothing; set => genderForClothing = value; }
        public Clothes(int id, double price, double discount, int amount, string title)
        {
            this.Id = id;
            this.Price = price;
            this.Discount = discount;
            this.Amount = amount;
            this.Title = title;
        }

        /*public Clothes(int id, double price, double discount, int amount, string title, string description, string brand, string color, string typeClothing, string genderForClothing)
        {
            this.Id = id;
            this.Price = price;
            this.Discount = discount;
            this.Amount = amount;
            this.Title = title;
            this.Description = description;
            this.Brand = brand;
            this.Color = color;
            this.TypeClothing = typeClothing;
            this.GenderForClothing = genderForClothing;
        }*/

        public double priceAfterDiscount()
        {
            return price * (1 - discount / 100);
        }
        public void PrintInfo()
        {
            Console.WriteLine("Clothing ID: " + id + ", Title = " + title + ", Price: " + price + ", Discount = " + discount + "%, Amount: " + this.amount);
        }
    }
}
