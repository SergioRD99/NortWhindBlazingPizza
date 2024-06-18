using Microsoft.AspNetCore.Components;
using NorthWind.BlazingPizza.Frontend.ViewModels.Index;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Pages
{
    public partial class Index
    {
        [Inject]
        IndexViewModel ViewModel { get; set; }
    }
}