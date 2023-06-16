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

namespace HydrargyrumBaikal
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Irkutsk(object sender, RoutedEventArgs e)
        {
            
        }
        private void IrkustkButton_Click(object sender, RoutedEventArgs e)
        {
           IrkutskMap irkutskMap = new IrkutskMap();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = irkutskMap;
            irkutskMap.ShowDialog();
        }

        private void AngarskButton_Click(object sender, RoutedEventArgs e)
        {
            AngarskMap angarskMap = new AngarskMap();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = angarskMap;
            angarskMap.ShowDialog();
        }

        private void ShelehoxButton_Click(object sender, RoutedEventArgs e)
        {
            ShelehovMap shelehovMap = new ShelehovMap();
            Application.Current.MainWindow.Close();
            Application.Current.MainWindow = shelehovMap;
            shelehovMap.ShowDialog();
        }
    }
}
