// See https://aka.ms/new-console-template for more information
using System;

int firstNum = int.Parse(Console.ReadLine());
int lastNum = int.Parse(Console.ReadLine());

    while (firstNum <= lastNum) 
    {
        Console.Write((char)firstNum + " ");
        firstNum++;
    }
