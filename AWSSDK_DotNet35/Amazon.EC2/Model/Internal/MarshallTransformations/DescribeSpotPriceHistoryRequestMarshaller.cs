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

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Spot Price History Request Marshaller
    /// </summary>       
    public class DescribeSpotPriceHistoryRequestMarshaller : IMarshaller<IRequest, DescribeSpotPriceHistoryRequest>
    {
        public IRequest Marshall(DescribeSpotPriceHistoryRequest describeSpotPriceHistoryRequest)
        {
            IRequest request = new DefaultRequest(describeSpotPriceHistoryRequest, "AmazonEC2");
            request.Parameters.Add("Action", "DescribeSpotPriceHistory");
            request.Parameters.Add("Version", "2014-02-01");
            if (describeSpotPriceHistoryRequest != null && describeSpotPriceHistoryRequest.IsSetStartTime())
            {
                request.Parameters.Add("StartTime", StringUtils.FromDateTime(describeSpotPriceHistoryRequest.StartTime));
            }
            if (describeSpotPriceHistoryRequest != null && describeSpotPriceHistoryRequest.IsSetEndTime())
            {
                request.Parameters.Add("EndTime", StringUtils.FromDateTime(describeSpotPriceHistoryRequest.EndTime));
            }
            if (describeSpotPriceHistoryRequest != null)
            {
                List<string> instanceTypesList = describeSpotPriceHistoryRequest.InstanceTypes;

                int instanceTypesListIndex = 1;
                foreach (string instanceTypesListValue in instanceTypesList)
                { 
                    request.Parameters.Add("InstanceType." + instanceTypesListIndex, StringUtils.FromString(instanceTypesListValue));
                    instanceTypesListIndex++;
                }
            }
            if (describeSpotPriceHistoryRequest != null)
            {
                List<string> productDescriptionsList = describeSpotPriceHistoryRequest.ProductDescriptions;

                int productDescriptionsListIndex = 1;
                foreach (string productDescriptionsListValue in productDescriptionsList)
                { 
                    request.Parameters.Add("ProductDescription." + productDescriptionsListIndex, StringUtils.FromString(productDescriptionsListValue));
                    productDescriptionsListIndex++;
                }
            }

            if (describeSpotPriceHistoryRequest != null)
            {
                List<Filter> filtersList = describeSpotPriceHistoryRequest.Filters;
                int filtersListIndex = 1;
                foreach (Filter filtersListValue in filtersList)
                {
                    if (filtersListValue != null && filtersListValue.IsSetName())
                    {
                        request.Parameters.Add("Filter." + filtersListIndex + ".Name", StringUtils.FromString(filtersListValue.Name));
                    }
                    if (filtersListValue != null)
                    {
                        List<string> valuesList = filtersListValue.Values;

                        int valuesListIndex = 1;
                        foreach (string valuesListValue in valuesList)
                        { 
                            request.Parameters.Add("Filter." + filtersListIndex + ".Value." + valuesListIndex, StringUtils.FromString(valuesListValue));
                            valuesListIndex++;
                        }
                    }

                    filtersListIndex++;
                }
            }
            if (describeSpotPriceHistoryRequest != null && describeSpotPriceHistoryRequest.IsSetAvailabilityZone())
            {
                request.Parameters.Add("AvailabilityZone", StringUtils.FromString(describeSpotPriceHistoryRequest.AvailabilityZone));
            }
            if (describeSpotPriceHistoryRequest != null && describeSpotPriceHistoryRequest.IsSetMaxResults())
            {
                request.Parameters.Add("MaxResults", StringUtils.FromInt(describeSpotPriceHistoryRequest.MaxResults));
            }
            if (describeSpotPriceHistoryRequest != null && describeSpotPriceHistoryRequest.IsSetNextToken())
            {
                request.Parameters.Add("NextToken", StringUtils.FromString(describeSpotPriceHistoryRequest.NextToken));
            }

            return request;
        }
    }
}
