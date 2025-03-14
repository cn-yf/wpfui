// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.
using System.Windows.Controls;
using Wpf.Ui.Gallery.Models;
using Wpf.Ui.Gallery.Views.Pages.Print;

namespace Wpf.Ui.Gallery.ViewModels.Pages.Print;
public partial class PrintViewModel : ViewModel
{
    private int _listViewSelectionModeComboBoxSelectedIndex = 0;

    public int ListViewSelectionModeComboBoxSelectedIndex
    {
        get => _listViewSelectionModeComboBoxSelectedIndex;
        set
        {
            _ = SetProperty(ref _listViewSelectionModeComboBoxSelectedIndex, value);
        }
    }

    [ObservableProperty]
    private SelectionMode _listViewSelectionMode = SelectionMode.Single;

    [ObservableProperty]
    private ObservableCollection<Person> _basicListViewItems = GeneratePersons();

    private static ObservableCollection<Person> GeneratePersons()
    {
        var random = new Random();
        var persons = new ObservableCollection<Person>();

        var names = new[]
        {
            "John",
        };
        var surnames = new[]
        {
            "Doe",
            "Tapia",
        };
        var companies = new[]
        {
            "Pineapple Inc.",
            "Macrosoft Redmond",
            "Amazing Basics Ltd",
            "Megabyte Computers Inc",
            "Roude Mics",
            "XD Projekt Red S.A.",
            "Lepo.co",
        };

        for (int i = 0; i < 50; i++)
        {
            persons.Add(
                new Person(
                    names[random.Next(0, names.Length)],
                    surnames[random.Next(0, surnames.Length)],
                    companies[random.Next(0, companies.Length)]
                )
            );
        }

        return persons;
    }
}
