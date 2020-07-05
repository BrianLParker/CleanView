namespace CleanView
{
    using Microsoft.AspNetCore.Components;
    using System;

    public partial class CleanLayout : ComponentBase
    {
        [Inject]
        public NavigationManager Nav { get; set; }

        [Parameter]
        public string BackgroundImageUrl { get; set; }

        [Parameter]
        public string FootNote { get; set; }

        [Parameter]
        public string BackgroundClass { get; set; } = "app-background-gradient";

        [Parameter]
        public RenderFragment HeaderCenter { get; set; }

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
        public int CopyrightStart { get; set; } = DateTime.Now.Year;

        [Parameter]
        public int ButterflyCount { get; set; } = (DateTime.Today.Month == 6 && DateTime.Today.Day == 22) ? 1 : 0;


        string _copyright => $"Copyright © {CopyrightStart}" + (CopyrightStart == DateTime.Now.Year ? "" : $" - {DateTime.Now.Year}") + $", " + CopyrightOwner;
        string _backgroundStyle => string.IsNullOrWhiteSpace(BackgroundImageUrl) ? "" : $"background-image: url('{BackgroundImageUrl}');";

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

        public void SetBackground(string url,string footNote,string cssClass)
        {
            FootNote = footNote;
            BackgroundClass = cssClass;
            BackgroundImageUrl = url;
            StateHasChanged();
        }
    }
}
