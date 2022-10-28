using System.Windows;

namespace LaboratoryWork_4
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void TextBox1_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
		{
			TextBox2.Text = TextBox2.CaesarAlgorithm(TextBox1.Text);
		}
	}
}