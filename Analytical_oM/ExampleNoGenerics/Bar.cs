﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.oM.Analytical.Elements.NoGen;
using BH.oM.Base;
using BH.oM.Geometry;

namespace BH.oM.Analytical.ExampleNoGenerics
{
    class Bar : BHoMObject, ILink
    {
        public INode EndNode { get; set; }

        public INode StartNode { get; set; }
    }
}
