using Gami.Core.Models;

namespace Gami.Core;

public interface IGameAchievementScanner : IBasePlugin
{
    public IAsyncEnumerable<Achievement> Scan(IGameLibraryRef game);

    public IAsyncEnumerable<AchievementProgress> ScanProgress(
        IGameLibraryRef game);
}