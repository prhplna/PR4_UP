using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace PR4_UP.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = txbLogin.Text.Trim();
            string password = psbPassword.Password;

            // Проверяем, что поля не пусты
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поля 'Логин' и 'Пароль' должны быть заполнены.");
                return;
            }

            // Пример проверки правильности логина и пароля (в реальном приложении проверка должна происходить на сервере)
            if (!IsValidLogin(login, password))
            {
                MessageBox.Show("Вы ввели неверный логин или пароль. Пожалуйста, проверьте ещё раз введенные данные.");
                ClearFields(); // Очистить поля для повторного ввода
            }
            else
            {
                // Вход выполнен успешно, здесь можно перейти на следующую страницу или продолжить работу с приложением
                MessageBox.Show($"Добро пожаловать, {login}!");
            }
        }
        // Очищает поля для нового ввода
        private void ClearFields()
        {
            txbLogin.Clear();
            psbPassword.Clear();
        }


    }

   
}

