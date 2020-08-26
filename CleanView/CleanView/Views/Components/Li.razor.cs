// ---------------------------------------------------------------
// Copyright (c) Brian Parker  All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

namespace CleanView.Views.Components
{
    using Microsoft.AspNetCore.Components;
    using System.Collections.Generic;

    public partial class Li<TItem> : ComponentBase
    {
        [Parameter]
        public IReadOnlyList<TItem> Items { get; set; }

        [Parameter]
        public RenderFragment<TItem> ChildContent { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> InputAttributes { get; set; }
    }
}
