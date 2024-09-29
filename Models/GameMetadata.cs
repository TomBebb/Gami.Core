using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
// ReSharper disable UnusedMember.Global

namespace Gami.Core.Models;

[SuppressMessage("ReSharper", "PropertyCanBeMadeInitOnly.Global")]
[SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
public record GameMetadata
{
    public string Description { get; set; } = "";

    public ImmutableArray<string> Developers { get; set; } = ImmutableArray<string>.Empty;
    public ImmutableArray<string> Genres { get; set; } = ImmutableArray<string>.Empty;
    public ImmutableArray<string> Platforms { get; set; } = ImmutableArray<string>.Empty;
    public ImmutableArray<string> Publishers { get; set; } = ImmutableArray<string>.Empty;
    public ImmutableArray<string> Series { get; set; } = ImmutableArray<string>.Empty;

    public GameMetadata Combine(GameMetadata other) =>
        new()
        {
            Description = Description.Length == 0 ? other.Description : Description,
            Developers = Developers.Concat(other.Developers).ToImmutableArray(),
            Genres = Genres.Concat(other.Genres).ToImmutableArray(),
            Platforms = Platforms.Concat(other.Platforms).ToImmutableArray(),
            Publishers = Publishers.Concat(other.Publishers).ToImmutableArray(),
            Series = Series.Concat(other.Series).ToImmutableArray()
        };
}