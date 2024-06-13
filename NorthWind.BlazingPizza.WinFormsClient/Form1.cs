using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Frontend.IoC;
using NorthWind.BlazingPizza.Frontend.RazorViews.Routing;

namespace NorthWind.BlazingPizza.WinFormsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeBlazorWebView();
        }

        void InitializeBlazorWebView()
        {
            Text = "Blazing Pizza";

            Bitmap bitmap = new Bitmap("wwwroot/images/icon-512.png");
            Icon = Icon.FromHandle(bitmap.GetHicon());

            BlazorWebView WebViewControl = new BlazorWebView();
            WebViewControl.Dock = DockStyle.Fill;
            Controls.Add(WebViewControl);

            IServiceCollection Service = new ServiceCollection();

            Service.AddWindowsFormsBlazorWebView();
            //Service.AddBlazingPizzaServices();

            WebViewControl.HostPage = "wwwroot/index.html";
            WebViewControl.Services = Service.BuildServiceProvider();
            WebViewControl.RootComponents.Add<App>("#app");
        }
    }
}
