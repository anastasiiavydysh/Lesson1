using System.Windows;

namespace Lessons1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBoxOutput.Text = TextBoxInput.Text;
        }
    }
}
