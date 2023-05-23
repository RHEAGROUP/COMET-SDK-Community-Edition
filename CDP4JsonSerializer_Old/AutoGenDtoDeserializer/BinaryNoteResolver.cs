// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinaryNoteResolver.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2022 RHEA System S.A.
//
//    Author: Sam Gerené, Merlin Bieze, Alex Vorobiev, Naron Phou, Alexander van Delft, Nathanael Smiechowski
//
//    This file is part of COMET-SDK Community Edition
//    This is an auto-generated class. Any manual changes to this file will be overwritten!
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
// --------------------------------------------------------------------------------------------------------------------

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace CDP4JsonSerializer
{
    using System;
    using System.Collections.Generic;

    using CDP4Common.CommonData;
    using CDP4Common.DiagramData;
    using CDP4Common.EngineeringModelData;
    using CDP4Common.ReportingData;
    using CDP4Common.SiteDirectoryData;

    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The purpose of the <see cref="BinaryNoteResolver"/> is to deserialize a JSON object to a <see cref="BinaryNote"/>
    /// </summary>
    public static class BinaryNoteResolver
    {
        /// <summary>
        /// Instantiate and deserialize the properties of a <paramref name="BinaryNote"/>
        /// </summary>
        /// <param name="jObject">The <see cref="JObject"/> containing the data</param>
        /// <returns>The <see cref="BinaryNote"/> to instantiate</returns>
        public static CDP4Common.DTO.BinaryNote FromJsonObject(JObject jObject)
        {
            var iid = jObject["iid"].ToObject<Guid>();
            var revisionNumber = jObject["revisionNumber"].IsNullOrEmpty() ? 0 : jObject["revisionNumber"].ToObject<int>();
            var binaryNote = new CDP4Common.DTO.BinaryNote(iid, revisionNumber);

            if (!jObject["caption"].IsNullOrEmpty())
            {
                binaryNote.Caption = jObject["caption"].ToObject<string>();
            }

            if (!jObject["category"].IsNullOrEmpty())
            {
                binaryNote.Category.AddRange(jObject["category"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["createdOn"].IsNullOrEmpty())
            {
                binaryNote.CreatedOn = jObject["createdOn"].ToObject<DateTime>();
            }

            if (!jObject["excludedDomain"].IsNullOrEmpty())
            {
                binaryNote.ExcludedDomain.AddRange(jObject["excludedDomain"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["excludedPerson"].IsNullOrEmpty())
            {
                binaryNote.ExcludedPerson.AddRange(jObject["excludedPerson"].ToObject<IEnumerable<Guid>>());
            }

            if (!jObject["fileType"].IsNullOrEmpty())
            {
                binaryNote.FileType = jObject["fileType"].ToObject<Guid>();
            }

            if (!jObject["modifiedOn"].IsNullOrEmpty())
            {
                binaryNote.ModifiedOn = jObject["modifiedOn"].ToObject<DateTime>();
            }

            if (!jObject["name"].IsNullOrEmpty())
            {
                binaryNote.Name = jObject["name"].ToObject<string>();
            }

            if (!jObject["owner"].IsNullOrEmpty())
            {
                binaryNote.Owner = jObject["owner"].ToObject<Guid>();
            }

            if (!jObject["shortName"].IsNullOrEmpty())
            {
                binaryNote.ShortName = jObject["shortName"].ToObject<string>();
            }

            if (!jObject["thingPreference"].IsNullOrEmpty())
            {
                binaryNote.ThingPreference = jObject["thingPreference"].ToObject<string>();
            }

            return binaryNote;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
