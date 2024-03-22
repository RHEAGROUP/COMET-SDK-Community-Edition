// -------------------------------------------------------------------------------------------------------------------------------
// <copyright file="NestedElementSerializer.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2024 RHEA System S.A.
// 
//    Authors: Sam Gerené, Alex Vorobiev, Alexander van Delft, Nathanael Smiechowski, Antoine Théate, Omar Elebiary, Jaime Bernar
// 
//    This file is part of CDP4-COMET SDK Community Edition
// 
//    The CDP4-COMET SDK Community Edition is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 3 of the License, or (at your option) any later version.
// 
//    The CDP4-COMET SDK Community Edition is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
// 
//    You should have received a copy of the GNU Lesser General Public License
//    along with this program; if not, write to the Free Software Foundation,
//    Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// </copyright>
// -------------------------------------------------------------------------------------------------------------------------------

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace CDP4JsonSerializer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.Json;

    using CDP4Common;
    using CDP4Common.CommonData;
    using CDP4Common.EngineeringModelData;
    using CDP4Common.ReportingData;
    using CDP4Common.SiteDirectoryData;
    using CDP4Common.Types;

    using NLog;

    using Thing = CDP4Common.DTO.Thing;
    using NestedElement = CDP4Common.DTO.NestedElement;

    /// <summary>
    /// The purpose of the <see cref="NestedElementSerializer"/> class is to provide a <see cref="NestedElement"/> specific serializer
    /// </summary>
    public class NestedElementSerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// Serializes a <see cref="Thing" /> into an <see cref="Utf8JsonWriter" />
        /// </summary>
        /// <param name="thing">The <see cref="Thing" /> that have to be serialized</param>
        /// <param name="writer">The <see cref="Utf8JsonWriter" /></param>
        /// <param name="requestedDataModelVersion">The <see cref="Version" /> that has been requested for the serialization</param>
        /// <exception cref="ArgumentException">If the provided <paramref name="thing" /> is not an <see cref="NestedElement" /></exception>
        /// <exception cref="NotSupportedException">If the provided <paramref name="requestedDataModelVersion" /> is not supported</exception>
        public void Serialize(Thing thing, Utf8JsonWriter writer, Version requestedDataModelVersion)
        {
            if (thing is not NestedElement nestedElement)
            {
                throw new ArgumentException("The thing shall be a NestedElement", nameof(thing));
            }

            if (requestedDataModelVersion < Version.Parse("1.0.0"))
            {
                Logger.Log(LogLevel.Info, "Skipping serialization of NestedElement since Version is below 1.0.0");
                return;
            }

            writer.WriteStartObject();

            switch(requestedDataModelVersion.ToString(3))
            {
                case "1.0.0":
                    Logger.Log(LogLevel.Trace, "Serializing NestedElement for Version 1.0.0");
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(nestedElement.ClassKind.ToString());
                    writer.WriteStartArray("elementUsage"u8);

                    foreach(var elementUsageItem in nestedElement.ElementUsage.OrderBy(x => x, this.OrderedItemComparer))
                    {
                        writer.WriteOrderedItem(elementUsageItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(nestedElement.Iid);
                    writer.WritePropertyName("isVolatile"u8);
                    writer.WriteBooleanValue(nestedElement.IsVolatile);
                    writer.WriteStartArray("nestedParameter"u8);

                    foreach(var nestedParameterItem in nestedElement.NestedParameter.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(nestedParameterItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(nestedElement.RevisionNumber);
                    writer.WritePropertyName("rootElement"u8);
                    writer.WriteStringValue(nestedElement.RootElement);
                    break;
                case "1.1.0":
                    Logger.Log(LogLevel.Trace, "Serializing NestedElement for Version 1.1.0");
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(nestedElement.ClassKind.ToString());
                    writer.WriteStartArray("elementUsage"u8);

                    foreach(var elementUsageItem in nestedElement.ElementUsage.OrderBy(x => x, this.OrderedItemComparer))
                    {
                        writer.WriteOrderedItem(elementUsageItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedDomain"u8);

                    foreach(var excludedDomainItem in nestedElement.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedDomainItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedPerson"u8);

                    foreach(var excludedPersonItem in nestedElement.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedPersonItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(nestedElement.Iid);
                    writer.WritePropertyName("isVolatile"u8);
                    writer.WriteBooleanValue(nestedElement.IsVolatile);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(nestedElement.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WriteStartArray("nestedParameter"u8);

                    foreach(var nestedParameterItem in nestedElement.NestedParameter.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(nestedParameterItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(nestedElement.RevisionNumber);
                    writer.WritePropertyName("rootElement"u8);
                    writer.WriteStringValue(nestedElement.RootElement);
                    break;
                case "1.2.0":
                    Logger.Log(LogLevel.Trace, "Serializing NestedElement for Version 1.2.0");
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(nestedElement.ClassKind.ToString());
                    writer.WriteStartArray("elementUsage"u8);

                    foreach(var elementUsageItem in nestedElement.ElementUsage.OrderBy(x => x, this.OrderedItemComparer))
                    {
                        writer.WriteOrderedItem(elementUsageItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedDomain"u8);

                    foreach(var excludedDomainItem in nestedElement.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedDomainItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedPerson"u8);

                    foreach(var excludedPersonItem in nestedElement.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedPersonItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(nestedElement.Iid);
                    writer.WritePropertyName("isVolatile"u8);
                    writer.WriteBooleanValue(nestedElement.IsVolatile);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(nestedElement.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WriteStartArray("nestedParameter"u8);

                    foreach(var nestedParameterItem in nestedElement.NestedParameter.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(nestedParameterItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(nestedElement.RevisionNumber);
                    writer.WritePropertyName("rootElement"u8);
                    writer.WriteStringValue(nestedElement.RootElement);
                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(nestedElement.ThingPreference);
                    break;
                case "1.3.0":
                    Logger.Log(LogLevel.Trace, "Serializing NestedElement for Version 1.3.0");
                    writer.WritePropertyName("actor"u8);

                    if(nestedElement.Actor.HasValue)
                    {
                        writer.WriteStringValue(nestedElement.Actor.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(nestedElement.ClassKind.ToString());
                    writer.WriteStartArray("elementUsage"u8);

                    foreach(var elementUsageItem in nestedElement.ElementUsage.OrderBy(x => x, this.OrderedItemComparer))
                    {
                        writer.WriteOrderedItem(elementUsageItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedDomain"u8);

                    foreach(var excludedDomainItem in nestedElement.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedDomainItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedPerson"u8);

                    foreach(var excludedPersonItem in nestedElement.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedPersonItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(nestedElement.Iid);
                    writer.WritePropertyName("isVolatile"u8);
                    writer.WriteBooleanValue(nestedElement.IsVolatile);
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(nestedElement.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WriteStartArray("nestedParameter"u8);

                    foreach(var nestedParameterItem in nestedElement.NestedParameter.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(nestedParameterItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(nestedElement.RevisionNumber);
                    writer.WritePropertyName("rootElement"u8);
                    writer.WriteStringValue(nestedElement.RootElement);
                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(nestedElement.ThingPreference);
                    break;
                default:
                    throw new NotSupportedException($"The provided version {requestedDataModelVersion.ToString(3)} is not supported");
            }

            writer.WriteEndObject();
        }

        /// <summary>
        /// Serialize a value for a <see cref="NestedElement"/> property into a <see cref="Utf8JsonWriter" />
        /// </summary>
        /// <param name="propertyName">The name of the property to serialize</param>
        /// <param name="value">The object value to serialize</param>
        /// <param name="writer">The <see cref="Utf8JsonWriter" /></param>
        /// <param name="requestedDataModelVersion">The <see cref="Version" /> that has been requested for the serialization</param>
        /// <remarks>This method should only be used in the scope of serializing a <see cref="ClasslessDTO" /></remarks>
        public void SerializeProperty(string propertyName, object value, Utf8JsonWriter writer, Version requestedDataModelVersion)
        {
            var requestedVersion = requestedDataModelVersion.ToString(3);

            switch(propertyName.ToLower())
            {
                case "actor":
                    if(!AllowedVersionsPerProperty["actor"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("actor"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((Guid)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "classkind":
                    if(!AllowedVersionsPerProperty["classKind"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("classKind"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue(((ClassKind)value).ToString());
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "elementusage":
                    if(!AllowedVersionsPerProperty["elementUsage"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WriteStartArray("elementUsage"u8);

                    if(value is IEnumerable<object> objectListElementUsage)
                    {
                        foreach(var elementUsageItem in objectListElementUsage.OfType<OrderedItem>().OrderBy(x => x, this.OrderedItemComparer))
                        {
                            writer.WriteOrderedItem(elementUsageItem);
                        }
                    }
                    
                    writer.WriteEndArray();
                    break;
                case "excludeddomain":
                    if(!AllowedVersionsPerProperty["excludedDomain"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WriteStartArray("excludedDomain"u8);

                    if(value is IEnumerable<object> objectListExcludedDomain)
                    {
                        foreach(var excludedDomainItem in objectListExcludedDomain.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedDomainItem);
                        }
                    }
                    
                    writer.WriteEndArray();
                    break;
                case "excludedperson":
                    if(!AllowedVersionsPerProperty["excludedPerson"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WriteStartArray("excludedPerson"u8);

                    if(value is IEnumerable<object> objectListExcludedPerson)
                    {
                        foreach(var excludedPersonItem in objectListExcludedPerson.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(excludedPersonItem);
                        }
                    }
                    
                    writer.WriteEndArray();
                    break;
                case "iid":
                    if(!AllowedVersionsPerProperty["iid"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("iid"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((Guid)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "isvolatile":
                    if(!AllowedVersionsPerProperty["isVolatile"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("isVolatile"u8);
                    
                    if(value != null)
                    {
                        writer.WriteBooleanValue((bool)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "modifiedon":
                    if(!AllowedVersionsPerProperty["modifiedOn"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("modifiedOn"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue(((DateTime)value).ToString(SerializerHelper.DateTimeFormat));
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "nestedparameter":
                    if(!AllowedVersionsPerProperty["nestedParameter"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WriteStartArray("nestedParameter"u8);

                    if(value is IEnumerable<object> objectListNestedParameter)
                    {
                        foreach(var nestedParameterItem in objectListNestedParameter.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(nestedParameterItem);
                        }
                    }
                    
                    writer.WriteEndArray();
                    break;
                case "revisionnumber":
                    if(!AllowedVersionsPerProperty["revisionNumber"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("revisionNumber"u8);
                    
                    if(value != null)
                    {
                        writer.WriteNumberValue((int)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "rootelement":
                    if(!AllowedVersionsPerProperty["rootElement"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("rootElement"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((Guid)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "thingpreference":
                    if(!AllowedVersionsPerProperty["thingPreference"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("thingPreference"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((string)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                default:
                    throw new ArgumentException($"The requested property {propertyName} does not exist on the NestedElement");
            }
        }

        /// <summary>
        /// Gets the association between a name of a property and all versions where that property is defined
        /// </summary>
        private static readonly IReadOnlyDictionary<string, IReadOnlyCollection<string>> AllowedVersionsPerProperty = new Dictionary<string, IReadOnlyCollection<string>>()
        {
            { "actor", new []{ "1.3.0" }},
            { "classKind", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "elementUsage", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedDomain", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedPerson", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "iid", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "isVolatile", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "modifiedOn", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "nestedParameter", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "revisionNumber", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "rootElement", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "thingPreference", new []{ "1.2.0", "1.3.0" }},
        };
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
