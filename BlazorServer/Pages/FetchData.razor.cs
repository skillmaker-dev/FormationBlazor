

using BlazorServer.Data;
using System.Net.NetworkInformation;
using System;
using Microsoft.AspNetCore.Components;

namespace BlazorServer.Pages
{
    public partial class FetchData
    {
        [Inject]
        WeatherForecastService ForecastService { get; set; }

        private WeatherForecast[]? forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
