// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrefixedUnitMessagePackFormatter.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2023 RHEA System S.A.
//
//    Author: Sam Gerené, Alex Vorobiev, Alexander van Delft, Nathanael Smiechowski, 
//            Antoine Théate, Omar Elabiary, Jaime Bernar
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
 | 2     | alias                                | Guid                         | 0..*        |  1.0.0  |
 | 3     | definition                           | Guid                         | 0..*        |  1.0.0  |
 | 4     | hyperLink                            | Guid                         | 0..*        |  1.0.0  |
 | 5     | isDeprecated                         | bool                         | 1..1        |  1.0.0  |
 | 6     | prefix                               | Guid                         | 1..1        |  1.0.0  |
 | 7     | referenceUnit                        | Guid                         | 1..1        |  1.0.0  |
 | 8     | excludedDomain                       | Guid                         | 0..*        |  1.1.0  |
 | 9     | excludedPerson                       | Guid                         | 0..*        |  1.1.0  |
 | 10    | modifiedOn                           | DateTime                     | 1..1        |  1.1.0  |
 | 11    | thingPreference                      | string                       | 0..1        |  1.2.0  |
 | 12    | actor                                | Guid                         | 0..1        |  1.3.0  |
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
    /// The purpose of the <see cref="PrefixedUnitMessagePackFormatter"/> is to provide
    /// the contract for MessagePack (de)serialization of the <see cref="PrefixedUnit"/> type
    /// </summary>
    [CDPVersion("1.0.0")]
    public class PrefixedUnitMessagePackFormatter : IMessagePackFormatter<PrefixedUnit>
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
        /// Serializes an <see cref="PrefixedUnit"/> DTO.
        /// </summary>
        /// <param name="writer">
        /// The <see cref="MessagePackWriter"/> to use when serializing the value.
        /// </param>
        /// <param name="prefixedUnit">
        /// The <see cref="PrefixedUnit"/> that is to be serialized.
        /// </param>
        /// <param name="options">
        /// The serialization settings to use.
        /// </param>
        public void Serialize(ref MessagePackWriter writer, PrefixedUnit prefixedUnit, MessagePackSerializerOptions options)
        {
            if (prefixedUnit == null)
            {
                throw new ArgumentNullException(nameof(prefixedUnit), "The PrefixedUnit may not be null");
            }

            writer.WriteArrayHeader(13);

            writer.Write(prefixedUnit.Iid.ToByteArray());
            writer.Write(prefixedUnit.RevisionNumber);

            writer.WriteArrayHeader(prefixedUnit.Alias.Count);
            foreach (var identifier in prefixedUnit.Alias.OrderBy(x => x, guidComparer))
            {
                writer.Write(identifier.ToByteArray());
            }
            writer.WriteArrayHeader(prefixedUnit.Definition.Count);
            foreach (var identifier in prefixedUnit.Definition.OrderBy(x => x, guidComparer))
            {
                writer.Write(identifier.ToByteArray());
            }
            writer.WriteArrayHeader(prefixedUnit.HyperLink.Count);
            foreach (var identifier in prefixedUnit.HyperLink.OrderBy(x => x, guidComparer))
            {
                writer.Write(identifier.ToByteArray());
            }
            writer.Write(prefixedUnit.IsDeprecated);
            writer.Write(prefixedUnit.Prefix.ToByteArray());
            writer.Write(prefixedUnit.ReferenceUnit.ToByteArray());
            writer.WriteArrayHeader(prefixedUnit.ExcludedDomain.Count);
            foreach (var identifier in prefixedUnit.ExcludedDomain.OrderBy(x => x, guidComparer))
            {
                writer.Write(identifier.ToByteArray());
            }
            writer.WriteArrayHeader(prefixedUnit.ExcludedPerson.Count);
            foreach (var identifier in prefixedUnit.ExcludedPerson.OrderBy(x => x, guidComparer))
            {
                writer.Write(identifier.ToByteArray());
            }
            writer.Write(prefixedUnit.ModifiedOn);
            writer.Write(prefixedUnit.ThingPreference);
            if (prefixedUnit.Actor.HasValue)
            {
                writer.Write(prefixedUnit.Actor.Value.ToByteArray());
            }
            else
            {
                writer.WriteNil();
            }

            writer.Flush();
        }

        /// <summary>
        /// Deserializes an <see cref="PrefixedUnit"/>.
        /// </summary>
        /// <param name="reader">
        /// The <see cref="MessagePackWriter"/> to deserialize the <see cref="PrefixedUnit"/> from.
        /// </param>
        /// <param name="options">
        /// The serialization settings to use.
        /// </param>
        /// <returns>
        /// The deserialized <see cref="PrefixedUnit"/>.
        /// </returns>
        public PrefixedUnit Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);

            var prefixedUnit = new PrefixedUnit();

            var propertyCounter = reader.ReadArrayHeader();

            for (var i = 0; i < propertyCounter; i++)
            {
                int valueLength;
                int valueCounter;
                OrderedItem orderedItem = null;

                switch (i)
                {
                    case 0:
                        prefixedUnit.Iid = reader.ReadBytes().ToGuid();
                        break;
                    case 1:
                        prefixedUnit.RevisionNumber = reader.ReadInt32();
                        break;
                    case 2:
                        valueLength = reader.ReadArrayHeader();
                        for (valueCounter = 0; valueCounter < valueLength; valueCounter++)
                        {
                            prefixedUnit.Alias.Add(reader.ReadBytes().ToGuid());
                        }
                        break;
                    case 3:
                        valueLength = reader.ReadArrayHeader();
                        for (valueCounter = 0; valueCounter < valueLength; valueCounter++)
                        {
                            prefixedUnit.Definition.Add(reader.ReadBytes().ToGuid());
                        }
                        break;
                    case 4:
                        valueLength = reader.ReadArrayHeader();
                        for (valueCounter = 0; valueCounter < valueLength; valueCounter++)
                        {
                            prefixedUnit.HyperLink.Add(reader.ReadBytes().ToGuid());
                        }
                        break;
                    case 5:
                        prefixedUnit.IsDeprecated = reader.ReadBoolean();
                        break;
                    case 6:
                        prefixedUnit.Prefix = reader.ReadBytes().ToGuid();
                        break;
                    case 7:
                        prefixedUnit.ReferenceUnit = reader.ReadBytes().ToGuid();
                        break;
                    case 8:
                        valueLength = reader.ReadArrayHeader();
                        for (valueCounter = 0; valueCounter < valueLength; valueCounter++)
                        {
                            prefixedUnit.ExcludedDomain.Add(reader.ReadBytes().ToGuid());
                        }
                        break;
                    case 9:
                        valueLength = reader.ReadArrayHeader();
                        for (valueCounter = 0; valueCounter < valueLength; valueCounter++)
                        {
                            prefixedUnit.ExcludedPerson.Add(reader.ReadBytes().ToGuid());
                        }
                        break;
                    case 10:
                        prefixedUnit.ModifiedOn = reader.ReadDateTime();
                        break;
                    case 11:
                        prefixedUnit.ThingPreference = reader.ReadString();
                        break;
                    case 12:
                        if (reader.TryReadNil())
                        {
                            prefixedUnit.Actor = null;
                        }
                        else
                        {
                            prefixedUnit.Actor = reader.ReadBytes().ToGuid();
                        }
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            reader.Depth--;

            return prefixedUnit;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
