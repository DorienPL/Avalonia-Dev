using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AppTest.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        AvaloniaXamlLoader.Load(this);

    }
}