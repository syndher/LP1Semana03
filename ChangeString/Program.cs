﻿using System ;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


namespace RightSize
{
      
    class Program
    {
           
        static void Main (string[] args)
        {
            Console.WriteLine("Write a line");
            string resposta = Console.ReadLine();

            Console.WriteLine("Write a character");
            string carater = Console.ReadLine();
            char caraterreal = char.Parse(carater);

            string substituto = "x";
            char charsub = char.Parse(substituto);

            string novaresposta = ""; 

            foreach (char caraterin in resposta)
            {
                if (caraterin == caraterreal)
                {
                    novaresposta +=  
                }
                    
            }


                
                        
            

                    
        }

               


            
    }
}