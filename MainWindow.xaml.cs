using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HELLO");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }   

        private void regist_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text != "Введите ваше имя")
            {
                MessageBox.Show($"Привет, {Name.Text}");
            }
            else
            {
                MessageBox.Show("Вы не ввели имя пользователя");
            }
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            Name.Text = "Введите ваше имя";
            mail.Text = "Введите ваш e-mail";
            number.Text = "Введите ваш номер";
            password.Text = "Введите ваш пароль";
            password2.Text = "Введите ваш парол еще раз";
        }

        private void Name_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void Name_TouchEnter(object sender, TouchEventArgs e)
        {
        }

        private void Name_DragEnter(object sender, DragEventArgs e)
        { 
        }

        private void Name_MouseDown(object sender, MouseButtonEventArgs e)
        { 
        }

        private void Name_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {  
        }

        private void Name_GotFocus(object sender, RoutedEventArgs e)
        {
        }

        private void Name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Name.Text == "")
            {
                Name.Text = "Введите ваше имя";
            }
        }

        private void mail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (mail.Text == "")
            {
                mail.Text = "Введите ваш e-mai";
            }
        }

        private void Name_GotFocus_1(object sender, RoutedEventArgs e)
        {
            Name.Text = "";
        }

        private void mail_GotFocus(object sender, RoutedEventArgs e)
        {
            mail.Text = "";
        }

        private void number_GotFocus(object sender, RoutedEventArgs e)
        {
            number.Text = "";
        }

        private void password_GotFocus(object sender, RoutedEventArgs e)
        {
            password.Text = "";
        }

        private void password2_GotFocus(object sender, RoutedEventArgs e)
        {
            password2.Text = "";
        }

        private void number_LostFocus(object sender, RoutedEventArgs e)
        {
            if (number.Text == "")
            {
                number.Text = "Введите ваш номер";
            }
        }

        private void password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Введите ваш пароль";
            }
        }

        private void password2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (password2.Text == "")
            {
                password2.Text = "Введите ваш пароль еще раз";
            }
        }

        private void math_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(num1T.Text);
                double num2 = Convert.ToDouble(num2T.Text);
                double sum = num1 + num2;
                outDA.Content = sum;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }

        }   
            
    }
}