﻿//---------------------------------------------------------------------
// <copyright file="EdmReference.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

using System.Collections.Generic;

namespace Microsoft.OData.Edm.Library
{
    /// <summary>
    /// Represents edmx:reference element in CSDL doc.
    /// </summary>
    public class EdmReference : IEdmReference
    {
        private string uri;
        private List<IEdmInclude> includes = new List<IEdmInclude>();
        private List<IEdmIncludeAnnotations> includeAnnotations = new List<IEdmIncludeAnnotations>();

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="uri">The Uri to load referneced model.</param>
        public EdmReference(string uri)
        {
            this.uri = uri;
        }

        /// <summary>
        /// Gets the Uri to load referneced model.
        /// </summary>
        public string Uri
        {
            get
            {
                return this.uri;
            }
        }

        /// <summary>
        /// Gets the Includes for referneced model.
        /// </summary>
        public IEnumerable<IEdmInclude> Includes
        {
            get
            {
                return this.includes;
            }
        }

        /// <summary>
        /// Gets the IncludeAnnotations for referneced model.
        /// </summary>
        public IEnumerable<IEdmIncludeAnnotations> IncludeAnnotations
        {
            get
            {
                return this.includeAnnotations;
            }
        }

        /// <summary>
        /// Add include information.
        /// </summary>
        /// <param name="edmInclude">The IEdmInclude.</param>
        public void AddInclude(IEdmInclude edmInclude)
        {
            this.includes.Add(edmInclude);
        }

        /// <summary>
        /// Add IncludeAnnotations information.
        /// </summary>
        /// <param name="edmIncludeAnnotations">The IEdmIncludeAnnotations.</param>
        public void AddIncludeAnnotations(IEdmIncludeAnnotations edmIncludeAnnotations)
        {
            this.includeAnnotations.Add(edmIncludeAnnotations);
        }
    }
}
