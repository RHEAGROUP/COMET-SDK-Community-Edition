﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValueArrayUtils.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2018 RHEA System S.A.
//
//    Author: Sam Gerené, Merlin Bieze, Alex Vorobiev, Naron Phou
//
//    This file is part of CDP4-SDK Community Edition
//
//    The CDP4-SDK Community Edition is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 3 of the License, or (at your option) any later version.
//
//    The CDP4-SDK Community Edition is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public License
//    along with this program; if not, write to the Free Software Foundation,
//    Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace CDP4Common.Helpers
{
    using System;
    using System.Collections.Generic;
    using CDP4Common.Types;

    /// <summary>
    /// The purpose of the <see cref="ValueArrayUtils"/> is to provide static helper methods for handling
    /// business logic related to <see cref="ValueArray{T}"/>
    /// </summary>
    public static class ValueArrayUtils
    {
        /// <summary>
        /// Creates a <see cref="ValueArray{String}"/> with as many slots containing "-" as the provided <paramref name="numberOfValues"/>
        /// </summary>
        /// <param name="size">
        /// An integer denoting the number of slots, this may not be lower than one.
        /// </param>
        /// <returns>
        /// An instance of <see cref="ValueArray{String}"/>
        /// </returns>
        public static ValueArray<string> CreateDefaultValueArray(int size)
        {
            if (size < 1)
            {
                throw new ArgumentOutOfRangeException($"The {nameof(size)} may not be smaller than 1.", nameof(size));
            }
            
            var defaultValue = new List<string>(size);

            for (int i = 0; i < size; i++)
            {
                defaultValue.Add("-");
            }

            var result = new ValueArray<string>(defaultValue);

            return result;
        }
    }
}