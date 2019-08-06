﻿// <copyright file="RuleDefinition.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2019 RHEA System S.A.
//
//    Author: Sam Gerené
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
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace CDP4Rules.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// The <see cref="RuleDefinition"/> class constitutes the root element of a <see cref="RuleDefinition"/> Document.
    /// </summary>
    [Serializable]
    [XmlType(TypeName = "RuleDefinition")]
    [XmlRoot("E-TM-10-25-RULE-DEFINITION")]
    public class RuleDefinition
    {
        /// <summary>
        /// Gets or sets the mandatory Document header, which contains metadata relevant for the <see cref="RuleDefinition"/> Document.
        /// </summary>
        [XmlElement("HEADER")]
        public Header Header { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="List{Rule}"/> contained in the <see cref="RuleDefinition"/> Document.
        /// </summary>
        [XmlArray("RULES")]
        [XmlArrayItem("RULE", typeof(Rule))]
        public List<Rule> Rules { get; set; }
    }
}