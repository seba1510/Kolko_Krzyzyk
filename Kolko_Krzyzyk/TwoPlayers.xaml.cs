using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kolko_Krzyzyk
{
	public partial class TwoPlayers: Window
	{
		public string[,] tab;
		public int runda = 1;
		string gracz;
		bool koniec = false;

		public TwoPlayers()
		{
			InitializeComponent();
		}

		private void Window_Closed(object sender, EventArgs e)
		{
			new MainWindow().Show();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (sender is Button)
			{
	
				(sender as Button).Content = runda % 2 == 0 ? "X" : "O";
				runda++;
				(sender as Button).IsEnabled = false;
			}

			if (runda % 2 == 1)
			{
				info.Content = "Turn: Player O";
			}
			else
			{
				info.Content = "Turn: Player X";
			}
			CzyWygralX();
			CzyWygralY();
		}

		private void MozliwosciWygranych(string gracz)
		{   //Poziom
			if (b11.Content == gracz && b12.Content == gracz && b13.Content == gracz && b14.Content == gracz) { info.Content = "Player " + gracz + " wins"; poziom1.Visibility = Visibility.Visible; koniec = true; }
			if (b21.Content == gracz && b22.Content == gracz && b23.Content == gracz && b24.Content == gracz) { info.Content = "Player " + gracz + " wins"; poziom2.Visibility = Visibility.Visible; koniec = true; }
			if (b31.Content == gracz && b32.Content == gracz && b33.Content == gracz && b34.Content == gracz) { info.Content = "Player " + gracz + " wins"; poziom3.Visibility = Visibility.Visible; koniec = true; }
			if (b41.Content == gracz && b42.Content == gracz && b43.Content == gracz && b44.Content == gracz) { info.Content = "Player " + gracz + " wins"; poziom4.Visibility = Visibility.Visible; koniec = true; }
			//Pion
			if (b11.Content == gracz && b21.Content == gracz && b31.Content == gracz && b41.Content == gracz) { info.Content = "Player " + gracz + " wins"; pion1.Visibility = Visibility.Visible; koniec = true; }
			if (b12.Content == gracz && b22.Content == gracz && b32.Content == gracz && b42.Content == gracz) { info.Content = "Player " + gracz + " wins"; pion2.Visibility = Visibility.Visible; koniec = true; }
			if (b13.Content == gracz && b23.Content == gracz && b33.Content == gracz && b43.Content == gracz) { info.Content = "Player " + gracz + " wins"; pion3.Visibility = Visibility.Visible; koniec = true; }
			if (b14.Content == gracz && b24.Content == gracz && b34.Content == gracz && b44.Content == gracz) { info.Content = "Player " + gracz + " wins"; pion4.Visibility = Visibility.Visible; koniec = true; }
			//Skos
			if (b11.Content == gracz && b22.Content == gracz && b33.Content == gracz && b44.Content == gracz) { info.Content = "Player " + gracz + " wins"; skos1.Visibility = Visibility.Visible; koniec = true; }
			if (b14.Content == gracz && b23.Content == gracz && b32.Content == gracz && b41.Content == gracz) { info.Content = "Player " + gracz + " wins"; skos2.Visibility = Visibility.Visible; koniec = true; }
			if (koniec == true)
			{
				BlokadaPlanszy();
			}

		}
		private void CzyWygralX()
		{
			gracz = "O";
			MozliwosciWygranych(gracz);
		}
		private void CzyWygralY()
		{
			gracz = "X";
			MozliwosciWygranych(gracz);
		}


		private void BlokadaPlanszy()
		{
			
			domenu.Visibility = Visibility.Visible;
		}
		private void domenu_Click(object sender, RoutedEventArgs e)
		{
			new MainWindow().Show();
			this.Close();
		}

	}
}
