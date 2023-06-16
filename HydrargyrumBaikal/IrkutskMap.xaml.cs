using Microsoft.Maps.MapControl.WPF;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.IO;
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
    /// Логика взаимодействия для IrkutskMap.xaml
    /// </summary>
    public partial class IrkutskMap : Window
    {
        Map map;

        static double minLat = 90;
        static double maxLat = -90;
        static double minLong = 180;
        static double maxLong = -180;
        double mapStep = CoordinatesInMeters(100);
        double tempLat;
        double tempLong;
        double minSample = double.MaxValue;
        double maxSample = double.MinValue;
        private const double RadiusInKm = 6371;


        public static double DistanceCalc(double lat1, double lon1, double lat2, double lon2)
        {
            var dLat = DegreesToRadians(lat2 - lat1);
            var dLon = DegreesToRadians(lon2 - lon1);

            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(DegreesToRadians(lat1)) * Math.Cos(DegreesToRadians(lat2)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return RadiusInKm * c;
        }

        private static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        private const double EarthRadiusInMeters = 6371000;
        private const double DegreesToRadiansKoef = Math.PI / 180.0;

        public static double CoordinatesInMeters(double distanceInMeters)
        {
            // расчет шага по широте в градусах
            double latitudinalDistance = distanceInMeters / EarthRadiusInMeters;
            double latitudinalDegrees = latitudinalDistance / DegreesToRadiansKoef;

            return latitudinalDegrees;
        }
        ObservableCollection<Marker> mlocations = new ObservableCollection<Marker>();

        public IrkutskMap()
        {
            
            InitializeComponent();
            FillMarkers(mlocations);



            foreach (Marker location in mlocations)
            {

                if (minLong > location.Longitude)
                {
                    minLong = location.Longitude;
                }
                if (maxLong < location.Longitude)
                {
                    maxLong = location.Longitude;
                }
                if (maxLat < location.Latitude)
                {
                    maxLat = location.Latitude;
                }
                if (minLat > location.Latitude)
                {
                    minLat = location.Latitude;
                }


            }

            foreach (Marker location in mlocations)
            {
                Pushpin pin = new Pushpin();
                Location pinLocation = new Location(location.Latitude, location.Longitude);
                pin.Content = ".";
                MapLayer.SetPosition(pin, pinLocation);
                HydragyrumMap.Children.Add(pin);
            }

        }

        private void FillMarkers(ObservableCollection<Marker>mlocations)
        {
            string connectionString = "Data Source=C:/Users/dennm/source/repos/HydrargyrumBaikal/HydrargyrumBaikal/hgdb.db";
            string query = "SELECT Latitude, Longitude, Sample, Number FROM Markers WHERE City_name = 'Иркутск'";
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

                            mlocations.Add(new Marker { Latitude = latitude, Longitude = longitude, Sample = sample, Number = number });
                        }

                    }
                }
            }
        }
        
        private void BDButton_Click(object sender, RoutedEventArgs e)
        {
            DBMenu dbMenu = new DBMenu();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = dbMenu;
            dbMenu.ShowDialog();
        }

        private void VizualisationButton_Click(object sender, RoutedEventArgs e)
        {
            double stepik = CoordinatesInMeters(4000 / Math.Sqrt(2));
            List<LocationCollection> locations = new List<LocationCollection>();
            List<Color> squarecolors = new List<Color>();
            tempLat = maxLat + stepik;
            tempLong = minLong - stepik;
            minLat -= stepik;
            maxLong += stepik;
            map = App.Current.MainWindow.FindName("HydragyrumMap") as Map;
            Color[] colors = new Color[] { Colors.DarkSlateBlue, Colors.DarkCyan, Colors.Turquoise, Colors.LimeGreen, Colors.Lime, Colors.Yellow, Colors.Orange, Colors.Red, Colors.Brown, Colors.Black };

            // расчет палитры цветов
            foreach (var pushpin in mlocations)
            {

                if (pushpin.Sample < minSample)
                    minSample = pushpin.Sample;
                if (pushpin.Sample > maxSample)
                    maxSample = pushpin.Sample;
            }

            while (tempLat > minLat)
            {
                while (tempLong < maxLong)
                {

                    double vminLat = tempLat - mapStep;
                    double vmaxLat = tempLat;
                    double vminLong = tempLong;
                    double vmaxLong = tempLong + mapStep;
                    tempLong += mapStep;
                    double sum1 = 0;
                    double sum2 = 0;
                    foreach (var marker in mlocations)
                    {
                        sum1 += marker.Sample / Math.Pow(DistanceCalc(marker.Latitude, marker.Longitude, vmaxLat, vminLong), 2);
                        sum2 += 1 / Math.Pow(DistanceCalc(marker.Latitude, marker.Longitude, vmaxLat, vminLong), 2);
                    }

                    MapPolygon mapPolygon = new MapPolygon
                    {
                        Opacity = 0.5,
                        StrokeThickness = 1,
                        Fill = new SolidColorBrush(colors[(int)Math.Floor(((sum1 / sum2) - minSample) / (maxSample - minSample) * (colors.Length - 1))]),
                        Locations = new LocationCollection { new Location(vmaxLat, vminLong), new Location(vminLat, vminLong), new Location(vminLat, vmaxLong), new Location(vmaxLat, vmaxLong),

                    }
                    };
                    map.Children.Add(mapPolygon);

                }
                tempLong = minLong - stepik;
                tempLat -= mapStep;
            }

            double range = maxSample - minSample;

            List<Color> pushpincolors = new List<Color>();

            foreach (var pushpin in mlocations)
            {
                double value = pushpin.Sample;
                int intervalIndex = (int)Math.Floor((value - minSample) / (maxSample - minSample) * (colors.Length - 1));
                if (intervalIndex < 0)
                    intervalIndex = 0;
                if (intervalIndex >= colors.Length)
                    intervalIndex = colors.Length - 1;
                pushpincolors.Add(colors[intervalIndex]);
            }
            int cindex = 0;
            foreach (var pushpin in map.Children.OfType<Pushpin>())
            {
                pushpin.Background = new SolidColorBrush(pushpincolors[cindex]);
                cindex++;

            }
        }

        private void WriteToFile(string data)
        {
            string fileName = "IrkutskHydrargyrumDB.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(data);
            }
        }


        //private void ExportDataToTxtFile()
        //{
        //    using (var DbContext = new AppContext())
        //    {
        //        var marker = DbContext.Markers.Where(m => m.CityName == "Иркутск").ToList();

        //        using (var writer = new StreamWriter("markers.txt"))
        //        {
        //            foreach (Marker location in mlocations)
        //            {
        //                writer.WriteLine($"{location.Longitude},{location.Latitude},{location.Sample}");
        //            }
        //        }
        //    }
        //}

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            // создаем диалог сохранения
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PNG Image|*.png";
            saveDialog.FileName = "map.png";

            // если пользователь выбрал файл и нажал ОК
            if (saveDialog.ShowDialog() == true)
            {
                // создаем RenderTargetBitmap с размерами карты
                RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap((int)HydragyrumMap.ActualWidth, (int)HydragyrumMap.ActualHeight, 96, 96, PixelFormats.Pbgra32);

                // рендерим карту на RenderTargetBitmap
                renderTargetBitmap.Render(HydragyrumMap);

                // создаем BitmapEncoder для сохранения изображения
                PngBitmapEncoder pngEncoder = new PngBitmapEncoder();
                pngEncoder.Frames.Add(BitmapFrame.Create(renderTargetBitmap));

                // сохраняем изображение в файл
                using (FileStream fileStream = new FileStream(saveDialog.FileName, FileMode.Create))
                {
                    pngEncoder.Save(fileStream);
                }
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ExportFileButton_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Data Source=C:/Users/dennm/source/repos/HydrargyrumBaikal/HydrargyrumBaikal/hgdb.db";
            string query = "SELECT Latitude, Longitude, Sample, Number FROM Markers WHERE City_name = 'Иркутск'";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                      string data = "";
                        foreach (Marker location in mlocations)
                         {
                         data += $"Number: {location.Number}, Longitude: {location.Longitude}, Latitude: {location.Latitude}, Sample: {location.Sample}\n";
                         }
                         WriteToFile(data);
 
                }
            }
            MessageBox.Show("Файл 'IrkutskHydrargyrumDB.txt' успешно сохранен!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = mainWindow;
            mainWindow.ShowDialog();
        }

        
    }
}
