using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week14_5
{
    class Program
    {
        public static void CM(int a)
        {
            if (a > 150)
                Console.Write("身高:" + a + " 全票");
            else if(a <= 150&&a>=120)
                Console.Write("身高:" + a + " 半票");
            else 
                Console.Write("身高:" + a + " 免費");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR__Week14_5");
            int cm;
            Console.Write("請輸入身高值:");
            cm = int.Parse(Console.ReadLine());
            CM(cm);
            Console.ReadLine();
        }
    }
}
