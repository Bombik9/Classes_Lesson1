using System.Runtime.Loader;
using System.Security.Cryptography;

namespace TASK6
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
         Address address = new Address();
            address.City = "Vinnitsa";
            address.Country = "Ukraine";
            address.Street = "Budivelna";

            address.Index = 23211;
            address.House = 9;
            address.Apartament = 0;

            address.Show();

           
            Console.ReadKey();
        }
    }
}