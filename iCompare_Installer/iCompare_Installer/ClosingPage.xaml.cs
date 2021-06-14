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

namespace iCompare_Installer
{
    /// <summary>
    /// Interaction logic for ClosingPage.xaml
    /// </summary>
    public partial class ClosingPage : Window
    {
        public ClosingPage()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
