// --------------------------------------------------------------------------------------------------------------------
// <copyright file "IterationSetupSerializer.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2023 RHEA System S.A.
//
//    Author: Sam Gerené, Merlin Bieze, Alex Vorobiev, Naron Phou, Alexander van Delft, Nathanael Smiechowski, Jaime Bernar
//
//    This file is part of CDP4-SDK Community Edition
//    This is an auto-generated class. Any manual changes to this file will be overwritten!
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
// --------------------------------------------------------------------------------------------------------------------

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace CDP4JsonSerializer
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.Json.Nodes;

    using CDP4Common.DTO;
    using CDP4Common.Types;
    
    /// <summary>
    /// The purpose of the <see cref="IterationSetupSerializer"/> class is to provide a <see cref="IterationSetup"/> specific serializer
    /// </summary>
    public class IterationSetupSerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// The map containing the serialization methods
        /// </summary>
        private readonly Dictionary<string, Func<object, JsonValue>> propertySerializerMap = new()
        {
            { "classKind", classKind => JsonValue.Create(classKind.ToString()) },
            { "createdOn", createdOn => JsonValue.Create(((DateTime)createdOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "description", description => JsonValue.Create(description) },
            { "excludedDomain", excludedDomain => JsonValue.Create(excludedDomain) },
            { "excludedPerson", excludedPerson => JsonValue.Create(excludedPerson) },
            { "frozenOn", frozenOn => JsonValue.Create(frozenOn != null ? ((DateTime)frozenOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ") : null) },
            { "iid", iid => JsonValue.Create(iid) },
            { "isDeleted", isDeleted => JsonValue.Create(isDeleted) },
            { "iterationIid", iterationIid => JsonValue.Create(iterationIid) },
            { "iterationNumber", iterationNumber => JsonValue.Create(iterationNumber) },
            { "modifiedOn", modifiedOn => JsonValue.Create(((DateTime)modifiedOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "revisionNumber", revisionNumber => JsonValue.Create(revisionNumber) },
            { "sourceIterationSetup", sourceIterationSetup => JsonValue.Create(sourceIterationSetup) },
            { "thingPreference", thingPreference => JsonValue.Create(thingPreference) },
        };

        /// <summary>
        /// Serialize the <see cref="IterationSetup"/>
        /// </summary>
        /// <param name="iterationSetup">The <see cref="IterationSetup"/> to serialize</param>
        /// <returns>The <see cref="JsonObject"/></returns>
        private JsonObject Serialize(IterationSetup iterationSetup)
        {
            var jsonObject = new JsonObject
            {
                {"classKind", this.PropertySerializerMap["classKind"](Enum.GetName(typeof(CDP4Common.CommonData.ClassKind), iterationSetup.ClassKind))},
                {"createdOn", this.PropertySerializerMap["createdOn"](iterationSetup.CreatedOn)},
                {"description", this.PropertySerializerMap["description"](iterationSetup.Description)},
                {"excludedDomain", this.PropertySerializerMap["excludedDomain"](iterationSetup.ExcludedDomain.OrderBy(x => x, this.guidComparer))},
                {"excludedPerson", this.PropertySerializerMap["excludedPerson"](iterationSetup.ExcludedPerson.OrderBy(x => x, this.guidComparer))},
                {"frozenOn", this.PropertySerializerMap["frozenOn"](iterationSetup.FrozenOn)},
                {"iid", this.PropertySerializerMap["iid"](iterationSetup.Iid)},
                {"isDeleted", this.PropertySerializerMap["isDeleted"](iterationSetup.IsDeleted)},
                {"iterationIid", this.PropertySerializerMap["iterationIid"](iterationSetup.IterationIid)},
                {"iterationNumber", this.PropertySerializerMap["iterationNumber"](iterationSetup.IterationNumber)},
                {"modifiedOn", this.PropertySerializerMap["modifiedOn"](iterationSetup.ModifiedOn)},
                {"revisionNumber", this.PropertySerializerMap["revisionNumber"](iterationSetup.RevisionNumber)},
                {"sourceIterationSetup", this.PropertySerializerMap["sourceIterationSetup"](iterationSetup.SourceIterationSetup)},
                {"thingPreference", this.PropertySerializerMap["thingPreference"](iterationSetup.ThingPreference)},
            };

            return jsonObject;
        }

        /// <summary>
        /// Gets the map containing the serialization method for each property of the <see cref="IterationSetup"/> class.
        /// </summary>
        public IReadOnlyDictionary<string, Func<object, JsonValue>> PropertySerializerMap => this.propertySerializerMap;

        /// <summary>
        /// Serialize the <see cref="Thing"/> to JObject
        /// </summary>
        /// <param name="thing">The <see cref="Thing"/> to serialize</param>
        /// <returns>The <see cref="JsonObject"/></returns>
        public JsonObject Serialize(Thing thing)
        {
            if (thing == null)
            {
                throw new ArgumentNullException($"The {nameof(thing)} may not be null.", nameof(thing));
            }

            if (thing is not IterationSetup iterationSetup)
            {
                throw new InvalidOperationException("The thing is not a IterationSetup.");
            }

            return this.Serialize(iterationSetup);
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
