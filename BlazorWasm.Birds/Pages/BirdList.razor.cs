using BlazorWasm.Birds.Services;
using Microsoft.JSInterop;

namespace BlazorWasm.Birds.Pages
{
    public partial class BirdList
    {
        private List<BirdModel>? _birds;
        private EnumBirdDetail _enumbirdsDetail = EnumBirdDetail.Disable;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                //await JsRuntime.InvokeAsync<IJSObjectReference>("import", "./assets/js/main.js");
                //var targetUrl = "./assets/js/main.js";
                //await JsRuntime.InvokeVoidAsync("loadJs", targetUrl);

                await Task.Delay(500);
                await JsRuntime.InvokeVoidAsync("loadForm");
                _birds = BirdService.GetBirds();
                StateHasChanged();
            }
        }

        private void Onclick(BirdModel item)
        {
            _enumbirdsDetail = EnumBirdDetail.Enable;

        }
    }
}
