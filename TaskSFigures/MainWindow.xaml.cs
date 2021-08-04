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
using FiguresLib;

namespace TaskSFigures
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

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Calculating calc = new Calculating();
                tb2.Text = calc.calculating(double.Parse(tb1.Text)).ToString("0.0000");
            }
            catch (Exception exp) { MessageBox.Show("Что то пошло не так: " + exp.Message, "Ошибка"); }
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(a1.Text), b = Convert.ToDouble(a2.Text), c = Convert.ToDouble(a3.Text);
                Calculating calc = new Calculating();
                tb3.Text = calc.calculating(a, b, c).ToString("0.0000");
                tb4.Text = calc.rectangular(a, b, c);
            }
            catch (Exception exp) { MessageBox.Show("Что то пошло не так(2): " + exp.Message, "Ошибка"); }
        }
    }
}
