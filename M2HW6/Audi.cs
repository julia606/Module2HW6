// <copyright file="Audi.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW6
{
    /// <summary>
    /// Audi.
    /// </summary>
    internal class Audi : SportCar
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Audi"/> class.
        /// </summary>
        /// <param name="price">Price.</param>
        /// <param name="fuel">Fuel.</param>
        public Audi(decimal price, double fuel)
        {
            this.Price = price;
            this.Fuel = fuel;
        }

        /// <summary>
        /// Model.
        /// </summary>
        /// <returns>Model of car.</returns>
        public override string Model()
        {
            return "Audi";
        }
    }
}
