﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstPracticalExercise
{
    public class Car:Transport
    {
        public Car() 
        {
        
        }
        public string FuelType {  get; set; }
        public void Honk()
        {
            Console.WriteLine($"{Name} signal chalmoqda: Beep Beep!");
        }
    }
}
