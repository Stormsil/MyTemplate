using System;

namespace MyTemplate.App;

public sealed class PageChangedMessage
{
    public required Type PageType { get; init; }
}