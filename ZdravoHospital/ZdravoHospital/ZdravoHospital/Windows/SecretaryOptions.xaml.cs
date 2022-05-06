using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ZdravoHospital.Windows
{
   
    public partial class SecretaryOptions : Window
    {
        public SecretaryOptions()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private static SecretaryOptions windowInstance;
        public static SecretaryOptions GetSecretaryOptions()
        {
            if (windowInstance == null)
            {
                windowInstance = new SecretaryOptions();
            }
            return windowInstance;
        }

        private void Patient_Click(object sender, RoutedEventArgs e)
        {


            SecretaryWindow secretaryWindow = SecretaryWindow.GetSecretaryWindow();
            secretaryWindow.Show();


        }

        private void AllAppointments_Click(object sender, RoutedEventArgs e)
        {
            var allAppointmentsWindow = new AllAppointmentsWindow();
            allAppointmentsWindow.Show();
        }

        private void MakeAppointment_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Record_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            windowInstance = null;
        }
    }
}
