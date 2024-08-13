namespace DongTa;

/// <summary>
/// Biểu diễn kết quả của 1 hành động CRUD
/// </summary>
/// <param name="Level">Information, Warning, Error, Success</param>
/// <param name="Description"></param>
public sealed record Message(LevelMessage Level, string Description) {
    public static readonly Message None = new(LevelMessage.None, string.Empty);
    public static readonly Message Success = new(LevelMessage.Success, "Action completed");
    public static readonly Message NotFound = new(LevelMessage.Error, "Không có dữ liệu thỏa mãn điều kiện tìm kiếm");
    public override string ToString() { return $"{GetLevelString(Level)}: {Description}"; }

    private static string GetLevelString(LevelMessage Level) => Level switch
    {
        LevelMessage.Error => nameof(LevelMessage.Error),
        LevelMessage.None => nameof(LevelMessage.None),
        LevelMessage.Warning => nameof(LevelMessage.Warning),
        _ => string.Empty
    };
}