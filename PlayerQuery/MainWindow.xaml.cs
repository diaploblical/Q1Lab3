using BaseballLib;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace PlayerQuery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BaseballEntities db = new BaseballEntities();
        public MainWindow()
        {
            InitializeComponent();
            db.Players.Load();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            CollectionViewSource playersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("playersViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // playersViewSource.Source = [generic data source]
            playersDataGrid.ItemsSource = db.Players.Local;
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            playersDataGrid.ItemsSource = (from players in db.Players
                                           where players.LastName == searchTxt.Text
                                           select new { players.BattingAverage, players.FirstName, players.LastName, players.PlayerID }).ToList();
        }

        private void UndoBtn_Click(object sender, RoutedEventArgs e)
        {
            playersDataGrid.ItemsSource = (from players in db.Players
                                           select new { players.BattingAverage, players.FirstName, players.LastName, players.PlayerID }).ToList();
        }
    }
}