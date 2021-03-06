/*
Copyright 2018 TE Connectivity

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
-------------------------------------------------------------------------
*/
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.PressInsertion
{
    /// <summary>
    /// Force parameters specific to a press fit connector
    /// </summary>
    public class ConnectorForces
    {

        /// <summary>
        /// The maximum force
        /// </summary>
        public double MaximumForce
        {
            get;
            set;
        }//MaxForce

        /// <summary>
        /// The minimum force
        /// </summary>
        public double MinimumForce
        {
            get;
            set;
        }//MinimumForce


        /// <summary>
        /// Other (external) force
        /// </summary>
        public double OtherForce
        {
            get;
            set;
        }//OtherForce

        /// <summary>
        /// User Defined Force
        /// </summary>
        public double UserDefinedForce
        {
            get;
            set;
        }//UserDefinedForce

    }//Force
}
