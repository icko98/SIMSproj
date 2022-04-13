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
    /// Interaction logic for EditRoom.xaml
    /// </summary>
    public partial class EditRoom : Window
    {
        public EditRoom()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Room r = ManagerWindow.SelectedRoom;
            Id.Text = r.Id;
            Name.Text = r.Name;
            Description.Text = r.Description;
            Floor.Text = r.Floor.ToString();
            Type.ItemsSource = Enum.GetValues(typeof(RoomType)).Cast<RoomType>();
            Type.SelectedItem = r.RoomType;
            Show();
        }

        private void Button_Click_No(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_Yes(object sender, RoutedEventArgs e)
        {
            ManagerWindow.roomController.EditRoom(new Room(Id.Text, Name.Text, Description.Text, int.Parse(Floor.Text), (RoomType)Type.SelectedItem));
            ManagerWindow.GetManagerWindow().refreshRoomTable();
            Close();
        }

    }
}
