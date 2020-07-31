using BlazorJQueryUIWrapper.Library.Widget;
using BlazorQuery.Library;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorJQueryUIWrapper.Library
{
    public static class BlazorJQueryUIWrapperDOM
    {
        
        public static async Task<BlazorQueryDOM> Spinner(this BlazorQueryDOM blazorQueryDOM)
        {
            await blazorQueryDOM.JSRuntimeInstance.InvokeAsync<Task>(BlazorJQueryUIWrapperList.Spinner, blazorQueryDOM.CurrentSelector);
            return blazorQueryDOM;
        }

        public async static Task<BlazorQueryDOM> Spinner(this Task<BlazorQueryDOM> dom) => await (await dom).Spinner();

        public static async Task<BlazorQueryDOM> Spinner(this BlazorQueryDOM blazorQueryDOM, SpinnerWidget spinnerWidget)
        {
            await blazorQueryDOM.JSRuntimeInstance.InvokeAsync<Task>(BlazorJQueryUIWrapperList.Spinner, blazorQueryDOM.CurrentSelector);
            return blazorQueryDOM;
        }


    }
}
