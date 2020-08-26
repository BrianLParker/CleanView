// ---------------------------------------------------------------
// Copyright (c) Brian Parker  All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

namespace CleanView
{
    using Microsoft.AspNetCore.Components.Web;
    using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
    using Microsoft.AspNetCore.Components;
    using System.Linq;
    using System.Threading.Tasks;

    public partial class UserAccountDisplay : ComponentBase
    {
        [Inject]
        public SignOutSessionStateManager SignOutManager { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }


        private async Task BeginSignOut(MouseEventArgs args)
        {
            await SignOutManager.SetSignOutState();
            Navigation.NavigateTo("authentication/logout");
        }

        string ShortName(string email) => email.Split('@').FirstOrDefault() ?? string.Empty;
    }

}
