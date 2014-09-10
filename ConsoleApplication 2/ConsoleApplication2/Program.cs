using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        static void Main(string[] args)
        {

            int värde = 0;
            
            for (int i = 0; i < 25; i++)
            {

                               
                if (värde > 2)
                {
                    värde = 0;
                }
                
                switch (värde)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 2:                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;                   
                }
                ++värde;
                
                
                for (int j = 0; j < 39; j++)
                {                   
                    Console.Write("* ");
                }
                
                Console.WriteLine();
                

                if (i % 2 == 0)
                {
                    Console.Write(" ");
                }
                
             
        
             }
            Console.ResetColor();
                
        
             
            

        }
    }
}
