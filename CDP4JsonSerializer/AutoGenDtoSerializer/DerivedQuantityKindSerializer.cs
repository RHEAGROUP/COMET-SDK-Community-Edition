// --------------------------------------------------------------------------------------------------------------------
// <copyright file "DerivedQuantityKindSerializer.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="DerivedQuantityKindSerializer"/> class is to provide a <see cref="DerivedQuantityKind"/> specific serializer
    /// </summary>
    public class DerivedQuantityKindSerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// The map containing the serialization methods
        /// </summary>
        private readonly Dictionary<string, Func<object, JsonValue>> propertySerializerMap = new()
        {
            { "alias", alias => JsonValue.Create(alias) },
 
            { "category", category => JsonValue.Create(category) },
            { "classKind", classKind => JsonValue.Create(classKind.ToString()) },
            { "defaultScale", defaultScale => JsonValue.Create(defaultScale) },
            { "definition", definition => JsonValue.Create(definition) },
            { "excludedDomain", excludedDomain => JsonValue.Create(excludedDomain) },
            { "excludedPerson", excludedPerson => JsonValue.Create(excludedPerson) },
            { "hyperLink", hyperLink => JsonValue.Create(hyperLink) },
            { "iid", iid => JsonValue.Create(iid) },
            { "isDeprecated", isDeprecated => JsonValue.Create(isDeprecated) },
            { "modifiedOn", modifiedOn => JsonValue.Create(((DateTime)modifiedOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "name", name => JsonValue.Create(name) },
 
            { "possibleScale", possibleScale => JsonValue.Create(possibleScale) },
  
            { "quantityDimensionSymbol", quantityDimensionSymbol => JsonValue.Create(quantityDimensionSymbol) },
            { "quantityKindFactor", quantityKindFactor => JsonValue.Create(((IEnumerable)quantityKindFactor).Cast<OrderedItem>().Select(x => x.ToJsonObject())) },
            { "revisionNumber", revisionNumber => JsonValue.Create(revisionNumber) },
            { "shortName", shortName => JsonValue.Create(shortName) },
            { "symbol", symbol => JsonValue.Create(symbol) },
            { "thingPreference", thingPreference => JsonValue.Create(thingPreference) },
        };

        /// <summary>
        /// Serialize the <see cref="DerivedQuantityKind"/>
        /// </summary>
        /// <param name="derivedQuantityKind">The <see cref="DerivedQuantityKind"/> to serialize</param>
        /// <returns>The <see cref="JsonObject"/></returns>
        private JsonObject Serialize(DerivedQuantityKind derivedQuantityKind)
        {
            var jsonObject = new JsonObject
            {
                {"alias", this.PropertySerializerMap["alias"](derivedQuantityKind.Alias.OrderBy(x => x, this.guidComparer))},
                {"category", this.PropertySerializerMap["category"](derivedQuantityKind.Category.OrderBy(x => x, this.guidComparer))},
                {"classKind", this.PropertySerializerMap["classKind"](Enum.GetName(typeof(CDP4Common.CommonData.ClassKind), derivedQuantityKind.ClassKind))},
                {"defaultScale", this.PropertySerializerMap["defaultScale"](derivedQuantityKind.DefaultScale)},
                {"definition", this.PropertySerializerMap["definition"](derivedQuantityKind.Definition.OrderBy(x => x, this.guidComparer))},
                {"excludedDomain", this.PropertySerializerMap["excludedDomain"](derivedQuantityKind.ExcludedDomain.OrderBy(x => x, this.guidComparer))},
                {"excludedPerson", this.PropertySerializerMap["excludedPerson"](derivedQuantityKind.ExcludedPerson.OrderBy(x => x, this.guidComparer))},
                {"hyperLink", this.PropertySerializerMap["hyperLink"](derivedQuantityKind.HyperLink.OrderBy(x => x, this.guidComparer))},
                {"iid", this.PropertySerializerMap["iid"](derivedQuantityKind.Iid)},
                {"isDeprecated", this.PropertySerializerMap["isDeprecated"](derivedQuantityKind.IsDeprecated)},
                {"modifiedOn", this.PropertySerializerMap["modifiedOn"](derivedQuantityKind.ModifiedOn)},
                {"name", this.PropertySerializerMap["name"](derivedQuantityKind.Name)},
                {"possibleScale", this.PropertySerializerMap["possibleScale"](derivedQuantityKind.PossibleScale.OrderBy(x => x, this.guidComparer))},
                {"quantityDimensionSymbol", this.PropertySerializerMap["quantityDimensionSymbol"](derivedQuantityKind.QuantityDimensionSymbol)},
                {"quantityKindFactor", this.PropertySerializerMap["quantityKindFactor"](derivedQuantityKind.QuantityKindFactor.OrderBy(x => x, this.orderedItemComparer))},
                {"revisionNumber", this.PropertySerializerMap["revisionNumber"](derivedQuantityKind.RevisionNumber)},
                {"shortName", this.PropertySerializerMap["shortName"](derivedQuantityKind.ShortName)},
                {"symbol", this.PropertySerializerMap["symbol"](derivedQuantityKind.Symbol)},
                {"thingPreference", this.PropertySerializerMap["thingPreference"](derivedQuantityKind.ThingPreference)},
            };

            return jsonObject;
        }

        /// <summary>
        /// Gets the map containing the serialization method for each property of the <see cref="DerivedQuantityKind"/> class.
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

            if (thing is not DerivedQuantityKind derivedQuantityKind)
            {
                throw new InvalidOperationException("The thing is not a DerivedQuantityKind.");
            }

            return this.Serialize(derivedQuantityKind);
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
