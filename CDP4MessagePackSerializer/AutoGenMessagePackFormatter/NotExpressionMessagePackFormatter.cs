// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotExpressionMessagePackFormatter.cs" company="RHEA System S.A.">
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
 | 2     | term                                 | Guid                         | 1..1        |  1.0.0  |
 | 3     | excludedDomain                       | Guid                         | 0..*        |  1.1.0  |
 | 4     | excludedPerson                       | Guid                         | 0..*        |  1.1.0  |
 | 5     | modifiedOn                           | DateTime                     | 1..1        |  1.1.0  |
 | 6     | thingPreference                      | string                       | 0..1        |  1.2.0  |
 | 7     | actor                                | Guid                         | 0..1        |  1.3.0  |
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
    /// The purpose of the <see cref="NotExpressionMessagePackFormatter"/> is to provide
    /// the contract for MessagePack (de)serialization of the <see cref="NotExpression"/> type
    /// </summary>
    [CDPVersion("1.0.0")]
    public class NotExpressionMessagePackFormatter : IMessagePackFormatter<NotExpression>
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
        /// Serializes an <see cref="NotExpression"/> DTO.
        /// </summary>
        /// <param name="writer">
        /// The <see cref="MessagePackWriter"/> to use when serializing the value.
        /// </param>
        /// <param name="notExpression">
        /// The <see cref="NotExpression"/> that is to be serialized.
        /// </param>
        /// <param name="options">
        /// The serialization settings to use.
        /// </param>
        public void Serialize(ref MessagePackWriter writer, NotExpression notExpression, MessagePackSerializerOptions options)
        {
            if (notExpression == null)
            {
                throw new ArgumentNullException(nameof(notExpression), "The NotExpression may not be null");
            }

            writer.WriteArrayHeader(8);

            writer.Write(notExpression.Iid.ToByteArray());
            writer.Write(notExpression.RevisionNumber);

            writer.Write(notExpression.Term.ToByteArray());
            writer.WriteArrayHeader(notExpression.ExcludedDomain.Count);
            foreach (var identifier in notExpression.ExcludedDomain.OrderBy(x => x, guidComparer))
            {
                writer.Write(identifier.ToByteArray());
            }
            writer.WriteArrayHeader(notExpression.ExcludedPerson.Count);
            foreach (var identifier in notExpression.ExcludedPerson.OrderBy(x => x, guidComparer))
            {
                writer.Write(identifier.ToByteArray());
            }
            writer.Write(notExpression.ModifiedOn);
            writer.Write(notExpression.ThingPreference);
            if (notExpression.Actor.HasValue)
            {
                writer.Write(notExpression.Actor.Value.ToByteArray());
            }
            else
            {
                writer.WriteNil();
            }

            writer.Flush();
        }

        /// <summary>
        /// Deserializes an <see cref="NotExpression"/>.
        /// </summary>
        /// <param name="reader">
        /// The <see cref="MessagePackWriter"/> to deserialize the <see cref="NotExpression"/> from.
        /// </param>
        /// <param name="options">
        /// The serialization settings to use.
        /// </param>
        /// <returns>
        /// The deserialized <see cref="NotExpression"/>.
        /// </returns>
        public NotExpression Deserialize(ref MessagePackReader reader, MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);

            var notExpression = new NotExpression();

            var propertyCounter = reader.ReadArrayHeader();

            for (var i = 0; i < propertyCounter; i++)
            {
                int valueLength;
                int valueCounter;
                OrderedItem orderedItem = null;

                switch (i)
                {
                    case 0:
                        notExpression.Iid = reader.ReadBytes().ToGuid();
                        break;
                    case 1:
                        notExpression.RevisionNumber = reader.ReadInt32();
                        break;
                    case 2:
                        notExpression.Term = reader.ReadBytes().ToGuid();
                        break;
                    case 3:
                        valueLength = reader.ReadArrayHeader();
                        for (valueCounter = 0; valueCounter < valueLength; valueCounter++)
                        {
                            notExpression.ExcludedDomain.Add(reader.ReadBytes().ToGuid());
                        }
                        break;
                    case 4:
                        valueLength = reader.ReadArrayHeader();
                        for (valueCounter = 0; valueCounter < valueLength; valueCounter++)
                        {
                            notExpression.ExcludedPerson.Add(reader.ReadBytes().ToGuid());
                        }
                        break;
                    case 5:
                        notExpression.ModifiedOn = reader.ReadDateTime();
                        break;
                    case 6:
                        notExpression.ThingPreference = reader.ReadString();
                        break;
                    case 7:
                        if (reader.TryReadNil())
                        {
                            notExpression.Actor = null;
                        }
                        else
                        {
                            notExpression.Actor = reader.ReadBytes().ToGuid();
                        }
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            reader.Depth--;

            return notExpression;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
