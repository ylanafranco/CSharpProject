using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_01_4758_7791
{
    class Program
    {
        static Random r = new Random(DateTime.Now.Millisecond);
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your choice between the 2 exercices");
            //int choice = Int32.Parse(Console.ReadLine());
            //do
            //{
            //    switch (choice)
            //    {
            //        case 1:
            //            Part_1 t1 = new Part_1();
            //            t1.hagrel(r);
            //            t1.showResults();
            //            break;
            //        case 2:
            //            Part_2 t2 = new Part_2();
            //            Console.WriteLine("Enter your choice");
            //            int choix = Int32.Parse(Console.ReadLine());
            //            break;
            //        default:
            //            break;
            //    }
            //} while (choice !=0);

            Console.WriteLine("Please choose between 'cheela1' or 'cheela2'");
            string choice = Console.ReadLine();
            if (choice == "cheela1")
            {
                Part_1 t1 = new Part_1();
                t1.hagrel(r);
                t1.showResults(); 
            }
                else if(choice == "cheela2")
                {
                Part_2 t2 = new Part_2();
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}

/* OUTPUT CHEELA1
 *   63  58  45  19  43  56  23 108  49  36  82 101 106  27  24  64  89  55  68  99
     27  88  83  60  61  93  78  20  94  77 101 101  89  51  35  61 115  97  34  42
     36  30  38  41  18  37  55  88  45  41  19   0  17  24  11   3  26  42  34  57
     Press any key to continue */
