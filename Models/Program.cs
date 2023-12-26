﻿using System;
using DesafioPOO.Models;
using PhonePooProject.Models;


namespace PhonePooProject
{
    class Program 
    {
        static void Main()
        {
            Flip f = new Flip("123456789", "ModelFlip", "IMEIFlip", 512); //Criação de uma instância (objeto).
            f.InstalarAplicativo("AppFlip"); //Chamando o método(). 
            Iphone i = new Iphone("111222333", "ModelIphone", "IMEIIphone", 1024);
            i.InstalarAplicativo("AppIphone");

            Console.ReadLine();
            
        }
    }
}
