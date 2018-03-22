﻿using System;
using System.Collections.Generic;
using System.Text;
using CFX.Structures;

namespace CFX.Production
{
    /// <summary>
    /// Sent to a process endpoint to block or disable a particular material setup location. 
    /// This is typically used where a loaded material may become unsuitable for use, 
    /// for example MSD expiry of an SMT material.
    /// </summary>
    public class BlockMaterialLocationsRequest : CFXMessage
    {
        public BlockMaterialLocationsRequest()
        {
            Locations = new List<MaterialLocation>();
        }

        /// <summary>
        /// A list of locations to be blocked
        /// </summary>
        public List<MaterialLocation> Locations
        {
            get;
            set;
        }
    }
}
