using System.Windows;

namespace DesktopClient.Framework.FontAwesome;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public string Aap { get; set; } = "Duotone_ArrowUp";
    //public EFontAwesomeIcon Aap { get; set; } = EFontAwesomeIcon.Duotone_ArrowDown;
    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = this;
    }
}
