using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorJQueryUIWrapper.Library
{
    public class BlazorJQueryUIWrapperDOM : ComponentBase
    {
        private IJSRuntime JSRuntime { get; set; }

        public BlazorJQueryUIWrapperDOM(IJSRuntime JSRuntime)
        {
            this.JSRuntime = JSRuntime;
        }

        public async Task Spinner(string CurrentSelector)
        {
            await JSRuntime.InvokeAsync<Task>(BlazorJQueryUIWrapperList.Spinner, CurrentSelector); 
        }


    }
}
