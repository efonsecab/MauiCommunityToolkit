﻿using System;
using CommunityToolkit.Maui.Core;

namespace CommunityToolkit.Core.Handlers;

public partial class PopupViewHandler : Microsoft.Maui.Handlers.ElementHandler<IPopup, object>
{
	/// <inheritdoc/>
	protected override object CreateNativeElement() => throw new NotImplementedException();

	/// <summary>
	/// Action that's triggered when the Popup is Dismissed.
	/// </summary>
	/// <param name="handler">An instance of <see cref="PopupViewHandler"/>.</param>
	/// <param name="view">An instance of <see cref="IPopup"/>.</param>
	/// <param name="result">The result that should return from this Popup.</param>
	public static void MapOnDismissed(PopupViewHandler handler, IPopup view, object? result)
	{
	}

	/// <summary>
	/// Action that's triggered when the Popup is Opened.
	/// </summary>
	/// <param name="handler">An instance of <see cref="PopupViewHandler"/>.</param>
	/// <param name="view">An instance of <see cref="IPopup"/>.</param>
	/// <param name="result">We don't need to provide the result parameter here.</param>
	public static void MapOnOpened(PopupViewHandler handler, IPopup view, object? result)
	{
	}

	/// <summary>
	/// Action that's triggered when the Popup is LightDismissed.
	/// </summary>
	/// <param name="handler">An instance of <see cref="PopupViewHandler"/>.</param>
	/// <param name="view">An instance of <see cref="IPopup"/>.</param>
	/// <param name="result">The result that should return from this Popup.</param>
	public static void MapOnLightDismiss(PopupViewHandler handler, IPopup view, object? result)
	{
	}

	/// <summary>
	/// Action that's triggered when the Popup <see cref="IPopup.Anchor"/> property changes.
	/// </summary>
	/// <param name="handler">An instance of <see cref="PopupViewHandler"/>.</param>
	/// <param name="view">An instance of <see cref="IPopup"/>.</param>
	public static void MapAnchor(PopupViewHandler handler, IPopup view)
	{
	}

	/// <summary>
	/// Action that's triggered when the Popup <see cref="IPopup.IsLightDismissEnabled"/> property changes.
	/// </summary>
	/// <param name="handler">An instance of <see cref="PopupViewHandler"/>.</param>
	/// <param name="view">An instance of <see cref="IPopup"/>.</param>
	public static void MapLightDismiss(PopupViewHandler handler, IPopup view)
	{
	}

	/// <summary>
	/// Action that's triggered when the Popup <see cref="IPopup.Color"/> property changes.
	/// </summary>
	/// <param name="handler">An instance of <see cref="PopupViewHandler"/>.</param>
	/// <param name="view">An instance of <see cref="IPopup"/>.</param>
	public static void MapColor(PopupViewHandler handler, IPopup view)
	{
	}

	/// <summary>
	/// Action that's triggered when the Popup <see cref="IPopup.Size"/> property changes.
	/// </summary>
	/// <param name="handler">An instance of <see cref="PopupViewHandler"/>.</param>
	/// <param name="view">An instance of <see cref="IPopup"/>.</param>
	public static void MapSize(PopupViewHandler handler, IPopup view)
	{
	}
}

