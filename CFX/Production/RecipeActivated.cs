﻿using System;
using System.Collections.Generic;
using System.Text;
using CFX.Structures;
using Newtonsoft.Json;

namespace CFX.Production
{
    /// <summary>
    /// Sent by a process endpoint to indicate the activation of a recipe by its name
    /// <code language="none">
    /// {
    ///   "RecipeName": "RECIPE3234",
    ///   "Revision": "B",
    ///   "Lane": 1,
    ///   "Stage": null,
    ///   "ExpectedCycleTime": 60,
    ///   "ExpectedUnitsPerWorkTransaction": 1,
    ///   "NumberOfComponentsPerUnit": 500,
    ///   "RecipeStagesInformation”: [
    ///   {
    ///     "Stage": {
    ///       "StageSequence": 1,
    ///       "StageName": "STAGE1",
    ///       "StageType": "Work"
    ///     }
    ///     "ExpectedCycleTime": 80,
    ///     "NumberOfComponentsPerUnit": 200
    ///   },
    ///   {
    ///     "Stage": {
    ///       "StageSequence": 2,
    ///       "StageName": "STAGE2",
    ///       "StageType": "Work"
    ///     }
    ///     "ExpectedCycleTime": 120,
    ///     "NumberOfComponentsPerUnit": 250
    ///   }
    ///   ]
    /// }
    /// </code>
    /// </summary>
    public class RecipeActivated : CFXMessage
    {
        public RecipeActivated()
        {
            RecipeStagesInformation = new List<RecipeStageInformation>();
        }

        /// <summary>
        /// THe name of the recipe (may include full path, if applicable)
        /// </summary>
        public string RecipeName
        {
            get;
            set;
        }

        /// <summary>
        /// Version number, e.g. “2.0” (Optional)
        /// </summary>
        public string Revision
        {
            get;
            set;
        }

        /// <summary>
        /// Number of the production lane (if applicable)
        /// </summary>
        public int? Lane
        {
            get;
            set;
        }

        /// <summary>
        /// An optional stage
        /// </summary>
        public Stage Stage
        {
            get;
            set;
        }

        /// <summary>
        /// The total amount of time that is expected to process one unit or group of units (as in the case of a carrier or panelized PCB), 
        /// assuming no blocked or starved conditions at the station.  This includes both productive and non-productive time, such as transfer, 
        /// positioning, etc.
        /// </summary>
        public double ExpectedCycleTime
        {
            get;
            set;
        }

        /// <summary>
        /// The number of units that are to be processed simulataneously by this recipe.  For example, in the case of a 2 x 2 panelized PCB, this
        /// property would be 4 because 4 units (PCBs) are procesed at one time per work transaction.  In the case that a station processes a
        /// variable number of units per transaction, this should represent the average number of units expected to be processed per transaction.
        /// </summary>
        public double ExpectedUnitsPerWorkTransaction
        {
            get;
            set;
        }

        /// <summary>
        /// The number of components to install for each unit of a work.
        /// </summary>
        public double NumberOfComponentsPerUnit
        {
            get;
            set;
        }

        /// <summary>
        /// <para>** NOTE: ADDED in CFX 1.2 **</para>
        /// An optional list of information about the recipe for each stage of the machine
        /// </summary>
        [JsonProperty(ItemTypeNameHandling = TypeNameHandling.Auto)]
        [CFX.Utilities.CreatedVersion("1.2")]
        public List<RecipeStageInformation> RecipeStagesInformation
        {
            get;
            set;
        }
    }
}
