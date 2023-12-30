// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using UiDesktopApp1.Interfaces;

namespace UiDesktopApp1.ViewModels.Pages
{
	public partial class DashboardViewModel : ObservableObject
	{
		private readonly IDateTime _iDateTime;

		[ObservableProperty]
		private int _counter = 0;

		[ObservableProperty]
		private string currentTime = string.Empty;

        public DashboardViewModel(IDateTime dateTime)
        {
			this._iDateTime = dateTime;
		}

        [RelayCommand]
		private void OnCounterIncrement()
		{
			Counter++;
		}

		[RelayCommand]
		private void OnTextChanged()
		{
			this.CurrentTime = this._iDateTime.GetCurrentTime().ToString();
		}
	}
}
