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

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Enable Logging Request Marshaller
    /// </summary>       
    public class EnableLoggingRequestMarshaller : IMarshaller<IRequest, EnableLoggingRequest>
    {
        public IRequest Marshall(EnableLoggingRequest enableLoggingRequest)
        {
            IRequest request = new DefaultRequest(enableLoggingRequest, "AmazonRedshift");
            request.Parameters.Add("Action", "EnableLogging");
            request.Parameters.Add("Version", "2012-12-01");
            if (enableLoggingRequest != null && enableLoggingRequest.IsSetClusterIdentifier())
            {
                request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(enableLoggingRequest.ClusterIdentifier));
            }
            if (enableLoggingRequest != null && enableLoggingRequest.IsSetBucketName())
            {
                request.Parameters.Add("BucketName", StringUtils.FromString(enableLoggingRequest.BucketName));
            }
            if (enableLoggingRequest != null && enableLoggingRequest.IsSetS3KeyPrefix())
            {
                request.Parameters.Add("S3KeyPrefix", StringUtils.FromString(enableLoggingRequest.S3KeyPrefix));
            }

            return request;
        }
    }
}
