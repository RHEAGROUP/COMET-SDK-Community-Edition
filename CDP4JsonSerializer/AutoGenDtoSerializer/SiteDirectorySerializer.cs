// --------------------------------------------------------------------------------------------------------------------
// <copyright file "SiteDirectorySerializer.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="SiteDirectorySerializer"/> class is to provide a <see cref="SiteDirectory"/> specific serializer
    /// </summary>
    public class SiteDirectorySerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// The map containing the serialization methods
        /// </summary>
        private readonly Dictionary<string, Func<object, JsonValue>> propertySerializerMap = new()
        {
            { "annotation", annotation => JsonValue.Create(annotation) },
            { "classKind", classKind => JsonValue.Create(classKind.ToString()) },
            { "createdOn", createdOn => JsonValue.Create(((DateTime)createdOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "defaultParticipantRole", defaultParticipantRole => JsonValue.Create(defaultParticipantRole) },
            { "defaultPersonRole", defaultPersonRole => JsonValue.Create(defaultPersonRole) },
            { "domain", domain => JsonValue.Create(domain) },
            { "domainGroup", domainGroup => JsonValue.Create(domainGroup) },
            { "excludedDomain", excludedDomain => JsonValue.Create(excludedDomain) },
            { "excludedPerson", excludedPerson => JsonValue.Create(excludedPerson) },
            { "iid", iid => JsonValue.Create(iid) },
            { "lastModifiedOn", lastModifiedOn => JsonValue.Create(((DateTime)lastModifiedOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "logEntry", logEntry => JsonValue.Create(logEntry) },
            { "model", model => JsonValue.Create(model) },
            { "modifiedOn", modifiedOn => JsonValue.Create(((DateTime)modifiedOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "name", name => JsonValue.Create(name) },
            { "naturalLanguage", naturalLanguage => JsonValue.Create(naturalLanguage) },
            { "organization", organization => JsonValue.Create(organization) },
            { "participantRole", participantRole => JsonValue.Create(participantRole) },
            { "person", person => JsonValue.Create(person) },
            { "personRole", personRole => JsonValue.Create(personRole) },
            { "revisionNumber", revisionNumber => JsonValue.Create(revisionNumber) },
            { "shortName", shortName => JsonValue.Create(shortName) },
            { "siteReferenceDataLibrary", siteReferenceDataLibrary => JsonValue.Create(siteReferenceDataLibrary) },
            { "thingPreference", thingPreference => JsonValue.Create(thingPreference) },
        };

        /// <summary>
        /// Serialize the <see cref="SiteDirectory"/>
        /// </summary>
        /// <param name="siteDirectory">The <see cref="SiteDirectory"/> to serialize</param>
        /// <returns>The <see cref="JsonObject"/></returns>
        private JsonObject Serialize(SiteDirectory siteDirectory)
        {
            var jsonObject = new JsonObject
            {
                {"annotation", this.PropertySerializerMap["annotation"](siteDirectory.Annotation.OrderBy(x => x, this.guidComparer))},
                {"classKind", this.PropertySerializerMap["classKind"](Enum.GetName(typeof(CDP4Common.CommonData.ClassKind), siteDirectory.ClassKind))},
                {"createdOn", this.PropertySerializerMap["createdOn"](siteDirectory.CreatedOn)},
                {"defaultParticipantRole", this.PropertySerializerMap["defaultParticipantRole"](siteDirectory.DefaultParticipantRole)},
                {"defaultPersonRole", this.PropertySerializerMap["defaultPersonRole"](siteDirectory.DefaultPersonRole)},
                {"domain", this.PropertySerializerMap["domain"](siteDirectory.Domain.OrderBy(x => x, this.guidComparer))},
                {"domainGroup", this.PropertySerializerMap["domainGroup"](siteDirectory.DomainGroup.OrderBy(x => x, this.guidComparer))},
                {"excludedDomain", this.PropertySerializerMap["excludedDomain"](siteDirectory.ExcludedDomain.OrderBy(x => x, this.guidComparer))},
                {"excludedPerson", this.PropertySerializerMap["excludedPerson"](siteDirectory.ExcludedPerson.OrderBy(x => x, this.guidComparer))},
                {"iid", this.PropertySerializerMap["iid"](siteDirectory.Iid)},
                {"lastModifiedOn", this.PropertySerializerMap["lastModifiedOn"](siteDirectory.LastModifiedOn)},
                {"logEntry", this.PropertySerializerMap["logEntry"](siteDirectory.LogEntry.OrderBy(x => x, this.guidComparer))},
                {"model", this.PropertySerializerMap["model"](siteDirectory.Model.OrderBy(x => x, this.guidComparer))},
                {"modifiedOn", this.PropertySerializerMap["modifiedOn"](siteDirectory.ModifiedOn)},
                {"name", this.PropertySerializerMap["name"](siteDirectory.Name)},
                {"naturalLanguage", this.PropertySerializerMap["naturalLanguage"](siteDirectory.NaturalLanguage.OrderBy(x => x, this.guidComparer))},
                {"organization", this.PropertySerializerMap["organization"](siteDirectory.Organization.OrderBy(x => x, this.guidComparer))},
                {"participantRole", this.PropertySerializerMap["participantRole"](siteDirectory.ParticipantRole.OrderBy(x => x, this.guidComparer))},
                {"person", this.PropertySerializerMap["person"](siteDirectory.Person.OrderBy(x => x, this.guidComparer))},
                {"personRole", this.PropertySerializerMap["personRole"](siteDirectory.PersonRole.OrderBy(x => x, this.guidComparer))},
                {"revisionNumber", this.PropertySerializerMap["revisionNumber"](siteDirectory.RevisionNumber)},
                {"shortName", this.PropertySerializerMap["shortName"](siteDirectory.ShortName)},
                {"siteReferenceDataLibrary", this.PropertySerializerMap["siteReferenceDataLibrary"](siteDirectory.SiteReferenceDataLibrary.OrderBy(x => x, this.guidComparer))},
                {"thingPreference", this.PropertySerializerMap["thingPreference"](siteDirectory.ThingPreference)},
            };

            return jsonObject;
        }

        /// <summary>
        /// Gets the map containing the serialization method for each property of the <see cref="SiteDirectory"/> class.
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

            if (thing is not SiteDirectory siteDirectory)
            {
                throw new InvalidOperationException("The thing is not a SiteDirectory.");
            }

            return this.Serialize(siteDirectory);
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
