using HomeTasks03082025.Models;

namespace HomeTasks03082025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Qurbanali", "Sadigov", "PB306", 97);

            student.PrintInfo();
            student.CheckGraduation();
            student.GetDiplomDegree();


            Product product = new Product("Samsung", "Ultra", 700, 200, 50);
            product.PrintInfo();
            product.Sale(9);
            product.Refill(7);


        }
    }
}
