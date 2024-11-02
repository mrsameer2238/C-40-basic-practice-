using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anotherexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************OutPut Window*************");
          
            //* Read a,b value then calculate sum of 2 numbers and store into c 
            // Variable,Then Display C value.
            Console.WriteLine("ENTER VALUE OF a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER VALUE OF b:");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Sum Of Varible is :"+c);
            Console.ReadKey();
            Console.WriteLine("===================================");
           
            //* Read 3 subject marks , then calculate total ,avg marks;
            Console.WriteLine(" ENTER 1st SUBJECT MARKS ::");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ENTER 2nd SUBJECT MARKS ::");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ENTER 3rd SUBJECT MARKS ::");
            int s3 = Convert.ToInt32(Console.ReadLine());
            int totl = s1 + s2 + s3;
            Console.WriteLine(" You Got Total MARKS ::"+totl);
            double avg = totl  / 3;
            Console.WriteLine(" Your Average is  ::"+avg);
            Console.ReadKey();
            Console.WriteLine("===================================");
            
            //* Read the product cost and quantity from users, then calculate bill
            //  amount.shop provide 15% Discount on Bill Amount so calculate Final 
            // bill Amount. 

            Console.WriteLine("ENTER Product Cost ::");
            double pcost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Quantity Of Product ::");
            int qant = Convert.ToInt32(Console.ReadLine());
            double bill = pcost * qant;
            Console.WriteLine("BiLL AMOUNT IS ::" +bill);
            double dis = (bill * 15 )/100;
            double final = bill - dis;
            Console.WriteLine("Discount Amount :" + dis);
            Console.WriteLine("FINAL BILLL AMPUNT IS ::" + final);
            Console.ReadKey();

        }
    }
}
