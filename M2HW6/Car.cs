// <copyright file="Car.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW6
{
    using System;

    /// <summary>
    /// Class Car.
    /// </summary>
    internal class Car : IComparable<Car>
    {
        private decimal price;
        private double fuelСonsumptionRate;

        /// <summary>
        /// Gets or sets prices of cars.
        /// </summary>
        public decimal Price
        {
            get
            {
                return this.price;
            }

            protected set
            {
                this.price = value;
            }
        }

        /// <summary>
        /// Gets or sets flues consumption rate.
        /// </summary>
        public double Fuel
        {
            get
            {
                return this.fuelСonsumptionRate;
            }

            protected set
            {
                this.fuelСonsumptionRate = value;
            }
        }

        /// <summary>
        /// Compares objects.
        /// </summary>
        /// <param name = "car" > Object An imal. </ param >
        /// <returns>Integer.</returns>
#nullable enable
        public int CompareTo(Car? car)
        {
            if (car is null)
            {
                throw new ArgumentException("Некорректное значение параметра");
            }

            return this.Fuel.CompareTo(car.Fuel);
        }

        /// <summary>
        /// Car's model.
        /// </summary>
        /// <returns>Model of car.</returns>
        public virtual string Model()
        {
            return "Model of car";
        }
    }
}