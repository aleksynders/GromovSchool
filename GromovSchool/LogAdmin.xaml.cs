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

namespace GromovSchool
{
    /// <summary>
    /// Логика взаимодействия для LogAdmin.xaml
    /// </summary>
    public partial class LogAdmin : Window
    {
        public LogAdmin()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (tbKodAdmin.Text == "0000")
            {
                MainWindow.Adm = true;
                MessageBox.Show("Вы активировали режим администратора");

                this.Close();
            }
            else
            {
                MessageBox.Show("Код введён не верно");
            }
        }
    }
}
