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

namespace WpfAppEvents
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

        public double sum = 0;
        private void KolvoSlide_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            KolvoLabel.Content = $"{e.NewValue} шт.";

            Summa.Content = $"Итого: {sum+=e.NewValue} P";
        }

        private void TelephoneTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !char.IsDigit(e.Text[0]);
        }

        private void GiftCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (GiftCheckBox.IsChecked == true)
            { sum +=100; }
            if (GiftCheckBox.IsChecked == false)
            { sum -= 100; }
            Summa.Content = $"Итого: {sum} P";

        }

        private void FastCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (FastCheckBox.IsChecked == true)
            { sum += 200; }
            if (FastCheckBox.IsChecked == false)
            { sum -= 200; }
            Summa.Content = $"Итого: {sum} P";
        }

    }
}
