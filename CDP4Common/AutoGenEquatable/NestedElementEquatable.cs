// ------------------------------------------------------------------------------------------------
// <copyright file="NestedElementEquatable.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2023 RHEA System S.A.
//
//    Author: Sam Gerené, Alex Vorobiev, Alexander van Delft, Nathanael Smiechowski, 
//            Antoine Théate, Omar Elabiary, Jaime Bernar
//
//    This file is part of CDP4-COMET-SDK Community Edition
//    This is an auto-generated class. Any manual changes to this file will be overwritten!
//
//    The CDP4-COMET-SDK Community Edition is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 3 of the License, or (at your option) any later version.
//
//    The CDP4-COMET-SDK Community Edition is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public License
//    along with this program; if not, write to the Free Software Foundation,
//    Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// ------------------------------------------------------------------------------------------------

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

/* -------------------------------------------- | ---------------------------- | ----------- | ------- *
 | index | name                                 | Type                         | Cardinality | version |
 | -------------------------------------------- | ---------------------------- | ----------- | ------- |
 | 0     | iid                                  | Guid                         |  1..1       |  1.0.0  |
 | 1     | revisionNumber                       | int                          |  1..1       |  1.0.0  |
 | -------------------------------------------- | ---------------------------- | ----------- | ------- |
 | 2     | elementUsage                         | Guid                         | 1..*        |  1.0.0  |
 | 3     | isVolatile                           | bool                         | 1..1        |  1.0.0  |
 | 4     | nestedParameter                      | Guid                         | 0..*        |  1.0.0  |
 | 5     | rootElement                          | Guid                         | 1..1        |  1.0.0  |
 | 6     | excludedDomain                       | Guid                         | 0..*        |  1.1.0  |
 | 7     | excludedPerson                       | Guid                         | 0..*        |  1.1.0  |
 | 8     | modifiedOn                           | DateTime                     | 1..1        |  1.1.0  |
 | 9     | thingPreference                      | string                       | 0..1        |  1.2.0  |
 * -------------------------------------------- | ---------------------------- | ----------- | ------- */

namespace CDP4Common.DTO.Equatable
{
    using System.Linq;

    using CDP4Common.DTO;

    /// <summary>
    /// An extension class for the <see cref="NestedElement"/> to support the computation
    /// of property based equality
    /// </summary>
    public static class NestedElementEquatable
    {
        /// <summary>
        /// Determines whether 2 <see cref="NestedElement"/> objects are the same
        /// by comparing all the properties
        /// </summary>
        /// <param name="me">
        /// The current <see cref="NestedElement"/>
        /// </param>
        /// <param name="other">
        /// The <see cref="NestedElement"/> that the <paramref name="me"/> is
        /// compared to
        /// </param>
        /// <returns>
        /// returns true when all the properties of the <see cref="NestedElement"/> objects
        /// have the same value
        /// </returns>
        public static bool ArePropertiesEqual(this NestedElement me, NestedElement other)
        {
            if (me == null && other == null) return true;

            if (me == null || other == null) return false;

            if (!me.Iid.Equals(other.Iid)) return false;

            if (!me.RevisionNumber.Equals(other.RevisionNumber)) return false;

            if (!me.ElementUsage.OrderBy(x => x.K).Select(x => x.K).SequenceEqual(other.ElementUsage.OrderBy(x => x.K).Select(x => x.K))) return false;
            if (!me.ElementUsage.OrderBy(x => x.K).Select(x => x.V).SequenceEqual(other.ElementUsage.OrderBy(x => x.K).Select(x => x.V))) return false;

            if (!me.IsVolatile.Equals(other.IsVolatile)) return false;

            if (!me.NestedParameter.OrderBy(x => x).SequenceEqual(other.NestedParameter.OrderBy(x => x))) return false;

            if (!me.RootElement.Equals(other.RootElement)) return false;

            if (!me.ExcludedDomain.OrderBy(x => x).SequenceEqual(other.ExcludedDomain.OrderBy(x => x))) return false;

            if (!me.ExcludedPerson.OrderBy(x => x).SequenceEqual(other.ExcludedPerson.OrderBy(x => x))) return false;

            if (!me.ModifiedOn.Equals(other.ModifiedOn)) return false;

            if (me.ThingPreference == null && other.ThingPreference != null) return false;
            if (me.ThingPreference != null && !me.ThingPreference.Equals(other.ThingPreference)) return false;

            return true;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------