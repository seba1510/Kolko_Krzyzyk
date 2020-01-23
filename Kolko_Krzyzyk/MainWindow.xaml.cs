using System.Windows;

namespace Kolko_Krzyzyk
{
	/// <summary>
	/// Logika interakcji dla klasy MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			exit.Content = "Exit game";
			zagraj.Content = "Play with friends";
			computer.Content = "vs Computer";
		}
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			new TwoPlayers().Show();
			this.Close();
		}
		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			new OnePlayer().Show();
			this.Close();
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
