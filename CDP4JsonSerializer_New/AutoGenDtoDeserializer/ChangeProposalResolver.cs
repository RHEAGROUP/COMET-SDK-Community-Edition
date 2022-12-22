// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChangeProposalResolver.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2023 RHEA System S.A.
//
//    Author: Sam Gerené, Merlin Bieze, Alex Vorobiev, Naron Phou, Jaime Bernar
//
//    This file is part of CDP4-SDK Community Edition
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

namespace CDP4JsonSerializer_SystemTextJson
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.Json;

    using CDP4Common.CommonData;
    using CDP4Common.EngineeringModelData;
    using CDP4Common.ReportingData;
    using CDP4Common.SiteDirectoryData;
    using CDP4Common.Types;

    using CDP4JsonSerializer_SystemTextJson.EnumDeserializers;
    
    /// <summary>
    /// The purpose of the <see cref="ChangeProposalResolver"/> is to deserialize a JSON object to a <see cref="ChangeProposal"/>
    /// </summary>
    public static class ChangeProposalResolver
    {
        /// <summary>
        /// Instantiate and deserialize the properties of a <see cref="ChangeProposal"/>
        /// </summary>
        /// <param name="jObject">The <see cref="JsonElement"/> containing the data</param>
        /// <returns>The <see cref="ChangeProposal"/> to instantiate</returns>
        public static CDP4Common.DTO.ChangeProposal FromJsonObject(JsonElement jObject)
        {
            jObject.TryGetProperty("iid", out var iid);
            jObject.TryGetProperty("revisionNumber", out var revisionNumber);
            var changeProposal = new CDP4Common.DTO.ChangeProposal(iid.GetGuid(), revisionNumber.GetInt32());

            if (jObject.TryGetProperty("approvedBy", out var approvedByProperty))
            {
                changeProposal.ApprovedBy.AddRange(approvedByProperty.Deserialize<IEnumerable<Guid>>());
            }

            if (jObject.TryGetProperty("author", out var authorProperty))
            {
                changeProposal.Author = authorProperty.Deserialize<Guid>();
            }

            if (jObject.TryGetProperty("category", out var categoryProperty))
            {
                changeProposal.Category.AddRange(categoryProperty.Deserialize<IEnumerable<Guid>>());
            }

            if (jObject.TryGetProperty("changeRequest", out var changeRequestProperty))
            {
                changeProposal.ChangeRequest = changeRequestProperty.Deserialize<Guid>();
            }

            if (jObject.TryGetProperty("classification", out var classificationProperty))
            {
                changeProposal.Classification = AnnotationClassificationKindDeserializer.Deserialize(classificationProperty);
            }

            if (jObject.TryGetProperty("content", out var contentProperty))
            {
                changeProposal.Content = contentProperty.Deserialize<string>();
            }

            if (jObject.TryGetProperty("createdOn", out var createdOnProperty))
            {
                changeProposal.CreatedOn = createdOnProperty.Deserialize<DateTime>();
            }

            if (jObject.TryGetProperty("discussion", out var discussionProperty))
            {
                changeProposal.Discussion.AddRange(discussionProperty.Deserialize<IEnumerable<Guid>>());
            }

            if (jObject.TryGetProperty("excludedDomain", out var excludedDomainProperty))
            {
                changeProposal.ExcludedDomain.AddRange(excludedDomainProperty.Deserialize<IEnumerable<Guid>>());
            }

            if (jObject.TryGetProperty("excludedPerson", out var excludedPersonProperty))
            {
                changeProposal.ExcludedPerson.AddRange(excludedPersonProperty.Deserialize<IEnumerable<Guid>>());
            }

            if (jObject.TryGetProperty("languageCode", out var languageCodeProperty))
            {
                changeProposal.LanguageCode = languageCodeProperty.Deserialize<string>();
            }

            if (jObject.TryGetProperty("modifiedOn", out var modifiedOnProperty))
            {
                changeProposal.ModifiedOn = modifiedOnProperty.Deserialize<DateTime>();
            }

            if (jObject.TryGetProperty("owner", out var ownerProperty))
            {
                changeProposal.Owner = ownerProperty.Deserialize<Guid>();
            }

            if (jObject.TryGetProperty("primaryAnnotatedThing", out var primaryAnnotatedThingProperty))
            {
                changeProposal.PrimaryAnnotatedThing = primaryAnnotatedThingProperty.Deserialize<Guid?>();
            }

            if (jObject.TryGetProperty("relatedThing", out var relatedThingProperty))
            {
                changeProposal.RelatedThing.AddRange(relatedThingProperty.Deserialize<IEnumerable<Guid>>());
            }

            if (jObject.TryGetProperty("shortName", out var shortNameProperty))
            {
                changeProposal.ShortName = shortNameProperty.Deserialize<string>();
            }

            if (jObject.TryGetProperty("sourceAnnotation", out var sourceAnnotationProperty))
            {
                changeProposal.SourceAnnotation.AddRange(sourceAnnotationProperty.Deserialize<IEnumerable<Guid>>());
            }

            if (jObject.TryGetProperty("status", out var statusProperty))
            {
                changeProposal.Status = AnnotationStatusKindDeserializer.Deserialize(statusProperty);
            }

            if (jObject.TryGetProperty("thingPreference", out var thingPreferenceProperty))
            {
                changeProposal.ThingPreference = thingPreferenceProperty.Deserialize<string>();
            }

            if (jObject.TryGetProperty("title", out var titleProperty))
            {
                changeProposal.Title = titleProperty.Deserialize<string>();
            }

            return changeProposal;
        }
    }
}
