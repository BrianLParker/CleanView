// ---------------------------------------------------------------
// Copyright (c) Brian Parker  All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

namespace CleanView.Views.Components
{
    using Microsoft.AspNetCore.Components;

    public partial class LeftMenuPanel : ComponentBase
    {
        [Parameter]
        public RenderFragment LeftIcon { get; set; }

        [Parameter]
        public RenderFragment Panel { get; set; }

        [Parameter]
        public string LeftButtonStateClass { get; set; }

        bool open = false;

        void OnClickLeft()
        {
            open = !open;
        }

        void OnFocusOut()
        {

        }
        void OnMouseOverPanel()
        {

        }
        void OnMouseOutPanel()
        {

        }
    }
}
