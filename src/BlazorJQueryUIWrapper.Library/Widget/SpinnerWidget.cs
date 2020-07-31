using BlazorQuery.Library.JQueryTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorJQueryUIWrapper.Library.Widget
{
    public class SpinnerWidget
    {
        public object Classes { get; set; } = null;
        public string Culture { get; set; } = null;
        public bool? Disabled { get; set; } = null;
        public object Icons { get; set; } = null;
        public bool? Incremental { get; set; } = null; // Can be also a function ???
        public int? Max { get; set; } = null; // Can be also a string ???
        public int? Min { get; set; } = null;// Can be also a string ???
        public string NumberFormat { get; set; } = null;
        public int? Page { get; set; } = null;
        public int? Step { get; set; } = null;// Can be also a string ???

        public void Destroy()
        {

        }
        public void Disable()
        {

        }
        public void Enable()
        {

        }
        public object Instance()
        {
            return null;
        }

        public bool IsValid()
        {
            return false;
        }

        public Action<Event, object> Change { get; set; } = null;
        public Action<Event, object> Create { get; set; } = null;
        public Action<Event, object> Spin { get; set; } = null;
        public Action<Event, object> Start { get; set; } = null;
        public Action<Event, object> Stop { get; set; } = null;
    }
}
