using System;

namespace MyTemplate.Demo;

public sealed class PageChangedMessage
{
    public required Type PageType { get; init; }
}