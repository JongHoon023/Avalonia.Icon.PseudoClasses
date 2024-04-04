using Avalonia.Controls;
using System.Threading.Tasks;

namespace Avalonia.Icon.PseudoClasses;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }

    private async void Window_Activated(object? sender, System.EventArgs e)
    {
        if (DataContext is MainWindowViewModel viewModel)
        {
            while (true)
            {
                await Task.Delay(3000).ConfigureAwait(false);
                viewModel.IsTrue = !viewModel.IsTrue;
            }
        }
    }
}
