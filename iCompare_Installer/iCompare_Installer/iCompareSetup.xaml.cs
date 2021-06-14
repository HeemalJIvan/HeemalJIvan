using Fluid.Business.DataServer;
using FusionXC.Data;
using Microsoft.Data.ConnectionUI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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

namespace iCompare_Installer
{
    /// <summary>
    /// Interaction logic for iCompareSetup.xaml
    /// </summary>
    public partial class iCompareSetup : Window
    {
       
        readonly MainWindow main = new MainWindow();
        readonly ClosingPage close = new ClosingPage();
        public iCompareSetup()
        {
            InitializeComponent();
            

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            
            main.Show();
            this.Close();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            close.Show();
            this.Close();
        }

        string GetConnectionString()
        {
            DataConnectionDialog dcd = new DataConnectionDialog();

            dcd.DataSources.Add(Microsoft.Data.ConnectionUI.DataSource.SqlDataSource);

            if (DataConnectionDialog.Show(dcd) == System.Windows.Forms.DialogResult.OK)
            {
                return dcd.ConnectionString;
            }

            return String.Empty;
        }
        private void btnRetrieve_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
