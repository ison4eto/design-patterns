using System;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    class Example
    {
        static void Main()
        {
            File[] Files = new File[2];
            Files[0] = new Furniture();
            Files[1] = new Crokery();
            foreach (File File in Files)
            {
                Console.WriteLine("\n" + File.GetType().Name + "--");
                foreach (Items Items in File.Itemss)
                {
                    Console.WriteLine(" " + Items.GetType().Name);
                }
            }
            Console.ReadKey();
        }
    }
}