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
using Lib_4;

namespace Практическая_работа__1
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

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ФИО: Жаров Артём Андреевич \nПрактическая работа №1" +
                "\nНайти минимум из n целых случайных чисел X, \nраспределенных в диапазоне от 10 до 40. Выве-\nсти на экран на одной строке сгенерирован-\nные числа, на другой строке результат.\r\n");
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRezult_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();

            if (Int32.TryParse(ColZnach.Text, out int a))
            {
                a = Convert.ToInt32(ColZnach.Text);

                RandomNumberProces proces = new RandomNumberProces(); // Создание экземпляра класса библиотеки Lib_4

                List<int> randomNumbers = proces.GenerateRandomNumbers(a); // Генерация случайных значений

                for (int i = 0; i < randomNumbers.Count; i++)
                {
                    listBox1.Items.Add(randomNumbers[i]); // Добавления значения в ListBox
                }

                int minZnach = proces.GetMinimumValue(randomNumbers); // Получение минимального значения

                tbRez.Text = minZnach.ToString();
            }
            else MessageBox.Show("Введено некорректное значения", "Ошибка:");
        }
    }
}