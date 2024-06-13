using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.AspNetCore.Components.WebView.Wpf;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Option;
using NorthWind.BlazingPizza.Frontend.IoC;

namespace NorthWind.BlazingPizza.WPF.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeBlazorWebView();
        }

        void InitializeBlazorWebView()
        {

            Title = "Blazing Pizza";
            string IconSheme = "pack://application:,,,";
            string IconRelativeUri = "wwwroot/Images/icon-512.png";
            Uri IconUri = new Uri($"{IconSheme}/{IconRelativeUri}",
                UriKind.RelativeOrAbsolute);
            Icon = BitmapFrame.Create(IconUri);

            var Services = new ServiceCollection();
            Services.AddWpfBlazorWebView();

            Services.AddBlazorWebViewDeveloperTools();


            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            Services.AddBlazingPizzaServices(
                blazingPizzaOption =>
                    configuration.GetRequiredSection(BlazingPizzaOptions.SectionKey)
                        .Bind(blazingPizzaOption));

            var BlazorWebViewControl = new BlazorWebView();

            BlazorWebViewControl.HostPage = "wwwroot/index.html";
            BlazorWebViewControl.Services = Services.BuildServiceProvider();
            BlazorWebViewControl.RootComponents.Add(
                new RootComponent
                {
                    ComponentType = typeof(Frontend.RazorViews.Routing.App),
                    Selector = "#app"
                });
            Content = BlazorWebViewControl;
        }
    }
}