// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReferencerRuleResolver.cs" company="RHEA System S.A.">
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace CDP4JsonSerializer
{
    using System.Text.Json;

    using NLog;

    /// <summary>
    /// The purpose of the <see cref="ReferencerRuleResolver"/> is to deserialize a JSON object to a <see cref="CDP4Common.DTO.ReferencerRule"/>
    /// </summary>
    public static class ReferencerRuleResolver
    {
        /// <summary>
        /// The NLog logger
        /// </summary>
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Instantiate and deserialize the properties of a <see cref="CDP4Common.DTO.ReferencerRule"/>
        /// </summary>
        /// <param name="jsonElement">The <see cref="JsonElement"/> containing the data</param>
        /// <returns>The <see cref="CDP4Common.DTO.ReferencerRule"/> to instantiate</returns>
        public static CDP4Common.DTO.ReferencerRule FromJsonObject(JsonElement jsonElement)
        {
            if (!jsonElement.TryGetProperty("iid"u8, out var iid))
            {
                throw new DeSerializationException("the mandatory iid property is not available, the ReferencerRuleResolver cannot be used to deserialize this JsonElement");
            }

            if (!jsonElement.TryGetProperty("revisionNumber"u8, out var revisionNumber))
            {
                throw new DeSerializationException("the mandatory revisionNumber property is not available, the ReferencerRuleResolver cannot be used to deserialize this JsonElement");
            }

            var referencerRule = new CDP4Common.DTO.ReferencerRule(iid.GetGuid(), revisionNumber.GetInt32());

            if (jsonElement.TryGetProperty("alias"u8, out var aliasProperty) && aliasProperty.ValueKind != JsonValueKind.Null)
            {
                foreach(var element in aliasProperty.EnumerateArray())
                {
                    referencerRule.Alias.Add(element.GetGuid());
                }
            }

            if (jsonElement.TryGetProperty("definition"u8, out var definitionProperty) && definitionProperty.ValueKind != JsonValueKind.Null)
            {
                foreach(var element in definitionProperty.EnumerateArray())
                {
                    referencerRule.Definition.Add(element.GetGuid());
                }
            }

            if (jsonElement.TryGetProperty("excludedDomain"u8, out var excludedDomainProperty) && excludedDomainProperty.ValueKind != JsonValueKind.Null)
            {
                foreach(var element in excludedDomainProperty.EnumerateArray())
                {
                    referencerRule.ExcludedDomain.Add(element.GetGuid());
                }
            }

            if (jsonElement.TryGetProperty("excludedPerson"u8, out var excludedPersonProperty) && excludedPersonProperty.ValueKind != JsonValueKind.Null)
            {
                foreach(var element in excludedPersonProperty.EnumerateArray())
                {
                    referencerRule.ExcludedPerson.Add(element.GetGuid());
                }
            }

            if (jsonElement.TryGetProperty("hyperLink"u8, out var hyperLinkProperty) && hyperLinkProperty.ValueKind != JsonValueKind.Null)
            {
                foreach(var element in hyperLinkProperty.EnumerateArray())
                {
                    referencerRule.HyperLink.Add(element.GetGuid());
                }
            }

            if (jsonElement.TryGetProperty("isDeprecated"u8, out var isDeprecatedProperty))
            {
                if(isDeprecatedProperty.ValueKind == JsonValueKind.Null)
                {
                    Logger.Debug("The non-nullabale isDeprecated property of the referencerRule {id} is null", referencerRule.Iid);
                }
                else
                {
                    referencerRule.IsDeprecated = isDeprecatedProperty.GetBoolean();
                }
            }

            if (jsonElement.TryGetProperty("maxReferenced"u8, out var maxReferencedProperty))
            {
                if(maxReferencedProperty.ValueKind == JsonValueKind.Null)
                {
                    Logger.Debug("The non-nullabale maxReferenced property of the referencerRule {id} is null", referencerRule.Iid);
                }
                else
                {
                    referencerRule.MaxReferenced = maxReferencedProperty.GetInt32();
                }
            }

            if (jsonElement.TryGetProperty("minReferenced"u8, out var minReferencedProperty))
            {
                if(minReferencedProperty.ValueKind == JsonValueKind.Null)
                {
                    Logger.Debug("The non-nullabale minReferenced property of the referencerRule {id} is null", referencerRule.Iid);
                }
                else
                {
                    referencerRule.MinReferenced = minReferencedProperty.GetInt32();
                }
            }

            if (jsonElement.TryGetProperty("modifiedOn"u8, out var modifiedOnProperty))
            {
                if(modifiedOnProperty.ValueKind == JsonValueKind.Null)
                {
                    Logger.Debug("The non-nullabale modifiedOn property of the referencerRule {id} is null", referencerRule.Iid);
                }
                else
                {
                    referencerRule.ModifiedOn = modifiedOnProperty.GetDateTime();
                }
            }

            if (jsonElement.TryGetProperty("name"u8, out var nameProperty))
            {
                if(nameProperty.ValueKind == JsonValueKind.Null)
                {
                    Logger.Debug("The non-nullabale name property of the referencerRule {id} is null", referencerRule.Iid);
                }
                else
                {
                    referencerRule.Name = nameProperty.GetString();
                }
            }

            if (jsonElement.TryGetProperty("referencedCategory"u8, out var referencedCategoryProperty) && referencedCategoryProperty.ValueKind != JsonValueKind.Null)
            {
                foreach(var element in referencedCategoryProperty.EnumerateArray())
                {
                    referencerRule.ReferencedCategory.Add(element.GetGuid());
                }
            }

            if (jsonElement.TryGetProperty("referencingCategory"u8, out var referencingCategoryProperty))
            {
                if(referencingCategoryProperty.ValueKind == JsonValueKind.Null)
                {
                    Logger.Debug("The non-nullabale referencingCategory property of the referencerRule {id} is null", referencerRule.Iid);
                }
                else
                {
                    referencerRule.ReferencingCategory = referencingCategoryProperty.GetGuid();
                }
            }

            if (jsonElement.TryGetProperty("shortName"u8, out var shortNameProperty))
            {
                if(shortNameProperty.ValueKind == JsonValueKind.Null)
                {
                    Logger.Debug("The non-nullabale shortName property of the referencerRule {id} is null", referencerRule.Iid);
                }
                else
                {
                    referencerRule.ShortName = shortNameProperty.GetString();
                }
            }

            if (jsonElement.TryGetProperty("thingPreference"u8, out var thingPreferenceProperty))
            {
                if(thingPreferenceProperty.ValueKind == JsonValueKind.Null)
                {
                    Logger.Debug("The non-nullabale thingPreference property of the referencerRule {id} is null", referencerRule.Iid);
                }
                else
                {
                    referencerRule.ThingPreference = thingPreferenceProperty.GetString();
                }
            }

            return referencerRule;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
