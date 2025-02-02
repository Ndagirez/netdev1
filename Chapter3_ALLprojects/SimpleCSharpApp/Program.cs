﻿// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void ShowEnvironmentDetails()
    {
        // Print out the drives on this machine,
        // and other interesting details.
        foreach (string drive in Environment.GetLogicalDrives())
        {
            Console.WriteLine("Drive: {0}", drive);
        }
        Console.WriteLine("OS: {0}", Environment.OSVersion);
        Console.WriteLine("Number of processors: {0}",
        Environment.ProcessorCount);
        Console.WriteLine(".NET Core Version: {0}",
        Environment.Version);
    }
    static int Main(string[] args)
    {
        // Display a message and wait for Enter key to be pressed.
        Console.WriteLine("***** My First C# App *****");
        Console.WriteLine("Hello World!");
        Console.WriteLine();
        // Process any incoming args.
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("Arg: {0}", args[i]);
        }
        Console.ReadLine();
        // Get arguments using System.Environment.
        string[] theArgs = Environment.GetCommandLineArgs();

        foreach (string arg in args)
        {
            Console.WriteLine("Arg: {0}", arg);
        }

        // Local method within the Top-level statements.
        ShowEnvironmentDetails();
        Console.ReadLine();
        return -1;
    }
}