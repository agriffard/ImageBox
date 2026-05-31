namespace ImageBox.Components;

public sealed class ImageBoxItem
{
    public required string ImageUrl { get; init; }

    public string? ThumbnailUrl { get; init; }

    public string? Alt { get; init; }

    public string? Caption { get; init; }
}
