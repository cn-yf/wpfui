// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

// ReSharper disable once CheckNamespace
namespace Wpf.Ui.Controls;

/// <summary>
/// States of the <see cref="ThumbRate"/> control.
/// </summary>
public enum ThumbRateState
{
    /// <summary>
    /// No thumb has been clicked.
    /// </summary>
    None,

    /// <summary>
    /// The thumb up has been clicked.
    /// </summary>
    Liked,

    /// <summary>
    /// The thumb down has been clicked.
    /// </summary>
    Disliked,
}
