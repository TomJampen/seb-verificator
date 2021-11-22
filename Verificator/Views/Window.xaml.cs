﻿/*
 * Copyright (c) 2021 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using Verificator.Data;

namespace Verificator.Views
{
	public partial class Window : System.Windows.Window
	{
		public Window()
		{
			InitializeComponent();
			DataContext = new WindowViewModel(new Repository());
		}
	}
}
