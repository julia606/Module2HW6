// <copyright file="LandRoverDefenderPickup.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW6
{
    /// <summary>
    /// Car with diesel engine.
    /// </summary>
    internal class LandRoverDefenderPickup : Pickup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LandRoverDefenderPickup"/> class.
        /// </summary>
        /// <param name="price">Price.</param>
        /// <param name="fuel">Fuel.</param>
        public LandRoverDefenderPickup(decimal price, double fuel)
        {
            this.Price = price;
            this.Fuel = fuel;
        }

        /// <summary>
        /// Car's model.
        /// </summary>
        /// <returns>Model of car.</returns>
        public override string Model()
        {
            return "Land Rover Defender";
        }
    }
}
