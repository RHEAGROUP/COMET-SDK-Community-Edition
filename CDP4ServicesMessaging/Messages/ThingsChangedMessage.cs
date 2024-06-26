﻿// -------------------------------------------------------------------------------------------------------------------------------
// <copyright file="ThingsChangedMessage.cs" company="Starion Group S.A.">
//    Copyright (c) 2015-2023 Starion Group S.A.
//
//    Author: Sam Gerené, Alex Vorobiev, Alexander van Delft, Antoine Théate, Nathanael Smiechowski
//
//    This file is part of COMET-SDK Community Edition
//
//    The CDP4-COMET-SDK Community Edition is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 3 of the License, or (at your option) any later version.
//
//    The CDP4-COMET-SDK Community Edition is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public License
//    along with this program; if not, write to the Free Software Foundation,
//    Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
// </copyright>
// -------------------------------------------------------------------------------------------------------------------------------


namespace CDP4ServicesMessaging.Messages
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using CDP4Common.DTO;

    /// <summary>
    /// The <see cref="ThingsChangedMessage"/> carries a collection of <see cref="Thing"/>s that have changed
    /// </summary>
    public class ThingsChangedMessage
    {
        /// <summary>
        /// Gets or sets the collection of <see cref="Thing"/>s that have been added.
        /// </summary>
        /// <value>The collection of changed <see cref="Thing"/>s.</value>
        public List<Thing> ChangedThings { get; set; } = new ();

        /// <summary>
        /// Gets or sets the orignal post operation as json <see cref="Stream"/>.
        /// </summary>
        /// <value>The collection of changed <see cref="Thing"/>s.</value>
        public string PostOperation { get; set; }
        
        /// <summary>
        /// Gets or sets the time stamp of the transaction that originates this message
        /// </summary>
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// Gets or sets the actor Id the unique identifier of the person who posted the things
        /// </summary>
        public Guid ActorId { get; set; }
    }
}
