using System;
using System.Collections.Generic;


namespace Core4Dispatch
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Load existing data on startup
            List<Driver> drivers = JsonStorageService.LoadData<Driver>("Data/drivers.json");
            List<Tractor> tractors = JsonStorageService.LoadData<Tractor>("Data/tractors.json");
            List<Trailer> trailers = JsonStorageService.LoadData<Trailer>("Data/trailers.json");

            Console.WriteLine("Loaded drivers:");
            foreach (var d in drivers)
            {
                Console.WriteLine($"{d.DriverId}: {d.Name} - {d.Status}");
            }

            // TEMP loads list until we build load model
            List<Load> loads = new List<Load>();

            // Launch main menu (placeholder for now)
            // MainMenu.Show(drivers, loads);

            Console.WriteLine("\nProgram.cs restore complete.");
        }
    }
}
