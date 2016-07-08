using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;

namespace EFTest
{
    class Program
    {
        static void Main(string[] args) {
            Database.SetInitializer(new ContextInitializer());
            using(ExternalMemberContext aContext = new ExternalMemberContext()) {
                Debug.WriteLine(aContext.Clients.Count());
            }
            Console.WriteLine("Worked");
            Console.ReadLine();
        }
    }
}