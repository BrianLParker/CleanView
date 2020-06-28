namespace CleanView
{
    using Microsoft.AspNetCore.Components;
    using System;

    public partial class CleanLayout : ComponentBase
    {
        [Inject]
        public NavigationManager Nav { get; set; }

        [Parameter]
        public string BackgroundImageUrl { get; set; } = $"_content/CleanView/image/background/background{new Random().Next(1, 8)}.jpg";

        [Parameter]
        public RenderFragment LeftIcon { get; set; }

        [Parameter]
        public RenderFragment LeftMenuPanel { get; set; }

        [Parameter]
        public RenderFragment RightIcon { get; set; }

        [Parameter]
        public RenderFragment RightMenuPanel { get; set; }

        [Parameter]
        public RenderFragment Content { get; set; }

        [Parameter]
        public string CopyrightOwner { get; set; } = "Owner";

        [Parameter]




        /// <summary>
        /// Start rear of copyright. If not current year the footer will show a year range.
        /// </summary>
        public int CopyrightStart { get; set; } = DateTime.Now.Year;

        [Parameter]
        public int ButterflyCount { get; set; } = 1;


        string _copyright => $"Copyright © {CopyrightStart}" + (CopyrightStart == DateTime.Now.Year ? "" : $" - {DateTime.Now.Year}") + $", " + CopyrightOwner;

        bool _openLeft = false;
        bool _openRight = false;


        string _leftButtonStateClass => _openLeft ? "fade-up-button-open" : "";
        string _rightButtonStateClass => _openRight ? "fade-up-button-open" : "";
        void OnClickLeft()
        {
            _openLeft = !_openLeft;
            _openRight = false;
        }
        void OnClickRight()
        {
            _openRight = !_openRight;
            _openLeft = false;
        }



        void OnFocusOut()
        {
            if (!_overPanel)
            {
                _openLeft = false;
                _openRight = false;
            }
        }

        bool _overPanel = false;

        void OnMouseOverPanel()
        {
            _overPanel = true;
        }

        void OnMouseOutPanel()
        {
            _overPanel = false;
        }

        protected override void OnInitialized()
        {
            Nav.LocationChanged += Nav_LocationChanged;
            base.OnInitialized();
        }
        int _count = new Random((int)DateTime.Now.Ticks).Next(3, 15) * -1;
        private void Nav_LocationChanged(object sender, Microsoft.AspNetCore.Components.Routing.LocationChangedEventArgs e)
        {
            if (_count < ButterflyCount)
            {
                _count++;

            }

            _openLeft = false;
            _openRight = false;
        }

        public void SetBackground(string url)
        {
            //InvokeAsync(() =>
            //{
            BackgroundImageUrl = url;
            StateHasChanged();
            //});
        }
    }
}
