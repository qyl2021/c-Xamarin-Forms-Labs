// ***********************************************************************
// Assembly         : XLabs.Sample
// Author           : XLabs Team
// Created          : 12-27-2015
// 
// Last Modified By : XLabs Team
// Last Modified On : 01-04-2016
// ***********************************************************************
// <copyright file="ButtonGroupPage.cs" company="XLabs Team">
//     Copyright (c) XLabs Team. All rights reserved.
// </copyright>
// <summary>
//       This project is licensed under the Apache 2.0 license
//       https://github.com/XLabs/Xamarin-Forms-Labs/blob/master/LICENSE
//       
//       XLabs is a open source project that aims to provide a powerfull and cross 
//       platform set of controls tailored to work with Xamarin Forms.
// </summary>
// ***********************************************************************
// 

using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace XLabs.Samples.Pages.Controls
{
    public class ButtonGroupPage : ContentPage
    {
        private const int MAX = 10;

        public ButtonGroupPage()
        {
            var buttonGroupQuantityItems = new List<string>();

            for (var i = 1; i <= MAX; i++)
            {
                buttonGroupQuantityItems.Add(i.ToString(CultureInfo.InvariantCulture));
            }

            var buttonGroupTagCloudItems = new List<string>
            {
                "Xamarin",
                "Xamarin.Forms",
                "iOS",
                "Android",
                "Windows Phone",
            };

            var buttonGroupMovieStartTimesItems = new List<string>
            {
                "12:00",
                "2:30",
                "5:00",
                "7:30",
            };

            var buttonGroupQuantity = new ButtonGroup
            {
                IsNumber = true,
                Rounded = true,
                ViewBackgroundColor = Color.Black,
                BorderColor = Color.White,
                OutlineColor = Color.Black,
                BackgroundColor = Device.OnPlatform(Color.Accent, Color.Accent, Color.White),
                TextColor = Device.OnPlatform(Color.White, Color.White, Color.Black),
                SelectedTextColor = Device.OnPlatform(Color.Black, Color.White, Color.White),
                SelectedBackgroundColor = Device.OnPlatform(Color.White, Color.Black, Color.Black),
                SelectedBorderColor = Device.OnPlatform(Color.White, Color.Silver, Color.Silver),
                SelectedFrameBackgroundColor = Device.OnPlatform(Color.Black, Color.Black, Color.Black),
                SelectedIndex = 3,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Padding = new Thickness(5),
                Font = Device.OnPlatform(
                    Font.OfSize("HelveticaNeue-Light", NamedSize.Medium),
                    Font.OfSize("Roboto Light", NamedSize.Medium),
                    Font.OfSize("Segoe WP Light", NamedSize.Medium)),
                Items = buttonGroupQuantityItems,
            };

            var buttonGroupTagCloud = new ButtonGroup
            {
                Rounded = false,
                IsNumber = false,
                ViewBackgroundColor = Color.White,
                BorderColor = Color.White,
                OutlineColor = Color.Black,
                BackgroundColor = Device.OnPlatform(Color.Accent, Color.Accent, Color.White),
                TextColor = Device.OnPlatform(Color.White, Color.Black, Color.Black),
                SelectedTextColor = Device.OnPlatform(Color.Black, Color.White, Color.White),
                SelectedBackgroundColor = Device.OnPlatform(Color.White, Color.Accent, Color.Accent),
                SelectedBorderColor = Device.OnPlatform(Color.White, Color.Accent, Color.Accent),
                SelectedFrameBackgroundColor = Device.OnPlatform(Color.White, Color.Accent, Color.Accent),
                SelectedIndex = 3,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Padding = new Thickness(5),
                Font = Device.OnPlatform(
                    Font.OfSize("HelveticaNeue-Light", NamedSize.Medium),
                    Font.OfSize("Roboto Light", NamedSize.Medium),
                    Font.OfSize("Segoe WP Light", NamedSize.Medium)),
                Items = buttonGroupTagCloudItems,
            };

            var buttonGroupMovieStartTimes = new ButtonGroup
            {
                Rounded = true,
                IsNumber = false,
                ViewBackgroundColor = Color.Black,
                BackgroundColor = Color.Silver,
                TextColor = Color.White,
                BorderColor = Color.White,
                OutlineColor = Color.Black,
                SelectedBackgroundColor = Color.Silver,
                SelectedTextColor = Color.Black,
                SelectedBorderColor = Color.Black,
                SelectedFrameBackgroundColor = Device.OnPlatform(Color.Black, Color.Black, Color.Black),
                SelectedIndex = 3,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Padding = new Thickness(5),
                Font = Device.OnPlatform(
                        Font.OfSize("HelveticaNeue-Light", NamedSize.Medium),
                        Font.OfSize("Roboto Light", NamedSize.Medium),
                        Font.OfSize("Segoe WP Light", NamedSize.Medium)),
                Items = buttonGroupMovieStartTimesItems,
            };

            var labelQuantity = new Label
            {
                Text = "Quantity",
                TextColor = Device.OnPlatform(Color.White, Color.White, Color.White),
            };

            var labelTagCloud = new Label
            {
                Text = "Tag Cloud",
                TextColor = Device.OnPlatform(Color.White, Color.White, Color.White),
            };

            var labelMovieStartTimes = new Label
            {
                Text = "Movie Start Times",
                TextColor = Device.OnPlatform(Color.White, Color.White, Color.White),
            };

            var stack = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    labelQuantity,
                    buttonGroupQuantity, 
                    labelTagCloud,
                    buttonGroupTagCloud, 
                    labelMovieStartTimes,
                    buttonGroupMovieStartTimes,
                },
            };

            Title = "Button Group";
            BackgroundColor = Color.Black;
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            Content = stack;
        }
    }
}
