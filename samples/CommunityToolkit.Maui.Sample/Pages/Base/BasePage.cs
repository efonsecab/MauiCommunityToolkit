﻿using System.Diagnostics;
using CommunityToolkit.Maui.Sample.ViewModels;

namespace CommunityToolkit.Maui.Sample.Pages;

public abstract class BasePage<TViewModel> : BasePage where TViewModel : BaseViewModel
{
	protected BasePage(IDeviceInfo deviceInfo, TViewModel viewModel) : base(deviceInfo, viewModel)
	{
	}

	public new TViewModel BindingContext => (TViewModel)base.BindingContext;
}

public abstract class BasePage : ContentPage
{
	protected BasePage(IDeviceInfo deviceInfo, object? viewModel = null)
	{
		BindingContext = viewModel;
		Padding = 12;

		SetDynamicResource(BackgroundColorProperty, "AppBackgroundColor");

		if (string.IsNullOrWhiteSpace(Title))
		{
			Title = this.GetType().Name;
		}
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		Debug.WriteLine($"OnAppearing: {Title}");
	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();

		Debug.WriteLine($"OnDisappearing: {Title}");
	}
}