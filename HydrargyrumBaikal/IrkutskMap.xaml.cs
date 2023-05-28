using Microsoft.Maps.MapControl.WPF;
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



namespace HydrargyrumBaikal
{
    /// <summary>
    /// Логика взаимодействия для IrkutskMap.xaml
    /// </summary>
    public partial class IrkutskMap : Window
    {
        Map map;
        
        public IrkutskMap()
        {
            
            InitializeComponent();
            
          
           
        }

        private void BDButton_Click(object sender, RoutedEventArgs e)
        {
            DBMenu DBMenu = new DBMenu();
            DBMenu.Show();
        }

        private void VizualisationButton_Click(object sender, RoutedEventArgs e)
        {
            map = App.Current.MainWindow.FindName("HydragyrumMap") as Map;
            LocationCollection locations = new LocationCollection()
                {
                    new Location(52.328098, 104.347672),
                    new Location(52.310332, 104.431023),
                    new Location(52.236477, 104.280428),
                    new Location(52.360158, 104.199493),
                };
            MapPolygon mapPolygon = new MapPolygon
            {
                Opacity = 0.5,
                Fill = new SolidColorBrush(Colors.Red),
                Locations = locations,
            };
            map.Children.Add(mapPolygon);
        }
    }
}
