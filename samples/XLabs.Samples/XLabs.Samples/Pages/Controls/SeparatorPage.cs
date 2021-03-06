// ***********************************************************************
// Assembly         : XLabs.Sample
// Author           : XLabs Team
// Created          : 12-27-2015
// 
// Last Modified By : XLabs Team
// Last Modified On : 01-04-2016
// ***********************************************************************
// <copyright file="SeparatorPage.cs" company="XLabs Team">
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

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace XLabs.Samples.Pages.Controls
{
	/// <summary>
	/// Class SeparatorPage.
	/// </summary>
	public class SeparatorPage : ContentPage
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SeparatorPage"/> class.
		/// </summary>
		public SeparatorPage()
		{
			var mainLayout = new StackLayout();

			var stackLayout = new StackLayout();
			var stackLabel = new Label() {
				Text = "Separators in stack layout"
			};
			stackLayout.Children.Add(stackLabel);
			var separator = new Separator() {
				Color = Color.Red
			};
			stackLayout.Children.Add(separator);
			var stackLabel2 = new Label() {
				Text = "Thicker"
			};
			stackLayout.Children.Add(stackLabel2);
			separator = new Separator() {
				Color = Color.Green,
				Thickness = 5
			};
			stackLayout.Children.Add(separator);
			stackLabel2 = new Label() {
				Text = "Bigger after spacing"
			};
			stackLayout.Children.Add(stackLabel2);
			separator = new Separator() {
				Color = Color.Blue,
				SpacingBefore = 2,
				SpacingAfter = 20
			};
			stackLayout.Children.Add(separator);
			stackLabel2 = new Label() {
				Text = "No spacing"
			};
			stackLayout.Children.Add(stackLabel2);
			separator = new Separator() {
				Color = Color.Blue,
				SpacingBefore = 0,
				SpacingAfter = 0
			};
			stackLayout.Children.Add(separator);
			stackLabel2 = new Label() {
				Text = "Bigger before spacing"
			};
			stackLayout.Children.Add(stackLabel2);
			separator = new Separator() {
				Color = Color.Blue,
				SpacingBefore = 20,
				SpacingAfter = 2
			};
			stackLayout.Children.Add(separator);
			stackLabel2 = new Label() {
				Text = "Dashed"
			};
			stackLayout.Children.Add(stackLabel2);
			separator = new Separator() {
				Color = Color.Red,
				StrokeType = StrokeType.Dashed

			};
			stackLayout.Children.Add(separator);
			stackLabel2 = new Label() {
				Text = "Dotted"
			};
			stackLayout.Children.Add(stackLabel2);
			separator = new Separator() {
				Color = Color.Red,
				StrokeType = StrokeType.Dotted

			};
			stackLayout.Children.Add(separator);

			//stackLayout.VerticalOptions = LayoutOptions.FillAndExpand;
			stackLayout.BackgroundColor = Color.Gray.MultiplyAlpha(0.2);

			mainLayout.Children.Add(stackLayout);

			Content = new ScrollView(){Content =  mainLayout};
		}
	}
}

