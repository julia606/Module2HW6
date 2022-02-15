// <copyright file="VolkswagenTiguan.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW6
{
    /// <summary>
    /// Class of car.
    /// </summary>
    internal class VolkswagenTiguan : CarWithDieselEngine
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolkswagenTiguan"/> class.
        /// </summary>
        /// <param name="price">Price.</param>
        /// <param name="fuel">Fuel.</param>
        public VolkswagenTiguan(decimal price, double fuel)
        {
            this.Price = price;
            this.Fuel = fuel;
        }

        /// <summary>
        /// Model of car.
        /// </summary>
        /// <returns>Model of your car.</returns>
        public override string Model()
        {
            return "Volkswagen Tiguan";
        }
    }
}
