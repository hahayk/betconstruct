using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApplicationTask
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {

                for (int i = 0; i < 100000000; i++)
                {
                    var x = Math.Sin(Math.Cos(i) * Math.Cos(i) + Math.Log(i));

                    Debug.WriteIf(x % 100 == 0, i);
                }
            });
        }

        private async void button1_Click(object sender, RoutedEventArgs e)
        {
            button1.IsEnabled = false;

            Task<double> task = Task.Run(() =>
            {
                var sum = 0.0;
                for (int i = 0; i < 10000000; i++)
                {
                    var x = Math.Sin(Math.Cos(i) * Math.Cos(i)) + Math.Sin(DateTime.Now.Ticks);

                    sum += x;
                }

                return sum;
            });

            var result = await task;
            
            textBox.Text = result.ToString();

            button1.IsEnabled = true;
        }
    }
}
