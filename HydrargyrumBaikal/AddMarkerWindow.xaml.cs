using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SQLite;

namespace HydrargyrumBaikal
{
    public partial class AddMarkerWindow : Window
    {
        private AppContext DBContext;

        public AddMarkerWindow()
        {
            InitializeComponent();
            string connectionString = "Data Source=C:/Users/dennm/source/repos/HydrargyrumBaikal/HydrargyrumBaikal/hgdb.db";
            // создаем контекст данных
            DBContext = new AppContext();

            // добавляем компоненты окна, такие как поля ввода, метки, кнопки и т.д.
        }

        private void AddMarkerButton_Click(object sender, RoutedEventArgs e)
        {
            // получаем данные из полей ввода
            int id = int.Parse(IdTextBox.Text);
            string cityName = CityNameTextBox.Text;
            Int64 number = Int64.Parse(NumberTextBox.Text);
            double longitude = double.Parse(LongitudeTextBox.Text);
            double latitude = double.Parse(LatitudeTextBox.Text);
            double sample = double.Parse(SampleTextBox.Text);

            // создаем объект Marker на основе этих данных
            Marker marker = new Marker(id, cityName, longitude, latitude, sample, number);

            // добавляем объект Marker в контекст данных и сохраняем его в базе данных
            DBContext.Markers.Add(marker);
            DBContext.SaveChanges();


            // закрываем окно
            this.Close();
        }
    }
}
