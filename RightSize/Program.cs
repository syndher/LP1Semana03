﻿using System ;


namespace RightSize
{
      
    class Program
    {
           
        static void Main (string[] args)
            
        {
            foreach (string palavra in args) 
            {
                if (palavra.Length > 3 & palavra.Length < 8)
                {
                    Console.WriteLine(palavra);
                }
                else if (palavra.Length >= 8)
                {
                    Console.Write("[EARLY STOP]");
                    break;
                }
                        
            }

                    
        }

               


            
    }
}