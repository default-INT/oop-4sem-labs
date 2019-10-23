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
using System.Windows.Shapes;
using System.Drawing;
using Polygons;

namespace PolygonsWPF
{
    /// <summary>
    /// Логика взаимодействия для AddPolygonWindow.xaml
    /// </summary>
    public partial class AddPolygonWindow : Window
    {
        Flatness flatness;

        public AddPolygonWindow(ref Flatness flatness)
        {
            this.flatness = flatness;
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (sidesTextBox.Text == "" || colorTextBox.Text == "")
            {
                msgTextBlock.Foreground = new SolidColorBrush(Colors.Red);
                msgTextBlock.Text = "Данные не были введены";
            }
            else
            {
                try
                {
                    flatness.AddPolygons(colorTextBox.Text, Flatness.SidesToInt(sidesTextBox.Text));
                    msgTextBlock.Foreground = new SolidColorBrush(Colors.Green);
                    msgTextBlock.Text = "Многоугольник успешно добавлен.";
                }
                catch
                {
                    msgTextBlock.Foreground = new SolidColorBrush(Colors.Red);
                    msgTextBlock.Text = "Данные некоректно введены!";
                }
            }
        }
    }
}
