// --------------------------------------------------------------------------------------------------------------------
// <copyright file "EngineeringModelDataDiscussionItemSerializer.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="EngineeringModelDataDiscussionItemSerializer"/> class is to provide a <see cref="EngineeringModelDataDiscussionItem"/> specific serializer
    /// </summary>
    public class EngineeringModelDataDiscussionItemSerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// The map containing the serialization methods
        /// </summary>
        private readonly Dictionary<string, Func<object, JsonValue>> propertySerializerMap = new()
        {
            { "author", author => JsonValue.Create(author) },
            { "classKind", classKind => JsonValue.Create(classKind.ToString()) },
            { "content", content => JsonValue.Create(content) },
            { "createdOn", createdOn => JsonValue.Create(((DateTime)createdOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "excludedDomain", excludedDomain => JsonValue.Create(excludedDomain) },
            { "excludedPerson", excludedPerson => JsonValue.Create(excludedPerson) },
            { "iid", iid => JsonValue.Create(iid) },
            { "languageCode", languageCode => JsonValue.Create(languageCode) },
            { "modifiedOn", modifiedOn => JsonValue.Create(((DateTime)modifiedOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "replyTo", replyTo => JsonValue.Create(replyTo) },
            { "revisionNumber", revisionNumber => JsonValue.Create(revisionNumber) },
            { "thingPreference", thingPreference => JsonValue.Create(thingPreference) },
        };

        /// <summary>
        /// Serialize the <see cref="EngineeringModelDataDiscussionItem"/>
        /// </summary>
        /// <param name="engineeringModelDataDiscussionItem">The <see cref="EngineeringModelDataDiscussionItem"/> to serialize</param>
        /// <returns>The <see cref="JsonObject"/></returns>
        private JsonObject Serialize(EngineeringModelDataDiscussionItem engineeringModelDataDiscussionItem)
        {
            var jsonObject = new JsonObject
            {
                {"author", this.PropertySerializerMap["author"](engineeringModelDataDiscussionItem.Author)},
                {"classKind", this.PropertySerializerMap["classKind"](Enum.GetName(typeof(CDP4Common.CommonData.ClassKind), engineeringModelDataDiscussionItem.ClassKind))},
                {"content", this.PropertySerializerMap["content"](engineeringModelDataDiscussionItem.Content)},
                {"createdOn", this.PropertySerializerMap["createdOn"](engineeringModelDataDiscussionItem.CreatedOn)},
                {"excludedDomain", this.PropertySerializerMap["excludedDomain"](engineeringModelDataDiscussionItem.ExcludedDomain.OrderBy(x => x, this.guidComparer))},
                {"excludedPerson", this.PropertySerializerMap["excludedPerson"](engineeringModelDataDiscussionItem.ExcludedPerson.OrderBy(x => x, this.guidComparer))},
                {"iid", this.PropertySerializerMap["iid"](engineeringModelDataDiscussionItem.Iid)},
                {"languageCode", this.PropertySerializerMap["languageCode"](engineeringModelDataDiscussionItem.LanguageCode)},
                {"modifiedOn", this.PropertySerializerMap["modifiedOn"](engineeringModelDataDiscussionItem.ModifiedOn)},
                {"replyTo", this.PropertySerializerMap["replyTo"](engineeringModelDataDiscussionItem.ReplyTo)},
                {"revisionNumber", this.PropertySerializerMap["revisionNumber"](engineeringModelDataDiscussionItem.RevisionNumber)},
                {"thingPreference", this.PropertySerializerMap["thingPreference"](engineeringModelDataDiscussionItem.ThingPreference)},
            };

            return jsonObject;
        }

        /// <summary>
        /// Gets the map containing the serialization method for each property of the <see cref="EngineeringModelDataDiscussionItem"/> class.
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

            if (thing is not EngineeringModelDataDiscussionItem engineeringModelDataDiscussionItem)
            {
                throw new InvalidOperationException("The thing is not a EngineeringModelDataDiscussionItem.");
            }

            return this.Serialize(engineeringModelDataDiscussionItem);
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
