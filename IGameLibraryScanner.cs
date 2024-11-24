﻿using System.Collections.Frozen;
using Gami.Core.Models;

namespace Gami.Core;

public interface IGameLibraryScanner : IBaseAddon
{
    public IAsyncEnumerable<IGameLibraryMetadata> Scan(FrozenSet<string> skipLibraryIds);
}