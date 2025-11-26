using System;
using System.Collections.Generic;

namespace Core4Logistics
{
    //Entry point of the program
    public static class Program
    {
        public static void Main(string[] args)
        {
            //Create the main driver list
            List<Driver> drivers = new List<Driver>();

           //Launch the main menu
           MainMenu.Show(drivers, loads);
        }
    }
}