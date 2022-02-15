// <copyright file="AbstractFactoryCar.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW6
{
    /// <summary>
    /// Abstract factory for car.
    /// </summary>
    internal abstract class AbstractFactoryCar
    {
        /// <summary>
        /// Get car with diesel.
        /// </summary>
        /// <returns>Object Car.</returns>
        public abstract CarWithDieselEngine GetCarWithDiesel();

        /// <summary>
        /// Get car with petrol engine.
        /// </summary>
        /// <returns>Object Car.</returns>
        public abstract CarWithPetrolEngine GetCarWithPetrol();

        /// <summary>
        /// Get pickup.
        /// </summary>
        /// <returns>Object Car.</returns>
        public abstract Pickup GetPickup();

        /// <summary>
        /// Get sport car.
        /// </summary>
        /// <returns>Object Car.</returns>
        public abstract SportCar GetSportCar();
    }
}
