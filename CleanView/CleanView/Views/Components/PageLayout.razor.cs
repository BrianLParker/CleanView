// ---------------------------------------------------------------
// Copyright (c) Brian Parker  All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

namespace CleanView
{
    using Microsoft.AspNetCore.Components;

    public partial class PageLayout : ComponentBase
    {

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string Url { get; set; }

        [Parameter]
        public string FootNote { get; set; }

        [Parameter]
        public string CssClass { get; set; } = "app-background-gradient";

        [CascadingParameter(Name = "CleanLayout")]
        public CleanLayout CleanLayout { get; set; }

        protected override void OnInitialized()
        {
            CleanLayout.SetBackground(Url, FootNote, CssClass);
            base.OnInitialized();
        }
    }
}
