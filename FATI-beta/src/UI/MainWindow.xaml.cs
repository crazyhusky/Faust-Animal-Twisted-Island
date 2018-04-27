
using System;
using System.Net;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Remote;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Remote.Protocol;
using Avalonia.Remote.Protocol.Designer;
using Avalonia.Remote.Protocol.Viewport;
using Avalonia.Threading;
using Avalonia.Media;
namespace FATIbeta.src.UI
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoaderPortableXaml.Load(this);
        }
        public void btnOptions_Click(object sender, RoutedEventArgs args)
        {
            
        }
        public void btnLoad_Click(object sender, RoutedEventArgs args)
        {
            
        }
        public void btnSave_Click(object sender, RoutedEventArgs args)
        {
            
        }
        public void btnNewGame_Click(object sender, RoutedEventArgs args)
        {
            this.FindControl<Popup>("InputPopup").Open();
        }

    }
}