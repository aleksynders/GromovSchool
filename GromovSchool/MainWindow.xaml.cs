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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool Adm;
        public MainWindow()
        {
            InitializeComponent();
            Base.BD = new EntitiesBD();
            FrameClass.MainFrame = fMain;
            Adm = false;
            FrameClass.MainFrame.Navigate(new ListService());
        }

        private void tbLoginAdmin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(Adm == false)
            {
                LogAdmin loginAdmin = new LogAdmin();
                loginAdmin.ShowDialog();
            }
        }
    }
}
