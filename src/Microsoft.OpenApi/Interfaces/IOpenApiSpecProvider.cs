﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.OpenApi.Interfaces
{
    public interface IOpenApiSpecProvider
    {
        OpenApiSpecVersion OpenApiSpec { get; } 
    }
}
