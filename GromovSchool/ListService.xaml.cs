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

namespace GromovSchool
{
    /// <summary>
    /// Логика взаимодействия для ListService.xaml
    /// </summary>
    public partial class ListService : Page
    {
        public ListService()
        {
            InitializeComponent();
            lvListService.ItemsSource = Base.BD.Service.ToList();
        }

        private void tbOldPrice_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock textBlock = (TextBlock)sender;
            if (textBlock.Uid != null)
            {
                textBlock.Visibility = Visibility.Visible;
            }
            else
            {
                textBlock.Visibility = Visibility.Collapsed;
            }
        }

        private void tbDiscount_Loaded(object sender, RoutedEventArgs e)
        {
            TextBlock textBlock = (TextBlock)sender;
            if (textBlock.Uid != null)
            {
                textBlock.Visibility = Visibility.Visible;
            }
            else
            {
                textBlock.Visibility = Visibility.Hidden;
            }
        }
    }
}
