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
using Amazon.Runtime;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>The result of an <c>UpdateServiceAccessPolicies</c> request. Contains the new access policies.</para>
    /// </summary>
    public partial class UpdateServiceAccessPoliciesResult : AmazonWebServiceResponse
    {
        
        private AccessPoliciesStatus accessPolicies;


        /// <summary>
        /// The access rules configured for the domain.
        ///  
        /// </summary>
        public AccessPoliciesStatus AccessPolicies
        {
            get { return this.accessPolicies; }
            set { this.accessPolicies = value; }
        }

        // Check to see if AccessPolicies property is set
        internal bool IsSetAccessPolicies()
        {
            return this.accessPolicies != null;
        }
    }
}
