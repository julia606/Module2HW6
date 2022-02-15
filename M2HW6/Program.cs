// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW6
{
    using System;

    /// <summary>
    /// Main class.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Find car with price greater 800,500.
        /// </summary>
        /// <param name = "car" > Object Car. </ param >
        /// <returns>All cars with price > 800,500.</returns>
        public static bool AnimalWithLengthGreater50(Car car)
        {
            return car.Price > 800500;
        }

        private static void Main(string[] args)
        {
            var myTaxiDepot = new TaxiDepot();
            Car[] cars = new Car[]
            {
                myTaxiDepot.GetPickup(), myTaxiDepot.GetCarWithDiesel(),
                myTaxiDepot.GetCarWithPetrol(), myTaxiDepot.GetSportCar(),
            };
            Console.WriteLine($"Стоимость автопарка: {myTaxiDepot.TotalPrice(cars)} грн.");
            Array.Sort(cars);

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model()} - {car.Price} грн.");
            }

            Console.WriteLine();
            ExtentionClass.Find(cars, AnimalWithLengthGreater50);
        }
    }
}
