// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParameterBase.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2023 RHEA System S.A.
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

namespace CDP4Common.DTO
{
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    using CDP4Common.CommonData;
    using CDP4Common.DiagramData;
    using CDP4Common.EngineeringModelData;
    using CDP4Common.ReportingData;
    using CDP4Common.SiteDirectoryData;
    using CDP4Common.Types;

    /// <summary>
    /// A Data Transfer Object representation of the <see cref="ParameterBase"/> class.
    /// </summary>
    [DataContract]
    public abstract partial class ParameterBase : Thing, IOwnedThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterBase"/> class.
        /// </summary>
        protected ParameterBase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterBase"/> class.
        /// </summary>
        /// <param name="iid">
        /// The unique identifier.
        /// </param>
        /// <param name="rev">
        /// The revision number.
        /// </param>
        protected ParameterBase(Guid iid, int rev) : base(iid: iid, rev: rev)
        {
        }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced Group.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: true, isPersistent: true)]
        [DataMember]
        public virtual Guid? Group { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsOptionDependent.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public virtual bool IsOptionDependent { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced Owner.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public virtual Guid Owner { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced ParameterType.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public virtual Guid ParameterType { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced Scale.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: true, isPersistent: true)]
        [DataMember]
        public virtual Guid? Scale { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced StateDependence.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: true, isPersistent: true)]
        [DataMember]
        public virtual Guid? StateDependence { get; set; }

        /// <summary>
        /// Get all Reference Properties by their Name and id's of instance values
        /// </summary>
        /// <returns>A dictionary of string (Name) and a collections of Guid's (id's of instance values)</returns>
        public override IDictionary<string, IEnumerable<Guid>> GetReferenceProperties()
        {
            var dictionary = new Dictionary<string, IEnumerable<Guid>>();

            dictionary.Add("ExcludedDomain", this.ExcludedDomain);

            dictionary.Add("ExcludedPerson", this.ExcludedPerson);

            if (this.Group != null)
            {
                dictionary.Add("Group", new [] { this.Group.Value });
            }

            if (this.Owner != null)
            {
                dictionary.Add("Owner", new [] { this.Owner });
            }

            if (this.ParameterType != null)
            {
                dictionary.Add("ParameterType", new [] { this.ParameterType });
            }

            if (this.Scale != null)
            {
                dictionary.Add("Scale", new [] { this.Scale.Value });
            }

            if (this.StateDependence != null)
            {
                dictionary.Add("StateDependence", new [] { this.StateDependence.Value });
            }

            return dictionary;
        }

        /// <summary>
        /// Tries to remove references to id's if they exist in a collection of id's (Guid's)
        /// </summary>
        /// <param name="ids">The collection of Guids to remove references for.</param>
        /// <param name="errors">The errors collected while trying to remove references</param>
        /// <returns>True if no errors were found while trying to remove references</returns>
        public override bool TryRemoveReferences(IEnumerable<Guid> ids, out List<string> errors)
        {
            errors = new List<string>();
            var referencedProperties = this.GetReferenceProperties();
            var addModelErrors = !ids.Contains(this.Iid);
            var result = true;

            foreach (var id in ids)
            {
                var foundProperty = referencedProperties.Where(x => x.Value.Contains(id)).ToList();

                if (foundProperty.Any())
                {
                    foreach (var kvp in foundProperty)
                    {
                        switch (kvp.Key)
                        {
                            case "ExcludedDomain":
                                this.ExcludedDomain.Remove(id);
                                break;

                            case "ExcludedPerson":
                                this.ExcludedPerson.Remove(id);
                                break;

                            case "Group":
                                this.Group = null;
                                break;

                            case "Owner":
                                if (addModelErrors)
                                {
                                    errors.Add($"Removed reference '{id}' from Owner property results in inconsistent ParameterBase.");
                                    result = false;
                                }
                                result = false;
                                break;

                            case "ParameterType":
                                if (addModelErrors)
                                {
                                    errors.Add($"Removed reference '{id}' from ParameterType property results in inconsistent ParameterBase.");
                                    result = false;
                                }
                                result = false;
                                break;

                            case "Scale":
                                this.Scale = null;
                                break;

                            case "StateDependence":
                                this.StateDependence = null;
                                break;
                        }
                    }
                }
            }
            
            return result;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
