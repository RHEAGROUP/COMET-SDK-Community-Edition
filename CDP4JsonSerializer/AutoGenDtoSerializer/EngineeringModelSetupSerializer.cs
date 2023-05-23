// --------------------------------------------------------------------------------------------------------------------
// <copyright file "EngineeringModelSetupSerializer.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="EngineeringModelSetupSerializer"/> class is to provide a <see cref="EngineeringModelSetup"/> specific serializer
    /// </summary>
    public class EngineeringModelSetupSerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// The map containing the serialization methods
        /// </summary>
        private readonly Dictionary<string, Func<object, JsonValue>> propertySerializerMap = new()
        {
            { "activeDomain", activeDomain => JsonValue.Create(activeDomain) },
            { "alias", alias => JsonValue.Create(alias) },
            { "classKind", classKind => JsonValue.Create(classKind.ToString()) },
            { "defaultOrganizationalParticipant", defaultOrganizationalParticipant => JsonValue.Create(defaultOrganizationalParticipant) },
            { "definition", definition => JsonValue.Create(definition) },
            { "engineeringModelIid", engineeringModelIid => JsonValue.Create(engineeringModelIid) },
            { "excludedDomain", excludedDomain => JsonValue.Create(excludedDomain) },
            { "excludedPerson", excludedPerson => JsonValue.Create(excludedPerson) },
            { "hyperLink", hyperLink => JsonValue.Create(hyperLink) },
            { "iid", iid => JsonValue.Create(iid) },
            { "iterationSetup", iterationSetup => JsonValue.Create(iterationSetup) },
            { "kind", kind => JsonValue.Create(kind.ToString()) },
            { "modifiedOn", modifiedOn => JsonValue.Create(((DateTime)modifiedOn).ToString("yyyy-MM-ddTHH:mm:ss.fffZ")) },
            { "name", name => JsonValue.Create(name) },
            { "organizationalParticipant", organizationalParticipant => JsonValue.Create(organizationalParticipant) },
            { "participant", participant => JsonValue.Create(participant) },
            { "requiredRdl", requiredRdl => JsonValue.Create(requiredRdl) },
            { "revisionNumber", revisionNumber => JsonValue.Create(revisionNumber) },
            { "shortName", shortName => JsonValue.Create(shortName) },
            { "sourceEngineeringModelSetupIid", sourceEngineeringModelSetupIid => JsonValue.Create(sourceEngineeringModelSetupIid) },
            { "studyPhase", studyPhase => JsonValue.Create(studyPhase.ToString()) },
            { "thingPreference", thingPreference => JsonValue.Create(thingPreference) },
        };

        /// <summary>
        /// Serialize the <see cref="EngineeringModelSetup"/>
        /// </summary>
        /// <param name="engineeringModelSetup">The <see cref="EngineeringModelSetup"/> to serialize</param>
        /// <returns>The <see cref="JsonObject"/></returns>
        private JsonObject Serialize(EngineeringModelSetup engineeringModelSetup)
        {
            var jsonObject = new JsonObject
            {
                {"activeDomain", this.PropertySerializerMap["activeDomain"](engineeringModelSetup.ActiveDomain.OrderBy(x => x, this.guidComparer))},
                {"alias", this.PropertySerializerMap["alias"](engineeringModelSetup.Alias.OrderBy(x => x, this.guidComparer))},
                {"classKind", this.PropertySerializerMap["classKind"](Enum.GetName(typeof(CDP4Common.CommonData.ClassKind), engineeringModelSetup.ClassKind))},
                {"defaultOrganizationalParticipant", this.PropertySerializerMap["defaultOrganizationalParticipant"](engineeringModelSetup.DefaultOrganizationalParticipant)},
                {"definition", this.PropertySerializerMap["definition"](engineeringModelSetup.Definition.OrderBy(x => x, this.guidComparer))},
                {"engineeringModelIid", this.PropertySerializerMap["engineeringModelIid"](engineeringModelSetup.EngineeringModelIid)},
                {"excludedDomain", this.PropertySerializerMap["excludedDomain"](engineeringModelSetup.ExcludedDomain.OrderBy(x => x, this.guidComparer))},
                {"excludedPerson", this.PropertySerializerMap["excludedPerson"](engineeringModelSetup.ExcludedPerson.OrderBy(x => x, this.guidComparer))},
                {"hyperLink", this.PropertySerializerMap["hyperLink"](engineeringModelSetup.HyperLink.OrderBy(x => x, this.guidComparer))},
                {"iid", this.PropertySerializerMap["iid"](engineeringModelSetup.Iid)},
                {"iterationSetup", this.PropertySerializerMap["iterationSetup"](engineeringModelSetup.IterationSetup.OrderBy(x => x, this.guidComparer))},
                {"kind", this.PropertySerializerMap["kind"](Enum.GetName(typeof(CDP4Common.SiteDirectoryData.EngineeringModelKind), engineeringModelSetup.Kind))},
                {"modifiedOn", this.PropertySerializerMap["modifiedOn"](engineeringModelSetup.ModifiedOn)},
                {"name", this.PropertySerializerMap["name"](engineeringModelSetup.Name)},
                {"organizationalParticipant", this.PropertySerializerMap["organizationalParticipant"](engineeringModelSetup.OrganizationalParticipant.OrderBy(x => x, this.guidComparer))},
                {"participant", this.PropertySerializerMap["participant"](engineeringModelSetup.Participant.OrderBy(x => x, this.guidComparer))},
                {"requiredRdl", this.PropertySerializerMap["requiredRdl"](engineeringModelSetup.RequiredRdl)},
                {"revisionNumber", this.PropertySerializerMap["revisionNumber"](engineeringModelSetup.RevisionNumber)},
                {"shortName", this.PropertySerializerMap["shortName"](engineeringModelSetup.ShortName)},
                {"sourceEngineeringModelSetupIid", this.PropertySerializerMap["sourceEngineeringModelSetupIid"](engineeringModelSetup.SourceEngineeringModelSetupIid)},
                {"studyPhase", this.PropertySerializerMap["studyPhase"](Enum.GetName(typeof(CDP4Common.SiteDirectoryData.StudyPhaseKind), engineeringModelSetup.StudyPhase))},
                {"thingPreference", this.PropertySerializerMap["thingPreference"](engineeringModelSetup.ThingPreference)},
            };

            return jsonObject;
        }

        /// <summary>
        /// Gets the map containing the serialization method for each property of the <see cref="EngineeringModelSetup"/> class.
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

            if (thing is not EngineeringModelSetup engineeringModelSetup)
            {
                throw new InvalidOperationException("The thing is not a EngineeringModelSetup.");
            }

            return this.Serialize(engineeringModelSetup);
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
