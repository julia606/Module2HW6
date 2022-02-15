// <copyright file="Mazda.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW6
{
    /// <summary>
    /// Mazda.
    /// </summary>
    internal class Mazda : CarWithPetrolEngine
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mazda"/> class.
        /// </summary>
        /// <param name="price">Price.</param>
        /// <param name="fuel">fuel.</param>
        public Mazda(decimal price, double fuel)
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
            return "Mazda";
        }
    }
}
