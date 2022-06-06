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

namespace kvadrat
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
        private void решение(object sender, RoutedEventArgs e)
        {
            double a = Int32.Parse(textBox1.Text); // преобразование строчки в число 
            double b = Int32.Parse(textBox2.Text);
            double c = Int32.Parse(textBox3.Text);
            double D = b * b - 4 * a * c;

            if (D < 0)  // если дискриминант <0
            {
                textBox4.Text = "Нет корней";
            }
            if (D == 0)  // Если дискриминант =0
            {
                double x = (-b / (2 * a)); // выводит 1 корень 
                textBox4.Text = x.ToString();
            }
            if (D > 0)
            {
                double x1 = ((-b - Math.Sqrt(D)) / (2 * a)); // нахождение первого корня
                double x2 = ((-b + Math.Sqrt(D)) / (2 * a)); // нахождение второго корня
                textBox4.Text = "x1 = " + x1 + Environment.NewLine + "x2 = " + x2; //Вывод ответа
            }
        }
    }
}
