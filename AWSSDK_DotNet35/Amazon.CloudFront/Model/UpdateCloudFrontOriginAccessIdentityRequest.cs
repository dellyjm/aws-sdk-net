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
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCloudFrontOriginAccessIdentity operation.
    /// <para> Update an origin access identity. </para>
    /// </summary>
    public partial class UpdateCloudFrontOriginAccessIdentityRequest : AmazonCloudFrontRequest
    {
        private CloudFrontOriginAccessIdentityConfig cloudFrontOriginAccessIdentityConfig;
        private string id;
        private string ifMatch;


        /// <summary>
        /// The identity's configuration information.
        ///  
        /// </summary>
        public CloudFrontOriginAccessIdentityConfig CloudFrontOriginAccessIdentityConfig
        {
            get { return this.cloudFrontOriginAccessIdentityConfig; }
            set { this.cloudFrontOriginAccessIdentityConfig = value; }
        }

        // Check to see if CloudFrontOriginAccessIdentityConfig property is set
        internal bool IsSetCloudFrontOriginAccessIdentityConfig()
        {
            return this.cloudFrontOriginAccessIdentityConfig != null;
        }

        /// <summary>
        /// The identity's id.
        ///  
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// The value of the ETag header you received when retrieving the identity's configuration. For example: E2QWRUHAPOMQZL.
        ///  
        /// </summary>
        public string IfMatch
        {
            get { return this.ifMatch; }
            set { this.ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this.ifMatch != null;
        }

    }
}
    
