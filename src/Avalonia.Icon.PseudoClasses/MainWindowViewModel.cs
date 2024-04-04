using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia.Icon.PseudoClasses;

public sealed partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private bool _isTrue;
}
