// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Behavior.cs" company="RHEA System S.A.">
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

namespace CDP4Common.EngineeringModelData
{
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    using CDP4Common.CommonData;
    using CDP4Common.DiagramData;
    using CDP4Common.EngineeringModelData;
    using CDP4Common.Helpers;
    using CDP4Common.ReportingData;
    using CDP4Common.SiteDirectoryData;
    using CDP4Common.Types;

    /// <summary>
    /// A Behavior is a textual {script} description or a binary file link containing an external function that takes inputs and produces outputs.
    /// </summary>
    [CDPVersion("1.4.0")]
    [Container(typeof(ElementDefinition), "Behavior")]
    public partial class Behavior : DefinedThing
    {
        /// <summary>
        /// Representation of the default value for the accessRight property of a PersonPermission for the affected class
        /// </summary>
        public new const PersonAccessRightKind DefaultPersonAccess = PersonAccessRightKind.NOT_APPLICABLE;

        /// <summary>
        /// Representation of the default value for the accessRight property of a PersonPermission for the affected class
        /// </summary>
        public new const ParticipantAccessRightKind DefaultParticipantAccess = ParticipantAccessRightKind.SAME_AS_CONTAINER;

        /// <summary>
        /// Initializes a new instance of the <see cref="Behavior"/> class.
        /// </summary>
        public Behavior()
        {
            this.BehavioralParameter = new ContainerList<BehavioralParameter>(this);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Behavior"/> class.
        /// </summary>
        /// <param name="iid">
        /// The unique identifier.
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{T, U}"/> where the current thing is stored.
        /// The <see cref="CacheKey"/> is the key used to store this thing.
        /// The key is a combination of this thing's identifier and the identifier of its <see cref="Iteration"/> container if applicable or null.
        /// </param>
        /// <param name="iDalUri">
        /// The <see cref="Uri"/> of this thing
        /// </param>
        public Behavior(Guid iid, ConcurrentDictionary<CacheKey, Lazy<CommonData.Thing>> cache, Uri iDalUri) : base(iid, cache, iDalUri)
        {
            this.BehavioralParameter = new ContainerList<BehavioralParameter>(this);
        }

        /// <summary>
        /// Gets or sets the BehavioralModelKind.
        /// </summary>
        /// <remarks>
        /// The kind of behavioral model being represented by script or File.
        /// </remarks>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        public BehavioralModelKind BehavioralModelKind { get; set; }

        /// <summary>
        /// Gets or sets a list of contained BehavioralParameter.
        /// </summary>
        /// <remarks>
        /// A collection of BehavioralParameters.
        /// </remarks>
        [UmlInformation(aggregation: AggregationKind.Composite, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        public ContainerList<BehavioralParameter> BehavioralParameter { get; protected set; }

        /// <summary>
        /// Gets or sets the Script.
        /// </summary>
        /// <remarks>
        /// The string representation of the script defining the behavior.
        /// </remarks>
        [UmlInformation(aggregation: AggregationKind.None, isDerived: false, isOrdered: false, isNullable: false, isPersistent: true)]
        public string Script { get; set; }

        /// <summary>
        /// Gets an <see cref="IEnumerable{IEnumerable}"/> that references the composite properties of the current <see cref="Behavior"/>.
        /// </summary>
        public override IEnumerable<IEnumerable> ContainerLists
        {
            get 
            {
                var containers = new List<IEnumerable>(base.ContainerLists);
                containers.Add(this.BehavioralParameter);
                return containers;
            }
        }

        /// <summary>
        /// Creates and returns a copy of this <see cref="Behavior"/> for edit purpose.
        /// </summary>
        /// <param name="cloneContainedThings">A value that indicates whether the contained <see cref="Thing"/>s should be cloned or not.</param>
        /// <returns>
        /// A cloned instance of <see cref="Behavior"/>.
        /// </returns>
        protected override Thing GenericClone(bool cloneContainedThings)
        {
            var clone = (Behavior)this.MemberwiseClone();
            clone.Alias = cloneContainedThings ? new ContainerList<Alias>(clone) : new ContainerList<Alias>(this.Alias, clone);
            clone.Attachment = cloneContainedThings ? new ContainerList<Attachment>(clone) : new ContainerList<Attachment>(this.Attachment, clone);
            clone.BehavioralParameter = cloneContainedThings ? new ContainerList<BehavioralParameter>(clone) : new ContainerList<BehavioralParameter>(this.BehavioralParameter, clone);
            clone.Definition = cloneContainedThings ? new ContainerList<Definition>(clone) : new ContainerList<Definition>(this.Definition, clone);
            clone.ExcludedDomain = new List<DomainOfExpertise>(this.ExcludedDomain);
            clone.ExcludedPerson = new List<Person>(this.ExcludedPerson);
            clone.HyperLink = cloneContainedThings ? new ContainerList<HyperLink>(clone) : new ContainerList<HyperLink>(this.HyperLink, clone);

            if (cloneContainedThings)
            {
                clone.Alias.AddRange(this.Alias.Select(x => x.Clone(true)));
                clone.Attachment.AddRange(this.Attachment.Select(x => x.Clone(true)));
                clone.BehavioralParameter.AddRange(this.BehavioralParameter.Select(x => x.Clone(true)));
                clone.Definition.AddRange(this.Definition.Select(x => x.Clone(true)));
                clone.HyperLink.AddRange(this.HyperLink.Select(x => x.Clone(true)));
            }

            clone.Original = this;
            clone.ResetCacheId();
            return clone;
        }

        /// <summary>
        /// Creates and returns a copy of this <see cref="Behavior"/> for edit purpose.
        /// </summary>
        /// <param name="cloneContainedThings">A value that indicates whether the contained <see cref="Thing"/>s should be cloned or not.</param>
        /// <returns>
        /// A cloned instance of <see cref="Behavior"/>.
        /// </returns>
        public new Behavior Clone(bool cloneContainedThings)
        {
            this.ChangeKind = ChangeKind.Update;
            return (Behavior)this.GenericClone(cloneContainedThings);
        }

        /// <summary>
        /// Validates the cardinalities of the properties of this <see cref="Behavior"/>.
        /// </summary>
        /// <returns>
        /// A list of potential errors.
        /// </returns>
        protected override IEnumerable<string> ValidatePocoCardinality()
        {
            var errorList = new List<string>(base.ValidatePocoCardinality());

            return errorList;
        }

        /// <summary>
        /// Resolve the properties of the current <see cref="Behavior"/> from its <see cref="DTO.Thing"/> counter-part
        /// </summary>
        /// <param name="dtoThing">The source <see cref="DTO.Thing"/></param>
        internal override void ResolveProperties(DTO.Thing dtoThing)
        {
            if (dtoThing == null)
            {
                throw new ArgumentNullException("dtoThing");
            }

            var dto = dtoThing as DTO.Behavior;
            if (dto == null)
            {
                throw new InvalidOperationException($"The DTO type {dtoThing.GetType()} does not match the type of the current Behavior POCO.");
            }

            this.Actor = (dto.Actor.HasValue) ? this.Cache.Get<Person>(dto.Actor.Value, dto.IterationContainerId) : null;
            this.Alias.ResolveList(dto.Alias, dto.IterationContainerId, this.Cache);
            this.Attachment.ResolveList(dto.Attachment, dto.IterationContainerId, this.Cache);
            this.BehavioralModelKind = dto.BehavioralModelKind;
            this.BehavioralParameter.ResolveList(dto.BehavioralParameter, dto.IterationContainerId, this.Cache);
            this.Definition.ResolveList(dto.Definition, dto.IterationContainerId, this.Cache);
            this.ExcludedDomain.ResolveList(dto.ExcludedDomain, dto.IterationContainerId, this.Cache);
            this.ExcludedPerson.ResolveList(dto.ExcludedPerson, dto.IterationContainerId, this.Cache);
            this.HyperLink.ResolveList(dto.HyperLink, dto.IterationContainerId, this.Cache);
            this.ModifiedOn = dto.ModifiedOn;
            this.Name = dto.Name;
            this.RevisionNumber = dto.RevisionNumber;
            this.Script = dto.Script;
            this.ShortName = dto.ShortName;
            this.ThingPreference = dto.ThingPreference;

            this.ResolveExtraProperties();
        }

        /// <summary>
        /// Generates a <see cref="DTO.Thing"/> from the current <see cref="Behavior"/>
        /// </summary>
        public override DTO.Thing ToDto()
        {
            var dto = new DTO.Behavior(this.Iid, this.RevisionNumber);

            dto.Actor = this.Actor != null ? (Guid?)this.Actor.Iid : null;
            dto.Alias.AddRange(this.Alias.Select(x => x.Iid));
            dto.Attachment.AddRange(this.Attachment.Select(x => x.Iid));
            dto.BehavioralModelKind = this.BehavioralModelKind;
            dto.BehavioralParameter.AddRange(this.BehavioralParameter.Select(x => x.Iid));
            dto.Definition.AddRange(this.Definition.Select(x => x.Iid));
            dto.ExcludedDomain.AddRange(this.ExcludedDomain.Select(x => x.Iid));
            dto.ExcludedPerson.AddRange(this.ExcludedPerson.Select(x => x.Iid));
            dto.HyperLink.AddRange(this.HyperLink.Select(x => x.Iid));
            dto.ModifiedOn = this.ModifiedOn;
            dto.Name = this.Name;
            dto.RevisionNumber = this.RevisionNumber;
            dto.Script = this.Script;
            dto.ShortName = this.ShortName;
            dto.ThingPreference = this.ThingPreference;

            dto.IterationContainerId = this.CacheKey.Iteration;
            dto.RegisterSourceThing(this);
            this.BuildDtoPartialRoutes(dto);
            return dto;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------