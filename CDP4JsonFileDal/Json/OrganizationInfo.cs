﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OrganizationInfo.cs" company="Starion Group S.A.">
//    Copyright (c) 2015-2019 Starion Group S.A.
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

namespace CDP4JsonFileDal.Json
{
    using System;

    /// <summary>
    /// Holds the organization info that is included in an exchange header file.
    /// </summary>
    public class OrganizationInfo
    {
        /// <summary>
        /// Gets or sets an optional unique identifier of the organization.
        /// </summary>
        public Guid? Iid { get; set; }

        /// <summary>
        /// Gets or sets the name of the organization.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the optional abbreviated name of a unit inside of the organization.
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets the optional geographic location of the organization.
        /// </summary>
        public string Site { get; set; }
    }
}
