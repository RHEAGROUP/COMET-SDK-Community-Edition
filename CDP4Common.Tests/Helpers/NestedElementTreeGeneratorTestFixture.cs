﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NestedElementTreeGeneratorTestFixtre.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2019 RHEA System S.A.
//
//    Author: Sam Gerené, Merlin Bieze, Alex Vorobiev, Naron Phou
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

namespace CDP4Common.Tests.Helpers
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    using CDP4Common.CommonData;
    using CDP4Common.EngineeringModelData;
    using CDP4Common.Helpers;
    using CDP4Common.SiteDirectoryData;

    using NUnit.Framework;

    /// <summary>
    /// Suite of tests for the <see cref="NestedElementTreeGenerator"/> class.
    /// </summary>
    [TestFixture]
    public class NestedElementTreeGeneratorTestFixture
    {
        public NestedElementTreeGenerator nestedElementTreeGenerator;
        private Uri uri;
        private ConcurrentDictionary<CDP4Common.Types.CacheKey, Lazy<Thing>> cache;
        public Iteration iteration;
        public DomainOfExpertise domainOfExpertise;
        private ElementDefinition elementDefinition_1;
        private ElementDefinition elementDefinition_2;
        private ElementUsage elementUsage_1;
        private ElementUsage elementUsage_2;
        private Option option_A;
        private Option option_B;
        private Parameter parameter;
        private ParameterOverride parameterOverride;

        [SetUp]
        public void SetUp()
        {
            this.nestedElementTreeGenerator = new NestedElementTreeGenerator();
            
            this.uri = new Uri("http://www.rheagroup.com");
            this.cache = new ConcurrentDictionary<CDP4Common.Types.CacheKey, Lazy<Thing>>();

            this.domainOfExpertise = new DomainOfExpertise(Guid.NewGuid(), this.cache, this.uri)
            {
                ShortName = "SYS",
                Name = "System"
            };
            
            this.iteration = new Iteration(Guid.NewGuid(), this.cache, this.uri);

            this.option_A = new Option(Guid.NewGuid(), this.cache, this.uri)
            {
                ShortName = "OPT_A",
                Name = "Option A"
            };
            
            this.option_B = new Option(Guid.NewGuid(), this.cache, this.uri)
            {
                ShortName = "OPT_B",
                Name = "Option B"
            };
            
            this.elementDefinition_1 = new ElementDefinition(Guid.NewGuid(), this.cache, this.uri)
            {
                ShortName = "Sat",
                Name = "Satellite"
            };

            this.elementDefinition_2 = new ElementDefinition(Guid.NewGuid(), this.cache, this.uri)
            {
                ShortName = "Bat",
                Name = "Battery"
            };

            this.elementUsage_1 = new ElementUsage(Guid.NewGuid(), this.cache, this.uri)
            {
                ElementDefinition = this.elementDefinition_2,
                ShortName = "bat_a",
                Name = "battery a"
            };

            this.elementUsage_2 = new ElementUsage(Guid.NewGuid(), this.cache, this.uri)
            {
                ElementDefinition = this.elementDefinition_2,
                ShortName = "bat_b",
                Name = "battery b"                
            };

            var simpleQuantityKind = new SimpleQuantityKind(Guid.NewGuid(), null, null)
            {
                ShortName = "m"
            };
            
            this.parameter = new Parameter(Guid.NewGuid(), this.cache, this.uri)
            {
                Owner = this.domainOfExpertise,
                ParameterType = simpleQuantityKind
            };

            this.parameterOverride = new ParameterOverride(Guid.NewGuid(), this.cache, this.uri)
            {
                Owner = this.domainOfExpertise,
                Parameter = this.parameter
            };

            var parameterValueset_1 = new ParameterValueSet()
            {
                ActualOption = this.option_B,
                Iid = Guid.NewGuid()
            };

            var parameterValueset_2 = new ParameterValueSet()
            {
                ActualOption = this.option_A,
                Iid = Guid.NewGuid()
            };

            var values_1 = new List<string> {"2"};
            var values_2 = new List<string> {"3"};

            var overrideValueset = new ParameterOverrideValueSet()
            {
                ParameterValueSet = parameterValueset_1,
                Iid = Guid.NewGuid()
            };

            this.iteration.Option.Add(this.option_A);
            this.iteration.Option.Add(this.option_B);
            this.iteration.DefaultOption = this.option_A;

            parameterValueset_1.Manual = new CDP4Common.Types.ValueArray<string>(values_1);
            parameterValueset_1.Reference = new CDP4Common.Types.ValueArray<string>(values_1);
            parameterValueset_1.Computed = new CDP4Common.Types.ValueArray<string>(values_1);
            parameterValueset_1.Formula = new CDP4Common.Types.ValueArray<string>(values_1);
            parameterValueset_1.ValueSwitch = ParameterSwitchKind.MANUAL;

            parameterValueset_2.Manual = new CDP4Common.Types.ValueArray<string>(values_2);
            parameterValueset_2.Reference = new CDP4Common.Types.ValueArray<string>(values_2);
            parameterValueset_2.Computed = new CDP4Common.Types.ValueArray<string>(values_2);
            parameterValueset_2.Formula = new CDP4Common.Types.ValueArray<string>(values_2);
            parameterValueset_2.ValueSwitch = ParameterSwitchKind.MANUAL;

            overrideValueset.Manual = new CDP4Common.Types.ValueArray<string>(values_1);
            overrideValueset.Reference = new CDP4Common.Types.ValueArray<string>(values_1);
            overrideValueset.Computed = new CDP4Common.Types.ValueArray<string>(values_1);
            overrideValueset.Formula = new CDP4Common.Types.ValueArray<string>(values_1);
            overrideValueset.ValueSwitch = ParameterSwitchKind.MANUAL;

            this.parameter.ValueSet.Add(parameterValueset_1);
            this.parameter.ValueSet.Add(parameterValueset_2);
            this.parameterOverride.ValueSet.Add(overrideValueset);

            this.elementUsage_1.ExcludeOption.Add(this.option_A);
            this.elementUsage_1.ParameterOverride.Add(this.parameterOverride);

            this.elementDefinition_1.Parameter.Add(this.parameter);
            this.elementDefinition_1.ContainedElement.Add(this.elementUsage_1);
            this.elementDefinition_1.ContainedElement.Add(this.elementUsage_2);
            this.elementDefinition_2.Parameter.Add(this.parameter);

            this.iteration.Element.Add(this.elementDefinition_1);
            this.iteration.Element.Add(this.elementDefinition_2);
            this.iteration.TopElement = this.elementDefinition_1;
        }

        [Test]
        public void Verify_that_null_arguments_throws_exception()
        {
            var option = this.iteration.Option.First();

            Assert.Throws<ArgumentNullException>(() => this.nestedElementTreeGenerator.Generate(null, null));

            Assert.Throws<ArgumentNullException>(() => this.nestedElementTreeGenerator.Generate(option, null));

            Assert.Throws<ArgumentNullException>(() => this.nestedElementTreeGenerator.GetNestedParameters(option, null));

            Assert.Throws<ArgumentNullException>(() => this.nestedElementTreeGenerator.GetNestedParameters(null, null));

            Assert.Throws<ArgumentNullException>(() => this.nestedElementTreeGenerator.GetNestedParameters(null, this.domainOfExpertise));
        }

        [Test]
        public void Verify_that_excluded_usage_option_a_does_not_get_generated_as_nested_element()
        {
            var option = this.iteration.Option.Single(x => x.ShortName == "OPT_A");
            
            var nestedElements = this.nestedElementTreeGenerator.Generate(option, this.domainOfExpertise);

            foreach (var nestedElement in nestedElements)
            {
                Console.WriteLine(nestedElement.ShortName);
            }

            Assert.AreEqual(2, nestedElements.Count());
        }

        [Test]
        public void Verify_that_excluded_usage_option_a_does_not_get_generated_as_nested_element_if_option_is_a_cloned_object()
        {
            var option = this.iteration.Option.Single(x => x.ShortName == "OPT_A");
            var optionClone = option.Clone(false);

            var nestedElements = this.nestedElementTreeGenerator.Generate(optionClone, this.domainOfExpertise);

            foreach (var nestedElement in nestedElements)
            {
                Console.WriteLine(nestedElement.ShortName);
            }

            Assert.AreEqual(2, nestedElements.Count());
        }

        [Test]
        public void Verify_that_excluded_usage_from_a_In_option_b_get_generated_as_nested_element()
        {
            var option = this.iteration.Option.Single(x => x.ShortName == "OPT_B");

            var nestedElements = this.nestedElementTreeGenerator.Generate(option, this.domainOfExpertise);

            foreach (var nestedElement in nestedElements)
            {
                Console.WriteLine(nestedElement.ShortName);
            }

            Assert.AreEqual(3, nestedElements.Count());
        }

        [Test]
        public void Verify_that_the_function_returns_values()
        {
            var option = this.iteration.Option.Single(x => x.ShortName == "OPT_A");
            var flatNestedParameters = this.nestedElementTreeGenerator.GetNestedParameters(option, this.domainOfExpertise);

            Assert.IsNotEmpty(flatNestedParameters);
        }

        [Test]
        public void Verify_that_Path_returns_value_for_Each_NestedElement_and_NestedParameter()
        {
            var option = this.iteration.Option.Single(x => x.ShortName == "OPT_A");
            var flatNestedParameters = this.nestedElementTreeGenerator.GetNestedParameters(option, this.domainOfExpertise);

            foreach (var nestedParameter in flatNestedParameters)
            {
                Assert.DoesNotThrow(() =>
                {
                    var path = nestedParameter.Path;
                });   
            }
        }

        [Test]
        public void Verify_that_Option_is_set_on_NestedElement_and_NestedParameter()
        {
            var option = this.iteration.Option.Single(x => x.ShortName == "OPT_A");

            var nestedElements = this.nestedElementTreeGenerator.Generate(option, this.domainOfExpertise);

            foreach (var nestedElement in nestedElements)
            {
                Assert.AreEqual(option, nestedElement.Container);

                foreach (var nestedParameter in nestedElement.NestedParameter)
                {
                    Assert.AreEqual(option, nestedParameter.Option);
                }
            }
        }

        [Test]
        public void Verify_that_ValueSet_is_set_on_NestedElement_and_NestedParameter()
        {
            var option = this.iteration.Option.Single(x => x.ShortName == "OPT_A");

            var NestedParameters = this.nestedElementTreeGenerator.GetNestedParameters(option, this.domainOfExpertise, false);

            foreach (var nestedParameter in NestedParameters)
            {
                Assert.IsNotNull(nestedParameter.ValueSet);
            }
        }

        [Test]
        public void VerifyThatGetNestedElementShortNameWorksForElementDefinition()
        {
            Assert.AreEqual("Sat", this.nestedElementTreeGenerator.GetNestedElementShortName(this.elementDefinition_1, this.option_A, this.domainOfExpertise));
            Assert.AreEqual(null, this.nestedElementTreeGenerator.GetNestedElementShortName(this.elementDefinition_2, this.option_A, this.domainOfExpertise));
            Assert.AreEqual("Sat", this.nestedElementTreeGenerator.GetNestedElementShortName(this.elementDefinition_1, this.option_B, this.domainOfExpertise));
            Assert.AreEqual(null, this.nestedElementTreeGenerator.GetNestedElementShortName(this.elementDefinition_2, this.option_B, this.domainOfExpertise));
        }

        [Test]
        public void VerifyThatGetNestedElementShortNameWorksForElementUsage()
        {
            Assert.AreEqual(null, this.nestedElementTreeGenerator.GetNestedElementShortName(this.elementUsage_1, this.option_A, this.domainOfExpertise));
            Assert.AreEqual("Sat.bat_b", this.nestedElementTreeGenerator.GetNestedElementShortName(this.elementUsage_2, this.option_A, this.domainOfExpertise));
            Assert.AreEqual("Sat.bat_a", this.nestedElementTreeGenerator.GetNestedElementShortName(this.elementUsage_1, this.option_B, this.domainOfExpertise));
            Assert.AreEqual("Sat.bat_b", this.nestedElementTreeGenerator.GetNestedElementShortName(this.elementUsage_2, this.option_B, this.domainOfExpertise));
        }

        [Test]
        public void VerifyThatGetNestedParameterPathWorks()
        {
            Assert.AreEqual("Sat\\m\\\\OPT_A", this.nestedElementTreeGenerator.GetNestedParameterPath(this.parameter, this.option_A, this.domainOfExpertise));
            Assert.AreEqual("Sat\\m\\\\OPT_A", this.nestedElementTreeGenerator.GetNestedParameterPath(this.parameterOverride, this.option_A, this.domainOfExpertise));
            Assert.AreEqual("Sat\\m\\\\OPT_B", this.nestedElementTreeGenerator.GetNestedParameterPath(this.parameter, this.option_B, this.domainOfExpertise));
            Assert.AreEqual("Sat\\m\\\\OPT_B", this.nestedElementTreeGenerator.GetNestedParameterPath(this.parameterOverride, this.option_B, this.domainOfExpertise));
        }
    }
}