using HomeTasks03082025.Models;

namespace HomeTasks03082025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student("Qurbanali", "Sadigov", "PB306", 97);

            //student.PrintInfo();
            //student.CheckGraduation();
            //student.GetDiplomDegree();


            //Product product = new Product("Samsung", "Ultra", 700, 200, 50);
            //product.PrintInfo();

            //product.Sale(4);
            //product.PrintInfo();
            //product.Sale(5);

            //product.Refill(7);
            //product.Sale(8);
            //product.PrintInfo();

            Phone phone = new Phone("Apple", "Iphone 16 Pro", 3000, 500, 15, "256GB", "Purple",0);
          
            phone.Pay(5);
            phone.Call(15);           ;
           

            


        }
    }
}
