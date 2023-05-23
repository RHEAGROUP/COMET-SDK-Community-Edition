// --------------------------------------------------------------------------------------------------------------------
// <copyright file "DateTimeParameterTypeSerializer.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="DateTimeParameterTypeSerializer"/> class is to provide a <see cref="DateTimeParameterType"/> specific serializer
    /// </summary>
    public class DateTimeParameterTypeSerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// The map containing the serialization methods
        /// </summary>
        private readonly Dictionary<string, Func<object, JsonValue>> propertySerializerMap = new()
        {
            { "alias", alias => JsonValue.Create(alias) },
            { "category", category => JsonValue.Create(category) },
            { "classKind", classKind => JsonValue.Create(classKind.ToString()) },
            { "definition", definition => JsonValue.Create(definition) },
            { "excludedDomain", excludedDomain => JsonValue.Create(excludedDomain) },
            { "excludedPerson", excludedPerson => JsonValue.Create(excludedPerson) },
            { "hyperLink", hyperLink => JsonValue.Create(hyperLink) },
            { "iid", iid => JsonValue.Create(iid) },
            { "isDeprecated", isDeprecated => JsonValue.Create(isDeprecated) },
            { "modifiedOn", modifiedOn => JsonValue.Create(((DateTime)modifiedOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "name", name => JsonValue.Create(name) },
 
            { "revisionNumber", revisionNumber => JsonValue.Create(revisionNumber) },
            { "shortName", shortName => JsonValue.Create(shortName) },
            { "symbol", symbol => JsonValue.Create(symbol) },
            { "thingPreference", thingPreference => JsonValue.Create(thingPreference) },
        };

        /// <summary>
        /// Serialize the <see cref="DateTimeParameterType"/>
        /// </summary>
        /// <param name="dateTimeParameterType">The <see cref="DateTimeParameterType"/> to serialize</param>
        /// <returns>The <see cref="JsonObject"/></returns>
        private JsonObject Serialize(DateTimeParameterType dateTimeParameterType)
        {
            var jsonObject = new JsonObject
            {
                {"alias", this.PropertySerializerMap["alias"](dateTimeParameterType.Alias.OrderBy(x => x, this.guidComparer))},
                {"category", this.PropertySerializerMap["category"](dateTimeParameterType.Category.OrderBy(x => x, this.guidComparer))},
                {"classKind", this.PropertySerializerMap["classKind"](Enum.GetName(typeof(CDP4Common.CommonData.ClassKind), dateTimeParameterType.ClassKind))},
                {"definition", this.PropertySerializerMap["definition"](dateTimeParameterType.Definition.OrderBy(x => x, this.guidComparer))},
                {"excludedDomain", this.PropertySerializerMap["excludedDomain"](dateTimeParameterType.ExcludedDomain.OrderBy(x => x, this.guidComparer))},
                {"excludedPerson", this.PropertySerializerMap["excludedPerson"](dateTimeParameterType.ExcludedPerson.OrderBy(x => x, this.guidComparer))},
                {"hyperLink", this.PropertySerializerMap["hyperLink"](dateTimeParameterType.HyperLink.OrderBy(x => x, this.guidComparer))},
                {"iid", this.PropertySerializerMap["iid"](dateTimeParameterType.Iid)},
                {"isDeprecated", this.PropertySerializerMap["isDeprecated"](dateTimeParameterType.IsDeprecated)},
                {"modifiedOn", this.PropertySerializerMap["modifiedOn"](dateTimeParameterType.ModifiedOn)},
                {"name", this.PropertySerializerMap["name"](dateTimeParameterType.Name)},
                {"revisionNumber", this.PropertySerializerMap["revisionNumber"](dateTimeParameterType.RevisionNumber)},
                {"shortName", this.PropertySerializerMap["shortName"](dateTimeParameterType.ShortName)},
                {"symbol", this.PropertySerializerMap["symbol"](dateTimeParameterType.Symbol)},
                {"thingPreference", this.PropertySerializerMap["thingPreference"](dateTimeParameterType.ThingPreference)},
            };

            return jsonObject;
        }

        /// <summary>
        /// Gets the map containing the serialization method for each property of the <see cref="DateTimeParameterType"/> class.
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

            if (thing is not DateTimeParameterType dateTimeParameterType)
            {
                throw new InvalidOperationException("The thing is not a DateTimeParameterType.");
            }

            return this.Serialize(dateTimeParameterType);
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
