/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;
using System.Collections.Generic;
using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for UploadSigningCertificate operation
    /// </summary>
    internal class UploadSigningCertificateResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            UploadSigningCertificateResponse response = new UploadSigningCertificateResponse();
            
            while (context.Read())
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("UploadSigningCertificateResult", 2))
                    {
                        UnmarshallResult(context,response);                        
                        continue;
                    }
                    
                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.GetInstance().Unmarshall(context);
                    }
                }
            }
                 
                        
            return response;
        }
        
        private static void UnmarshallResult(XmlUnmarshallerContext context,UploadSigningCertificateResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Certificate", targetDepth))
                    {
                        response.Certificate = SigningCertificateUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }
                            


            return;
        }
        
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            
            if (errorResponse.Code != null && errorResponse.Code.Equals("DuplicateCertificate"))
            {
                return new DuplicateCertificateException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidCertificate"))
            {
                return new InvalidCertificateException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("MalformedCertificate"))
            {
                return new MalformedCertificateException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchEntity"))
            {
                return new NoSuchEntityException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("LimitExceeded"))
            {
                return new LimitExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            if (errorResponse.Code != null && errorResponse.Code.Equals("EntityAlreadyExists"))
            {
                return new EntityAlreadyExistsException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
    
            return new AmazonIdentityManagementServiceException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static UploadSigningCertificateResponseUnmarshaller instance;

        public static UploadSigningCertificateResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new UploadSigningCertificateResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
