using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace cinequiz.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
#if DEBUG
            this.AttachDevTools();
#endif
        }
        
    }
}