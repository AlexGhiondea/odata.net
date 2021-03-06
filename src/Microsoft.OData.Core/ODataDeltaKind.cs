﻿//---------------------------------------------------------------------
// <copyright file="ODataDeltaKind.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

namespace Microsoft.OData.Core
{
    /// <summary>
    /// Delta kinds
    /// </summary>
    internal enum ODataDeltaKind
    {
        /// <summary>None delta</summary>
        None,

        /// <summary>Delta feed</summary>
        Feed,

        /// <summary>Delta entry</summary>
        Entry,

        /// <summary>Delta deleted entry</summary>
        DeletedEntry,

        /// <summary>Delta link</summary>
        Link,

        /// <summary>Delta deleted link</summary>
        DeletedLink,
    }
}
