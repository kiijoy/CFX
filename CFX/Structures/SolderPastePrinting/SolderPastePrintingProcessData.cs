﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using CFX;
using CFX.Structures;

namespace CFX.Structures.SolderPastePrinting
{
    /// <summary>
    /// Describes the Solder paster printing ProcessData structure 
    /// </summary>
    [JsonObject(ItemTypeNameHandling = TypeNameHandling.Auto)]
    public class SolderPastePrintingProcessData
    {
        public SolderPastePrintingProcessData()
        {

        }
        /// <summary>
        /// List of Stroke objects for Solder Paste Printing
        /// </summary>
        public List<Stroke> Strokes { get; set; }
        /// <summary>
        /// Print gap value 
        /// </summary>
        public double? Print_Gap { get; set; }
        /// <summary>
        /// Separation object 
        /// </summary>
        public Separation Separation { get; set; }
        /// <summary>
        /// Periodic cleaning object List. Normally it shall be one, but in this way it may be extended more easily 
        /// </summary>
        public List<PeriodicCleaning> PeriodicCleaning { get; set; }
    }
}