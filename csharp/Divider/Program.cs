﻿using System;

class Divider 
{
    public static void Main (string[] args) 
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++) 
        {
            if (n % i == 0)
                Console.WriteLine(i);
        }
        Console.WriteLine();
    }
}