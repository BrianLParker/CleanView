using System;
using System.Collections.Generic;
using System.Text;

namespace CleanView.Components
{
    interface ICleanViewOptions
    {
        bool Transparent { get; set; }
        string BackgroundUrl { get; set; }
    }

    class CleanViewOptions : ICleanViewOptions
    {
        public bool Transparent { get; set; } = true;
        public string BackgroundUrl { get; set; } = "_content/CleanView/background.jpg";

    }
}
