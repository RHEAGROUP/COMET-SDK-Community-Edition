﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NestedElementTestFixture.cs" company="Starion Group S.A.">
//    Copyright (c) 2015-2021 Starion Group S.A.
//
//    Author: Sam Gerené, Merlin Bieze, Alex Vorobiev, Naron Phou, Alexander van Delft, Kamil Wojnowski, 
//            Nathanael Smiechowski, Ahmed Abulwafa Ahmed
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
    using System;
    using System.Collections.Concurrent;
    using System.Linq;

    using CDP4Common.CommonData;
    using CDP4Common.EngineeringModelData;
    using CDP4Common.Helpers;
    using CDP4Common.SiteDirectoryData;
    using CDP4Common.Types;

    using NUnit.Framework;

    [TestFixture]
    internal class NestedElementTestFixture
    {
        private readonly Uri uri = new Uri("http://sdk.cdp4.org");
        private ConcurrentDictionary<CacheKey, Lazy<Thing>> cache;

        private NestedElement nestedElement;

        private ElementUsage elementUsage1;
        private ElementUsage elementUsage2;
        private ElementUsage elementUsage3_1;
        private ElementUsage elementUsage3_2;
        private ElementUsage elementUsage4;
        private ElementDefinition rootElementDef;
        private ElementDefinition elementDef1;
        private ElementDefinition elementDef2;
        private ElementDefinition elementDef3;
        private ElementDefinition elementDef4;
        private DomainOfExpertise domain;
        private DomainOfExpertise domain2;
        private Category category;
        private Option option;
        private Iteration iteration;

        [SetUp]
        public void Setup()
        {
            this.cache = new ConcurrentDictionary<CacheKey, Lazy<Thing>>();

            this.iteration = new Iteration(Guid.NewGuid(), this.cache, this.uri);
            this.option = new Option(Guid.NewGuid(), this.cache, this.uri) { Container = this.iteration };

            this.iteration.Option.Add(this.option);

            this.nestedElement = new NestedElement(Guid.NewGuid(), this.cache, this.uri);
            this.rootElementDef = new ElementDefinition(Guid.NewGuid(), this.cache, this.uri) { Name = "ElementDef", ShortName = "Def", Container = this.iteration };
            this.elementDef1 = new ElementDefinition(Guid.NewGuid(), this.cache, this.uri) { Name = "ElementDef1", ShortName = "Def1", Container = this.iteration };
            this.elementDef2 = new ElementDefinition(Guid.NewGuid(), this.cache, this.uri) { Name = "ElementDef2", ShortName = "Def2", Container = this.iteration };
            this.elementDef3 = new ElementDefinition(Guid.NewGuid(), this.cache, this.uri) { Name = "ElementDef3", ShortName = "Def3", Container = this.iteration };
            this.elementDef4 = new ElementDefinition(Guid.NewGuid(), this.cache, this.uri) { Name = "ElementDef4", ShortName = "Def4", Container = this.iteration };
            this.elementUsage1 = new ElementUsage(Guid.NewGuid(), this.cache, this.uri) { Name = "ElementUsage", ShortName = "Use1", ElementDefinition = this.elementDef1 };
            this.elementUsage2 = new ElementUsage(Guid.NewGuid(), this.cache, this.uri) { Name = "ElementUsage2", ShortName = "Use2", ElementDefinition = this.elementDef2 };
            this.elementUsage3_1 = new ElementUsage(Guid.NewGuid(), this.cache, this.uri) { Name = "ElementUsage3_1", ShortName = "Use3_1", ElementDefinition = this.elementDef3 };
            this.elementUsage3_2 = new ElementUsage(Guid.NewGuid(), this.cache, this.uri) { Name = "ElementUsage3_2", ShortName = "Use3_2", ElementDefinition = this.elementDef3 };
            this.elementUsage4 = new ElementUsage(Guid.NewGuid(), this.cache, this.uri) { Name = "ElementUsage4", ShortName = "Use4", ElementDefinition = this.elementDef4 };

            this.iteration.TopElement = this.rootElementDef;
            this.rootElementDef.ContainedElement.Add(this.elementUsage1);
            this.elementDef1.ContainedElement.Add(this.elementUsage2);
            this.elementDef1.ContainedElement.Add(this.elementUsage3_1);
            this.elementDef1.ContainedElement.Add(this.elementUsage3_2);
            this.elementDef3.ContainedElement.Add(this.elementUsage4);

            this.domain = new DomainOfExpertise(Guid.NewGuid(), this.cache, this.uri);
            this.domain2 = new DomainOfExpertise(Guid.NewGuid(), this.cache, this.uri);

            this.elementUsage1.Owner = this.domain2;
            this.elementUsage2.Owner = this.domain2;
            this.elementUsage2.ElementDefinition = this.elementDef2;
            this.elementUsage3_1.Owner = this.domain2;
            this.elementUsage3_2.Owner = this.domain2;
            this.elementUsage4.Owner = this.domain2;
            this.rootElementDef.Owner = this.domain;

            this.nestedElement.RootElement = this.rootElementDef;
            this.nestedElement.ElementUsage.Add(this.elementUsage1);
            this.nestedElement.ElementUsage.Add(this.elementUsage2);

            this.category = new Category(Guid.NewGuid(), this.cache, this.uri) { Name = "Category", ShortName = "Cat" };

            var lazyCategory = new Lazy<Thing>(() => this.category);
            this.cache.TryAdd(new CacheKey(this.category.Iid, null), lazyCategory);

            var iterationSetup = new IterationSetup(Guid.NewGuid(), this.cache, this.uri);
            this.iteration.IterationSetup = iterationSetup;

            var engineeringModelSetup = new EngineeringModelSetup(Guid.NewGuid(), this.cache, this.uri);
            engineeringModelSetup.IterationSetup.Add(iterationSetup);

            var modelReferenceLibrary = new ModelReferenceDataLibrary(Guid.NewGuid(), this.cache, this.uri);

            modelReferenceLibrary.DefinedCategory.Add(this.category);
            engineeringModelSetup.RequiredRdl.Add(modelReferenceLibrary);
        }

        [Test]
        public void VerifyThatGetNameWorks()
        {
            Assert.That(this.nestedElement.Name, Is.EqualTo("ElementUsage2"));
        }

        [Test]
        public void VerifyThatGetNameWorksWhenNoElementUsages()
        {
            this.nestedElement.ElementUsage.Clear();
            Assert.That(this.nestedElement.Name, Is.EqualTo("ElementDef"));
        }

        [Test]
        public void VerifyShortName()
        {
            Assert.That(this.nestedElement.ShortName, Is.EqualTo("Def.Use1.Use2"));
        }

        [Test]
        public void VerifyGetOwner()
        {
            Assert.That(ReferenceEquals(this.domain2, this.nestedElement.Owner), Is.True);
        }

        [Test]
        public void VerifyGetOwnerWhenNoElementUsages()
        {
            this.nestedElement.ElementUsage.Clear();
            Assert.That(ReferenceEquals(this.domain, this.nestedElement.Owner), Is.True);
        }

        [Test]
        public void VerifyGetElementBase()
        {
            Assert.That(ReferenceEquals(this.elementUsage2, this.nestedElement.GetElementBase()), Is.True);
        }

        [Test]
        public void VerifyGetElementBaseWhenNoElementUsages()
        {
            this.nestedElement.ElementUsage.Clear();
            this.nestedElement.IsRootElement = true;
            Assert.That(ReferenceEquals(this.rootElementDef, this.nestedElement.GetElementBase()), Is.True);
        }

        [Test]
        public void VerifyGetElementDefinition()
        {
            Assert.That(ReferenceEquals(this.elementDef2, this.nestedElement.GetElementDefinition()), Is.True);
        }

        [Test]
        public void VerifyGetElementDefinitionWhenNoElementUsages()
        {
            this.nestedElement.ElementUsage.Clear();
            this.nestedElement.IsRootElement = true;
            Assert.That(ReferenceEquals(this.rootElementDef, this.nestedElement.GetElementDefinition()), Is.True);
        }

        [Test]
        public void VerifyGetElementUsage()
        {
            Assert.That(ReferenceEquals(this.elementUsage2, this.nestedElement.GetElementUsage()), Is.True);
        }

        [Test]
        public void VerifyGetElementUsageWhenNoElementUsages()
        {
            this.nestedElement.ElementUsage.Clear();
            this.nestedElement.IsRootElement = true;
            Assert.That(this.nestedElement.GetElementUsage(), Is.Null);
        }

        [Test]
        public void VerifyHasCategory()
        {
            Assert.That(this.nestedElement.IsMemberOfCategory(this.category), Is.False);
        }

        [Test]
        public void VerifyHasCategoryWorksForElementDefinition()
        {
            this.elementDef2.Category.Add(this.category);
            Assert.That(this.nestedElement.IsMemberOfCategory(this.category), Is.True);
        }

        [Test]
        public void VerifyHasCategoryWorksForElementUsage()
        {
            this.elementUsage2.Category.Add(this.category);
            Assert.That(this.nestedElement.IsMemberOfCategory(this.category), Is.True);
        }

        [Test]
        public void VerifyHasCategoryWorksForRootElementElementDefinition()
        {
            this.nestedElement.ElementUsage.Clear();
            this.nestedElement.IsRootElement = true;
            this.rootElementDef.Category.Add(this.category);
            Assert.That(this.nestedElement.IsMemberOfCategory(this.category), Is.True);
        }

        [Test]
        public void VerifyGetChildrenWorks()
        {
            var nestedElementTreeGenerator = new NestedElementTreeGenerator();
            var nestedElements = nestedElementTreeGenerator.Generate(this.option, this.domain).ToList();
            Assert.That(nestedElements.Count, Is.EqualTo(7));

            var children = nestedElements.First(x => x.IsRootElement).GetChildren(nestedElements).ToList();
            Assert.That(children.Count, Is.EqualTo(1));
            Assert.That(children.First().Name, Is.EqualTo(this.elementUsage1.Name));

            var children2 = children.First().GetChildren(nestedElements).ToList();
            Assert.That(children2.Count, Is.EqualTo(3));
            Assert.That(children2.First().Name, Is.EqualTo(this.elementUsage2.Name));

            var sameInstanceElementUsageNestedElement1 = nestedElements.Single(x => x.ElementUsage.LastOrDefault() == this.elementUsage3_1);
            var sameInstanceElementUsageNestedElement2 = nestedElements.Single(x => x.ElementUsage.LastOrDefault() == this.elementUsage3_2);
            
            Assert.That(sameInstanceElementUsageNestedElement1.GetChildren(nestedElements).Count(), Is.EqualTo(1));
            Assert.That(sameInstanceElementUsageNestedElement2.GetChildren(nestedElements).Count(), Is.EqualTo(1));
        }
    }
}
