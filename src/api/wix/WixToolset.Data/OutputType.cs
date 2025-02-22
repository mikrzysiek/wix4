// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Data
{
    using System;

    /// <summary>
    /// Various types of output.
    /// </summary>
    public enum OutputType
    {
        /// <summary>Unknown output type.</summary>
        Unknown,

        /// <summary>Bundle output type.</summary>
        Bundle,

        /// <summary>Library output type.</summary>
        Library,

        /// <summary>Module output type.</summary>
        Module,

        /// <summary>Patch output type.</summary>
        Patch,

        /// <summary>Patch Creation output type.</summary>
        PatchCreation,

        /// <summary>Package output type.</summary>
        Package,

        /// <summary>Package output type.</summary>
        [Obsolete]
        Product = Package,

        /// <summary>Transform output type.</summary>
        Transform,

        /// <summary>Intermediate representation post-link output type.</summary>
        IntermediatePostLink,
    }
}
