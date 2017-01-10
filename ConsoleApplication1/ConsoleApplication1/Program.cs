using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext dataContext = new DataClasses1DataContext();
            Console.WriteLine(dataContext.Customers.Count());
            Console.ReadLine();
        }
    }
}
