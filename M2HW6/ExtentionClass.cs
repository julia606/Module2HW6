// <copyright file="ExtentionClass.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace M2HW6
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Extension Class.
    /// </summary>
    internal static class ExtentionClass
    {
        /// <summary>
        /// Compares objects.
        /// </summary>
        /// <param name = "cars" > Array of Cars. </ param >
        /// <param name = "match" > Matching condition. </ param >
        public static void Find(this Car[] cars, Predicate<Car> match)
        {
            foreach (var car in cars)
            {
                if (match(car))
                {
                    Console.WriteLine($"Найдена машина ценой больше 800500 тыс.грн  : {car.Model()}");
                }
            }
        }
    }
}
