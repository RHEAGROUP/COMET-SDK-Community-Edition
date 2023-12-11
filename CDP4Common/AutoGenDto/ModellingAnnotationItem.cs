// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModellingAnnotationItem.cs" company="RHEA System S.A.">
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
    /// A Data Transfer Object representation of the <see cref="ModellingAnnotationItem"/> class.
    /// </summary>
    [DataContract]
    [CDPVersion("1.1.0")]
    [Container(typeof(EngineeringModel), "ModellingAnnotation")]
    public abstract partial class ModellingAnnotationItem : EngineeringModelDataAnnotation, ICategorizableThing, IOwnedThing, IShortNamedThing
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModellingAnnotationItem"/> class.
        /// </summary>
        protected ModellingAnnotationItem()
        {
            this.ApprovedBy = new List<Guid>();
            this.Category = new List<Guid>();
            this.SourceAnnotation = new List<Guid>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModellingAnnotationItem"/> class.
        /// </summary>
        /// <param name="iid">
        /// The unique identifier.
        /// </param>
        /// <param name="rev">
        /// The revision number.
        /// </param>
        protected ModellingAnnotationItem(Guid iid, int rev) : base(iid: iid, rev: rev)
        {
            this.ApprovedBy = new List<Guid>();
            this.Category = new List<Guid>();
            this.SourceAnnotation = new List<Guid>();
        }

        /// <summary>
        /// Gets or sets the unique identifiers of the contained ApprovedBy instances.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.Composite, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public virtual List<Guid> ApprovedBy { get; set; }

        /// <summary>
        /// Gets or sets the list of unique identifiers of the referenced Category instances.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public virtual List<Guid> Category { get; set; }

        /// <summary>
        /// Gets or sets the Classification.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public virtual AnnotationClassificationKind Classification { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the referenced Owner.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public virtual Guid Owner { get; set; }

        /// <summary>
        /// Gets or sets the ShortName.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public virtual string ShortName { get; set; }

        /// <summary>
        /// Gets or sets the list of unique identifiers of the referenced SourceAnnotation instances.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public virtual List<Guid> SourceAnnotation { get; set; }

        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public virtual AnnotationStatusKind Status { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        [DataMember]
        public virtual string Title { get; set; }

        /// <summary>
        /// Gets the route for the current <see ref="ModellingAnnotationItem"/>.
        /// </summary>
        public override string Route
        {
            get { return this.ComputedRoute(); }
        }

        /// <summary>
        /// Gets an <see cref="IEnumerable{IEnumerable}"/> that references the composite properties of the current <see cref="ModellingAnnotationItem"/>.
        /// </summary>
        public override IEnumerable<IEnumerable> ContainerLists
        {
            get 
            {
                var containers = new List<IEnumerable>(base.ContainerLists);
                containers.Add(this.ApprovedBy);
                return containers;
            }
        }

        /// <summary>
        /// Get all Reference Properties by their Name and id's of instance values
        /// </summary>
        /// <returns>A dictionary of string (Name) and a collections of Guid's (id's of instance values)</returns>
        public override IDictionary<string, IEnumerable<Guid>> GetReferenceProperties()
        {
            var dictionary = new Dictionary<string, IEnumerable<Guid>>();

            dictionary.Add("ApprovedBy", this.ApprovedBy);

            if (this.Author != null)
            {
                dictionary.Add("Author", new [] { this.Author });
            }

            dictionary.Add("Category", this.Category);

            dictionary.Add("Discussion", this.Discussion);

            dictionary.Add("ExcludedDomain", this.ExcludedDomain);

            dictionary.Add("ExcludedPerson", this.ExcludedPerson);

            if (this.Owner != null)
            {
                dictionary.Add("Owner", new [] { this.Owner });
            }

            if (this.PrimaryAnnotatedThing != null)
            {
                dictionary.Add("PrimaryAnnotatedThing", new [] { this.PrimaryAnnotatedThing.Value });
            }

            dictionary.Add("RelatedThing", this.RelatedThing);

            dictionary.Add("SourceAnnotation", this.SourceAnnotation);

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
                            case "ApprovedBy":
                                this.ApprovedBy.Remove(id);
                                break;

                            case "Author":
                                if (addModelErrors)
                                {
                                    errors.Add($"Removed reference '{id}' from Author property results in inconsistent ModellingAnnotationItem.");
                                    result = false;
                                }
                                result = false;
                                break;

                            case "Category":
                                this.Category.Remove(id);
                                break;

                            case "Discussion":
                                this.Discussion.Remove(id);
                                break;

                            case "ExcludedDomain":
                                this.ExcludedDomain.Remove(id);
                                break;

                            case "ExcludedPerson":
                                this.ExcludedPerson.Remove(id);
                                break;

                            case "Owner":
                                if (addModelErrors)
                                {
                                    errors.Add($"Removed reference '{id}' from Owner property results in inconsistent ModellingAnnotationItem.");
                                    result = false;
                                }
                                result = false;
                                break;

                            case "PrimaryAnnotatedThing":
                                this.PrimaryAnnotatedThing = null;
                                break;

                            case "RelatedThing":
                                this.RelatedThing.Remove(id);
                                break;

                            case "SourceAnnotation":
                                this.SourceAnnotation.Remove(id);
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
