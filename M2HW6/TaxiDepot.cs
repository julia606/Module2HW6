// <copyright file="TaxiDepot.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW6
{
    /// <summary>
    /// Get car with petrol engine.
    /// </summary>
    /// <returns>Object Car.</returns>
    internal class TaxiDepot : AbstractFactoryCar
    {
        /// <summary>
        /// Get car with diesel engine.
        /// </summary>
        /// <returns>Object Car.</returns>
        public override CarWithDieselEngine GetCarWithDiesel()
        {
            return new VolkswagenTiguan(900450, 6.1);
        }

        /// <summary>
        /// Get car with petrol engine.
        /// </summary>
        /// <returns>Object Car.</returns>
        public override CarWithPetrolEngine GetCarWithPetrol()
        {
            return new Mazda(750900, 5.9);
        }

        /// <summary>
        /// Get pickup.
        /// </summary>
        /// <returns>Object Car.</returns>
        public override Pickup GetPickup()
        {
            return new LandRoverDefenderPickup(1200100, 6);
        }

        /// <summary>
        /// Get sport car.
        /// </summary>
        /// <returns>Object Car.</returns>
        public override SportCar GetSportCar()
        {
            return new Audi(1225789, 5.8);
        }

        /// <summary>
        /// Total price of cars.
        /// </summary>
        /// <returns>Total price of taxi depot.</returns>
        /// <param name = "cars" > Array of Cars. </ param >
        public decimal TotalPrice(Car[] cars)
        {
            decimal total = 0;
            foreach (Car car in cars)
            {
                total += car.Price;
            }

            return total;
        }
    }
}
