using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace ToolGiamSatNguoiRaVaoCang.Services
{
    public class SizeListener : ComponentBase
    {
        private IJSRuntime JSRuntime = null;
        public event EventHandler<bool> Size;
        private int browserWidth;
        public async void Init(IJSRuntime js)
        {
            // enforce single invocation            
            if (JSRuntime == null)
            {
                this.JSRuntime = js;
                await JSRuntime.InvokeAsync<string>("MatchesQuery", "(min-width: 1000px)", DotNetObjectReference.Create(this));
            }
        }
        [JSInvokable]
        public void OnQueryChanged(bool isDesktop)
        {
            this.Size?.Invoke(this, isDesktop);
        }
    }
}
