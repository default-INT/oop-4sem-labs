using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
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
using Polygons;
using Polygon = Polygons.Polygon;
using Microsoft.Win32;

namespace PolygonsWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Flatness flatness = new Flatness();

        public MainWindow()
        {
            InitializeComponent();
        }

        private System.Windows.Media.Color ConvertColor(System.Drawing.Color color)
        {
            System.Windows.Media.Color mediaColor = System.Windows.Media.Color.FromRgb(color.R, color.G, color.B);
            return mediaColor;
        }

        private void RefreshData()
        {
            msgTextBlock.Text = "";
            polygonsStackPanel.Children.Clear();

            foreach (Polygon polygon in flatness.GetPolygons())
            {
                TextBlock polygonTextBox = new TextBlock();
                polygonTextBox.Text = polygon.ToString;
                polygonTextBox.HorizontalAlignment = HorizontalAlignment.Left;
                polygonTextBox.Foreground = new SolidColorBrush(ConvertColor(polygon.color));
                polygonTextBox.FontSize = 20;
                polygonsStackPanel.Children.Add(polygonTextBox);
            }

            if (flatness.GetP_RedRightTriangle() != 0)
                msgTextBlock.Text = "Периметр всех красных прямоугольных треугольников равен P = " + flatness.GetP_RedRightTriangle() + " см";
            else msgTextBlock.Text = "На плоскости нету красных прямоугольных треугольников.";
        }

        private void Windows_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshData();
        }

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            flatness.SortPolygons();
            RefreshData();
        }

        private void OpenFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName.Length == 0) return;
            try
            {
                string way = openFileDialog.FileName;
                flatness.ReadToFile(way);
                RefreshData();
            }
            catch
            {
                msgTextBlock.Text = "Не удалось прочитать файл";
            }
            
        }

        private void AddPolygonButton_Click(object sender, RoutedEventArgs e)
        {
            AddPolygonWindow addPolygonWindow = new AddPolygonWindow(ref flatness);
            addPolygonWindow.Show();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
