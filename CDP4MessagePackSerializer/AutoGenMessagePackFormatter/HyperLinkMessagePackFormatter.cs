// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HyperLinkMessagePackFormatter.cs" company="Starion Group S.A.">
//    Copyright (c) 2015-2024 Starion Group S.A.
//
//    Author: Sam Gerené, Alex Vorobiev, Alexander van Delft, Nathanael Smiechowski, 
//            Antoine Théate, Omar Elebiary, Jaime Bernar
//
//    This file is part of CDP4-COMET SDK Community Edition
//    This is an auto-generated class. Any manual changes to this file will be overwritten!
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
// --------------------------------------------------------------------------------------------------------------------

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

/* -------------------------------------------- | ---------------------------- | ----------- | ------- *
 | index | name                                 | Type                         | Cardinality | version |
 | -------------------------------------------- | ---------------------------- | ----------- | ------- |
 | 0     | iid                                  | Guid                         |  1..1       |  1.0.0  |
 | 1     | revisionNumber                       | int                          |  1..1       |  1.0.0  |
 | -------------------------------------------- | ---------------------------- | ----------- | ------- |
 | 2     | content                              | string                       | 1..1        |  1.0.0  |
 | 3     | languageCode                         | string                       | 1..1        |  1.0.0  |
 | 4     | uri                                  | string                       | 1..1        |  1.0.0  |
 | 5     | excludedDomain                       | Guid                         | 0..*        |  1.1.0  |
 | 6     | excludedPerson                       | Guid                         | 0..*        |  1.1.0  |
 | 7     | modifiedOn                           | DateTime                     | 1..1        |  1.1.0  |
 | 8     | thingPreference                      | string                       | 0..1        |  1.2.0  |
 | 9     | actor                                | Guid                         | 0..1        |  1.3.0  |
 * -------------------------------------------- | ---------------------------- | ----------- | ------- */

namespace CDP4MessagePackSerializer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using CDP4Common;
    using CDP4Common.Comparers;
    using CDP4Common.DTO;
    using CDP4Common.Types;

    using global::MessagePack;
    using global::MessagePack.Formatters;

    /// <summary>
    /// The purpose of the <see cref="HyperLinkMessagePackFormatter"/> is to provide
    /// the contract for MessagePack (de)serialization of the <see cref="HyperLink"/> type
    /// </summary>
    [CDPVersion("1.0.0")]
    public class HyperLinkMessagePackFormatter : IMessagePackFormatter<HyperLink>
    {
        /// <summary>
        /// The <see cref="GuidComparer"/> used to compare 2 <see cref="Guid"/>s
        /// </summary>
        private static readonly GuidComparer guidComparer = new GuidComparer();

        /// <summary>
        /// The <see cref="OrderedItemComparer"/> used to compare 2 <see cref="OrderedItem"/>s
        /// </summary>
        private static readonly OrderedItemComparer orderedItemComparer = new OrderedItemComparer();

        /// <summary>
        /// Serializes an <see cref="HyperLink"/> DTO.
        /// </summary>
        /// <param name="writer">
        /// The <see cref="MessagePackWriter"/> to use when serializing the value.
        /// </param>
        /// <param name="hyperLink">
        /// The <see cref="HyperLink"/> that is to be serialized.
        /// </param>
        /// <param name="options">
        /// The serialization settings to use.
        /// </param>
        public void Serialize(ref MessagePackWriter writer, HyperLink hyperLink, MessagePackSerializerOptions options)
        {
            if (hyperLink == null)
            {
                throw new ArgumentNullException(nameof(hyperLink), "The HyperLink may not be null");
            }

            writer.WriteArrayHeader(10);

            writer.Write(hyperLink.Iid.ToByteArray());
            writer.Write(hyperLink.RevisionNumber);

            writer.Write(hyperLink.Content);
            writer.Write(hyperLink.LanguageCode);
            writer.Write(hyperLink.Uri);
            writer.WriteArrayHeader(hyperLink.ExcludedDomain.Count);
            foreach (var identifier in hyperLink.ExcludedDomain.OrderBy(x => x, guidComparer))
            {
                writer.Write(identifier.ToByteArray());
            }
            writer.WriteArrayHeader(hyperLink.ExcludedPerson.Count);
            foreach (var identifier in hyperLink.ExcludedPerson.OrderBy(x => x, guidComparer))
            {
                writer.Write(identifier.ToByteArray());
            }
            writer.Write(hyperLink.ModifiedOn);
            writer.Write(hyperLink.ThingPreference);
            if (hyperLink.Actor.HasValue)
            {
                writer.Write(hyperLink.Actor.Value.ToByteArray());
            }
            else
            {
                writer.WriteNil();
            }

            writer.Flush();
        }

        /// <summary>
        /// Deserializes an <see cref="HyperLink"/>.
        /// </summary>
        /// <param name="reader">
        /// The <see cref="MessagePackWriter"/> to deserialize the <see cref="HyperLink"/> from.
        /// </param>
        /// <param name="options">
        /// The serialization settings to use.
        /// </param>
        /// <returns>
        /// The deserialized <see cref="HyperLink"/>.
        /// </returns>
        public HyperLink Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);

            var hyperLink = new HyperLink();

            var propertyCounter = reader.ReadArrayHeader();

            for (var i = 0; i < propertyCounter; i++)
            {
                int valueLength;
                int valueCounter;
                OrderedItem orderedItem = null;

                switch (i)
                {
                    case 0:
                        hyperLink.Iid = reader.ReadBytes().ToGuid();
                        break;
                    case 1:
                        hyperLink.RevisionNumber = reader.ReadInt32();
                        break;
                    case 2:
                        hyperLink.Content = reader.ReadString();
                        break;
                    case 3:
                        hyperLink.LanguageCode = reader.ReadString();
                        break;
                    case 4:
                        hyperLink.Uri = reader.ReadString();
                        break;
                    case 5:
                        valueLength = reader.ReadArrayHeader();
                        for (valueCounter = 0; valueCounter < valueLength; valueCounter++)
                        {
                            hyperLink.ExcludedDomain.Add(reader.ReadBytes().ToGuid());
                        }
                        break;
                    case 6:
                        valueLength = reader.ReadArrayHeader();
                        for (valueCounter = 0; valueCounter < valueLength; valueCounter++)
                        {
                            hyperLink.ExcludedPerson.Add(reader.ReadBytes().ToGuid());
                        }
                        break;
                    case 7:
                        hyperLink.ModifiedOn = reader.ReadDateTime();
                        break;
                    case 8:
                        hyperLink.ThingPreference = reader.ReadString();
                        break;
                    case 9:
                        if (reader.TryReadNil())
                        {
                            hyperLink.Actor = null;
                        }
                        else
                        {
                            hyperLink.Actor = reader.ReadBytes().ToGuid();
                        }
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            reader.Depth--;

            return hyperLink;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
