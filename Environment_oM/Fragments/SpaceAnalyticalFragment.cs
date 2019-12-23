﻿/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2019, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BH.oM.Base;
using System.ComponentModel;

namespace BH.oM.Environment.Fragments
{
    [Description("Fragment containing the space analytical property related to spaces")]
    public class SpaceAnalyticalFragment : IBHoMFragment
    {
        [Description("The amount of internal domestic hot water supply for the space")]
        public double InternalDomesticHotWater { get; set; } = 0;

        [Description("The daylight factor for the space")]
        public double DaylightFactor { get; set; } = 0;

        [Description("The length of the facade on the space")]
        public double FacadeLength { get; set; } = 0;

        [Description("The fixed convection coefficient of the space")]
        public double FixedConvectionCoefficient { get; set; } = 0;

        [Description("The cooling size method of the space from the Sizing Method enum")]
        public SizingMethod SizeCoolingMethod { get; set; } = SizingMethod.Sizing;

        [Description("The heating size method of the space from the Sizing Method enum")]
        public SizingMethod SizeHeatingMethod { get; set; } = SizingMethod.Sizing;

        [Description("The radiant proportion of the space")]
        public double RadiantProportion { get; set; } = 0;
    }
}