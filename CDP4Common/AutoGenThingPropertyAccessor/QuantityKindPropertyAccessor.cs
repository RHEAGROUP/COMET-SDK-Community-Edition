// ------------------------------------------------------------------------------------------------
// <copyright file="QuantityKindPropertyAccessor.cs" company="RHEA System S.A.">
//    Copyright (c) 2015-2023 RHEA System S.A.
//
//    Author: Sam Gerené, Alex Vorobiev, Alexander van Delft, Nathanael Smiechowski, 
//            Antoine Théate, Omar Elabiary, Jaime Bernar
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
// ------------------------------------------------------------------------------------------------

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace CDP4Common.SiteDirectoryData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using CDP4Common.CommonData;
    using CDP4Common.DiagramData;
    using CDP4Common.EngineeringModelData;
    using CDP4Common.PropertyAccesor;
    using CDP4Common.ReportingData;
    using CDP4Common.SiteDirectoryData;

    /// <summary>
    /// Generated methods that support the QueryValue logic
    /// </summary>
    public partial class QuantityKind
    {
        /// <summary>
        /// Queries the value(s) of the specified property
        /// </summary>
        /// <param name="path">
        /// The path of the property for which the value is to be queried
        /// </param>
        /// <returns>
        /// an object that represents the value.
        /// </returns>
        /// <remarks>
        /// An object, which is either an instance or List of <see cref="Thing"/>
        /// or an bool, int, string or List thereof
        /// </remarks>
        public override object QueryValue(string path)
        {
            var pd = PropertyDescriptor.QueryPropertyDescriptor(path);

            var propertyName = pd.Name.ToLower();

            switch (propertyName)
            {
                case "iid":
                    return base.QueryThingValues(pd.Input);
                case "revisionnumber":
                    return base.QueryThingValues(pd.Input);
                case "classkind":
                    return base.QueryThingValues(pd.Input);
                case "excludeddomain":
                    return base.QueryThingValues(pd.Input);
                case "excludedperson":
                    return base.QueryThingValues(pd.Input);
                case "modifiedon":
                    return base.QueryThingValues(pd.Input);
                case "thingpreference":
                    return base.QueryThingValues(pd.Input);
                case "actor":
                    return base.QueryThingValues(pd.Input);
                case "alias":
                    return base.QueryValue(pd.Input);
                case "allpossiblescale":
                    pd.VerifyPropertyDescriptorForEnumerableReferenceProperty();

                    var allPossibleScaleUpperBound = pd.Upper.Value;

                    if (pd.Lower.Value == 0 && allPossibleScaleUpperBound == int.MaxValue && !this.AllPossibleScale.Any())
                    {
                        if (pd.Next == null)
                        {
                            return new List<MeasurementScale>();
                        }

                        var sentinelMeasurementScale = new IntervalScale(Guid.Empty, null, null);

                        return sentinelMeasurementScale.QuerySentinelValue(pd.NextPath, true);
                    }

                    if (pd.Upper.Value == int.MaxValue)
                    {
                        allPossibleScaleUpperBound = this.AllPossibleScale.Count - 1;
                    }

                    if (this.AllPossibleScale.Count - 1 < pd.Lower.Value)
                    {
                        throw new IndexOutOfRangeException($"Invalid Multiplicity for AllPossibleScale property, the lower bound {pd.Lower.Value} is higher than the max index of this list.");
                    }

                    if (this.AllPossibleScale.Count - 1 < allPossibleScaleUpperBound)
                    {
                        throw new IndexOutOfRangeException($"Invalid Multiplicity for the AllPossibleScale property, the upper bound {pd.Upper.Value} is higher than the max index of this list.");
                    }

                    if (pd.Lower.Value == pd.Upper.Value)
                    {
                        if (pd.Next == null)
                        {
                            return this.AllPossibleScale[pd.Lower.Value];
                        }

                        return this.AllPossibleScale[pd.Lower.Value].QueryValue(pd.NextPath);
                    }

                    if (pd.Next == null)
                    {
                        var allPossibleScaleObjects = new List<MeasurementScale>();

                        for (var i = pd.Lower.Value; i < allPossibleScaleUpperBound + 1; i++)
                        {
                            allPossibleScaleObjects.Add(this.AllPossibleScale[i]);
                        }

                        return allPossibleScaleObjects;
                    }

                    var allPossibleScaleNextObjects = new List<object>();

                    for (var i = pd.Lower.Value; i < allPossibleScaleUpperBound + 1; i++)
                    {
                        var queryResult = this.AllPossibleScale[i].QueryValue(pd.Next.Input);

                        if (queryResult is IEnumerable<object> queriedValues)
                        {
                            foreach (var queriedValue in queriedValues)
                            {
                                if (queriedValue != null)
                                {
                                    allPossibleScaleNextObjects.Add(queriedValue);
                                }
                            }
                        }
                        else
                        {
                            if (queryResult != null)
                            {
                                allPossibleScaleNextObjects.Add(queryResult);
                            }
                        }
                    }

                    return allPossibleScaleNextObjects;
                case "category":
                    return base.QueryValue(pd.Input);
                case "defaultscale":
                    pd.VerifyPropertyDescriptorForReferenceProperty();

                    if (pd.Next == null)
                    {
                        return this.DefaultScale;
                    }

                    if (this.DefaultScale != null)
                    {
                        return this.DefaultScale.QueryValue(pd.Next.Input);
                    }

                    var sentineldefaultscale = new IntervalScale(Guid.Empty, null, null);
                    return sentineldefaultscale.QuerySentinelValue(pd.Next.Input, false);
                case "definition":
                    return base.QueryValue(pd.Input);
                case "hyperlink":
                    return base.QueryValue(pd.Input);
                case "isdeprecated":
                    return base.QueryValue(pd.Input);
                case "name":
                    return base.QueryValue(pd.Input);
                case "numberofvalues":
                    return base.QueryValue(pd.Input);
                case "possiblescale":
                    pd.VerifyPropertyDescriptorForEnumerableReferenceProperty();

                    var possibleScaleUpperBound = pd.Upper.Value;

                    if (pd.Lower.Value == 0 && possibleScaleUpperBound == int.MaxValue && !this.PossibleScale.Any())
                    {
                        if (pd.Next == null)
                        {
                            return new List<MeasurementScale>();
                        }

                        var sentinelMeasurementScale = new IntervalScale(Guid.Empty, null, null);

                        return sentinelMeasurementScale.QuerySentinelValue(pd.NextPath, true);
                    }

                    if (pd.Upper.Value == int.MaxValue)
                    {
                        possibleScaleUpperBound = this.PossibleScale.Count - 1;
                    }

                    if (this.PossibleScale.Count - 1 < pd.Lower.Value)
                    {
                        throw new IndexOutOfRangeException($"Invalid Multiplicity for PossibleScale property, the lower bound {pd.Lower.Value} is higher than the max index of this list.");
                    }

                    if (this.PossibleScale.Count - 1 < possibleScaleUpperBound)
                    {
                        throw new IndexOutOfRangeException($"Invalid Multiplicity for the PossibleScale property, the upper bound {pd.Upper.Value} is higher than the max index of this list.");
                    }

                    if (pd.Lower.Value == pd.Upper.Value)
                    {
                        if (pd.Next == null)
                        {
                            return this.PossibleScale[pd.Lower.Value];
                        }

                        return this.PossibleScale[pd.Lower.Value].QueryValue(pd.NextPath);
                    }

                    if (pd.Next == null)
                    {
                        var possibleScaleObjects = new List<MeasurementScale>();

                        for (var i = pd.Lower.Value; i < possibleScaleUpperBound + 1; i++)
                        {
                            possibleScaleObjects.Add(this.PossibleScale[i]);
                        }

                        return possibleScaleObjects;
                    }

                    var possibleScaleNextObjects = new List<object>();

                    for (var i = pd.Lower.Value; i < possibleScaleUpperBound + 1; i++)
                    {
                        var queryResult = this.PossibleScale[i].QueryValue(pd.Next.Input);

                        if (queryResult is IEnumerable<object> queriedValues)
                        {
                            foreach (var queriedValue in queriedValues)
                            {
                                if (queriedValue != null)
                                {
                                    possibleScaleNextObjects.Add(queriedValue);
                                }
                            }
                        }
                        else
                        {
                            if (queryResult != null)
                            {
                                possibleScaleNextObjects.Add(queryResult);
                            }
                        }
                    }

                    return possibleScaleNextObjects;
                case "quantitydimensionexponent":
                    if (!pd.Lower.HasValue || !pd.Upper.HasValue)
                    {
                        throw new Exception("Invalid Multiplicity for the QuantityDimensionExponent property, the lower and upper bound must be specified");
                    }

                    if (pd.Lower.Value == 0 && pd.Upper.Value == int.MaxValue && !this.QuantityDimensionExponent.Any())
                    {
                        return new List<string>();
                    }

                    if (pd.Upper.Value == int.MaxValue)
                    {
                        pd.Upper = this.QuantityDimensionExponent.Count - 1;
                    }

                    if (this.QuantityDimensionExponent.Count - 1 < pd.Lower.Value)
                    {
                        throw new IndexOutOfRangeException($"Invalid Multiplicity for the QuantityDimensionExponent property, the lower bound {pd.Upper.Value} is higher than the max index of this list.");
                    }

                    if (this.QuantityDimensionExponent.Count - 1 < pd.Upper.Value)
                    {
                        throw new IndexOutOfRangeException($"Invalid Multiplicity for the QuantityDimensionExponent property, the upper bound {pd.Upper.Value} is higher than the max index of this list.");
                    }

                    if (pd.Lower.Value == pd.Upper.Value)
                    {
                        return this.QuantityDimensionExponent[pd.Lower.Value];
                    }

                    var quantityDimensionExponentobjects = new List<string>();

                    for (var i = pd.Lower.Value; i < pd.Upper.Value + 1; i++)
                    {
                        quantityDimensionExponentobjects.Add(this.QuantityDimensionExponent[i]);
                    }

                    return quantityDimensionExponentobjects;
                case "quantitydimensionexpression":
                    pd.VerifyPropertyDescriptorForValueProperty();
                    return this.QuantityDimensionExpression;
                case "quantitydimensionsymbol":
                    pd.VerifyPropertyDescriptorForValueProperty();
                    return this.QuantityDimensionSymbol;
                case "shortname":
                    return base.QueryValue(pd.Input);
                case "symbol":
                    return base.QueryValue(pd.Input);
                default:
                    throw new ArgumentException($"The path:{path} does not exist on {this.ClassKind}");
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
