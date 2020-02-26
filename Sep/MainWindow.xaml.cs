using Sep.BL.DTOs;
using Sep.BL.Entities;
using Sep.BL.Repositories;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private long _currentUserId;
        private IRepositoryFactory _repositoryFactory;
        public MainWindow()
        {
            InitializeComponent();

            var roomRepository = _repositoryFactory.GetRooms();
            var rooms = roomRepository
                .GetRooms(_currentUserId)
                .Select( x=> x.Name);

            Rooms.ItemsSource = rooms;
        }
    }
}
