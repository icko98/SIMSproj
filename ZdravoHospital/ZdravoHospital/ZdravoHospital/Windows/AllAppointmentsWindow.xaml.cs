using Model;
using System;
using System.Collections.Generic;
using System.Data;
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
using ZdravoHospital.Controller;

namespace ZdravoHospital.Windows
{
    /// <summary>
    /// Interaction logic for AllAppointmentsWindow.xaml
    /// </summary>
    public partial class AllAppointmentsWindow : Window
    {
        AllAppointmentsCotroller allAppointmentsCotroller = new AllAppointmentsCotroller();
        DataTable dt;
        public AllAppointmentsWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dt = new DataTable();
            List<AllAppointments> allAppointments = allAppointmentsCotroller.GetAll();

            foreach (AllAppointments appointment in allAppointments)
            {
                //MessageBox.Show(appointment.ToString());
                
                
            }
            dataGridAllAppointments.ItemsSource = dt.DefaultView;
            dataGridAllAppointments.SelectionMode = DataGridSelectionMode.Single;
        }

        private void Button_Click_SEdit(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_SDelete(object sender, RoutedEventArgs e)
        {

        }
    }
}
