using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace BlazorApp1.Helpers
{
    public static class JSRuntimeExtensions
    {
        public async static Task ClickAsync(
            this IJSRuntime jsRuntime,
            string element)
        {
            await jsRuntime.InvokeAsync<object>(
                  "click",
                  element);
        }

        public async static Task SaveAsAsync(
            this IJSRuntime jsRuntime,
            string filename,
            byte[] data)
        {
            await jsRuntime.InvokeAsync<object>(
                  "saveAsFile",
                  filename,
                  Convert.ToBase64String(data));
        }
    }
}
