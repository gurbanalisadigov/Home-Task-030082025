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

        public Product(string BrandName, string Model, double Price, double Cost, int Count)
        {

            this.BrandName = BrandName;
            this.Model = Model;
            this.Price = Price;
            this.Cost = Cost;
            this.InCome = 0;
            this.Count = Count;

            if (Count < 0)
                this.Count = 0;
            else
                this.Count = Count;

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
