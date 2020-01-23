﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Kolko_Krzyzyk
{
	/// <summary>
	/// Logika interakcji dla klasy App.xaml
	/// </summary>
	public partial class App : Application
	{
		[STAThread]
		public static void Main()
		{
			var application = new App();
			application.InitializeComponent();
			application.Run();
		}
	}
}