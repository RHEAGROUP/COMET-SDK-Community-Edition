﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDataCollector.cs" company="Starion Group S.A.">
//    Copyright (c) 2015-2023 Starion Group S.A.
//
//    Author: Sam Gerené, Alex Vorobiev, Alexander van Delft
//
//    This file is part of COMET-SDK Community Edition
//
//    The COMET-SDK Community Edition is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 3 of the License, or (at your option) any later version.
//
//    The COMET-SDK Community Edition is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public License
//    along with this program; if not, write to the Free Software Foundation,
//    Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// </copyright>
// -------------------------------------------------------------------------------------------------------------------------------

namespace CDP4Reporting.DataCollection
{
    using CDP4Reporting.DynamicTableChecker;

    public interface IDataCollector
    {
        /// <summary>
        /// The <see cref="IDynamicTableCellsCollector"/> that contains data about table cells that can be added dynamically to the report.
        /// </summary>
        IDynamicTableCellsCollector DynamicTableCellsCollector { get; }

        /// <summary>
        /// Creates a new data object instance. Could be anything depending on what the data is used for.
        /// </summary>
        /// <returns>
        /// An object instance.
        /// </returns>
        object CreateDataObject();
    }
}
