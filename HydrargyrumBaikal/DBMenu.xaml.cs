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
        ObservableCollection<Marker> locations = new ObservableCollection<Marker>();

        private void FillDataGrid()
        {
            string connectionString = "Data Source=C:/Users/dennm/source/repos/HydrargyrumBaikal/HydrargyrumBaikal/hgdb.db";
            string query = "SELECT Latitude, Longitude, Sample, Number, City_name, id FROM Markers";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {   
                            double latitude = (double)reader["Latitude"];
                            double longitude = (double)reader["Longitude"];
                            double sample = (double)reader["Sample"];
                            Int64 number = (Int64)reader["Number"];
                            string cityName = (string)reader["City_name"];
                            locations.Add(new Marker { Latitude = latitude, Longitude = longitude, Sample = sample, Number = number });
                        }
                        DGridHydrargyrum.ItemsSource = locations;
                        
                        
                    }
                }
            }
            //foreach (Marker location in locations)
            //{
            //    this.DGridHydrargyrum.Items.Add(location);
            //}
        }
        public DBMenu()
        {

            InitializeComponent();
            FillDataGrid();
            //foreach (DataGridColumn column in DGridHydrargyrum.Columns)
            //            {

            //                DGridHydrargyrum.Columns.Remove(column);

            //            }
            //DataContext = locations;
            //var dg = new DataGrid();
            //this.MainGrid.Children.Add(dg);

            //List<Marker> locations = new List<Marker>();



        }


    }
}
