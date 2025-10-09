using System;

namespace MyTemplate.App.Helpers;

public sealed class PageChangedMessage
{
    public required Type PageType { get; init; }
}