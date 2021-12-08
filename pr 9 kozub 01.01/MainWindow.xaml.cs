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

namespace pr_9_kozub_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HundreedMeterRunners runner1;
        HundreedMeterRunners runner2;
        HundreedMeterRunners runner3;
        HundreedMeterRunners runner4;
        HundreedMeterRunners runner5;
        HundreedMeterRunners runner6;
        HundreedMeterRunners runner7;
        HundreedMeterRunners runner8;

        HundreedMeterRunners[] runners;
        public MainWindow()
        {
            InitializeComponent();

            runner1 = new HundreedMeterRunners("Кузнецов", "Даниил", "Григорьевич", 1, 12.00);
            runner2 = new HundreedMeterRunners("Романова", "Варвара", "Макаровна", 2, 10.80);
            runner3 = new HundreedMeterRunners("Горюнова", "Марьяна", "Алексеевна", 3, 10.60);
            runner4 = new HundreedMeterRunners("Зотова", "Алиса", "Кирилловна", 4, 11);
            runner5 = new HundreedMeterRunners("Герасимов", "Максим", "Маркович", 5, 10.50);
            runner6 = new HundreedMeterRunners("Крылова", "Анастасия", "Алексеевна", 6, 13);
            runner7 = new HundreedMeterRunners("Кожевникова", "Полина", "Григорьевна", 7, 9.98);
            runner8 = new HundreedMeterRunners("Иванова", "Эмилия", "Мироновна", 8, 12.25);

            listBox1.Items.Add($"{runner1.Surname} {runner1.Name} {runner1.Patronymic}: Номер - {runner1.Number} | Результат - {runner1.Result}");
            listBox1.Items.Add($"{runner2.Surname} {runner2.Name} {runner2.Patronymic}: Номер - {runner2.Number} | Результат - {runner2.Result}");
            listBox1.Items.Add($"{runner3.Surname} {runner3.Name} {runner3.Patronymic}: Номер - {runner3.Number} | Результат - {runner3.Result}");
            listBox1.Items.Add($"{runner4.Surname} {runner4.Name} {runner4.Patronymic}: Номер - {runner4.Number} | Результат - {runner4.Result}");
            listBox1.Items.Add($"{runner5.Surname} {runner5.Name} {runner5.Patronymic}: Номер - {runner5.Number} | Результат - {runner5.Result}");
            listBox1.Items.Add($"{runner6.Surname} {runner6.Name} {runner6.Patronymic}: Номер - {runner6.Number} | Результат - {runner6.Result}");
            listBox1.Items.Add($"{runner7.Surname} {runner7.Name} {runner7.Patronymic}: Номер - {runner7.Number} | Результат - {runner7.Result}");
            listBox1.Items.Add($"{runner8.Surname} {runner8.Name} {runner8.Patronymic}: Номер - {runner8.Number} | Результат - {runner8.Result}");

        }

        struct HundreedMeterRunners
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Patronymic { get; set; }
            public int Number { get; set; }
            public double Result { get; set; }

            public HundreedMeterRunners(string surname, string name, string patronymic, int number, double result)
            {
                Surname = surname;
                Name = name;
                Patronymic = patronymic;
                Number = number;
                Result = result;
            }
        }

        private void calculateAverage_Click(object sender, RoutedEventArgs e)
        {
            runners = new HundreedMeterRunners[] { runner1, runner2, runner3, runner4, runner5, runner6, runner7, runner8 };
            double sum = 0;
            double averageResult;
            for (int i = 0; i < runners.Length; i++)
            {
                sum += runners[i].Result;
            }
            averageResult = Math.Round(sum / (runners.Length * 1.0), 3);
            MessageBox.Show($"Средний результат равен {averageResult}");
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №9\n" +
                "Козуб Дмитрий ИСП-34\n" +
                "Заполнить таблицу участников забега на 100 метров на 8 человек с полями: ФИО, номер, результат." +
                " Вывести результат на экран. Вывести средний результат.", "О программе", MessageBoxButton.OK);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
