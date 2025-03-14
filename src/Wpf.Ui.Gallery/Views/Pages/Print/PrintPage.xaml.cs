// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using Wpf.Ui.Controls;
using Wpf.Ui.Gallery.ControlsLookup;
using Wpf.Ui.Gallery.ViewModels.Pages.Print;

namespace Wpf.Ui.Gallery.Views.Pages.Print;

[GalleryPage("Selectable list.", SymbolRegular.GroupList24)]
/// <summary>
/// 打印功能模块主页面（最后更新：2025-03-13）
/// 实现导航接口，支持页面路由功能 
/// </summary>
public partial class PrintPage : INavigableView<PrintViewModel>
{
    /// <summary>
    /// 页面视图模型实例（MVVM模式）
    /// </summary>
    public PrintViewModel ViewModel { get; }

    /// <summary>
    /// 构造函数注入视图模型 
    /// </summary>
    /// <param name="viewModel">通过DI容器注入的打印视图模型</param>
    public PrintPage(PrintViewModel viewModel)
    {
        ViewModel = viewModel;
        DataContext = this;

        InitializeComponent();

    }


    /// <summary>
    /// 按钮点击事件处理（功能最后验证：2025-03-13）
    /// 功能：生成带时间戳的操作日志 
    /// </summary>
    private void Button_Click(object sender, RoutedEventArgs e)
    {

        OutputLogTextBox.Text += $"按钮在 {DateTime.Now:yyyy-MM-dd HH:mm:ss} 被激活。\n";

    }
}