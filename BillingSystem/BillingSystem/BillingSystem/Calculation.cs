
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem
{
    class Calculation
    {
        int  totalamount=0, vsp=0,vsq=500, bsp=1300, bsq=1000, ksp=4500, ksq=980, vdsp=1100, vdsq=1250, kdsp=1570, kdsq=2500;
       double gst=0;
        public int SilkSaree(int ch,int qty)
        {
            
            totalamount = 0;
            if (ch==1&&qty<vsq)
            {
                Console.Write("Enter  Varanasi Silk's Amount:--> ");
                vsp=Convert.ToInt32(Console.ReadLine());
                vsq -= qty;
                totalamount = totalamount + (qty * vsp);
                gst = totalamount * (2.5 / 100);
                
                totalamount = totalamount + Convert.ToInt32(gst);
                Console.WriteLine("Varanaasi Silk's Amount:->  {0}  Gst :-> {1} Total amount:->{2} ",vsp,gst,totalamount);
            }
            
            else if (ch == 2 && qty < bsq)
            {
                Console.Write("Enter  Banaras Silk's Amount:--> ");
                bsp = Convert.ToInt32(Console.ReadLine());
                bsq -= qty;
                totalamount = totalamount + (qty * bsp);
                gst = totalamount * (2.5 / 100);
                totalamount = totalamount + Convert.ToInt32(gst);
                Console.WriteLine("Banaras Silk's Amount:->  {0}  Gst :-> {1} Total amount:->{2} ", bsp, gst, totalamount);
            }
            
            else if (ch == 3 && qty < ksq)
            {
                Console.Write("Enter  kanceepuram Silk's Amount:--> ");
                ksp = Convert.ToInt32(Console.ReadLine());
                ksq -= qty;
                totalamount = totalamount + (qty * ksp);
                gst = totalamount * (2.5 / 100);
                totalamount = totalamount + Convert.ToInt32(gst);
                Console.WriteLine("Kanceepuram Silk's Amount:->  {0}  Gst :-> {1} Total amount:->{2} ", ksp, gst, totalamount);
            }
            else
            {
                Console.WriteLine("Out Of Stock");
            }
            return totalamount;
        }

        public int DesignerSaree(int ch, int qty)
        {
            totalamount = 0;
            if (ch == 4 && qty < vdsq)
            {
                Console.Write("Enter  Varanasi  Designer Silk's Amount:--> ");
                vdsp = Convert.ToInt32(Console.ReadLine());
                vdsq -= qty;
                totalamount = totalamount + (qty * vdsp);
                Console.WriteLine(totalamount);
                gst = totalamount * (3.2 / 100);
               totalamount = totalamount + Convert.ToInt32(gst);
                Console.WriteLine("Varanaasi Designer Silk's Amount:->  {0}  Gst :-> {1} Total amount:-> {2}", vdsp, gst, totalamount);
            }
           
           else if (ch == 5 && qty < kdsq)
            {
                Console.Write("Enter  Kancheepuram Desighner Silk's Amount:--> ");
                kdsp = Convert.ToInt32(Console.ReadLine());
                kdsq -= qty;
                totalamount = totalamount + (qty * kdsp);
                gst = totalamount * (3.2 / 100);
                totalamount = totalamount + Convert.ToInt32(gst);
                Console.WriteLine(" Kancheepuram Desighner Silk's Amount:->  {0}  Gst :-> {1} Total amount:->{2} ", kdsp, gst, totalamount);
            }
            else
            {
                Console.WriteLine("Out Of Stock");
            }
            return totalamount;
        }
    }
}
