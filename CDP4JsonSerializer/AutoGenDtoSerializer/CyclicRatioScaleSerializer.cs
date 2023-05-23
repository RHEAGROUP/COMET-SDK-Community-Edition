// --------------------------------------------------------------------------------------------------------------------
// <copyright file "CyclicRatioScaleSerializer.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="CyclicRatioScaleSerializer"/> class is to provide a <see cref="CyclicRatioScale"/> specific serializer
    /// </summary>
    public class CyclicRatioScaleSerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// The map containing the serialization methods
        /// </summary>
        private readonly Dictionary<string, Func<object, JsonValue>> propertySerializerMap = new()
        {
            { "alias", alias => JsonValue.Create(alias) },
            { "classKind", classKind => JsonValue.Create(classKind.ToString()) },
            { "definition", definition => JsonValue.Create(definition) },
            { "excludedDomain", excludedDomain => JsonValue.Create(excludedDomain) },
            { "excludedPerson", excludedPerson => JsonValue.Create(excludedPerson) },
            { "hyperLink", hyperLink => JsonValue.Create(hyperLink) },
            { "iid", iid => JsonValue.Create(iid) },
            { "isDeprecated", isDeprecated => JsonValue.Create(isDeprecated) },
            { "isMaximumInclusive", isMaximumInclusive => JsonValue.Create(isMaximumInclusive) },
            { "isMinimumInclusive", isMinimumInclusive => JsonValue.Create(isMinimumInclusive) },
            { "mappingToReferenceScale", mappingToReferenceScale => JsonValue.Create(mappingToReferenceScale) },
            { "maximumPermissibleValue", maximumPermissibleValue => JsonValue.Create(maximumPermissibleValue) },
            { "minimumPermissibleValue", minimumPermissibleValue => JsonValue.Create(minimumPermissibleValue) },
            { "modifiedOn", modifiedOn => JsonValue.Create(((DateTime)modifiedOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "modulus", modulus => JsonValue.Create(modulus) },
            { "name", name => JsonValue.Create(name) },
            { "negativeValueConnotation", negativeValueConnotation => JsonValue.Create(negativeValueConnotation) },
            { "numberSet", numberSet => JsonValue.Create(numberSet.ToString()) },
            { "positiveValueConnotation", positiveValueConnotation => JsonValue.Create(positiveValueConnotation) },
            { "revisionNumber", revisionNumber => JsonValue.Create(revisionNumber) },
            { "shortName", shortName => JsonValue.Create(shortName) },
            { "thingPreference", thingPreference => JsonValue.Create(thingPreference) },
            { "unit", unit => JsonValue.Create(unit) },
            { "valueDefinition", valueDefinition => JsonValue.Create(valueDefinition) },
        };

        /// <summary>
        /// Serialize the <see cref="CyclicRatioScale"/>
        /// </summary>
        /// <param name="cyclicRatioScale">The <see cref="CyclicRatioScale"/> to serialize</param>
        /// <returns>The <see cref="JsonObject"/></returns>
        private JsonObject Serialize(CyclicRatioScale cyclicRatioScale)
        {
            var jsonObject = new JsonObject
            {
                {"alias", this.PropertySerializerMap["alias"](cyclicRatioScale.Alias.OrderBy(x => x, this.guidComparer))},
                {"classKind", this.PropertySerializerMap["classKind"](Enum.GetName(typeof(CDP4Common.CommonData.ClassKind), cyclicRatioScale.ClassKind))},
                {"definition", this.PropertySerializerMap["definition"](cyclicRatioScale.Definition.OrderBy(x => x, this.guidComparer))},
                {"excludedDomain", this.PropertySerializerMap["excludedDomain"](cyclicRatioScale.ExcludedDomain.OrderBy(x => x, this.guidComparer))},
                {"excludedPerson", this.PropertySerializerMap["excludedPerson"](cyclicRatioScale.ExcludedPerson.OrderBy(x => x, this.guidComparer))},
                {"hyperLink", this.PropertySerializerMap["hyperLink"](cyclicRatioScale.HyperLink.OrderBy(x => x, this.guidComparer))},
                {"iid", this.PropertySerializerMap["iid"](cyclicRatioScale.Iid)},
                {"isDeprecated", this.PropertySerializerMap["isDeprecated"](cyclicRatioScale.IsDeprecated)},
                {"isMaximumInclusive", this.PropertySerializerMap["isMaximumInclusive"](cyclicRatioScale.IsMaximumInclusive)},
                {"isMinimumInclusive", this.PropertySerializerMap["isMinimumInclusive"](cyclicRatioScale.IsMinimumInclusive)},
                {"mappingToReferenceScale", this.PropertySerializerMap["mappingToReferenceScale"](cyclicRatioScale.MappingToReferenceScale.OrderBy(x => x, this.guidComparer))},
                {"maximumPermissibleValue", this.PropertySerializerMap["maximumPermissibleValue"](cyclicRatioScale.MaximumPermissibleValue)},
                {"minimumPermissibleValue", this.PropertySerializerMap["minimumPermissibleValue"](cyclicRatioScale.MinimumPermissibleValue)},
                {"modifiedOn", this.PropertySerializerMap["modifiedOn"](cyclicRatioScale.ModifiedOn)},
                {"modulus", this.PropertySerializerMap["modulus"](cyclicRatioScale.Modulus)},
                {"name", this.PropertySerializerMap["name"](cyclicRatioScale.Name)},
                {"negativeValueConnotation", this.PropertySerializerMap["negativeValueConnotation"](cyclicRatioScale.NegativeValueConnotation)},
                {"numberSet", this.PropertySerializerMap["numberSet"](Enum.GetName(typeof(CDP4Common.SiteDirectoryData.NumberSetKind), cyclicRatioScale.NumberSet))},
                {"positiveValueConnotation", this.PropertySerializerMap["positiveValueConnotation"](cyclicRatioScale.PositiveValueConnotation)},
                {"revisionNumber", this.PropertySerializerMap["revisionNumber"](cyclicRatioScale.RevisionNumber)},
                {"shortName", this.PropertySerializerMap["shortName"](cyclicRatioScale.ShortName)},
                {"thingPreference", this.PropertySerializerMap["thingPreference"](cyclicRatioScale.ThingPreference)},
                {"unit", this.PropertySerializerMap["unit"](cyclicRatioScale.Unit)},
                {"valueDefinition", this.PropertySerializerMap["valueDefinition"](cyclicRatioScale.ValueDefinition.OrderBy(x => x, this.guidComparer))},
            };

            return jsonObject;
        }

        /// <summary>
        /// Gets the map containing the serialization method for each property of the <see cref="CyclicRatioScale"/> class.
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

            if (thing is not CyclicRatioScale cyclicRatioScale)
            {
                throw new InvalidOperationException("The thing is not a CyclicRatioScale.");
            }

            return this.Serialize(cyclicRatioScale);
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
