﻿using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> treasure = new Dictionary<string, int>();
            while (true)
            {
                string items = Console.ReadLine();
                if (items == "stop")
                {
                    break;
                }
                int value = int.Parse(Console.ReadLine());

                if (treasure.ContainsKey(items))
                {
                    treasure[items] += value;
                }
                else
                {
                    treasure.Add(items, value);
                }


            }
            foreach (var item in treasure)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
        
