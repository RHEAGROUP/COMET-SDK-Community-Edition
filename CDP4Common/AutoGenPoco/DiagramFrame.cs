// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DiagramFrame.cs" company="RHEA System S.A.">
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

namespace CDP4Common.DiagramData
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
    /// Represents a drawing frame that can be used to visually group a number of other diagram shapes.
    /// </summary>
    [CDPVersion("1.4.0")]
    [Container(typeof(DiagramElementContainer), "DiagramElement")]
    public partial class DiagramFrame : DiagramShape
    {
        /// <summary>
        /// Representation of the default value for the accessRight property of a PersonPermission for the affected class
        /// </summary>
        public new const PersonAccessRightKind DefaultPersonAccess = PersonAccessRightKind.NOT_APPLICABLE;

        /// <summary>
        /// Representation of the default value for the accessRight property of a PersonPermission for the affected class
        /// </summary>
        public new const ParticipantAccessRightKind DefaultParticipantAccess = ParticipantAccessRightKind.SAME_AS_SUPERCLASS;

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagramFrame"/> class.
        /// </summary>
        public DiagramFrame()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagramFrame"/> class.
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
        public DiagramFrame(Guid iid, ConcurrentDictionary<CacheKey, Lazy<CommonData.Thing>> cache, Uri iDalUri) : base(iid, cache, iDalUri)
        {
        }

        /// <summary>
        /// Creates and returns a copy of this <see cref="DiagramFrame"/> for edit purpose.
        /// </summary>
        /// <param name="cloneContainedThings">A value that indicates whether the contained <see cref="Thing"/>s should be cloned or not.</param>
        /// <returns>
        /// A cloned instance of <see cref="DiagramFrame"/>.
        /// </returns>
        protected override Thing GenericClone(bool cloneContainedThings)
        {
            var clone = (DiagramFrame)this.MemberwiseClone();
            clone.Bounds = cloneContainedThings ? new ContainerList<Bounds>(clone) : new ContainerList<Bounds>(this.Bounds, clone);
            clone.DiagramElement = cloneContainedThings ? new ContainerList<DiagramElementThing>(clone) : new ContainerList<DiagramElementThing>(this.DiagramElement, clone);
            clone.ExcludedDomain = new List<DomainOfExpertise>(this.ExcludedDomain);
            clone.ExcludedPerson = new List<Person>(this.ExcludedPerson);
            clone.LocalStyle = cloneContainedThings ? new ContainerList<OwnedStyle>(clone) : new ContainerList<OwnedStyle>(this.LocalStyle, clone);

            if (cloneContainedThings)
            {
                clone.Bounds.AddRange(this.Bounds.Select(x => x.Clone(true)));
                clone.DiagramElement.AddRange(this.DiagramElement.Select(x => x.Clone(true)));
                clone.LocalStyle.AddRange(this.LocalStyle.Select(x => x.Clone(true)));
            }

            clone.Original = this;
            clone.ResetCacheId();
            return clone;
        }

        /// <summary>
        /// Creates and returns a copy of this <see cref="DiagramFrame"/> for edit purpose.
        /// </summary>
        /// <param name="cloneContainedThings">A value that indicates whether the contained <see cref="Thing"/>s should be cloned or not.</param>
        /// <returns>
        /// A cloned instance of <see cref="DiagramFrame"/>.
        /// </returns>
        public new DiagramFrame Clone(bool cloneContainedThings)
        {
            this.ChangeKind = ChangeKind.Update;
            return (DiagramFrame)this.GenericClone(cloneContainedThings);
        }

        /// <summary>
        /// Validates the cardinalities of the properties of this <see cref="DiagramFrame"/>.
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
        /// Resolve the properties of the current <see cref="DiagramFrame"/> from its <see cref="DTO.Thing"/> counter-part
        /// </summary>
        /// <param name="dtoThing">The source <see cref="DTO.Thing"/></param>
        internal override void ResolveProperties(DTO.Thing dtoThing)
        {
            if (dtoThing == null)
            {
                throw new ArgumentNullException("dtoThing");
            }

            var dto = dtoThing as DTO.DiagramFrame;
            if (dto == null)
            {
                throw new InvalidOperationException($"The DTO type {dtoThing.GetType()} does not match the type of the current DiagramFrame POCO.");
            }

            this.Actor = (dto.Actor.HasValue) ? this.Cache.Get<Person>(dto.Actor.Value, dto.IterationContainerId) : null;
            this.Bounds.ResolveList(dto.Bounds, dto.IterationContainerId, this.Cache);
            this.DepictedThing = (dto.DepictedThing.HasValue) ? this.Cache.Get<Thing>(dto.DepictedThing.Value, dto.IterationContainerId) : null;
            this.DiagramElement.ResolveList(dto.DiagramElement, dto.IterationContainerId, this.Cache);
            this.ExcludedDomain.ResolveList(dto.ExcludedDomain, dto.IterationContainerId, this.Cache);
            this.ExcludedPerson.ResolveList(dto.ExcludedPerson, dto.IterationContainerId, this.Cache);
            this.LocalStyle.ResolveList(dto.LocalStyle, dto.IterationContainerId, this.Cache);
            this.ModifiedOn = dto.ModifiedOn;
            this.Name = dto.Name;
            this.RevisionNumber = dto.RevisionNumber;
            this.SharedStyle = (dto.SharedStyle.HasValue) ? this.Cache.Get<SharedStyle>(dto.SharedStyle.Value, dto.IterationContainerId) : null;
            this.ThingPreference = dto.ThingPreference;

            this.ResolveExtraProperties();
        }

        /// <summary>
        /// Generates a <see cref="DTO.Thing"/> from the current <see cref="DiagramFrame"/>
        /// </summary>
        public override DTO.Thing ToDto()
        {
            var dto = new DTO.DiagramFrame(this.Iid, this.RevisionNumber);

            dto.Actor = this.Actor != null ? (Guid?)this.Actor.Iid : null;
            dto.Bounds.AddRange(this.Bounds.Select(x => x.Iid));
            dto.DepictedThing = this.DepictedThing != null ? (Guid?)this.DepictedThing.Iid : null;
            dto.DiagramElement.AddRange(this.DiagramElement.Select(x => x.Iid));
            dto.ExcludedDomain.AddRange(this.ExcludedDomain.Select(x => x.Iid));
            dto.ExcludedPerson.AddRange(this.ExcludedPerson.Select(x => x.Iid));
            dto.LocalStyle.AddRange(this.LocalStyle.Select(x => x.Iid));
            dto.ModifiedOn = this.ModifiedOn;
            dto.Name = this.Name;
            dto.RevisionNumber = this.RevisionNumber;
            dto.SharedStyle = this.SharedStyle != null ? (Guid?)this.SharedStyle.Iid : null;
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