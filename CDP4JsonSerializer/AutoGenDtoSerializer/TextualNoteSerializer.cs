// --------------------------------------------------------------------------------------------------------------------
// <copyright file "TextualNoteSerializer.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="TextualNoteSerializer"/> class is to provide a <see cref="TextualNote"/> specific serializer
    /// </summary>
    public class TextualNoteSerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// The map containing the serialization methods
        /// </summary>
        private readonly Dictionary<string, Func<object, JsonValue>> propertySerializerMap = new()
        {
            { "category", category => JsonValue.Create(category) },
            { "classKind", classKind => JsonValue.Create(classKind.ToString()) },
            { "content", content => JsonValue.Create(content) },
            { "createdOn", createdOn => JsonValue.Create(((DateTime)createdOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "excludedDomain", excludedDomain => JsonValue.Create(excludedDomain) },
            { "excludedPerson", excludedPerson => JsonValue.Create(excludedPerson) },
            { "iid", iid => JsonValue.Create(iid) },
            { "languageCode", languageCode => JsonValue.Create(languageCode) },
            { "modifiedOn", modifiedOn => JsonValue.Create(((DateTime)modifiedOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "name", name => JsonValue.Create(name) },
            { "owner", owner => JsonValue.Create(owner) },
            { "revisionNumber", revisionNumber => JsonValue.Create(revisionNumber) },
            { "shortName", shortName => JsonValue.Create(shortName) },
            { "thingPreference", thingPreference => JsonValue.Create(thingPreference) },
        };

        /// <summary>
        /// Serialize the <see cref="TextualNote"/>
        /// </summary>
        /// <param name="textualNote">The <see cref="TextualNote"/> to serialize</param>
        /// <returns>The <see cref="JsonObject"/></returns>
        private JsonObject Serialize(TextualNote textualNote)
        {
            var jsonObject = new JsonObject
            {
                {"category", this.PropertySerializerMap["category"](textualNote.Category.OrderBy(x => x, this.guidComparer))},
                {"classKind", this.PropertySerializerMap["classKind"](Enum.GetName(typeof(CDP4Common.CommonData.ClassKind), textualNote.ClassKind))},
                {"content", this.PropertySerializerMap["content"](textualNote.Content)},
                {"createdOn", this.PropertySerializerMap["createdOn"](textualNote.CreatedOn)},
                {"excludedDomain", this.PropertySerializerMap["excludedDomain"](textualNote.ExcludedDomain.OrderBy(x => x, this.guidComparer))},
                {"excludedPerson", this.PropertySerializerMap["excludedPerson"](textualNote.ExcludedPerson.OrderBy(x => x, this.guidComparer))},
                {"iid", this.PropertySerializerMap["iid"](textualNote.Iid)},
                {"languageCode", this.PropertySerializerMap["languageCode"](textualNote.LanguageCode)},
                {"modifiedOn", this.PropertySerializerMap["modifiedOn"](textualNote.ModifiedOn)},
                {"name", this.PropertySerializerMap["name"](textualNote.Name)},
                {"owner", this.PropertySerializerMap["owner"](textualNote.Owner)},
                {"revisionNumber", this.PropertySerializerMap["revisionNumber"](textualNote.RevisionNumber)},
                {"shortName", this.PropertySerializerMap["shortName"](textualNote.ShortName)},
                {"thingPreference", this.PropertySerializerMap["thingPreference"](textualNote.ThingPreference)},
            };

            return jsonObject;
        }

        /// <summary>
        /// Gets the map containing the serialization method for each property of the <see cref="TextualNote"/> class.
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

            if (thing is not TextualNote textualNote)
            {
                throw new InvalidOperationException("The thing is not a TextualNote.");
            }

            return this.Serialize(textualNote);
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
