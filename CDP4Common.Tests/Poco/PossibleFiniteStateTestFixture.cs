﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PossibleFiniteStateTestFixture.cs" company="Starion Group S.A.">
//    Copyright (c) 2015-2024 Starion Group S.A.
//
//    Author: Sam Gerené, Merlin Bieze, Alex Vorobiev, Naron Phou
//
//    This file is part of CDP4-COMET-SDK Community Edition
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
// --------------------------------------------------------------------------------------------------------------------

namespace CDP4Common.Tests.Poco
{
    using CDP4Common.EngineeringModelData;
    using CDP4Common.Exceptions;
    using CDP4Common.SiteDirectoryData;

    using NUnit.Framework;
    
    [TestFixture]
    internal class PossibleFiniteStateTestFixture
    {
        [Test]
        public void TestGetOwner()
        {
            var thing = new PossibleFiniteState();
            var list = new PossibleFiniteStateList();
            list.Owner = new DomainOfExpertise();
            list.PossibleState.Add(thing);

            Assert.That(ReferenceEquals(list.Owner, thing.Owner), Is.True);
        }

        [Test]
        public void TestGetOwnerThrowEx()
        {
            var thing = new PossibleFiniteState();
            Assert.Throws<ContainmentException>(() =>
            {
                var d = thing.Owner;
            });
        }

        [Test]
        public void VerifyIsDefault()
        {
            var thing = new PossibleFiniteState();
            var list = new PossibleFiniteStateList();
            
            list.PossibleState.Add(thing);
            Assert.That(thing.IsDefault, Is.False);

            list.DefaultState = thing;
            Assert.That(thing.IsDefault, Is.True);
        }
    }
}