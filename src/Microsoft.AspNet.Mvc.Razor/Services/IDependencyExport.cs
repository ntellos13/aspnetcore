﻿using System;
using System.Collections.Generic;

namespace Microsoft.Net.Runtime
{
    [AssemblyNeutral]
    public interface IDependencyExport
    {
        IList<IMetadataReference> MetadataReferences { get; }
        IList<ISourceReference> SourceReferences { get; }
    }
}