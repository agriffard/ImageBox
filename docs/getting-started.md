# Getting Started

1. Install the package:

   ```bash
   dotnet add package ImageBox
   ```

2. Add `@using ImageBox.Components` to your `_Imports.razor`.
3. Pass an image list to the `ImageBox` component.

```razor
<ImageBox Items="_images" />

@code {
    private static readonly IReadOnlyList<ImageBoxItem> _images =
    [
        new() { ImageUrl = "https://example.com/1.jpg", Alt = "Image 1" },
        new() { ImageUrl = "https://example.com/2.jpg", Alt = "Image 2" }
    ];
}
```
