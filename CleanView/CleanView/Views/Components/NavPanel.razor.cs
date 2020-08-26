// ---------------------------------------------------------------
// Copyright (c) Brian Parker  All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

namespace CleanView
{
    using Microsoft.AspNetCore.Components;

    public partial class NavPanel : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        public void SetContent(RenderFragment fragment)
        {
            SubPanelFragment = fragment;
            Toggle();
            StateHasChanged();
        }

        void Toggle()
        {
            _panelOpen = !_panelOpen;
        }

        bool _panelOpen = false;
    }
}
