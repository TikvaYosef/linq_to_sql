using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_to_sql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conectionString = "Data Source=desktop-5e70rm2;Initial Catalog=dataDb;Integrated Security=True;Pooling=False";
            DataClasses1DataContext data = new DataClasses1DataContext(conectionString);

            foreach (var dogitem in data.Dogs)
            {
                Console.WriteLine(dogitem.age);
            }
            Console.ReadLine();
          
        }
    }
}
