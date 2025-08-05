using System;

namespace HomeTasks03082025.Models
{
    internal class Phone: Product
    {
       private string _ram;
       private string _color;
       public double _balance;

        public string Ram
        {
            get
            {
                return _ram;

            }
            set
            {
                _ram = value;
            }

        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
           set
            {
                _balance = value;
            }
        }


        public Phone(string brandName, string model, decimal price, decimal cost, int count, string ram,string color, double balance):base(brandName,model,price,cost,count)
        {
            _ram = ram;
            _color = color;
            _balance =balance;

        }

        public void Call(int seconds)
        {
            double cost =  seconds * 0.1;
            if (Balance > cost)
            {
                Balance -= cost;
                Console.WriteLine("Zeng Edildi");
            }
            else
            {      
                Console.WriteLine("Zeng Etmek ucun Balansda Kifayet qeder vesait qalmayib");
            }
        }
        public double Pay(double money)

        {
            if (money > 0)
            {
                Balance += money;
                Console.WriteLine($"{money} mebleg daxil edildi.Yeni Balans: {Balance}");

            }
            return Balance;

        }
    }
}
