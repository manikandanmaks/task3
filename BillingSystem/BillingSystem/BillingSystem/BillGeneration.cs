using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem
{
    class BillGeneration:Calculation
    {

        public BillGeneration()
        {

        }
        ~BillGeneration()
        {

        }
        int t = 0, final=0;
        public void Calculation1(int ch, int qty)
        {
          
           
           t= SilkSaree(ch,qty);
            
            final =final+t;

           

        }
        public void  Calculation1(int ch, int qty,int f)
        {
           
            t=DesignerSaree(ch,qty);
            
            final = final + t;

        }

        public int finalt()
        {
            return final;
        }

    }
}
