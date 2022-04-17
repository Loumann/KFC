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

namespace KFC
{
    /// <summary>
    /// Логика взаимодействия для LogonList.xaml
    /// </summary>
    public partial class LogonList : Page
    {
        ContentMenu _contentMenu = new ContentMenu();

        public LogonList()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {//проверка логина и пароля на наличие символов
            if (LoginTextBox.Text.Length == 0)
            {
                MessageBox.Show("Логин не верный");
            
            }
            else if (LoginTextBox.Text.Length == 1)
            {
                if (PasstextBox.Text.Length == 0)
                {
                    MessageBox.Show("Пароль не верный");
                }
                else if (PasstextBox.Text.Length == 1 )
                {

                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {//с ЛогонЛист в меню для клиента
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new ContentMenu());
        }
    }
}
