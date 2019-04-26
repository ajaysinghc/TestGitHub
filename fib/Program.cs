using System;

namespace fib
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] num = {2,4,6,8};
            int numOfElements = 12;
           var final =  printNum(num, numOfElements);
           for(int i= 0; i<final.Length;i++)
               Console.WriteLine(final[i]);
            Console.ReadLine();
        }
        
        static int sumLastNElement(int[] num, int start, int lastN)
        {
           int k= 0;
           for(int j = 0; j<=lastN; j++)
               k+=num[start-j];
           return k;
        }

        static int[] printNum(int[] num , int count)
        {
            int numLen = num.Length;
            var final = new int[count];
           // Array.Copy()

            for(int i = 0; i<final.Length; i++ )
            {
               if (i< numLen )
               {
                   final[i] = num[i];
               }
               else
               {
                  if(i== numLen)
                      final[i] = sumLastNElement(final,i,numLen);
                  else
                      final[i] = final[i-1] + final[i-1] - final[i-numLen-1];//sumLastNElement(final,i,numLen);
               }
            }
            return final;
        }
    }
}
