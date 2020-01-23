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
using Kolko_Krzyzyk_Library;
using System.Threading;

namespace Kolko_Krzyzyk
{
	public partial class OnePlayer : Window
	{
		Game game = new Game();
		List<Button> lista = new List<Button>();

		string gracz;
		string zwyciezca;
		bool koniec = false;
		int x;
		public OnePlayer()
		{
			InitializeComponent();
			info.Content = "Your turn";
			
			lista.Add(b11);
			lista.Add(b12);
			lista.Add(b13);
			lista.Add(b14);
			lista.Add(b21);
			lista.Add(b22);
			lista.Add(b23);
			lista.Add(b24);
			lista.Add(b31);
			lista.Add(b32);
			lista.Add(b33);
			lista.Add(b34);
			lista.Add(b41);
			lista.Add(b42);
			lista.Add(b43);
			lista.Add(b44);
			
		}

		private void Window_Closed(object sender, EventArgs e)
		{
			new MainWindow().Show();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			info.Content = "Your turn...";
			(sender as Button).Content = "O";
			(sender as Button).IsEnabled = false;
			info.Content = "Computer is thinking";
			CzyWygralPlayer();
		}
		private async void ComputerTurn()
		{
			if (koniec == false)
			{
				do
				{
					x = game.RandomList(0, 16);
				} while (lista[x].IsEnabled == false);

				lista[x].Content = "X";
				lista[x].IsEnabled = false;

				CzyWygralComputer();
				info.Content = "Your turn...";
			}
		}
		

		private void MozliwosciWygranych(string gracz, string zwyciezca)
		{   //Poziom
			if (b11.Content == gracz && b12.Content == gracz && b13.Content == gracz && b14.Content == gracz) { info.Content = zwyciezca + " won"; poziom1.Visibility = Visibility.Visible; koniec = true; }
			if (b21.Content == gracz && b22.Content == gracz && b23.Content == gracz && b24.Content == gracz) { info.Content = zwyciezca + " won"; poziom2.Visibility = Visibility.Visible; koniec = true; }
			if (b31.Content == gracz && b32.Content == gracz && b33.Content == gracz && b34.Content == gracz) { info.Content = zwyciezca + " won"; poziom3.Visibility = Visibility.Visible; koniec = true; }
			if (b41.Content == gracz && b42.Content == gracz && b43.Content == gracz && b44.Content == gracz) { info.Content = zwyciezca + " won"; poziom4.Visibility = Visibility.Visible; koniec = true; }
			//Pion
			if (b11.Content == gracz && b21.Content == gracz && b31.Content == gracz && b41.Content == gracz) { info.Content = zwyciezca + " won"; pion1.Visibility = Visibility.Visible; koniec = true; }
			if (b12.Content == gracz && b22.Content == gracz && b32.Content == gracz && b42.Content == gracz) { info.Content = zwyciezca + " won"; pion2.Visibility = Visibility.Visible; koniec = true; }
			if (b13.Content == gracz && b23.Content == gracz && b33.Content == gracz && b43.Content == gracz) { info.Content = zwyciezca + " won"; pion3.Visibility = Visibility.Visible; koniec = true; }
			if (b14.Content == gracz && b24.Content == gracz && b34.Content == gracz && b44.Content == gracz) { info.Content = zwyciezca + " won"; pion4.Visibility = Visibility.Visible; koniec = true; }
			//Skos
			if (b11.Content == gracz && b22.Content == gracz && b33.Content == gracz && b44.Content == gracz) { info.Content = zwyciezca + " won"; skos1.Visibility = Visibility.Visible; koniec = true; }
			if (b14.Content == gracz && b23.Content == gracz && b32.Content == gracz && b41.Content == gracz) { info.Content = zwyciezca + " won"; skos2.Visibility = Visibility.Visible; koniec = true; }
			if (koniec == true)
			{
				BlokadaPlanszy();
			}

		}
		private void CzyWygralPlayer()
		{
			zwyciezca = "You";
			gracz = "O";
			MozliwosciWygranych(gracz, zwyciezca);
		}
		private void CzyWygralComputer()
		{
			zwyciezca = "Computer";
			gracz = "X";
			MozliwosciWygranych(gracz, zwyciezca);
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

		private new void IsEnabledChanged(object sender, MouseEventArgs e)
		{
			if ((sender as Button).IsEnabled == false)
			{
				Thread.Sleep(1000);
				ComputerTurn();
			}
		}
	}
}
	

