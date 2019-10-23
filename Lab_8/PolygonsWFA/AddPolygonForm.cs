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
    public partial class AddPolygonForm : Form
    {
        Flatness flatness;

        public AddPolygonForm(ref Flatness flatness)
        {
            this.flatness = flatness;
            InitializeComponent();
        }

        private void sidesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (sidesTextBox.Text == "" || colorTextBox.Text == "")
            {
                msgLabel.ForeColor = Color.FromName("Red");
                msgLabel.Text = "Данные не были введены";
            }
            else
            {
                try
                {
                    flatness.AddPolygons(colorTextBox.Text, Flatness.SidesToInt(sidesTextBox.Text));
                    msgLabel.ForeColor = Color.FromName("Green");
                    msgLabel.Text = "Многоугольник успешно добавлен.";
                }
                catch
                {
                    msgLabel.ForeColor = Color.FromName("Red");
                    msgLabel.Text = "Данные некоректно введены!";
                }
                
            }
        }
    }
}
