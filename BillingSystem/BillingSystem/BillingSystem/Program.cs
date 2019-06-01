using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0, quantity = 0;
            Console.WriteLine("!!!!!!!!!!!Welcome To Saravana Stores!!!!!!!!!!!!!");
            Console.WriteLine("1-->Varanasi Silk                 - 1200/-");
            Console.WriteLine("2-->Banaras Silk                  - 1300/- ");
            Console.WriteLine("3-->Kancheepuram Silk             - 4500/-");
            Console.WriteLine("4-->Varanasi Designer Silk        - 1100/-");
            Console.WriteLine("5-->Kancheepuram Designer Silk    - 1570/- ");
            Console.WriteLine("Enter your no of  variety : ");
            int variety = 0;
            variety= Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter your choices along with qty [Ex: 1 4]: ");
            int itr;
            BillGeneration bg = new BillGeneration();
            for (itr=0;itr<variety;itr++)
            {
                choice = Convert.ToInt32(Console.ReadLine());

                quantity = Convert.ToInt32(Console.ReadLine());
                int flag = 0;
                
                if (choice > 3)
                {
                    flag = 1;

                    bg.Calculation1(choice, quantity, flag);
                }
                else
                {
                    bg.Calculation1(choice, quantity);
                }
            }
            Console.WriteLine("Total:{0}", bg.finalt());
            Console.ReadKey();
        }
      
    }


}
  
