using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace WPFTest
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

        private async void btnGetHtml_Click(object sender, RoutedEventArgs e)
        {
            var url = txtUrl.Text;
            using (var client = new HttpClient())
            {
                try
                {
                    btnGetHtml.IsEnabled = false;
                    txtHtml.Text = await client.GetStringAsync(url);
                }
                catch
                {
                    txtHtml.Text = "wow, wrong input!!!!";
                }
                finally
                {
                    btnGetHtml.IsEnabled = true;
                }
            }
        }
    }
}
