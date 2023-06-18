using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SQLite;
using Microsoft.EntityFrameworkCore;

namespace HydrargyrumBaikal
{
    public partial class AddMarkerWindow : Window
    {
        private AppContext DbContext;

        public AddMarkerWindow()
        {
            InitializeComponent();
            DbContext = new AppContext();
            DataContext = DbContext;
 
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

            Marker marker = new Marker(id, cityName, longitude, latitude, sample, number);

            //DbContext.Create(marker);

            this.Close();
        }
    }
}
