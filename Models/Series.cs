using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Gami.Core.Models;

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
[SuppressMessage("ReSharper", "PropertyCanBeMadeInitOnly.Global")]
public sealed class Series : NamedIdItem
{
    [Timestamp] public byte[] Version { get; set; } = null!;
    public List<Game> Games { get; set; } = null!;
}