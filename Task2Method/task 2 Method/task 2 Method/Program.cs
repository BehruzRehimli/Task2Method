using System;

namespace task_2_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 :- Verilmiş N tam ədədinin rəqəmləri cəmini tapan metod 
            //Console.WriteLine("Zehmet olmasa Task 1 uchun eded daxil edin :");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($" ---Reqemlerin cemi {digtSum(n)}-dir");
            #endregion
            #region Task 2 :- Verilmiş M dəyərindən verilmiş N dəyərinədək 21-ə bölünən ədədlərin ədədi ortasını tapan metod  


            //Console.WriteLine("Zehmet olmasa Task 2 uchun 1ci ededi daxil edin :");
            //int m=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Zehmet olmasa Task 2 uchun 2ci ededi daxil edin :");
            //int n =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Verilen ededler arasinda 21-e bolunen ededlerin ededi ortasi {avar21(n,m)}");

            #endregion
            #region Task 3 :- Verilmis yazıda a herfi olub olmadigini tapan metod
            //Console.WriteLine("Zehmet olmasa 3cu task uchun verilen daxil edin : ");
            //string word = Console.ReadLine();
            //if (havea(word)==true)
            //{
            //    Console.WriteLine($" Yazdiginiz verilende a herifi var");
            //}
            //else
            //{
            //    Console.WriteLine("Yazdiginiz verilende a herifi yoxdur");
            //}



            #endregion
        }
        static int digtSum(int n)
        {
            int sum = 0;    
            while (n>=1)
            {
                sum+= n%10;
                n/=10;
            }
            return sum;
        }
        static double avar21(int n, int m)
        {
            int sum = 0;
            double counter = 0;
            int bigger;
            int lower;
            if (n>m)
            {
                bigger= n;
                lower= m;
            }
            else
            {
                bigger= m;
                lower= n;
            }
            for (int i = lower; i < bigger; i++)
            {
                if (i%21==0)
                {
                    sum+= i;
                    counter++;
                }
            }
            return (sum/counter);   
        }
        static bool havea(string n)
        {
            bool test= false;
            foreach (var i in n)
            {
                if (i=='a')
                {
                    test = true;
                    break;
                }
            }
            return test;
        }
    }
}
