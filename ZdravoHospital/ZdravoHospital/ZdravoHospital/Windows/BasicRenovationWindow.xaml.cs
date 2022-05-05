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

namespace ZdravoHospital.Windows
{
    /// <summary>
    /// Interaction logic for BasicRenovationWindow.xaml
    /// </summary>
    public partial class BasicRenovationWindow : Window
    {
        public BasicRenovationWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private static BasicRenovationWindow windowInstance;

        public static BasicRenovationWindow GetBasicRenovationWindow()
        {
            if (windowInstance == null)
            {
                windowInstance = new BasicRenovationWindow();
            }
            return windowInstance;
        }
    }
}
