/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes a Reserved Instance offering.</para>
    /// </summary>
    public partial class PricingDetail
    {
        
        private double? price;
        private int? count;


        /// <summary>
        /// The price per instance.
        ///  
        /// </summary>
        public double Price
        {
            get { return this.price ?? default(double); }
            set { this.price = value; }
        }

        // Check to see if Price property is set
        internal bool IsSetPrice()
        {
            return this.price.HasValue;
        }

        /// <summary>
        /// The number of instances available for the price.
        ///  
        /// </summary>
        public int Count
        {
            get { return this.count ?? default(int); }
            set { this.count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this.count.HasValue;
        }
    }
}
