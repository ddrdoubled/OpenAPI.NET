﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. 

using System;
using System.Collections.Generic;
using Microsoft.OpenApi.Interfaces;

namespace Microsoft.OpenApi.Models
{
    /// <summary>
    /// Contact Object.
    /// </summary>
    public class OpenApiContact : IOpenApiExtensible
    {
        /// <summary>
        /// The identifying name of the contact person/organization.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The URL pointing to the contact information. MUST be in the format of a URL.
        /// </summary>
        public Uri Url { get; set; }

        /// <summary>
        /// The email address of the contact person/organization.
        /// MUST be in the format of an email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// This object MAY be extended with Specification Extensions.
        /// </summary>
        public IDictionary<string, IOpenApiExtension> Extensions { get; set; } = new Dictionary<string, IOpenApiExtension>();
    }
}
