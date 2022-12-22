// --------------------------------------------------------------------------------------------------------------------
// <copyright file "ChangeRequestSerializer.cs" company="RHEA System S.A.">
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

namespace CDP4JsonSerializer_SystemTextJson
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.Json.Nodes;

    using CDP4Common.DTO;
    using CDP4Common.Types;
    
    /// <summary>
    /// The purpose of the <see cref="ChangeRequestSerializer"/> class is to provide a <see cref="ChangeRequest"/> specific serializer
    /// </summary>
    public class ChangeRequestSerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// The map containing the serialization methods
        /// </summary>
        private readonly Dictionary<string, Func<object, JsonValue>> propertySerializerMap = new Dictionary<string, Func<object, JsonValue>>
        {
            { "approvedBy", approvedBy => JsonValue.Create(approvedBy) },
            { "author", author => JsonValue.Create(author) },
            { "category", category => JsonValue.Create(category) },
            { "classification", classification => JsonValue.Create(classification.ToString()) },
            { "classKind", classKind => JsonValue.Create(classKind.ToString()) },
            { "content", content => JsonValue.Create(content) },
            { "createdOn", createdOn => JsonValue.Create(((DateTime)createdOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "discussion", discussion => JsonValue.Create(discussion) },
            { "excludedDomain", excludedDomain => JsonValue.Create(excludedDomain) },
            { "excludedPerson", excludedPerson => JsonValue.Create(excludedPerson) },
            { "iid", iid => JsonValue.Create(iid) },
            { "languageCode", languageCode => JsonValue.Create(languageCode) },
            { "modifiedOn", modifiedOn => JsonValue.Create(((DateTime)modifiedOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "owner", owner => JsonValue.Create(owner) },
            { "primaryAnnotatedThing", primaryAnnotatedThing => JsonValue.Create(primaryAnnotatedThing) },
            { "relatedThing", relatedThing => JsonValue.Create(relatedThing) },
            { "revisionNumber", revisionNumber => JsonValue.Create(revisionNumber) },
            { "shortName", shortName => JsonValue.Create(shortName) },
            { "sourceAnnotation", sourceAnnotation => JsonValue.Create(sourceAnnotation) },
            { "status", status => JsonValue.Create(status.ToString()) },
            { "thingPreference", thingPreference => JsonValue.Create(thingPreference) },
            { "title", title => JsonValue.Create(title) },
        };

        /// <summary>
        /// Serialize the <see cref="ChangeRequest"/>
        /// </summary>
        /// <param name="changeRequest">The <see cref="ChangeRequest"/> to serialize</param>
        /// <returns>The <see cref="JsonObject"/></returns>
        private JsonObject Serialize(ChangeRequest changeRequest)
        {
            var jsonObject = new JsonObject();
            jsonObject.Add("approvedBy", this.PropertySerializerMap["approvedBy"](changeRequest.ApprovedBy.OrderBy(x => x, this.guidComparer)));
            jsonObject.Add("author", this.PropertySerializerMap["author"](changeRequest.Author));
            jsonObject.Add("category", this.PropertySerializerMap["category"](changeRequest.Category.OrderBy(x => x, this.guidComparer)));
            jsonObject.Add("classification", this.PropertySerializerMap["classification"](Enum.GetName(typeof(CDP4Common.ReportingData.AnnotationClassificationKind), changeRequest.Classification)));
            jsonObject.Add("classKind", this.PropertySerializerMap["classKind"](Enum.GetName(typeof(CDP4Common.CommonData.ClassKind), changeRequest.ClassKind)));
            jsonObject.Add("content", this.PropertySerializerMap["content"](changeRequest.Content));
            jsonObject.Add("createdOn", this.PropertySerializerMap["createdOn"](changeRequest.CreatedOn));
            jsonObject.Add("discussion", this.PropertySerializerMap["discussion"](changeRequest.Discussion.OrderBy(x => x, this.guidComparer)));
            jsonObject.Add("excludedDomain", this.PropertySerializerMap["excludedDomain"](changeRequest.ExcludedDomain.OrderBy(x => x, this.guidComparer)));
            jsonObject.Add("excludedPerson", this.PropertySerializerMap["excludedPerson"](changeRequest.ExcludedPerson.OrderBy(x => x, this.guidComparer)));
            jsonObject.Add("iid", this.PropertySerializerMap["iid"](changeRequest.Iid));
            jsonObject.Add("languageCode", this.PropertySerializerMap["languageCode"](changeRequest.LanguageCode));
            jsonObject.Add("modifiedOn", this.PropertySerializerMap["modifiedOn"](changeRequest.ModifiedOn));
            jsonObject.Add("owner", this.PropertySerializerMap["owner"](changeRequest.Owner));
            jsonObject.Add("primaryAnnotatedThing", this.PropertySerializerMap["primaryAnnotatedThing"](changeRequest.PrimaryAnnotatedThing));
            jsonObject.Add("relatedThing", this.PropertySerializerMap["relatedThing"](changeRequest.RelatedThing.OrderBy(x => x, this.guidComparer)));
            jsonObject.Add("revisionNumber", this.PropertySerializerMap["revisionNumber"](changeRequest.RevisionNumber));
            jsonObject.Add("shortName", this.PropertySerializerMap["shortName"](changeRequest.ShortName));
            jsonObject.Add("sourceAnnotation", this.PropertySerializerMap["sourceAnnotation"](changeRequest.SourceAnnotation.OrderBy(x => x, this.guidComparer)));
            jsonObject.Add("status", this.PropertySerializerMap["status"](Enum.GetName(typeof(CDP4Common.ReportingData.AnnotationStatusKind), changeRequest.Status)));
            jsonObject.Add("thingPreference", this.PropertySerializerMap["thingPreference"](changeRequest.ThingPreference));
            jsonObject.Add("title", this.PropertySerializerMap["title"](changeRequest.Title));
            return jsonObject;
        }

        /// <summary>
        /// Gets the map containing the serialization method for each property of the <see cref="ChangeRequest"/> class.
        /// </summary>
        public IReadOnlyDictionary<string, Func<object, JsonValue>> PropertySerializerMap 
        {
            get { return this.propertySerializerMap; }
        }

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

            var changeRequest = thing as ChangeRequest;
            if (changeRequest == null)
            {
                throw new InvalidOperationException("The thing is not a ChangeRequest.");
            }

            return this.Serialize(changeRequest);
        }
    }
}
