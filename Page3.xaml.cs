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
using practika3_1.DataSet1TableAdapters;

namespace practika3_1
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        ChurchServiceTableAdapter churchService = new ChurchServiceTableAdapter();
        public Page3()
        {
            InitializeComponent();
            thirdGrid.ItemsSource = churchService.GetDataBy();
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            thirdGrid.Columns[0].Visibility = Visibility.Collapsed;
            thirdGrid.Columns[2].Visibility = Visibility.Collapsed;
            thirdGrid.Columns[3].Visibility = Visibility.Collapsed;
        }
    }
}
