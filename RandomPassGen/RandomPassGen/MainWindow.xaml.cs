using System.Windows;
using System.Windows.Controls;

namespace RandomPassGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rnPassButton_Click(object sender, RoutedEventArgs e)
        {
            RndPassGen gen = new RndPassGen();


            pswdTextBoxHEX.Text = gen.GeneratePasswordRnd(AllCheckBox.IsChecked, LowCheckBox.IsChecked, HighCheckBox.IsChecked,
                                                        SymbolsCheckBox.IsChecked, NumbersCheckBox.IsChecked);
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        
        }
    }
}
