﻿using System;

namespace IClown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IClown fingersTheClown = new ScaryScary("big red nose", 14); 
            fingersTheClown.Honk(); 
            
            if(fingersTheClown is IScaryClown iScaryClownReference)
                iScaryClownReference.ScareAdults();
            

               


            Console.ReadKey();
        }
    }
}
