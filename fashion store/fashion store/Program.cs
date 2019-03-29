using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;


namespace fashion_store
{
    class Program
    {
        static void Main(string[] args)
        {
           // Client client = new Client();
          

            // Integration test using AutoFixture 

            var fixture = new Fixture();
           
            var client1 = fixture.Build<Client>().CreateMany();
            client1.ToList();
            Console.ReadLine();




        }
    }
}
