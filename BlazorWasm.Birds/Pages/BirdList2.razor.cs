using BlazorWasm.Birds.Services;
using Microsoft.JSInterop;

namespace BlazorWasm.Birds.Pages
{
    public partial class BirdList2
    {
        private List<BirdModel>? _birds;
        private EnumBirdDetail _enumbirdsDetail = EnumBirdDetail.Disable;
        private BirdModel? _birdDetail;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                //await JsRuntime.InvokeAsync<IJSObjectReference>("import", "./assets/js/main.js");
                //var targetUrl = "./assets/js/main.js";
                //await JsRuntime.InvokeVoidAsync("loadJs", targetUrl);

               await LoadJavaScript();
                _birds = BirdService.GetBirds();
                StateHasChanged();
            }
        }
        private async Task Detail(BirdModel item)
        {
            _birdDetail = item;
            _enumbirdsDetail = EnumBirdDetail.Enable;
            await LoadJavaScript();
            StateHasChanged();
        }

        private void Back()
        {
            _enumbirdsDetail = EnumBirdDetail.Disable;
            _birdDetail = null;
        }

        private async Task LoadJavaScript()
        {
            await Task.Delay(500);
            await JsRuntime.InvokeVoidAsync("loadForm");
        }
    }
}
