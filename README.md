# ImageBox

[![NuGet](https://img.shields.io/nuget/v/ImageBox.svg)](https://www.nuget.org/packages/ImageBox)

**ImageBox — Gallery + Lightbox** is a .NET 10 Blazor component library that provides a responsive masonry grid and a zoomable, keyboard-navigable lightbox.

## Features

- Responsive masonry gallery
- Lightbox dialog with previous/next controls
- Keyboard navigation (`ArrowLeft`, `ArrowRight`, `Esc`, `Home`, `End`)
- Zoom controls (`+` / `-`) in the lightbox
- NuGet-ready package metadata

## Install

```bash
dotnet add package ImageBox
```

## Usage

```razor
@using ImageBox.Components

<ImageBox Items="images" />

@code {
    private static readonly IReadOnlyList<ImageBoxItem> images =
    [
        new() { ImageUrl = "https://example.com/photo-1.jpg", Alt = "Photo 1", Caption = "Photo 1" },
        new() { ImageUrl = "https://example.com/photo-2.jpg", Alt = "Photo 2", Caption = "Photo 2" }
    ];
}
```

## Repository structure

- `/ImageBox` — Blazor component library (.NET 10)
- `/ImageBox.Sample` — Blazor WebAssembly sample app
- `/ImageBox.Tests` — bUnit/xUnit tests
- `/docs` — quick docs and setup notes

## Documentation

- [Getting Started](docs/getting-started.md)
- [Sample App](docs/sample-app.md)
