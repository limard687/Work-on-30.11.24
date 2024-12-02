using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Приложение_для_генерации_чиел_Yield_return
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

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            NumbersListBox.Items.Clear();
                if (int.TryParse(FromTextBox.Text, out int start) && int.TryParse(ToTextBox.Text, out int end))
                {
                    foreach (var number in GenerateNumbers(start, end))
                    {
                        NumbersListBox.Items.Add(number);
                        Thread.Sleep(1000);
                    }
                    MessageBox.Show("Вывод прошел корректно!");
                }
        }

        static IEnumerable<int> GenerateNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                yield return i;
            }
        }
    }
}
