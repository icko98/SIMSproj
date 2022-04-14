using Controller;
using System.Collections.ObjectModel;
using System.Windows;
using System.ComponentModel;
namespace ZdravoHospital.Windows
{
    /// <summary>
    /// Interaction logic for DoctorWindow.xaml
    /// </summary>
    public partial class DoctorWindow : Window
    {
        public static AppController appController = new AppController();
        public ObservableCollection<Model.App> Xapps { get; set; }

        public static Model.App SelectedApp { get; set; }
        public DoctorWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;

            Xapps = new ObservableCollection<Model.App>(appController.GetAll());
        }
        private static DoctorWindow windowInst;

        public static DoctorWindow GetDoctorWindow()
        {
            if (windowInst == null)
            {
                windowInst = new DoctorWindow();
            }
            return windowInst;
        }

        public void refreshAppTable()
        {
            appTable.ItemsSource = null;
            appTable.ItemsSource = appController.GetAll();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            windowInst = null;
        }
        private void Button_Click_DAdd(object sender, RoutedEventArgs e)
        {
            CreateApp createApp = new CreateApp();
            createApp.Show();
        }
        private void Button_Click_DDelete(object sender, RoutedEventArgs e)
        {
            if (SelectedApp == null)
            {
                return; 
            }
        DeleteApp deleteApp = new DeleteApp();
            deleteApp.Show();
        }
        private void Button_Click_DEdit(object sender, RoutedEventArgs e)
        {
            if(SelectedApp == null)
            {
                return;

            }
            EditApp editApp = new EditApp();
        }
    }
}
