using AngleExample; // Используем пространство имен AngleExample
using System;
using System.Windows;

namespace AngleExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateAnglesButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получение значений из TextBox
                int angle1Degrees = int.Parse(Angle1DegreesTextBox.Text);
                int angle1Minutes = int.Parse(Angle1MinutesTextBox.Text);
                int angle2Degrees = int.Parse(Angle2DegreesTextBox.Text);
                int angle2Minutes = int.Parse(Angle2MinutesTextBox.Text);

                // Создание углов
                Angle angle1 = new Angle(angle1Degrees, angle1Minutes);
                Angle angle2 = new Angle(angle2Degrees, angle2Minutes);

                // Вывод результатов
                Angle1RadiansTextBlock.Text = angle1.ToRadians().ToString();
                AnglesEqualTextBlock.Text = (angle1 == angle2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
