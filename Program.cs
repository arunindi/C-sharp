﻿using System.ComponentModel;
using System.Globalization;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

public class Program
{
    public static void Main(string[] args)
    {
        Calculator mine=new Calculator();
        {
            Console.Write(mine.Add(2,3));               
        }
    }
}
public class Calculator
{    
    public int Add(int a,int b)
   {
    return a+b;
   }
   public string methodanother()
   {
        return "Hello priends";
   }
}