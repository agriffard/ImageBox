using Bunit;
using ImageBox.Components;
using Microsoft.AspNetCore.Components.Web;

namespace ImageBox.Tests;

public class ImageBoxComponentTests : BunitContext
{
    [Fact]
    public void RendersAllGalleryItems()
    {
        var images = CreateImages();

        var cut = Render<global::ImageBox.Components.ImageBox>(parameters => parameters
            .Add(p => p.Items, images));

        Assert.Equal(images.Count, cut.FindAll(".imagebox-card").Count);
    }

    [Fact]
    public void OpensLightboxAndNavigatesWithKeyboard()
    {
        var images = CreateImages();

        var cut = Render<global::ImageBox.Components.ImageBox>(parameters => parameters
            .Add(p => p.Items, images));

        cut.FindAll(".imagebox-card")[0].Click();
        var openedSource = cut.Find("figure img").GetAttribute("src");
        Assert.NotNull(openedSource);

        cut.Find(".imagebox-lightbox").KeyDown(new KeyboardEventArgs { Key = "ArrowRight" });
        Assert.NotEqual(openedSource, cut.Find("figure img").GetAttribute("src"));

        cut.Find(".imagebox-lightbox").KeyDown(new KeyboardEventArgs { Key = "Escape" });
        Assert.Empty(cut.FindAll(".imagebox-lightbox"));
    }

    private static IReadOnlyList<ImageBoxItem> CreateImages() =>
    [
        new() { ImageUrl = "https://example.com/first.jpg", Alt = "First" },
        new() { ImageUrl = "https://example.com/second.jpg", Alt = "Second" }
    ];
}
