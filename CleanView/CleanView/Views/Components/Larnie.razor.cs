// ---------------------------------------------------------------
// Copyright (c) Brian Parker  All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------
//  This component is a dedication to my wife Larnie, 22nd June 1968 - 20th March 2020.
//  Crohn's Disease is a horrible condition. Larnie passed away alone because of COVID-19
//  restrictions. 🌺🌸 
// ---------------------------------------------------------------

namespace CleanView.Views.Components
{
    using System;

    public partial class Larnie
    {
        protected override void OnInitialized()
        {
            timer = new System.Timers.Timer();
            timer.AutoReset = false;
            timer.Elapsed += timer_Elapsed;
            ResetTimer();

            base.OnInitialized();
        }
        void ResetTimer()
        {
            var duration = Random.Next(5000, 15000);

            timer.Stop();
            timer.Interval = duration;
            timer.Start();
        }
        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            InvokeAsync(() =>
            {
                targetCorner = Random.Next(0, 4);
                StateHasChanged();

            });
            ResetTimer();

        }
        string _class => targetCorner switch
        {
            0 => "lb-pos1",
            1 => "lb-pos2",
            2 => "lb-pos3",
            _ => "lb-pos4"
        };
        static Random Random = new Random((int)DateTime.Now.Ticks);
        int targetCorner = Random.Next(0, 4);
        int angle = Random.Next(0, 360);
        System.Timers.Timer timer;
    }
}
