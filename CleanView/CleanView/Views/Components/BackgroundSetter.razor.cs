// ---------------------------------------------------------------
// Copyright (c) Brian Parker  All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

namespace CleanView
{
    using Microsoft.AspNetCore.Components;

    public partial class BackgroundSetter : ComponentBase
    {
        [Parameter]
        public string Url { get; set; } = null;

        [Parameter]
        public string FootNote { get; set; } = null;

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
