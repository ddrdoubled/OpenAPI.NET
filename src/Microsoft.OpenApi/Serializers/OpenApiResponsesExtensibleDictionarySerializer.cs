﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;

namespace Microsoft.OpenApi.Serializers
{
    public class OpenApiResponsesExtensibleDictionarySerializer : OpenApiExtensibleDictionarySerializer<OpenApiResponses, OpenApiResponse>
    {
        public OpenApiResponsesExtensibleDictionarySerializer(IOpenApiElementSerializer<OpenApiResponse> elementSerializer, IOpenApiSpecProvider specProvider) 
            : base(elementSerializer, specProvider)
        {
        }
    }
}