
using System;
using System.Linq;
using System.Net;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Remote;
using Avalonia.Interactivity;
using Avalonia.LogicalTree;
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
            this.FindControl<Button>("btnOptions").Click += btnOptions_Click;
            this.FindControl<Button>("btnNewGame").Click += btnNewGame_Click;
            this.FindControl<Button>("btnLoad").Click += btnLoad_Click;
            this.FindControl<Button>("btnSave").Click += btnSave_Click;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += InputAbstraction.GameTick;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoaderPortableXaml.Load(this);

            foreach (var logicalChild in this.GetLogicalChildren().OfType<Button>())
            {
                logicalChild.Click += InputAbstraction.GameInputUpdate;
            }
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