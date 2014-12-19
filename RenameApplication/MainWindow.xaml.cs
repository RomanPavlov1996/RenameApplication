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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace RenameApplication
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnStartClick(object sender, RoutedEventArgs e)
		{
			string[] dirInfo = Directory.GetFiles(Environment.CurrentDirectory + @"\images");

			for (int n = 1; n <= dirInfo.Length; n++)
			{
				string endPath = @"images\" + n.ToString() + dirInfo[n - 1].Remove(0, dirInfo[n - 1].IndexOf('.'));
				File.Move(dirInfo[n - 1], endPath);
				prgProgress.Value = 100 / dirInfo.Length * n;
			}

			MessageBox.Show("Ready!");
			this.Close();
		}
	}
}
