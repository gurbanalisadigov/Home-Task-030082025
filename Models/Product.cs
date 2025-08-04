using System;

namespace HomeTasks03082025.Models
{
    internal class Product
    {
        public string BrandName;
        public string Model;
        public double Price;
        public double Cost;
        public double InCome;
        public int Count;

        public Product(string brandName, string model, double price, double cost, int count)
        {

            this.BrandName = brandName;
            this.Model = model;
            this.Price = price;
            this.Cost = cost;
            this.InCome = 0;
            this.Count = count;

            if (count < 0)
                this.Count = 0;
            else
                this.Count = count;

        }
        public void PrintInfo()
        {
            Console.WriteLine($"Brandname: {BrandName}, Model: {Model}, Price: {Price}, Cost: {Cost}, Income: {InCome}, Count: {Count}");


        }
        public void Sale(int amount)
        {
            if (Count >= amount)
            {
                InCome += (Price - Cost) * amount;
                Count -= amount;
                Console.WriteLine($"{amount} eded mehsul satildi");
            }

            else
                Console.WriteLine("Mehsul bitmisdir");

        }

        public void Refill(int amount)
        {
            if (amount >= 0)
            {
                Count += amount;
                Console.WriteLine($"{amount}  eded qeder mehsul elave olundu.Umumi Yeni Say: {amount}");

            }
            else
                Console.WriteLine("Zehmet Olmasa musbet eded daxil edin");
        }




    }
}
