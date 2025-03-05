﻿using System ;
using System.Net.Http.Headers;
using System.Numerics;



namespace ArrayMul
{
      
    class Program
    {
           
        static void Main (string[] args)
        {
            float arg1 = float.Parse(args[0]);
            float arg2 = float.Parse(args[1]);
            float arg3 = float.Parse(args[2]);
            float arg4 = float.Parse(args[3]);
            float arg5 = float.Parse(args[4]);
            float arg6 = float.Parse(args[5]);

            float[][] matrix = new float [2][];
            matrix[0] = new float[2] {arg1, arg2};
            matrix[1] = new float[2] {arg3, arg4};

            float[][] vector = new float[2][];
            vector[0] = new float [1] {arg5};
            vector[1] = new float [1] {arg6};

            for (int i = 0; i < matrix.Length; i++)
            {
                
                for (int j = 0; j < vector.Length; j++)
                {

                }
            }
            
        }
                
            
            


                
                        
            

                    
    }

               


            
}
