using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Polygons;

namespace PolygonsWFA
{
    public partial class Form1 : Form
    {
        Flatness flatness = new Flatness();

        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            redSLable.Text = "";
            int height = 20;
            panel.Controls.Clear();

            foreach (Polygon polygon in flatness.GetPolygons())
            {
                Label rowLable = new Label();
                rowLable.Width = panel.Width - 30;
                rowLable.Font = new Font("Arial", 16);
                rowLable.ForeColor = polygon.color;
                rowLable.Text = polygon.ToString;
                rowLable.Location = new Point(10, height);
                panel.Controls.Add(rowLable);
                height += 30;
            }

            if (flatness.GetP_RedRightTriangle() != 0)
            {
                redSLable.Text = "Периметр всех красных прямоугольных треугольников равен P = " + flatness.GetP_RedRightTriangle() + " см";
            }
            else
            {
                redSLable.Text = "На плоскости нету красных прямоугольных треугольников.";
            }
        }

        private void Window_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
            string way = openFileDialog.FileName;
            flatness.ReadToFile(way);
            RefreshData();
        }

        private void addPolygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPolygonForm addPolygonForm = new AddPolygonForm(ref flatness);
            addPolygonForm.Show();
        }

        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flatness.SortPolygons();
            RefreshData();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
