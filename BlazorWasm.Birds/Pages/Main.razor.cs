using Microsoft.JSInterop;

namespace BlazorWasm.Birds.Pages
{
    public partial class Main
    {
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                //await JsRuntime.InvokeAsync<IJSObjectReference>("import", "./assets/js/main.js");
                //var targetUrl = "./assets/js/main.js";
                //await JsRuntime.InvokeVoidAsync("loadJs", targetUrl);

                await Task.Delay(500);
                await JsRuntime.InvokeVoidAsync("loadForm");
            }
        }
    }
}
