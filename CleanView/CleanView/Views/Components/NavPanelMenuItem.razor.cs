// ---------------------------------------------------------------
// Copyright (c) Brian Parker  All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

namespace CleanView
{
    using Microsoft.AspNetCore.Components;
    using System.Collections.Generic;

    public partial class NavPanelMenuItem : ComponentBase
    {

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> InputAttributes { get; set; }

        [Parameter]
        public string Name { get; set; }

        [Parameter]
        public string Icon { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [CascadingParameter]
        public NavPanel ParentPanel { get; set; }

        void SetParent()
        {
            ParentPanel?.SetContent(ChildContent);
        }

    }

}
