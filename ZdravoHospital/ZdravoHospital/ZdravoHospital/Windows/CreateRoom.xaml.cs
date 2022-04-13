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
using Model;

namespace ZdravoHospital.Windows
{
    /// <summary>
    /// Interaction logic for CreateRoom.xaml
    /// </summary>
    public partial class CreateRoom : Window
    {
        public CreateRoom()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = this;
            Type.ItemsSource = Enum.GetValues(typeof(RoomType)).Cast<RoomType>();
            
        }

        private void Button_Click_No(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_Yes(object sender, RoutedEventArgs e)
        {
            List<Room> rooms = ManagerWindow.roomController.GetRooms();
            foreach (Room r in rooms)
            {
                if (r.Id == Id.Text)
                {
                    MessageBox.Show("The entered id number already exists", "eror");
                    return;
                }

            }

            ManagerWindow.roomController.CreateRoom(new Room(Id.Text, Name.Text, Description.Text, int.Parse(Floor.Text), (RoomType)Type.SelectedItem));
            ManagerWindow.GetManagerWindow().refreshRoomTable();
            Close();
        }
       
    }
}
