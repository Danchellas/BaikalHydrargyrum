using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
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

namespace HydrargyrumBaikal
{
    /// <summary>
    /// Логика взаимодействия для DBMenu.xaml
    /// </summary>
    public partial class DBMenu : Window
    {
        private AppContext DbContext;
        ObservableCollection<Marker> locations = new ObservableCollection<Marker>();

        private void FillDataGrid()
        {
            string connectionString = "Data Source=C:/Users/MarkovDN/Source/Repos/BaikalHydrargyrum/HydrargyrumBaikal/hgdb.db";
            string query = "SELECT ID, Latitude, Longitude, Sample, Number, City_name FROM Markers";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["ID"]);
                            double latitude = (double)reader["Latitude"];
                            double longitude = (double)reader["Longitude"];
                            double sample = (double)reader["Sample"];
                            Int64 number = (Int64)reader["Number"];
                            string cityName = (string)reader["City_name"];
                            locations.Add(new Marker {ID = id, CityName = cityName, Latitude = latitude, Longitude = longitude, Sample = sample, Number = number });
                        }
                        DGridHydrargyrum.ItemsSource = locations;


                    }
                }
            }

        }
        public DBMenu()
        {

            InitializeComponent();
            FillDataGrid();
            DbContext = new AppContext();

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = mainWindow;
            mainWindow.ShowDialog();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddMarkerWindow addMarkerWindow = new AddMarkerWindow();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = addMarkerWindow;
            addMarkerWindow.ShowDialog();
        }
    }
}
