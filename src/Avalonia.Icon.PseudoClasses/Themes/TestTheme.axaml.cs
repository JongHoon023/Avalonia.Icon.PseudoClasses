using System;
using Avalonia.Styling;
using Avalonia.Markup.Xaml;

namespace Avalonia.Icon.PseudoClasses;

public class TestTheme : Style
{
    public TestTheme(IServiceProvider? provider = null)
    {
        AvaloniaXamlLoader.Load(provider, this);
    }
}