// -------------------------------------------------------------------------------------------------------------------------------
// <copyright file="EngineeringModelSerializer.cs" company="RHEA System S.A.">
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
    using EngineeringModel = CDP4Common.DTO.EngineeringModel;

    /// <summary>
    /// The purpose of the <see cref="EngineeringModelSerializer"/> class is to provide a <see cref="EngineeringModel"/> specific serializer
    /// </summary>
    public class EngineeringModelSerializer : BaseThingSerializer, IThingSerializer
    {
        /// <summary>
        /// Serializes a <see cref="Thing" /> into an <see cref="Utf8JsonWriter" />
        /// </summary>
        /// <param name="thing">The <see cref="Thing" /> that have to be serialized</param>
        /// <param name="writer">The <see cref="Utf8JsonWriter" /></param>
        /// <param name="requestedDataModelVersion">The <see cref="Version" /> that has been requested for the serialization</param>
        /// <exception cref="ArgumentException">If the provided <paramref name="thing" /> is not an <see cref="EngineeringModel" /></exception>
        /// <exception cref="NotSupportedException">If the provided <paramref name="requestedDataModelVersion" /> is not supported</exception>
        public void Serialize(Thing thing, Utf8JsonWriter writer, Version requestedDataModelVersion)
        {
            if (thing is not EngineeringModel engineeringModel)
            {
                throw new ArgumentException("The thing shall be a EngineeringModel", nameof(thing));
            }

            if (requestedDataModelVersion < Version.Parse("1.0.0"))
            {
                Logger.Log(LogLevel.Info, "Skipping serialization of EngineeringModel since Version is below 1.0.0");
                return;
            }

            writer.WriteStartObject();

            switch(requestedDataModelVersion.ToString(3))
            {
                case "1.0.0":
                    Logger.Log(LogLevel.Trace, "Serializing EngineeringModel for Version 1.0.0");
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(engineeringModel.ClassKind.ToString());
                    writer.WriteStartArray("commonFileStore"u8);

                    foreach(var commonFileStoreItem in engineeringModel.CommonFileStore.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(commonFileStoreItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("engineeringModelSetup"u8);
                    writer.WriteStringValue(engineeringModel.EngineeringModelSetup);
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(engineeringModel.Iid);
                    writer.WriteStartArray("iteration"u8);

                    foreach(var iterationItem in engineeringModel.Iteration.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(iterationItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("lastModifiedOn"u8);
                    writer.WriteStringValue(engineeringModel.LastModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WriteStartArray("logEntry"u8);

                    foreach(var logEntryItem in engineeringModel.LogEntry.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(logEntryItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(engineeringModel.RevisionNumber);
                    break;
                case "1.1.0":
                    Logger.Log(LogLevel.Trace, "Serializing EngineeringModel for Version 1.1.0");
                    writer.WriteStartArray("book"u8);

                    foreach(var bookItem in engineeringModel.Book.OrderBy(x => x, this.OrderedItemComparer))
                    {
                        writer.WriteOrderedItem(bookItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(engineeringModel.ClassKind.ToString());
                    writer.WriteStartArray("commonFileStore"u8);

                    foreach(var commonFileStoreItem in engineeringModel.CommonFileStore.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(commonFileStoreItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("engineeringModelSetup"u8);
                    writer.WriteStringValue(engineeringModel.EngineeringModelSetup);
                    writer.WriteStartArray("excludedDomain"u8);

                    foreach(var excludedDomainItem in engineeringModel.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedDomainItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedPerson"u8);

                    foreach(var excludedPersonItem in engineeringModel.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedPersonItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("genericNote"u8);

                    foreach(var genericNoteItem in engineeringModel.GenericNote.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(genericNoteItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(engineeringModel.Iid);
                    writer.WriteStartArray("iteration"u8);

                    foreach(var iterationItem in engineeringModel.Iteration.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(iterationItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("lastModifiedOn"u8);
                    writer.WriteStringValue(engineeringModel.LastModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WriteStartArray("logEntry"u8);

                    foreach(var logEntryItem in engineeringModel.LogEntry.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(logEntryItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("modellingAnnotation"u8);

                    foreach(var modellingAnnotationItem in engineeringModel.ModellingAnnotation.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(modellingAnnotationItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(engineeringModel.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(engineeringModel.RevisionNumber);
                    break;
                case "1.2.0":
                    Logger.Log(LogLevel.Trace, "Serializing EngineeringModel for Version 1.2.0");
                    writer.WriteStartArray("book"u8);

                    foreach(var bookItem in engineeringModel.Book.OrderBy(x => x, this.OrderedItemComparer))
                    {
                        writer.WriteOrderedItem(bookItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(engineeringModel.ClassKind.ToString());
                    writer.WriteStartArray("commonFileStore"u8);

                    foreach(var commonFileStoreItem in engineeringModel.CommonFileStore.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(commonFileStoreItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("engineeringModelSetup"u8);
                    writer.WriteStringValue(engineeringModel.EngineeringModelSetup);
                    writer.WriteStartArray("excludedDomain"u8);

                    foreach(var excludedDomainItem in engineeringModel.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedDomainItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedPerson"u8);

                    foreach(var excludedPersonItem in engineeringModel.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedPersonItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("genericNote"u8);

                    foreach(var genericNoteItem in engineeringModel.GenericNote.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(genericNoteItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(engineeringModel.Iid);
                    writer.WriteStartArray("iteration"u8);

                    foreach(var iterationItem in engineeringModel.Iteration.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(iterationItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("lastModifiedOn"u8);
                    writer.WriteStringValue(engineeringModel.LastModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WriteStartArray("logEntry"u8);

                    foreach(var logEntryItem in engineeringModel.LogEntry.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(logEntryItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("modellingAnnotation"u8);

                    foreach(var modellingAnnotationItem in engineeringModel.ModellingAnnotation.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(modellingAnnotationItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(engineeringModel.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(engineeringModel.RevisionNumber);
                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(engineeringModel.ThingPreference);
                    break;
                case "1.3.0":
                    Logger.Log(LogLevel.Trace, "Serializing EngineeringModel for Version 1.3.0");
                    writer.WritePropertyName("actor"u8);

                    if(engineeringModel.Actor.HasValue)
                    {
                        writer.WriteStringValue(engineeringModel.Actor.Value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    writer.WriteStartArray("book"u8);

                    foreach(var bookItem in engineeringModel.Book.OrderBy(x => x, this.OrderedItemComparer))
                    {
                        writer.WriteOrderedItem(bookItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("classKind"u8);
                    writer.WriteStringValue(engineeringModel.ClassKind.ToString());
                    writer.WriteStartArray("commonFileStore"u8);

                    foreach(var commonFileStoreItem in engineeringModel.CommonFileStore.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(commonFileStoreItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("engineeringModelSetup"u8);
                    writer.WriteStringValue(engineeringModel.EngineeringModelSetup);
                    writer.WriteStartArray("excludedDomain"u8);

                    foreach(var excludedDomainItem in engineeringModel.ExcludedDomain.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedDomainItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("excludedPerson"u8);

                    foreach(var excludedPersonItem in engineeringModel.ExcludedPerson.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(excludedPersonItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("genericNote"u8);

                    foreach(var genericNoteItem in engineeringModel.GenericNote.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(genericNoteItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("iid"u8);
                    writer.WriteStringValue(engineeringModel.Iid);
                    writer.WriteStartArray("iteration"u8);

                    foreach(var iterationItem in engineeringModel.Iteration.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(iterationItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("lastModifiedOn"u8);
                    writer.WriteStringValue(engineeringModel.LastModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WriteStartArray("logEntry"u8);

                    foreach(var logEntryItem in engineeringModel.LogEntry.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(logEntryItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WriteStartArray("modellingAnnotation"u8);

                    foreach(var modellingAnnotationItem in engineeringModel.ModellingAnnotation.OrderBy(x => x, this.GuidComparer))
                    {
                        writer.WriteStringValue(modellingAnnotationItem);
                    }

                    writer.WriteEndArray();
                    
                    writer.WritePropertyName("modifiedOn"u8);
                    writer.WriteStringValue(engineeringModel.ModifiedOn.ToString(SerializerHelper.DateTimeFormat));
                    writer.WritePropertyName("revisionNumber"u8);
                    writer.WriteNumberValue(engineeringModel.RevisionNumber);
                    writer.WritePropertyName("thingPreference"u8);
                    writer.WriteStringValue(engineeringModel.ThingPreference);
                    break;
                default:
                    throw new NotSupportedException($"The provided version {requestedDataModelVersion.ToString(3)} is not supported");
            }

            writer.WriteEndObject();
        }

        /// <summary>
        /// Serialize a value for a <see cref="EngineeringModel"/> property into a <see cref="Utf8JsonWriter" />
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
                case "book":
                    if(!AllowedVersionsPerProperty["book"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WriteStartArray("book"u8);

                    if(value is IEnumerable<object> objectListBook)
                    {
                        foreach(var bookItem in objectListBook.OfType<OrderedItem>().OrderBy(x => x, this.OrderedItemComparer))
                        {
                            writer.WriteOrderedItem(bookItem);
                        }
                    }
                    
                    writer.WriteEndArray();
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
                case "commonfilestore":
                    if(!AllowedVersionsPerProperty["commonFileStore"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WriteStartArray("commonFileStore"u8);

                    if(value is IEnumerable<object> objectListCommonFileStore)
                    {
                        foreach(var commonFileStoreItem in objectListCommonFileStore.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(commonFileStoreItem);
                        }
                    }
                    
                    writer.WriteEndArray();
                    break;
                case "engineeringmodelsetup":
                    if(!AllowedVersionsPerProperty["engineeringModelSetup"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("engineeringModelSetup"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue((Guid)value);
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

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
                case "genericnote":
                    if(!AllowedVersionsPerProperty["genericNote"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WriteStartArray("genericNote"u8);

                    if(value is IEnumerable<object> objectListGenericNote)
                    {
                        foreach(var genericNoteItem in objectListGenericNote.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(genericNoteItem);
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
                case "iteration":
                    if(!AllowedVersionsPerProperty["iteration"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WriteStartArray("iteration"u8);

                    if(value is IEnumerable<object> objectListIteration)
                    {
                        foreach(var iterationItem in objectListIteration.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(iterationItem);
                        }
                    }
                    
                    writer.WriteEndArray();
                    break;
                case "lastmodifiedon":
                    if(!AllowedVersionsPerProperty["lastModifiedOn"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WritePropertyName("lastModifiedOn"u8);
                    
                    if(value != null)
                    {
                        writer.WriteStringValue(((DateTime)value).ToString(SerializerHelper.DateTimeFormat));
                    }
                    else
                    {
                        writer.WriteNullValue();
                    }

                    break;
                case "logentry":
                    if(!AllowedVersionsPerProperty["logEntry"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WriteStartArray("logEntry"u8);

                    if(value is IEnumerable<object> objectListLogEntry)
                    {
                        foreach(var logEntryItem in objectListLogEntry.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(logEntryItem);
                        }
                    }
                    
                    writer.WriteEndArray();
                    break;
                case "modellingannotation":
                    if(!AllowedVersionsPerProperty["modellingAnnotation"].Contains(requestedVersion))
                    {
                        return;
                    }

                    writer.WriteStartArray("modellingAnnotation"u8);

                    if(value is IEnumerable<object> objectListModellingAnnotation)
                    {
                        foreach(var modellingAnnotationItem in objectListModellingAnnotation.OfType<Guid>().OrderBy(x => x, this.GuidComparer))
                        {
                            writer.WriteStringValue(modellingAnnotationItem);
                        }
                    }
                    
                    writer.WriteEndArray();
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
                    throw new ArgumentException($"The requested property {propertyName} does not exist on the EngineeringModel");
            }
        }

        /// <summary>
        /// Gets the association between a name of a property and all versions where that property is defined
        /// </summary>
        private static readonly IReadOnlyDictionary<string, IReadOnlyCollection<string>> AllowedVersionsPerProperty = new Dictionary<string, IReadOnlyCollection<string>>()
        {
            { "actor", new []{ "1.3.0" }},
            { "book", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "classKind", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "commonFileStore", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "engineeringModelSetup", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedDomain", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "excludedPerson", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "genericNote", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "iid", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "iteration", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "lastModifiedOn", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "logEntry", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "modellingAnnotation", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "modifiedOn", new []{ "1.1.0", "1.2.0", "1.3.0" }},
            { "revisionNumber", new []{ "1.0.0", "1.1.0", "1.2.0", "1.3.0" }},
            { "thingPreference", new []{ "1.2.0", "1.3.0" }},
        };
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
