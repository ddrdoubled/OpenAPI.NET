﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. 

using System.Collections.Generic;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Writers;

namespace Microsoft.OpenApi.Models
{
    /// <summary>
    /// Security Requirement Object.
    /// Each name MUST correspond to a security scheme which is declared in
    /// the Security Schemes under the Components Object.
    /// If the security scheme is of type "oauth2" or "openIdConnect",
    /// then the value is a list of scope names required for the execution.
    /// For other security scheme types, the array MUST be empty.
    /// </summary>
    public class OpenApiSecurityRequirement : Dictionary<OpenApiSecurityScheme, IList<string>>, IOpenApiElement
    {
        /// <summary>
        /// Initializes the <see cref="OpenApiSecurityRequirement"/> class.
        /// This constructor ensures that only Reference.Id is considered when two dictionary keys
        /// of type <see cref="OpenApiSecurityScheme"/> are compared.
        /// </summary>
        public OpenApiSecurityRequirement()
            : base(new OpenApiSecuritySchemeReferenceEqualityComparer())
        {
        }

        /// <summary>
        /// Comparer for OpenApiSecurityScheme that only considers the Id in the Reference
        /// (i.e. the string that will actually be displayed in the written document)
        /// </summary>
        private class OpenApiSecuritySchemeReferenceEqualityComparer : IEqualityComparer<OpenApiSecurityScheme>
        {
            /// <summary>
            /// Determines whether the specified objects are equal.
            /// </summary>
            public bool Equals(OpenApiSecurityScheme x, OpenApiSecurityScheme y)
            {
                if (x == null && y == null)
                {
                    return true;
                }

                if (x == null || y == null)
                {
                    return false;
                }

                if (x.Reference == null || y.Reference == null)
                {
                    return false;
                }

                return x.Reference.Id == y.Reference.Id;
            }

            /// <summary>
            /// Returns a hash code for the specified object.
            /// </summary>
            public int GetHashCode(OpenApiSecurityScheme obj)
            {
                return obj?.Reference?.Id == null ? 0 : obj.Reference.Id.GetHashCode();
            }
        }
    }
}
